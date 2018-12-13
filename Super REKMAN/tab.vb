Imports AxSHDocVw
Imports System.Diagnostics
Imports System.Windows
Imports System.Text.RegularExpressions
Imports Microsoft.Win32
Imports System
Imports System.Drawing
Imports System.Drawing.Graphics
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net
Public Class tab
    Public statusnum As Boolean = False
    Public off As Boolean = False

    Private Sub tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWebBrowser1.Navigate(My.Settings.homepage)
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)
    End Sub
    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
    End Sub
    Private Sub FullScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullScreenToolStripMenuItem.Click
        Form1.WindowState = System.Windows.Forms.FormWindowState.Maximized
        NewTabToolStripMenuItem.Enabled = False
        Panel1.Hide()
        MenuStrip1.Hide()
        Form1.FormBorderStyle = FormBorderStyle.None
        Button7.Hide()
        ProgressBar1.Hide()
        Panel2.Show()
        Label2.Hide()
        AxWebBrowser1.Dock = DockStyle.Fill
        Label21.Hide()
        Label3.Hide()
        Button13.Hide()
    End Sub
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
    End Sub
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
    End Sub
    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AxWebBrowser1.GoBack()
        Button2.Visible = True
        Button9.Visible = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxWebBrowser1.GoForward()
        Button1.Visible = True
        Button2.Visible = False
        Button8.Visible = False
        Button9.Visible = True
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AxWebBrowser1.Navigate(My.Settings.homepage)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text.StartsWith("http://www.") Then
            AxWebBrowser1.Navigate(TextBox1.Text)
        ElseIf TextBox1.Text.StartsWith("https://www.") Then
            AxWebBrowser1.Navigate(TextBox1.Text)
        Else
            If TextBox1.Text.Contains(":\") And off = True Then
                AxWebBrowser1.Navigate(TextBox1.Text)
            Else
                Dim add As String
                Dim rec As String
                add = "https://www.google.co.in/search?q="
                rec = "&oq="
                AxWebBrowser1.Navigate(add + TextBox1.Text + rec + TextBox1.Text)
            End If
        End If
        Button1.Visible = True
        Button8.Visible = False
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AxWebBrowser1.Refresh()
        Button11.Visible = True
        Button4.Visible = False
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Button1.Visible = True
        Button8.Visible = False
    End Sub
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
    End Sub
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim t As New TabPage
        Dim newtab As New tab
        newtab.Show()
        newtab.TopLevel = False
        newtab.Dock = DockStyle.Fill
        t.Controls.Add(newtab)
        Form1.TabControl1.TabPages.Add(t)
    End Sub
    Private Sub AxWebBrowser1_Enter(sender As Object, e As EventArgs)
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        AxWebBrowser1.Stop()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
    End Sub
    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
    End Sub
    Private Sub NewTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewTabToolStripMenuItem.Click
        Dim t As New TabPage
        Dim newtab As New tab
        newtab.Show()
        newtab.TopLevel = False
        newtab.Dock = DockStyle.Fill
        t.Controls.Add(newtab)
        Form1.TabControl1.TabPages.Add(t)
    End Sub
    Private Sub RemoveTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveTabToolStripMenuItem.Click
        Form1.TabControl1.TabPages.Remove(Form1.TabControl1.SelectedTab)
        If Form1.TabControl1.TabPages.Count = 0 Then
            Form1.Close()
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If Form1.TabControl1.TabPages.Count > 1 Then
            Dim result As DialogResult = MessageBox.Show("More than one tab are Opened. Do You want to close all ?", "++  Super REKMAN  ++", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.Yes Then
                Form1.Close()
            Else

            End If
        Else
            Form1.Close()
        End If
    End Sub
    Private Sub RefreshTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshTabToolStripMenuItem.Click
        Button4.PerformClick()
    End Sub
    Private Sub NewWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        Dim f As New Form
        Dim f1 = New Form1
        f1.Show()
    End Sub
    Private Sub AxWebBrowser1_Enter_1(sender As Object, e As EventArgs) Handles AxWebBrowser1.Enter
    End Sub
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Settings.Show()
    End Sub
    Private Sub AxWebBrowser1_NavigateComplete2(sender As Object, e As DWebBrowserEvents2_NavigateComplete2Event) Handles AxWebBrowser1.NavigateComplete2
        Parent.Text = AxWebBrowser1.LocationName
        If statusnum = False Then
            My.Settings.his.Add(AxWebBrowser1.LocationURL)
        Else
            My.Settings.his.Add("-----------NO data due to incognito.-----------")
        End If
        If AxWebBrowser1.LocationURL.StartsWith("https://www.youtube.com/") Then
            Button13.Show()
        End If
    End Sub
    Private Sub AxWebBrowser1_ProgressChange(sender As Object, e As DWebBrowserEvents2_ProgressChangeEvent) Handles AxWebBrowser1.ProgressChange
        Try
            ProgressBar1.Maximum = e.progressMax
            ProgressBar1.Value = e.progress
            Label2.Text = "Loading"
            Label21.Text = "Transferring Data ..."
            If ProgressBar1.Value = ProgressBar1.Maximum Then
                Label2.Text = "Done"
                Label21.Text = AxWebBrowser1.LocationURL
            End If
        Catch ex As Exception
            Label2.Text = "Error"
            Label21.Text = AxWebBrowser1.LocationURL
        End Try
        Button10.Hide()
        Button6.Show()
        Button4.Visible = True
        Button11.Visible = False
    End Sub
    Private Sub AxWebBrowser1_DocumentComplete(sender As Object, e As DWebBrowserEvents2_DocumentCompleteEvent) Handles AxWebBrowser1.DocumentComplete
        TextBox1.Text = AxWebBrowser1.LocationURL.ToString
        'Parent.Text = AxWebBrowser1.LocationName
        SavePageToolStripMenuItem.Enabled = True
        If AxWebBrowser1.LocationURL.EndsWith(".pdf") Then
            AxWebBrowser1.Stop()
            Downloadertab.Show()
            Downloadertab.TextBox1.Text = AxWebBrowser1.LocationURL
        End If
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button3.PerformClick()
        End If
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
    End Sub
    Private Sub Label21_MouseEnter(sender As Object, e As EventArgs) Handles Label21.MouseEnter
        Label21.Hide()
    End Sub
    Private Sub Label21_MouseLeave(sender As Object, e As EventArgs) Handles Label21.MouseLeave
        Label21.Show()
    End Sub
    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
    End Sub
    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDialog1.ShowDialog()
    End Sub
    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
        History.Show()
    End Sub
    Private Sub AxWebBrowser1_NavigateError(sender As Object, e As DWebBrowserEvents2_NavigateErrorEvent) Handles AxWebBrowser1.NavigateError
        'Parent.Text = "Problem Loading Page"
    End Sub
    Private Sub AxWebBrowser1_FileDownload(sender As Object, e As DWebBrowserEvents2_FileDownloadEvent) Handles AxWebBrowser1.FileDownload
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Panel1.Show()
        MenuStrip1.Show()
        Form1.FormBorderStyle = FormBorderStyle.Sizable
        Button7.Show()
        ProgressBar1.Show()
        Panel2.Hide()
        NewTabToolStripMenuItem.Enabled = True
        AxWebBrowser1.Dock = DockStyle.None
        Label21.Show()
        AxWebBrowser1.Anchor = AnchorStyles.Bottom + AnchorStyles.Top + AnchorStyles.Left + AnchorStyles.Right
        AxWebBrowser1.Location = New Point(0, 71)
        Button13.Show()
        Label3.Show()
    End Sub
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
    End Sub
    Private Sub Panel2_DragOver(sender As Object, e As DragEventArgs) Handles Panel2.DragOver
    End Sub
    Private Sub Panel2_MouseEnter(sender As Object, e As EventArgs) Handles Panel2.MouseEnter
    End Sub
    Private Sub tab_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
    End Sub
    Private Sub AxWebBrowser1_OnFullScreen(sender As Object, e As DWebBrowserEvents2_OnFullScreenEvent) Handles AxWebBrowser1.OnFullScreen
    End Sub
    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        about.Show()
    End Sub
    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        calc.Show()
    End Sub
    Private Sub NotepadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotepadToolStripMenuItem.Click
        Process.Start("notepad.exe")
    End Sub
    Private Sub DownloadManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadManagerToolStripMenuItem.Click
    End Sub
    Private Sub Label21_MouseMove(sender As Object, e As MouseEventArgs) Handles Label21.MouseMove
        Label21.Hide()
    End Sub
    Private Sub OnlineHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnlineHelpToolStripMenuItem.Click
        Dim t As New TabPage
        Dim ewtab As New tab
        ewtab.Show()
        ewtab.TopLevel = False
        ewtab.Dock = DockStyle.Fill
        t.Controls.Add(ewtab)
        Form1.TabControl1.TabPages.Add(t)
        ewtab.AxWebBrowser1.Navigate("www.skb.tk")
    End Sub
    Private Sub ToolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolsToolStripMenuItem.Click
    End Sub
    Private Sub FavoritesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FavoritesToolStripMenuItem.Click
        favoritestab.Show()
    End Sub
    Private Sub Button6_MouseHover(sender As Object, e As EventArgs) Handles Button6.MouseHover
    End Sub
    Private Sub Button6_MouseEnter(sender As Object, e As EventArgs) Handles Button6.MouseEnter
    End Sub
    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles Button6.MouseLeave
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Settings.favor.Add(AxWebBrowser1.LocationURL.ToString)
        Button6.Hide()
        Button10.Show()
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Panel1.Show()
        MenuStrip1.Show()
        Form1.FormBorderStyle = FormBorderStyle.Sizable
        Button7.Show()
        ProgressBar1.Show()
        Panel2.Hide()
        NewTabToolStripMenuItem.Enabled = True
        AxWebBrowser1.Dock = DockStyle.None
        Label21.Show()
        AxWebBrowser1.Anchor = AnchorStyles.Bottom + AnchorStyles.Top + AnchorStyles.Left + AnchorStyles.Right
        AxWebBrowser1.Location = New Point(0, 71)
        Button13.Show()
        Label3.Show()

    End Sub
    Private Sub DownloadsToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub
    Private Sub NewIncognitoWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewIncognitoWindowToolStripMenuItem.Click
        statusnum = True
        HistoryToolStripMenuItem.Visible = False
        ToolStripMenuItem1.Visible = True
        NewIncognitoWindowToolStripMenuItem.Visible = False
        Label3.Show()
        PictureBox1.Show()
        INCOGNITO.Show()
        Label21.Hide()
        Form1.Enabled = False

    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If Form1.TabControl1.TabPages.Count > 1 Then
            Dim result As DialogResult = MessageBox.Show("More than one tab are Opened. Do you really want to exit INCOGNITO mode ? It will save history of all the opening tabs..", "++   Super REKMAN   ++", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                statusnum = False
                HistoryToolStripMenuItem.Visible = True
                Label3.Hide()
                ToolStripMenuItem1.Visible = False
                NewIncognitoWindowToolStripMenuItem.Visible = True
                Label21.Show()
                PictureBox1.Hide()
            Else

            End If
        Else
            statusnum = False
            HistoryToolStripMenuItem.Visible = True
            Label3.Hide()
            ToolStripMenuItem1.Visible = False
            NewIncognitoWindowToolStripMenuItem.Visible = True
            Label21.Show()
            PictureBox1.Hide()
        End If

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    End Sub
    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Hide()
    End Sub
    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Show()
    End Sub
    Private Sub SavePageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SavePageToolStripMenuItem.Click
        WebBrowser1.Navigate(AxWebBrowser1.LocationURL)
        SavePageToolStripMenuItem.Enabled = False
        MsgBox("Saving Webpage!")
        GetImage()
    End Sub
    Private Sub GetImage()
        If WebBrowser1.Document Is Nothing Then
            Return
        End If
        Try
            Dim scrollWidth As Integer
            Dim scrollHeight As Integer
            scrollHeight = WebBrowser1.Document.Body.ScrollRectangle.Height
            scrollWidth = WebBrowser1.Document.Body.ScrollRectangle.Width
            WebBrowser1.Size = New Size(scrollWidth, scrollHeight)
            Dim bm As New Bitmap(scrollWidth, scrollHeight)
            WebBrowser1.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
            Dim SaveAsName As String
            SaveAsName = Regex.Replace(AxWebBrowser1.LocationName, "(\\|\/|\:|\*|\?|\""|\<|\>|\|)?", "")
            bm.Save(SaveAsName & ".png", System.Drawing.Imaging.ImageFormat.Png)
            bm.Dispose()
            MsgBox("Page Saved!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
        SavePageToolStripMenuItem.Enabled = True
    End Sub
    Private Sub Label21_TextChanged(sender As Object, e As EventArgs) Handles Label21.TextChanged
    End Sub
    Private Sub AxWebBrowser1_DownloadComplete(sender As Object, e As EventArgs) Handles AxWebBrowser1.DownloadComplete
    End Sub
    Private Sub DownloadsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DownloadsToolStripMenuItem.Click
        downloadspage.Show()
    End Sub
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Downloadertab.Show()
        Downloadertab.Visible = True
    End Sub
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If (AxWebBrowser1.LocationURL.StartsWith("https://www.youtube.com/")) Then
            Dim nam, add As String
            nam = AxWebBrowser1.LocationURL.Substring(AxWebBrowser1.LocationURL.IndexOf(".") + 1)
            add = "https://www.ss"
            Dim t As New TabPage
            Dim ewtab As New tab
            ewtab.Show()
            ewtab.TopLevel = False
            ewtab.Dock = DockStyle.Fill
            t.Controls.Add(ewtab)
            Form1.TabControl1.TabPages.Add(t)
            ewtab.AxWebBrowser1.Navigate(add + nam)
        Else

        End If
    End Sub

    Private Sub ShortcutsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShortcutsToolStripMenuItem.Click
        know_shortcuts.Show()
    End Sub

    Private Sub OfflineModeONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OfflineModeONToolStripMenuItem.Click
        off = True
        OfflineModeOFFToolStripMenuItem.Visible = True
        OfflineModeONToolStripMenuItem.Visible = False
    End Sub

    Private Sub OfflineModeOFFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OfflineModeOFFToolStripMenuItem.Click
        off = False
        OfflineModeOFFToolStripMenuItem.Visible = False
        OfflineModeONToolStripMenuItem.Visible = True
    End Sub
End Class


