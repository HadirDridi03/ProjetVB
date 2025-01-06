<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reservationForm
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
        txtRechercheDest = New TextBox()
        dtpRechercheDate = New DateTimePicker()
        dgvResult = New DataGridView()
        Numero = New DataGridViewTextBoxColumn()
        Destination = New DataGridViewTextBoxColumn()
        DateHeure = New DataGridViewTextBoxColumn()
        PlaceDispo = New DataGridViewTextBoxColumn()
        Prix = New DataGridViewTextBoxColumn()
        btnRechercher = New Button()
        label = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtTel = New TextBox()
        txtPrenom = New TextBox()
        txtNom = New TextBox()
        btnDeconnexion = New Button()
        btnReserver = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        CType(dgvResult, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtRechercheDest
        ' 
        txtRechercheDest.Location = New Point(278, 79)
        txtRechercheDest.Name = "txtRechercheDest"
        txtRechercheDest.Size = New Size(125, 27)
        txtRechercheDest.TabIndex = 0
        ' 
        ' dtpRechercheDate
        ' 
        dtpRechercheDate.Location = New Point(237, 138)
        dtpRechercheDate.Name = "dtpRechercheDate"
        dtpRechercheDate.Size = New Size(250, 27)
        dtpRechercheDate.TabIndex = 1
        ' 
        ' dgvResult
        ' 
        dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvResult.Columns.AddRange(New DataGridViewColumn() {Numero, Destination, DateHeure, PlaceDispo, Prix})
        dgvResult.Location = New Point(52, 258)
        dgvResult.Name = "dgvResult"
        dgvResult.RowHeadersWidth = 51
        dgvResult.Size = New Size(680, 131)
        dgvResult.TabIndex = 2
        ' 
        ' Numero
        ' 
        Numero.HeaderText = "Numéro de vol"
        Numero.MinimumWidth = 6
        Numero.Name = "Numero"
        Numero.Width = 125
        ' 
        ' Destination
        ' 
        Destination.HeaderText = "Destination de vol"
        Destination.MinimumWidth = 6
        Destination.Name = "Destination"
        Destination.Width = 125
        ' 
        ' DateHeure
        ' 
        DateHeure.HeaderText = "Date et heure du vol"
        DateHeure.MinimumWidth = 6
        DateHeure.Name = "DateHeure"
        DateHeure.Width = 125
        ' 
        ' PlaceDispo
        ' 
        PlaceDispo.HeaderText = "Nombre de places disponibles"
        PlaceDispo.MinimumWidth = 6
        PlaceDispo.Name = "PlaceDispo"
        PlaceDispo.Width = 125
        ' 
        ' Prix
        ' 
        Prix.HeaderText = "Prix du vol"
        Prix.MinimumWidth = 6
        Prix.Name = "Prix"
        Prix.Width = 125
        ' 
        ' btnRechercher
        ' 
        btnRechercher.BackColor = Color.IndianRed
        btnRechercher.Font = New Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRechercher.Location = New Point(552, 96)
        btnRechercher.Name = "btnRechercher"
        btnRechercher.Size = New Size(217, 69)
        btnRechercher.TabIndex = 3
        btnRechercher.Text = "Rechercher"
        btnRechercher.UseVisualStyleBackColor = False
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Font = New Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label.Location = New Point(52, 69)
        label.Name = "label"
        label.Size = New Size(157, 52)
        label.TabIndex = 4
        label.Text = "Destination:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(52, 520)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 52)
        Label1.TabIndex = 5
        Label1.Text = "Prénom:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(52, 460)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 52)
        Label2.TabIndex = 6
        Label2.Text = "Nom:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(52, 582)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 52)
        Label3.TabIndex = 7
        Label3.Text = "Téléphone:"
        ' 
        ' txtTel
        ' 
        txtTel.Location = New Point(216, 592)
        txtTel.Name = "txtTel"
        txtTel.Size = New Size(125, 27)
        txtTel.TabIndex = 10
        ' 
        ' txtPrenom
        ' 
        txtPrenom.Location = New Point(216, 530)
        txtPrenom.Name = "txtPrenom"
        txtPrenom.Size = New Size(125, 27)
        txtPrenom.TabIndex = 11
        ' 
        ' txtNom
        ' 
        txtNom.Location = New Point(216, 470)
        txtNom.Name = "txtNom"
        txtNom.Size = New Size(125, 27)
        txtNom.TabIndex = 12
        ' 
        ' btnDeconnexion
        ' 
        btnDeconnexion.BackColor = SystemColors.ActiveCaptionText
        btnDeconnexion.Font = New Font("Javanese Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeconnexion.ForeColor = Color.IndianRed
        btnDeconnexion.Location = New Point(196, 658)
        btnDeconnexion.Name = "btnDeconnexion"
        btnDeconnexion.Size = New Size(404, 64)
        btnDeconnexion.TabIndex = 13
        btnDeconnexion.Text = "Deconnexion"
        btnDeconnexion.UseVisualStyleBackColor = False
        ' 
        ' btnReserver
        ' 
        btnReserver.BackColor = Color.IndianRed
        btnReserver.Font = New Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReserver.Location = New Point(523, 504)
        btnReserver.Name = "btnReserver"
        btnReserver.Size = New Size(227, 68)
        btnReserver.TabIndex = 14
        btnReserver.Text = "Reserver"
        btnReserver.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Javanese Text", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.IndianRed
        Label4.Location = New Point(292, -2)
        Label4.Name = "Label4"
        Label4.Size = New Size(217, 78)
        Label4.TabIndex = 15
        Label4.Text = "Resérvation"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(52, 130)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 52)
        Label5.TabIndex = 16
        Label5.Text = "Date:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(52, 203)
        Label6.Name = "Label6"
        Label6.Size = New Size(208, 52)
        Label6.TabIndex = 17
        Label6.Text = "Vols disponibles:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Javanese Text", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.IndianRed
        Label7.Location = New Point(40, 392)
        Label7.Name = "Label7"
        Label7.Size = New Size(140, 78)
        Label7.TabIndex = 18
        Label7.Text = "Client:"
        ' 
        ' reservationForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._9ba7a6f8ff3d337564ee1fe7d97c74b1
        ClientSize = New Size(800, 737)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnReserver)
        Controls.Add(btnDeconnexion)
        Controls.Add(txtNom)
        Controls.Add(txtPrenom)
        Controls.Add(txtTel)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(label)
        Controls.Add(btnRechercher)
        Controls.Add(dgvResult)
        Controls.Add(dtpRechercheDate)
        Controls.Add(txtRechercheDest)
        Name = "reservationForm"
        Text = "reservationForm"
        CType(dgvResult, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtRechercheDest As TextBox
    Friend WithEvents dtpRechercheDate As DateTimePicker
    Friend WithEvents dgvResult As DataGridView
    Friend WithEvents btnRechercher As Button
    Friend WithEvents label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents btnDeconnexion As Button
    Friend WithEvents btnReserver As Button
    Friend WithEvents Numero As DataGridViewTextBoxColumn
    Friend WithEvents Destination As DataGridViewTextBoxColumn
    Friend WithEvents DateHeure As DataGridViewTextBoxColumn
    Friend WithEvents PlaceDispo As DataGridViewTextBoxColumn
    Friend WithEvents Prix As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
