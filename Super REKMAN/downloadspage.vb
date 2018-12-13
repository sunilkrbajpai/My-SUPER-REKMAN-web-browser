Public Class downloadspage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.down.Remove(ListBox1.SelectedItem)
        ListBox1.SelectedItems.Remove(ListBox1.SelectedItems)
        Me.Close()
        Form1.Enabled = True
    End Sub
    Private Sub downloadspage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.DataSource = My.Settings.down
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.down.Clear()
        Me.Close()
        Form1.Enabled = True
    End Sub
End Class