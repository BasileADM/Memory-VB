<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Jouer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Entrer_nom = New System.Windows.Forms.ComboBox()
        Me.Scores = New System.Windows.Forms.Button()
        Me.Options = New System.Windows.Forms.Button()
        Me.Quitter = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Jouer
        '
        Me.Jouer.Location = New System.Drawing.Point(134, 170)
        Me.Jouer.Name = "Jouer"
        Me.Jouer.Size = New System.Drawing.Size(75, 23)
        Me.Jouer.TabIndex = 0
        Me.Jouer.Text = "Jouer"
        Me.Jouer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "4 Memory"
        '
        'Entrer_nom
        '
        Me.Entrer_nom.FormattingEnabled = True
        Me.Entrer_nom.Location = New System.Drawing.Point(116, 141)
        Me.Entrer_nom.Name = "Entrer_nom"
        Me.Entrer_nom.Size = New System.Drawing.Size(121, 23)
        Me.Entrer_nom.TabIndex = 2
        Me.Entrer_nom.Text = "Entrer nom"
        '
        'Scores
        '
        Me.Scores.Location = New System.Drawing.Point(134, 199)
        Me.Scores.Name = "Scores"
        Me.Scores.Size = New System.Drawing.Size(75, 23)
        Me.Scores.TabIndex = 3
        Me.Scores.Text = "Scores"
        Me.Scores.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.Options.Location = New System.Drawing.Point(134, 228)
        Me.Options.Name = "Options"
        Me.Options.Size = New System.Drawing.Size(75, 23)
        Me.Options.TabIndex = 4
        Me.Options.Text = "Options"
        Me.Options.UseVisualStyleBackColor = True
        '
        'Quitter
        '
        Me.Quitter.Location = New System.Drawing.Point(134, 257)
        Me.Quitter.Name = "Quitter"
        Me.Quitter.Size = New System.Drawing.Size(75, 23)
        Me.Quitter.TabIndex = 5
        Me.Quitter.Text = "Quitter"
        Me.Quitter.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(131, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "a concentration game"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 330)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Quitter)
        Me.Controls.Add(Me.Options)
        Me.Controls.Add(Me.Scores)
        Me.Controls.Add(Me.Entrer_nom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Jouer)
        Me.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Jouer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Entrer_nom As ComboBox
    Friend WithEvents Scores As Button
    Friend WithEvents Options As Button
    Friend WithEvents Quitter As Button
    Friend WithEvents Label2 As Label
End Class
