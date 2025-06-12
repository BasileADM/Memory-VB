Imports System.ComponentModel
Imports System.Data

Public Class Form2

    ' === VARIABLES ET CONSTANTES ===
    ' Temps restant au début de la partie (valeur définie dans Form4)
    Private tempsRestant As Integer = Form4.Chrono_Temps_partie.Value

    ' Dictionnaire associant chaque PictureBox à l’image qu’elle doit afficher (face de la carte)
    Private cartesFaces As New Dictionary(Of PictureBox, Image)

    ' Image représentant le dos des cartes
    Private imageDos As Image = Image.FromFile(Application.StartupPath & "\Images\BackCard.png")

    ' Liste de toutes les cartes affichées à l’écran
    Private listeCartes As New List(Of PictureBox)

    ' Liste temporaire des cartes retournées (en cours de comparaison)
    Private cartesRetournees As New List(Of PictureBox)

    ' Indique si le jeu est actuellement en pause
    Private enPause As Boolean = False

    ' Mémorise si la partie a déjà été mise en pause
    Private jeuPause As Boolean = False

    ' Timer temporaire pour gérer le délai entre le retournement de cartes non identiques
    Private timerRetourCartes As Timer = Nothing

    ' Définition du code Konami pour déclencher une victoire instantanée
    Private ReadOnly konamiCode As Keys() = {
        Keys.Up, Keys.Up, Keys.Down, Keys.Down,
        Keys.Left, Keys.Right, Keys.Left, Keys.Right,
        Keys.B, Keys.A
    }
    Private konamiIndex As Integer = 0 ' Position actuelle dans la saisie du code

    ' === EVENEMENTS DU FORMULAIRE ===

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialise l’interface de jeu
        InitialiserGrille()
        RepartirCartes()
        Nom_joueur.Text = Form1.Entrer_nom.Text

        ' Démarre le chronomètre
        Timer.Interval = 1000
        Timer.Enabled = True
        Timer.Start()
        Timer_affichage.Text = "Temps restant : " & tempsRestant & " s"

        ' Retire le focus du formulaire pour éviter les sélections non voulues
        Me.ActiveControl = Nothing

        ' Active ou non le bouton pause en fonction des paramètres de Form4
        ButtonPause.Visible = Form4.CheckBoxpause.Checked
        ButtonPause.Text = "Pause"
    End Sub

    Private Sub Form2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' Donne le focus au formulaire
        Me.Activate()
        Me.Focus()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' Affiche Form1 si Form2 est fermé
        Form1.Show()
    End Sub

    ' === EVENEMENTS DES BOUTONS ===

    Private Sub Bouton_abandon_Click(sender As Object, e As EventArgs) Handles Bouton_abandon.Click
        ' L’utilisateur abandonne la partie
        Timer.Stop()
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub ButtonPause_Click(sender As Object, e As EventArgs) Handles ButtonPause.Click
        ' Met le jeu en pause ou le reprend
        jeuPause = True
        If enPause Then
            Timer.Start()
            enPause = False
            CType(sender, Button).Text = "Pause"
            ' Réactive les cartes cachées
            For Each pb In listeCartes
                If pb.Tag = "cachee" Then pb.Enabled = True
            Next
        Else
            Timer.Stop()
            enPause = True
            CType(sender, Button).Text = "Reprendre"
            ' Désactive toutes les cartes
            For Each pb In listeCartes
                pb.Enabled = False
            Next
        End If
    End Sub

    ' === EVENEMENTS DES CARTES ===

    Private Sub Carte_Click(sender As Object, e As EventArgs)
        ' Gestion du clic sur une carte
        Dim pb As PictureBox = CType(sender, PictureBox)

        ' Empêche certaines actions si conditions non respectées
        If pb.Tag = "visible" OrElse Not pb.Enabled OrElse cartesRetournees.Contains(pb) Then Exit Sub
        If enPause Then Exit Sub

        ' Affiche la carte
        AfficherCarte(pb)
        cartesRetournees.Add(pb)

        ' Si une seule carte est retournée, on attend la deuxième
        If cartesRetournees.Count = 1 Then Exit Sub

        ' Si les deux cartes sont différentes, on les retourne après un délai
        If cartesFaces(pb) IsNot cartesFaces(cartesRetournees(0)) Then
            RetournerCartesApresPause()
            Exit Sub
        End If

        ' Si les cartes sont identiques (paire trouvée)
        If cartesRetournees.Count = 4 Then
            For Each c In cartesRetournees
                c.Enabled = False
                c.Image = ImageEnGris(cartesFaces(c)) ' Grise les cartes validées
            Next
            cartesRetournees.Clear()
            VerifierFinPartie(False)
        End If
    End Sub

    ' === GESTION DU TIMER ===

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        ' Décrémente le temps restant
        tempsRestant -= 1
        VerifierFinPartie(False)

        ' Affiche une alerte si moins de 10 secondes restantes
        If Form4.Chrono_alarm_Checkbox.Checked AndAlso tempsRestant < 10 Then
            Alerte.Visible = True
        End If

        ' Met à jour l’affichage ou arrête le jeu si le temps est écoulé
        If tempsRestant > 0 Then
            Timer_affichage.Text = "Temps restant : " & tempsRestant & " s"
        Else
            Timer.Stop()
            If MsgBox("Partie Perdue", vbOKOnly) Then
                Me.Close()
                Form1.Show()
                Exit Sub
            End If
        End If
    End Sub

    ' === FONCTIONS UTILITAIRES ===

    Private Sub InitialiserGrille()
        ' Crée dynamiquement les 20 cartes (PictureBox)
        TableLayoutPanelCartes.Controls.Clear()
        listeCartes.Clear()
        For i = 1 To 20
            Dim pb As New PictureBox()
            pb.Name = "pbCarte" & i
            pb.SizeMode = PictureBoxSizeMode.Zoom
            pb.Dock = DockStyle.Fill
            pb.Image = imageDos
            pb.Tag = "cachee"
            AddHandler pb.Click, AddressOf Carte_Click
            TableLayoutPanelCartes.Controls.Add(pb)
            listeCartes.Add(pb)
        Next

        ' Configure la grille 4x5
        With TableLayoutPanelCartes
            .RowCount = 4
            .ColumnCount = 5
            .RowStyles.Clear()
            .ColumnStyles.Clear()
            For i = 1 To .RowCount
                .RowStyles.Add(New RowStyle(SizeType.Percent, 100 / .RowCount))
            Next
            For i = 1 To .ColumnCount
                .ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100 / .ColumnCount))
            Next
        End With
    End Sub

    Private Sub RepartirCartes()
        ' Prépare la liste des cartes à distribuer (5 images différentes × 4 exemplaires)
        Dim cartes As New List(Of Image)
        For i = 0 To 4
            Dim chemin As String = Application.StartupPath & "\Images\Card" & i & ".png"
            If Not System.IO.File.Exists(chemin) Then MsgBox("Fichier introuvable : " & chemin)
            Dim img As Image = Image.FromFile(chemin)
            For j = 1 To 4
                cartes.Add(img)
            Next
        Next

        ' Mélange les cartes
        Dim rnd As New Random()
        Dim cartesMelangees = cartes.OrderBy(Function(x) rnd.Next()).ToList()

        ' Affecte chaque carte à un PictureBox
        For i = 0 To listeCartes.Count - 1
            Dim pb As PictureBox = listeCartes(i)
            cartesFaces(pb) = cartesMelangees(i)
            pb.Image = imageDos
            pb.Tag = "cachee"
            pb.Enabled = True
        Next
        cartesRetournees.Clear()
    End Sub

    Private Sub CacherCarte(pb As PictureBox)
        ' Cache une carte (affiche le dos)
        pb.Image = imageDos
        pb.Tag = "cachee"
    End Sub

    Private Sub AfficherCarte(pb As PictureBox)
        ' Affiche la face d’une carte
        pb.Image = cartesFaces(pb)
        pb.Tag = "visible"
    End Sub

    Private Function MemeImage(cartes As List(Of PictureBox)) As Boolean
        ' Vérifie si toutes les cartes retournées ont la même image
        If cartes.Count = 0 Then Return False
        Dim img = cartesFaces(cartes(0))
        Return cartes.All(Function(pb) cartesFaces(pb) Is img)
    End Function

    Private Sub RetournerCartesApresPause()
        ' Désactive temporairement toutes les cartes, puis les retourne au bout de 700 ms
        For Each pb In listeCartes
            If pb.Enabled AndAlso pb.Tag = "cachee" Then
                pb.Enabled = False
            End If
        Next

        If timerRetourCartes IsNot Nothing Then
            timerRetourCartes.Stop()
            timerRetourCartes.Dispose()
        End If

        timerRetourCartes = New Timer With {.Interval = 700}
        AddHandler timerRetourCartes.Tick, Sub()
                                               timerRetourCartes.Stop()
                                               For Each pb In cartesRetournees
                                                   CacherCarte(pb)
                                                   pb.Enabled = True
                                               Next
                                               For Each pb In listeCartes
                                                   If pb.Tag = "cachee" Then pb.Enabled = True
                                               Next
                                               cartesRetournees.Clear()
                                               timerRetourCartes.Dispose()
                                               timerRetourCartes = Nothing
                                           End Sub
        timerRetourCartes.Start()
    End Sub

    Private Function ImageEnGris(img As Image) As Image
        ' Applique un filtre de désaturation à l’image
        Dim bmp As New Bitmap(img.Width, img.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            Dim cm As New Imaging.ColorMatrix(New Single()() {
                New Single() {0.3, 0.3, 0.3, 0, 0},
                New Single() {0.59, 0.59, 0.59, 0, 0},
                New Single() {0.11, 0.11, 0.11, 0, 0},
                New Single() {0, 0, 0, 1, 0},
                New Single() {0, 0, 0, 0, 1}
            })
            Dim ia As New Imaging.ImageAttributes()
            ia.SetColorMatrix(cm)
            g.DrawImage(img, New Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia)
        End Using
        Return bmp
    End Function

    ' === GESTION DE LA FIN DE PARTIE ===

    Private Sub VerifierFinPartie(Konami As Boolean)
        ' Vérifie si toutes les cartes ont été découvertes
        Dim toutesValidees As Boolean = listeCartes.All(Function(pb) Not pb.Enabled AndAlso pb.Tag = "visible")
        If toutesValidees Then
            If Timer IsNot Nothing AndAlso Timer.Enabled Then Timer.Stop()

            If Not jeuPause Then
                Dim tempsTotal As Integer = Form4.Chrono_Temps_partie.Value
                Dim tempsUtilise As Integer = tempsTotal - tempsRestant
                Dim tempsJoue As New TimeSpan(0, 0, tempsUtilise)
                ModuleScores.AjouterScore(Form1.Entrer_nom.Text, tempsJoue)
            End If

            If Konami Then
                MsgBox("Konami code détecté: Victoire instantanée!", vbOKOnly, "Victoire")
            Else
                MsgBox("Félicitations ! Vous avez trouvé toutes les paires !", vbOKOnly, "Victoire")
            End If

            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub GagnerPartie()
        ' Affiche toutes les cartes et force la victoire
        For Each pb As PictureBox In listeCartes
            AfficherCarte(pb)
            pb.Enabled = False
            pb.Image = ImageEnGris(cartesFaces(pb))
        Next
        VerifierFinPartie(True)
    End Sub

    ' === KONAMI CODE ET GESTION CLAVIER ===

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        ' Intercepte les touches du clavier pour détecter le code Konami
        If keyData = konamiCode(konamiIndex) Then
            konamiIndex += 1
            If konamiIndex = konamiCode.Length Then
                GagnerPartie()
                konamiIndex = 0
            End If
        Else
            konamiIndex = If(keyData = konamiCode(0), 1, 0)
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

End Class
