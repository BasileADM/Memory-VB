Imports System.Data

' Formulaire d'affichage du classement des scores
Public Class Form3

    ' === INITIALISATION ===

    ' Chargement du formulaire
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Charge les scores depuis le module, puis les affiche dans le tableau
        ModuleScores.ChargerScores()
        chargerTableau()
    End Sub

    ' Retour au menu principal quand la fenêtre est fermée
    Private Sub Form3_Closing(sender As Object, e As EventArgs) Handles Me.Closing
        Form1.Show()
    End Sub

    ' === BOUTONS ===

    ' Bouton pour revenir à l'écran précédent
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Close()
    End Sub

    ' Réinitialise les scores et recharge le tableau
    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        ResetScores()
        chargerTableau()
    End Sub

    ' === AFFICHAGE DU TABLEAU DE CLASSEMENT ===

    ' Charge les données des scores triés dans le DataGridView
    Private Sub chargerTableau()
        ' Récupère les scores triés du module
        Dim dtTrie = ModuleScores.GetScoresTries()

        ' Crée une nouvelle table d'affichage avec colonnes spécifiques
        Dim dtAffichage As New DataTable()
        dtAffichage.Columns.Add("Rang", GetType(Integer))
        dtAffichage.Columns.Add("Nom du joueur", GetType(String))
        dtAffichage.Columns.Add("Temps", GetType(String))

        ' Remplit la table avec les données triées
        For i = 0 To dtTrie.Rows.Count - 1
            dtAffichage.Rows.Add(
                i + 1,
                dtTrie.Rows(i)("Nom du joueur"),
                CType(dtTrie.Rows(i)("Temps"), TimeSpan).ToString("mm\:ss")
            )
        Next

        ' Configure l'affichage du DataGridView
        dgvClassement.DataSource = dtAffichage
        dgvClassement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvClassement.ReadOnly = True
        dgvClassement.AllowUserToAddRows = False
        dgvClassement.AllowUserToDeleteRows = False
        dgvClassement.RowHeadersVisible = False
    End Sub

End Class
