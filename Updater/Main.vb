Imports System.Net
Imports System.IO.FileStream
Imports System.IO.StreamReader
Imports System.IO.TextReader
Imports System.Windows.Forms
Imports System.IO.File
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Security
Imports System.IO

Public Class Main
    ' répertoire de base
    Private Repertoire As String = "C:\nom de l'éditeur\nom du logiciel\"
    Private VersionActuelle As String = My.Computer.FileSystem.ReadAllText(Repertoire & "VERSION\version.md") ' Version actuelle de ce logiciel
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Création des répertoire du logiciel.
        If System.IO.Directory.Exists(Repertoire) = False Then
            ' on crée le répertoire de base ainsi que les sous-répertoires 
            System.IO.Directory.CreateDirectory(Repertoire)
            System.IO.Directory.CreateDirectory(Repertoire & "UPDATE\")
            System.IO.Directory.CreateDirectory(Repertoire & "LOG\")
            System.IO.Directory.CreateDirectory(Repertoire & "VERSION\")
            System.IO.Directory.CreateDirectory(Repertoire & "DATA\")
            System.IO.Directory.CreateDirectory(Repertoire & "USERDATA\")
            System.IO.Directory.CreateDirectory(Repertoire & "LOG\MARKDOWN_UPDATE\")
            System.IO.Directory.CreateDirectory(Repertoire & "UPDATE\SOFTWARE\")
        End If

        ' Elements masqué lors de l'affichage de "UpdateDialog".
        GB_DOWNLOAD.Visible = False ' GroupBox de "Logiciel à jour".
        GB_INSTALL.Visible = False ' GroupBox de "Mise à jour disponible".

        ' Elements fonctionnelle lors de l'affichage de la form.
        TXT_VERSION.Text = "Version actuel : " & Application.ProductVersion
        Label3.Text = "Version actuelle : " & Application.ProductVersion
    End Sub

    Private Sub B_SearchUpdate_Click(sender As Object, e As EventArgs) Handles B_SearchUpdate.Click
        CheckUpdates() ' On apelle la fonction CheckUpdate qui verifie les mise à jour disponible
    End Sub

    Sub CheckUpdates() ' Fonction CheckUpdate qui sera appelé au lancement du logiciel
        If My.Computer.FileSystem.FileExists(Repertoire & "VERSION\version.md") Then
            My.Computer.FileSystem.DeleteFile(Repertoire & "VERSION\version.md")
            Dim Client As WebClient = New WebClient
            Client.DownloadFileAsync(New Uri("URL du fichier .md"), Repertoire & "VERSION\version.md")
            MsgBox("Toutes nos excuses 😥" & vbNewLine & "Le fichier n'existe pas dans la base de données du logiciel" & vbNewLine & "Nous allons télécharger le fichier.", MsgBoxStyle.Exclamation, "Fichier introuvable")
        Else  'Sinon, 
            Dim Client As WebClient = New WebClient
            Client.DownloadFileAsync(New Uri("URL du fichier .md"), "Lien répertoire ou le fichier .md seras")
            MsgBox("Félicitation 😉" & vbNewLine & "Vous allez pouvoir poursuivre la mise à jour", MsgBoxStyle.Information, "Poursuite de l'update acquis")
        End If

        Dim MAJ As New WebClient ' 
        Dim DernireVersion As String = My.Computer.FileSystem.ReadAllText(Repertoire & "VERSION\version.md")
        Label3.Text = "Version actuelle : " & Application.ProductVersion & vbNewLine & "Nouvelle version : " & DernireVersion
        If VersionActuelle = DernireVersion Then
            MsgBox("Le logiciel est à jour" & vbNewLine & "Version disponible : " & DernireVersion, MsgBoxStyle.Information, "UPDATE")
        Else 'sinon
            MsgBox("Le logiciel n'est pas à jour" & vbNewLine & "La dernière version est : " & DernireVersion, vbOKOnly + MsgBoxStyle.Critical, "Erreur")
            GB_DOWNLOAD.Visible = True
            My.Computer.FileSystem.DeleteFile(Repertoire & "VERSION\version.md")
            GB_INSTALL.Visible = False
        End If
    End Sub

    Private Sub B_DownloadUpdate_Click(sender As Object, e As EventArgs) Handles B_DownloadUpdate.Click
        Try
            Dim Client As WebClient = New WebClient
            AddHandler Client.DownloadProgressChanged, AddressOf client_ProgressChanged

            AddHandler Client.DownloadFileCompleted, AddressOf client_DownloadCompleted

            Client.DownloadFileAsync(New Uri("URL sources de votre logiciel (.exe)"), Repertoire & "UPDATE\SOFTWARE\ Nom du logiciel .exe")
            txt_status.Text = "Téléchargement en cours..."
            txt_status.Enabled = False
            Timer1.Start()
            txt_status.Visible = True
            Label1.Visible = True
            PB_POURCENTAGES.Visible = True
            ProgressBar1.Visible = True
            B_DownloadUpdate.Enabled = False
        Catch exception1 As Exception
            MsgBox("Toutes nos excuses 😥" & vbNewLine & "Le téléchargement n'à pas plus se faire" & vbNewLine & "Nous allons fermer automatiquement le logiciel.", MsgBoxStyle.Exclamation, "Echec de téléchargement")
            Application.Exit()
        End Try
    End Sub

    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Try
            Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
            Dim bytesIn3 As Double = bytesIn / 1024
            Dim bytesIn2 As Integer = bytesIn3
            Format(bytesIn2, "#0")

            Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())

            Dim totalBytes3 As Double = totalBytes / 1024
            Dim totalBytes2 As Integer = totalBytes3
            Format(totalBytes, "#0")

            Dim percentage As Double = bytesIn / totalBytes * 100

            ProgressBar1.Value = Int32.Parse(Math.Truncate(percentage).ToString())
            Label1.Text = bytesIn2 & " Ko" & " sur " & totalBytes2 & " Ko"
            PB_POURCENTAGES.Text = ProgressBar1.Value & " %"
        Catch exception1 As Exception
            MsgBox("Toutes nos excuses 😥" & vbNewLine & "Le téléchargement n'à pas plus se faire" & vbNewLine & "Nous allons fermer automatiquement le logiciel.", MsgBoxStyle.Exclamation, "Echec de téléchargement")
            Application.Exit()
        End Try
    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Try
            GB_DOWNLOAD.Visible = False
            GB_INSTALL.Visible = True
            MsgBox("Félicitation 😉" & vbNewLine & "Le téléchargement à bien était fait.", MsgBoxStyle.Information, "Téléchargement terminé")
            Timer1.Stop()
        Catch exception1 As Exception
            MsgBox("Toutes nos excuses 😥" & vbNewLine & "Le téléchargement n'à pas plus se faire" & vbNewLine & "Nous allons fermer automatiquement le logiciel.", MsgBoxStyle.Exclamation, "Echec de téléchargement")
            Application.Exit()
        End Try
    End Sub

    Private Sub CB_INSTALL_CheckedChanged(sender As Object, e As EventArgs) Handles CB_INSTALL.CheckedChanged
        Process.Start(Repertoire & "UPDATE\SOFTWARE\ Nom du logiciel .exe")
        Application.Exit()
    End Sub

    Private Sub CB_DECLINE_CheckedChanged(sender As Object, e As EventArgs) Handles CB_DECLINE.CheckedChanged
        MsgBox("Pour installer la nouvelle version." & vbNewLine & "vous serez obligez de rechercher une nouvelle mise à jour.", MsgBoxStyle.Information, "Installation annulée")
        Me.Close()
    End Sub
End Class