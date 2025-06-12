Imports System.ComponentModel

' Formulaire des options du jeu
Public Class Form4

    ' === INITIALISATION ===

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chrono_Settings_box.Enabled = True
        Chrono_Checkbox.Checked = True
        CheckBoxFacile.Checked = False
        CheckBoxNormal.Checked = False
        CheckBoxDifficile.Checked = False
        ActiverPersonnalise() ' Active les champs personnalisés
    End Sub

    ' Retour au menu principal à la fermeture
    Private Sub Form4_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Show()
    End Sub

    ' === BOUTONS ===

    ' Enregistre les paramètres et retourne au menu
    Private Sub Enregistrer_Parametres_Click(sender As Object, e As EventArgs) Handles Enregistrer_Parametres.Click
        Me.Hide()
        Form1.Show()
    End Sub

    ' Annule les modifications si l'utilisateur confirme
    Private Sub Annuler_option_Click(sender As Object, e As EventArgs) Handles Annuler_option.Click
        If MsgBox("Voulez-vous vraiment annuler les modifications ?", vbYesNo) = vbYes Then
            Hide()
            Chrono_Checkbox.Checked = True
            CheckBoxFacile.Checked = False
            CheckBoxNormal.Checked = False
            CheckBoxDifficile.Checked = False
            ActiverPersonnalise()
            Form1.Show()
        End If
    End Sub

    ' === CHECKBOXES DE DIFFICULTÉ ===

    ' Mode personnalisé
    Private Sub Chrono_Checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles Chrono_Checkbox.CheckedChanged
        If Chrono_Checkbox.Checked Then
            CheckBoxFacile.Checked = False
            CheckBoxNormal.Checked = False
            CheckBoxDifficile.Checked = False
            ActiverPersonnalise()
        End If
    End Sub

    ' Mode facile
    Private Sub CheckBoxFacile_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFacile.CheckedChanged
        If CheckBoxFacile.Checked Then
            Chrono_Checkbox.Checked = False
            CheckBoxNormal.Checked = False
            CheckBoxDifficile.Checked = False
            AppliquerReglage(120, True, False)
            MettreAJourCheckBoxPause(True, False)
        End If
    End Sub

    ' Mode normal
    Private Sub CheckBoxNormal_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxNormal.CheckedChanged
        If CheckBoxNormal.Checked Then
            Chrono_Checkbox.Checked = False
            CheckBoxFacile.Checked = False
            CheckBoxDifficile.Checked = False
            AppliquerReglage(60, True, False)
            MettreAJourCheckBoxPause(False, False)
        End If
    End Sub

    ' Mode difficile
    Private Sub CheckBoxDifficile_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDifficile.CheckedChanged
        If CheckBoxDifficile.Checked Then
            Chrono_Checkbox.Checked = False
            CheckBoxFacile.Checked = False
            CheckBoxNormal.Checked = False
            AppliquerReglage(40, False, False)
            MettreAJourCheckBoxPause(False, False)
        End If
    End Sub

    ' === MÉTHODES UTILES ===

    ' Active les contrôles pour un mode personnalisé
    Private Sub ActiverPersonnalise()
        Chrono_Temps_partie.Enabled = True
        Chrono_alarm_Checkbox.Enabled = True
        MettreAJourCheckBoxPause(False, True)
    End Sub

    ' Applique un réglage de temps et alarme
    Private Sub AppliquerReglage(temps As Integer, alarme As Boolean, Optional personnalise As Boolean = False)
        Chrono_Temps_partie.Value = temps
        Chrono_alarm_Checkbox.Checked = alarme
        Chrono_Temps_partie.Enabled = False
        Chrono_alarm_Checkbox.Enabled = False
    End Sub

    ' Gestion de l'affichage du label "Pause"
    Private Sub CheckBoxpause_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxpause.CheckedChanged
        If CheckBoxpause.Checked = True Then
            LabelPause.Visible = True
        Else
            LabelPause.Visible = False ' <-- Même comportement dans les deux cas
        End If
    End Sub

    ' Met à jour l'état de la checkbox de pause
    Private Sub MettreAJourCheckBoxPause(valeur As Boolean, actif As Boolean)
        CheckBoxpause.Checked = valeur
        CheckBoxpause.Enabled = actif
    End Sub


End Class
