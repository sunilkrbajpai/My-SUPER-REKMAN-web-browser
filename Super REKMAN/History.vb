Public Class History
    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.DataSource = My.Settings.his
        Me.Visible = True
        Form1.Enabled = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.his.Clear()
        Me.Close()
        Form1.Enabled = True

    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click

    End Sub

    Private Sub History_Leave(sender As Object, e As EventArgs) Handles Me.Leave

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

        Form1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.his.Remove(ListBox1.SelectedItem)
        ListBox1.SelectedItems.Remove(ListBox1.SelectedItems)
        Me.Close()
        Form1.Enabled = True


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

    Private Sub History_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Enabled = True
    End Sub
End Class