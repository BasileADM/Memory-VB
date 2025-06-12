<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Chrono_Checkbox = New System.Windows.Forms.CheckBox()
        Me.Chrono_Settings_box = New System.Windows.Forms.GroupBox()
        Me.LabelPause = New System.Windows.Forms.Label()
        Me.CheckBoxpause = New System.Windows.Forms.CheckBox()
        Me.Chrono_alarm_Checkbox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chrono_Temps_partie = New System.Windows.Forms.NumericUpDown()
        Me.Enregistrer_Parametres = New System.Windows.Forms.Button()
        Me.Annuler_option = New System.Windows.Forms.Button()
        Me.CheckBoxFacile = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDifficile = New System.Windows.Forms.CheckBox()
        Me.CheckBoxNormal = New System.Windows.Forms.CheckBox()
        Me.Chrono_Settings_box.SuspendLayout()
        CType(Me.Chrono_Temps_partie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chrono_Checkbox
        '
        Me.Chrono_Checkbox.AutoSize = True
        Me.Chrono_Checkbox.Checked = True
        Me.Chrono_Checkbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chrono_Checkbox.Location = New System.Drawing.Point(53, 183)
        Me.Chrono_Checkbox.Name = "Chrono_Checkbox"
        Me.Chrono_Checkbox.Size = New System.Drawing.Size(86, 17)
        Me.Chrono_Checkbox.TabIndex = 0
        Me.Chrono_Checkbox.Text = "Personnalisé"
        Me.Chrono_Checkbox.UseVisualStyleBackColor = True
        '
        'Chrono_Settings_box
        '
        Me.Chrono_Settings_box.Controls.Add(Me.LabelPause)
        Me.Chrono_Settings_box.Controls.Add(Me.CheckBoxpause)
        Me.Chrono_Settings_box.Controls.Add(Me.Chrono_alarm_Checkbox)
        Me.Chrono_Settings_box.Controls.Add(Me.Label1)
        Me.Chrono_Settings_box.Controls.Add(Me.Chrono_Temps_partie)
        Me.Chrono_Settings_box.Location = New System.Drawing.Point(184, 12)
        Me.Chrono_Settings_box.Name = "Chrono_Settings_box"
        Me.Chrono_Settings_box.Size = New System.Drawing.Size(265, 146)
        Me.Chrono_Settings_box.TabIndex = 1
        Me.Chrono_Settings_box.TabStop = False
        '
        'LabelPause
        '
        Me.LabelPause.AutoSize = True
        Me.LabelPause.ForeColor = System.Drawing.Color.Red
        Me.LabelPause.Location = New System.Drawing.Point(10, 116)
        Me.LabelPause.Name = "LabelPause"
        Me.LabelPause.Size = New System.Drawing.Size(186, 13)
        Me.LabelPause.TabIndex = 5
        Me.LabelPause.Text = "Votre score ne sera pas comptabilisé !"
        Me.LabelPause.Visible = False
        '
        'CheckBoxpause
        '
        Me.CheckBoxpause.AutoSize = True
        Me.CheckBoxpause.Location = New System.Drawing.Point(32, 91)
        Me.CheckBoxpause.Name = "CheckBoxpause"
        Me.CheckBoxpause.Size = New System.Drawing.Size(56, 17)
        Me.CheckBoxpause.TabIndex = 4
        Me.CheckBoxpause.Text = "Pause"
        Me.CheckBoxpause.UseVisualStyleBackColor = True
        '
        'Chrono_alarm_Checkbox
        '
        Me.Chrono_alarm_Checkbox.AutoSize = True
        Me.Chrono_alarm_Checkbox.Location = New System.Drawing.Point(32, 53)
        Me.Chrono_alarm_Checkbox.Name = "Chrono_alarm_Checkbox"
        Me.Chrono_alarm_Checkbox.Size = New System.Drawing.Size(58, 17)
        Me.Chrono_alarm_Checkbox.TabIndex = 2
        Me.Chrono_alarm_Checkbox.Text = "Alertes"
        Me.Chrono_alarm_Checkbox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ChoixTemps"
        '
        'Chrono_Temps_partie
        '
        Me.Chrono_Temps_partie.Location = New System.Drawing.Point(118, 17)
        Me.Chrono_Temps_partie.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.Chrono_Temps_partie.Name = "Chrono_Temps_partie"
        Me.Chrono_Temps_partie.Size = New System.Drawing.Size(120, 20)
        Me.Chrono_Temps_partie.TabIndex = 3
        Me.Chrono_Temps_partie.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.Chrono_Temps_partie.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'Enregistrer_Parametres
        '
        Me.Enregistrer_Parametres.Location = New System.Drawing.Point(347, 183)
        Me.Enregistrer_Parametres.Name = "Enregistrer_Parametres"
        Me.Enregistrer_Parametres.Size = New System.Drawing.Size(102, 28)
        Me.Enregistrer_Parametres.TabIndex = 2
        Me.Enregistrer_Parametres.Text = "Enregistrer"
        Me.Enregistrer_Parametres.UseVisualStyleBackColor = True
        '
        'Annuler_option
        '
        Me.Annuler_option.Location = New System.Drawing.Point(216, 183)
        Me.Annuler_option.Name = "Annuler_option"
        Me.Annuler_option.Size = New System.Drawing.Size(102, 28)
        Me.Annuler_option.TabIndex = 3
        Me.Annuler_option.Text = "Annuler"
        Me.Annuler_option.UseVisualStyleBackColor = True
        '
        'CheckBoxFacile
        '
        Me.CheckBoxFacile.AutoSize = True
        Me.CheckBoxFacile.Location = New System.Drawing.Point(53, 124)
        Me.CheckBoxFacile.Name = "CheckBoxFacile"
        Me.CheckBoxFacile.Size = New System.Drawing.Size(54, 17)
        Me.CheckBoxFacile.TabIndex = 4
        Me.CheckBoxFacile.Text = "Facile"
        Me.CheckBoxFacile.UseVisualStyleBackColor = True
        '
        'CheckBoxDifficile
        '
        Me.CheckBoxDifficile.AutoSize = True
        Me.CheckBoxDifficile.Location = New System.Drawing.Point(53, 31)
        Me.CheckBoxDifficile.Name = "CheckBoxDifficile"
        Me.CheckBoxDifficile.Size = New System.Drawing.Size(60, 17)
        Me.CheckBoxDifficile.TabIndex = 5
        Me.CheckBoxDifficile.Text = "Difficile"
        Me.CheckBoxDifficile.UseVisualStyleBackColor = True
        '
        'CheckBoxNormal
        '
        Me.CheckBoxNormal.AutoSize = True
        Me.CheckBoxNormal.Location = New System.Drawing.Point(53, 76)
        Me.CheckBoxNormal.Name = "CheckBoxNormal"
        Me.CheckBoxNormal.Size = New System.Drawing.Size(59, 17)
        Me.CheckBoxNormal.TabIndex = 6
        Me.CheckBoxNormal.Text = "Normal"
        Me.CheckBoxNormal.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 246)
        Me.Controls.Add(Me.CheckBoxNormal)
        Me.Controls.Add(Me.CheckBoxDifficile)
        Me.Controls.Add(Me.CheckBoxFacile)
        Me.Controls.Add(Me.Annuler_option)
        Me.Controls.Add(Me.Enregistrer_Parametres)
        Me.Controls.Add(Me.Chrono_Settings_box)
        Me.Controls.Add(Me.Chrono_Checkbox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.Chrono_Settings_box.ResumeLayout(False)
        Me.Chrono_Settings_box.PerformLayout()
        CType(Me.Chrono_Temps_partie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chrono_Checkbox As CheckBox
    Friend WithEvents Chrono_Settings_box As GroupBox
    Friend WithEvents Chrono_alarm_Checkbox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Chrono_Temps_partie As NumericUpDown
    Friend WithEvents Enregistrer_Parametres As Button
    Friend WithEvents Annuler_option As Button
    Friend WithEvents CheckBoxFacile As CheckBox
    Friend WithEvents CheckBoxDifficile As CheckBox
    Friend WithEvents CheckBoxNormal As CheckBox
    Friend WithEvents CheckBoxpause As CheckBox
    Friend WithEvents LabelPause As Label
End Class
