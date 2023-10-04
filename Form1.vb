Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As Double
        Dim B As Double
        Dim C As Double
        A = Val(TextBox1.Text)
        B = Val(TextBox2.Text)
        C = (A ^ 2 + B ^ 2) ^ 0.5

        TextBox3.Text = C
    End Sub
End Class
