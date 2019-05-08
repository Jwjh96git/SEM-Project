Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "Neeta Kadam" And TextBox2.Text = "kneeta" Then
            MessageBox.Show("login success")
            Home.Show()
            Hide()
        Else
            Shownotis()
        End If
    End Sub

    Public Sub Shownotis()
        MsgBox("Please enter the right user and password", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Warning")

    End Sub


End Class
