Imports System.Net
Public Class Downloadertab
    Dim sta As Boolean = False
    Private WithEvents httpclient As WebClient
    Private Sub Downloadertab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.down.Add(TextBox2.Text)

        sta = True
        ProgressBar1.Style = ProgressBarStyle.Continuous
        MsgBox("Starting to download...")
        ProgressBar1.Style = ProgressBarStyle.Blocks
        httpclient = New WebClient
        Dim save As String = TextBox2.Text
        Dim download As String = TextBox1.Text
        httpclient.DownloadFileAsync(New Uri(download), save)
        Label3.Text = "Current Status =      Downloading..."
        Button1.Enabled = False
        Button2.Enabled = False
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SaveFileDialog1.ShowDialog()
        SaveFileDialog1.Title = "Save File to..."
        TextBox2.Text = SaveFileDialog1.FileName
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    End Sub
    Private Sub httpclient_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles httpclient.DownloadProgressChanged
        ProgressBar1.Maximum = e.TotalBytesToReceive
        ProgressBar1.Value = e.BytesReceived
        Label4.Text = "Downloading Status" & e.ProgressPercentage & "%"
        If e.ProgressPercentage = 100 Then
            Label3.Text = "Current Status =      Completed"
            MsgBox("Download completed")
            Me.Close()

        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If sta = True Then
            httpclient.CancelAsync()
            sta = False
            Button1.Enabled = True
            Button2.Enabled = True
        End If
        Label3.Text = "Current Status =      Cancelled !"
        Me.Close()
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Button1.Enabled = True
    End Sub
End Class