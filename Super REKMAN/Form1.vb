Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As New TabPage
        Dim newtab As New tab
        newtab.Show()
        newtab.TopLevel = False
        newtab.Dock = DockStyle.Fill
        t.Controls.Add(newtab)
        TabControl1.TabPages.Add(t)


    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If tab.Panel1.Visible = False Then
            tab.Panel2.Visible = True
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.TabControl1.TabPages.Count > 1 Then
            Dim res As DialogResult = MessageBox.Show("More than one tab are Opened. Do You want to close all ?", "++   Super REKMAN   ++", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If res = DialogResult.Yes Then
                Application.Exit()
            Else
                e.Cancel = True
            End If
        Else
            Application.Exit()
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub
End Class
