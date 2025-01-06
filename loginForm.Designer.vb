<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        txtNom = New TextBox()
        cmbRole = New ComboBox()
        btnConnexion = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtMdp = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' txtNom
        ' 
        txtNom.Location = New Point(379, 114)
        txtNom.Name = "txtNom"
        txtNom.Size = New Size(275, 27)
        txtNom.TabIndex = 0
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Admin", "Utilisateur"})
        cmbRole.Location = New Point(379, 258)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(275, 28)
        cmbRole.TabIndex = 1
        ' 
        ' btnConnexion
        ' 
        btnConnexion.BackColor = Color.IndianRed
        btnConnexion.Font = New Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConnexion.Location = New Point(289, 359)
        btnConnexion.Name = "btnConnexion"
        btnConnexion.Size = New Size(197, 51)
        btnConnexion.TabIndex = 2
        btnConnexion.Text = "Se connecter"
        btnConnexion.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(131, 104)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 52)
        Label1.TabIndex = 3
        Label1.Text = "Nom:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(92, 173)
        Label2.Name = "Label2"
        Label2.Size = New Size(172, 52)
        Label2.TabIndex = 4
        Label2.Text = "Mot de passe:"
        ' 
        ' txtMdp
        ' 
        txtMdp.Location = New Point(379, 183)
        txtMdp.Name = "txtMdp"
        txtMdp.Size = New Size(275, 27)
        txtMdp.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(133, 248)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 52)
        Label3.TabIndex = 6
        Label3.Text = "Rôle:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Javanese Text", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.IndianRed
        Label4.Location = New Point(288, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(198, 78)
        Label4.TabIndex = 7
        Label4.Text = "Connexion"
        ' 
        ' loginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._9ba7a6f8ff3d337564ee1fe7d97c74b1
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtMdp)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnConnexion)
        Controls.Add(cmbRole)
        Controls.Add(txtNom)
        Name = "loginForm"
        Text = "loginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNom As TextBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnConnexion As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMdp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
