Public Class favoritestab
    Private Sub favoritestab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.DataSource = My.Settings.favor

        TextBox1.Text = "http://"
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.favor.Remove(ListBox1.SelectedItem)
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.favor.Add(TextBox1.Text)
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        Dim t As New TabPage
        Dim ewtab As New tab
        ewtab.Show()
        ewtab.TopLevel = False
        ewtab.Dock = DockStyle.Fill
        t.Controls.Add(ewtab)
        Form1.TabControl1.TabPages.Add(t)
        ewtab.AxWebBrowser1.Navigate(ListBox1.SelectedItem)
    End Sub
End Class