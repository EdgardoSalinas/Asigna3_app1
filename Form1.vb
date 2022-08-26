Public Class Form1

    Public Function fn_promedio(ByVal a As Integer, ByVal b As Integer) As Integer
        Return (a + b) / 2
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, r As Integer
        a = Val(txt_numero1.Text)
        b = Val(txt_numero2.Text)
        r = fn_promedio(a, b)
        txt_promedio.Text = r.ToString

    End Sub
End Class
