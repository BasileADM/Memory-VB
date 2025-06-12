<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.dgvClassement = New System.Windows.Forms.DataGridView()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonReset = New System.Windows.Forms.Button()
        CType(Me.dgvClassement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClassement
        '
        Me.dgvClassement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClassement.Location = New System.Drawing.Point(224, 99)
        Me.dgvClassement.Name = "dgvClassement"
        Me.dgvClassement.RowHeadersWidth = 51
        Me.dgvClassement.RowTemplate.Height = 24
        Me.dgvClassement.Size = New System.Drawing.Size(314, 226)
        Me.dgvClassement.TabIndex = 1
        '
        'ButtonBack
        '
        Me.ButtonBack.Location = New System.Drawing.Point(341, 357)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(90, 34)
        Me.ButtonBack.TabIndex = 2
        Me.ButtonBack.Text = "Retour"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(338, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Classement"
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(462, 69)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(76, 24)
        Me.ButtonReset.TabIndex = 5
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 466)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.dgvClassement)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.dgvClassement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvClassement As DataGridView
    Friend WithEvents ButtonBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonReset As Button
End Class
