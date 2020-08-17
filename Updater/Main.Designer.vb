<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.B_DownloadUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PB_POURCENTAGES = New System.Windows.Forms.Label()
        Me.txt_status = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GB_DOWNLOAD = New System.Windows.Forms.GroupBox()
        Me.GB_INSTALL = New System.Windows.Forms.GroupBox()
        Me.CB_DECLINE = New System.Windows.Forms.CheckBox()
        Me.CB_INSTALL = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_VERSION = New System.Windows.Forms.Label()
        Me.B_SearchUpdate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GB_DOWNLOAD.SuspendLayout()
        Me.GB_INSTALL.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'B_DownloadUpdate
        '
        Me.B_DownloadUpdate.Location = New System.Drawing.Point(5, 12)
        Me.B_DownloadUpdate.Name = "B_DownloadUpdate"
        Me.B_DownloadUpdate.Size = New System.Drawing.Size(598, 23)
        Me.B_DownloadUpdate.TabIndex = 0
        Me.B_DownloadUpdate.Text = "TÉLÉCHARGER LA MISE À JOURS MAINTENANT "
        Me.B_DownloadUpdate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "0 % sur 0 %"
        '
        'PB_POURCENTAGES
        '
        Me.PB_POURCENTAGES.Location = New System.Drawing.Point(529, 64)
        Me.PB_POURCENTAGES.Name = "PB_POURCENTAGES"
        Me.PB_POURCENTAGES.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PB_POURCENTAGES.Size = New System.Drawing.Size(67, 13)
        Me.PB_POURCENTAGES.TabIndex = 3
        Me.PB_POURCENTAGES.Text = "0 %"
        Me.PB_POURCENTAGES.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_status
        '
        Me.txt_status.Location = New System.Drawing.Point(6, 64)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(517, 13)
        Me.txt_status.TabIndex = 5
        Me.txt_status.Text = "En attente de téléchargement..."
        Me.txt_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(5, 41)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(598, 19)
        Me.ProgressBar1.TabIndex = 6
        '
        'GB_DOWNLOAD
        '
        Me.GB_DOWNLOAD.Controls.Add(Me.Label1)
        Me.GB_DOWNLOAD.Controls.Add(Me.txt_status)
        Me.GB_DOWNLOAD.Controls.Add(Me.PB_POURCENTAGES)
        Me.GB_DOWNLOAD.Controls.Add(Me.ProgressBar1)
        Me.GB_DOWNLOAD.Controls.Add(Me.B_DownloadUpdate)
        Me.GB_DOWNLOAD.Location = New System.Drawing.Point(12, 49)
        Me.GB_DOWNLOAD.Name = "GB_DOWNLOAD"
        Me.GB_DOWNLOAD.Size = New System.Drawing.Size(609, 109)
        Me.GB_DOWNLOAD.TabIndex = 7
        Me.GB_DOWNLOAD.TabStop = False
        '
        'GB_INSTALL
        '
        Me.GB_INSTALL.Controls.Add(Me.CB_DECLINE)
        Me.GB_INSTALL.Controls.Add(Me.CB_INSTALL)
        Me.GB_INSTALL.Controls.Add(Me.Label2)
        Me.GB_INSTALL.Location = New System.Drawing.Point(12, 50)
        Me.GB_INSTALL.Name = "GB_INSTALL"
        Me.GB_INSTALL.Size = New System.Drawing.Size(609, 109)
        Me.GB_INSTALL.TabIndex = 8
        Me.GB_INSTALL.TabStop = False
        '
        'CB_DECLINE
        '
        Me.CB_DECLINE.Location = New System.Drawing.Point(29, 68)
        Me.CB_DECLINE.Name = "CB_DECLINE"
        Me.CB_DECLINE.Size = New System.Drawing.Size(526, 24)
        Me.CB_DECLINE.TabIndex = 13
        Me.CB_DECLINE.Text = "Je souhaite installer la mise à jour du logiciel plus tard."
        Me.CB_DECLINE.UseVisualStyleBackColor = True
        '
        'CB_INSTALL
        '
        Me.CB_INSTALL.Location = New System.Drawing.Point(29, 42)
        Me.CB_INSTALL.Name = "CB_INSTALL"
        Me.CB_INSTALL.Size = New System.Drawing.Size(567, 24)
        Me.CB_INSTALL.TabIndex = 12
        Me.CB_INSTALL.Text = "Je souhaite installer maintenant la mise à jour du logiciel."
        Me.CB_INSTALL.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(6, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Installer la nouvelle mise à jour"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(609, 40)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Pour rechercher si une mise à jour et disponible," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cliquez sur le bouton ""Recherc" &
    "her une mise à jour""."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 19.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(302, 30)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Système de mise à jour"
        '
        'TXT_VERSION
        '
        Me.TXT_VERSION.Location = New System.Drawing.Point(192, 103)
        Me.TXT_VERSION.Name = "TXT_VERSION"
        Me.TXT_VERSION.Size = New System.Drawing.Size(248, 17)
        Me.TXT_VERSION.TabIndex = 11
        Me.TXT_VERSION.Text = "{_infos_software_and_build_}"
        Me.TXT_VERSION.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'B_SearchUpdate
        '
        Me.B_SearchUpdate.Location = New System.Drawing.Point(195, 123)
        Me.B_SearchUpdate.Name = "B_SearchUpdate"
        Me.B_SearchUpdate.Size = New System.Drawing.Size(245, 23)
        Me.B_SearchUpdate.TabIndex = 12
        Me.B_SearchUpdate.Text = "RECHERCHER UNE MISE À JOUR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.B_SearchUpdate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Location = New System.Drawing.Point(320, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(301, 30)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Version actuelle : {_Application.ProductVersion_}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nouvelle version : {_File_Buil" &
    "dApp}"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 169)
        Me.Controls.Add(Me.GB_DOWNLOAD)
        Me.Controls.Add(Me.GB_INSTALL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.B_SearchUpdate)
        Me.Controls.Add(Me.TXT_VERSION)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Main"
        Me.Text = "Mise à jour : Nom du logiciel"
        Me.GB_DOWNLOAD.ResumeLayout(False)
        Me.GB_DOWNLOAD.PerformLayout()
        Me.GB_INSTALL.ResumeLayout(False)
        Me.GB_INSTALL.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents B_DownloadUpdate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PB_POURCENTAGES As Label
    Friend WithEvents txt_status As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents GB_DOWNLOAD As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GB_INSTALL As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_VERSION As Label
    Friend WithEvents B_SearchUpdate As Button
    Friend WithEvents CB_DECLINE As CheckBox
    Friend WithEvents CB_INSTALL As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
