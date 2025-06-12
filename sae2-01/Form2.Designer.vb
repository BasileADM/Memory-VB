<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Bouton_abandon = New System.Windows.Forms.Button()
        Me.Joueur = New System.Windows.Forms.Label()
        Me.Nom_joueur = New System.Windows.Forms.Label()
        Me.Timer_affichage = New System.Windows.Forms.Label()
        Me.Alerte = New System.Windows.Forms.Label()
        Me.TableLayoutPanelCartes = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonPause = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer
        '
        '
        'Bouton_abandon
        '
        Me.Bouton_abandon.Location = New System.Drawing.Point(573, 13)
        Me.Bouton_abandon.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Bouton_abandon.Name = "Bouton_abandon"
        Me.Bouton_abandon.Size = New System.Drawing.Size(108, 29)
        Me.Bouton_abandon.TabIndex = 0
        Me.Bouton_abandon.Text = "Abandon"
        Me.Bouton_abandon.UseVisualStyleBackColor = True
        '
        'Joueur
        '
        Me.Joueur.AutoSize = True
        Me.Joueur.Location = New System.Drawing.Point(26, 21)
        Me.Joueur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Joueur.Name = "Joueur"
        Me.Joueur.Size = New System.Drawing.Size(64, 17)
        Me.Joueur.TabIndex = 1
        Me.Joueur.Text = "Joueur : "
        '
        'Nom_joueur
        '
        Me.Nom_joueur.AutoSize = True
        Me.Nom_joueur.Location = New System.Drawing.Point(87, 21)
        Me.Nom_joueur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Nom_joueur.Name = "Nom_joueur"
        Me.Nom_joueur.Size = New System.Drawing.Size(64, 17)
        Me.Nom_joueur.TabIndex = 2
        Me.Nom_joueur.Text = "Joueur : "
        '
        'Timer_affichage
        '
        Me.Timer_affichage.AutoSize = True
        Me.Timer_affichage.Location = New System.Drawing.Point(270, 21)
        Me.Timer_affichage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Timer_affichage.Name = "Timer_affichage"
        Me.Timer_affichage.Size = New System.Drawing.Size(138, 17)
        Me.Timer_affichage.TabIndex = 3
        Me.Timer_affichage.Text = "Temps restant : 10 s"
        '
        'Alerte
        '
        Me.Alerte.AutoSize = True
        Me.Alerte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alerte.ForeColor = System.Drawing.Color.Red
        Me.Alerte.Location = New System.Drawing.Point(236, 49)
        Me.Alerte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Alerte.Name = "Alerte"
        Me.Alerte.Size = New System.Drawing.Size(209, 25)
        Me.Alerte.TabIndex = 4
        Me.Alerte.Text = "10 secondes restantes"
        Me.Alerte.Visible = False
        '
        'TableLayoutPanelCartes
        '
        Me.TableLayoutPanelCartes.AutoSize = True
        Me.TableLayoutPanelCartes.ColumnCount = 5
        Me.TableLayoutPanelCartes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelCartes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelCartes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelCartes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelCartes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanelCartes.Location = New System.Drawing.Point(90, 87)
        Me.TableLayoutPanelCartes.Name = "TableLayoutPanelCartes"
        Me.TableLayoutPanelCartes.RowCount = 4
        Me.TableLayoutPanelCartes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelCartes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelCartes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelCartes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelCartes.Size = New System.Drawing.Size(387, 429)
        Me.TableLayoutPanelCartes.TabIndex = 25
        '
        'ButtonPause
        '
        Me.ButtonPause.Location = New System.Drawing.Point(450, 14)
        Me.ButtonPause.Name = "ButtonPause"
        Me.ButtonPause.Size = New System.Drawing.Size(95, 28)
        Me.ButtonPause.TabIndex = 26
        Me.ButtonPause.Text = "Pause"
        Me.ButtonPause.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 528)
        Me.Controls.Add(Me.ButtonPause)
        Me.Controls.Add(Me.TableLayoutPanelCartes)
        Me.Controls.Add(Me.Alerte)
        Me.Controls.Add(Me.Timer_affichage)
        Me.Controls.Add(Me.Nom_joueur)
        Me.Controls.Add(Me.Joueur)
        Me.Controls.Add(Me.Bouton_abandon)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer As Timer
    Friend WithEvents Bouton_abandon As Button
    Friend WithEvents Joueur As Label
    Friend WithEvents Nom_joueur As Label
    Friend WithEvents Timer_affichage As Label
    Friend WithEvents Alerte As Label
    Friend WithEvents TableLayoutPanelCartes As TableLayoutPanel
    Friend WithEvents ButtonPause As Button
End Class
