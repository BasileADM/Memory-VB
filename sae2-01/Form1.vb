Imports System.ComponentModel

' Formulaire principal de l'application
Public Class Form1

    ' === INITIALISATION ===

    ' Chargement initial du formulaire
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Jouer.Enabled = False ' Désactive le bouton "Jouer" par défaut
        InitialiserScores()   ' Initialise les scores

        ' Remplit la ComboBox avec les noms enregistrés
        Entrer_nom.Items.Clear()
        For Each nom In ObtenirNomsJoueursUniques()
            Entrer_nom.Items.Add(nom)
        Next
    End Sub

    ' === FERMETURE DU FORMULAIRE ===

    ' Confirmation avant fermeture du formulaire
    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MsgBox("Voulez-vous vraiment quitter l'application ?", vbYesNo) = vbNo Then
            e.Cancel = True ' Annule la fermeture
        Else
            Application.Exit() ' Ferme complètement l'application
        End If
    End Sub

    ' === ÉVÉNEMENTS DES BOUTONS ===

    ' Lancement du jeu
    Private Sub Jouer_Click(sender As Object, e As EventArgs) Handles Jouer.Click
        Me.Hide()
        Form2.Show()
    End Sub

    ' Affichage des scores
    Private Sub Scores_Click(sender As Object, e As EventArgs) Handles Scores.Click
        Me.Hide()
        Form3.Show()
    End Sub

    ' Ouverture du menu options
    Private Sub Options_Click(sender As Object, e As EventArgs) Handles Options.Click
        Me.Hide()
        Form4.Show()
    End Sub

    ' Fermeture de l'application
    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles Quitter.Click
        Close()
        Application.Exit()
    End Sub

    ' === SAISIE UTILISATEUR ===

    ' Active le bouton "Jouer" si le nom entré contient au moins 3 caractères
    Private Sub Entrer_nom_TextUpdate(sender As Object, e As EventArgs) Handles Entrer_nom.TextUpdate
        Jouer.Enabled = Entrer_nom.Text.Length >= 3
    End Sub

End Class
