Public Class calc

    Dim int1 As New Decimal
    Dim int2 As New Decimal

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Please Enter the numbers first")
        Else
            Try
                int1 = TextBox1.Text
                int2 = TextBox2.Text
                Label4.Text = "=" & int1 + int2
            Catch ex As Exception
                MsgBox("Invalid Number!")
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Please Enter the numbers first")
        Else
            Try
                int1 = TextBox1.Text
                int2 = TextBox2.Text
                Label4.Text = "=" & int1 * int2
            Catch ex As Exception
                MsgBox("Invalid Number!")
            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""

        Label4.Text = ""
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Please Enter the numbers first")
        Else
            Try
                int1 = TextBox1.Text
                int2 = TextBox2.Text
                Label4.Text = "=" & int1 - int2
            Catch ex As Exception
                MsgBox("Invalid Number!")
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Please Enter the numbers first")
        Else
            Try
                int1 = TextBox1.Text
                int2 = TextBox2.Text
                Label4.Text = "=" & int1 / int2
            Catch ex As Exception
                MsgBox("Invalid Number!")
            End Try
        End If
    End Sub

    Private Sub calc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class