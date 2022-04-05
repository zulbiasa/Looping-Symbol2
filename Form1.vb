Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y As Integer

        For x = 1 To 3
            For y = 1 To 5
                TextBox1.Text = TextBox1.Text & "$" & vbCr
            Next y
            TextBox1.Text = TextBox1.Text & vbCrLf
        Next x
    End Sub
End Class
