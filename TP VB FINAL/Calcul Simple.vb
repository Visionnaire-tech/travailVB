Public Class Calcul_Simple
    Dim a, b, c As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = Double.Parse(TextBox1.Text)
        b = Double.Parse(TextBox2.Text)
        c = a + b
        MsgBox("Somme est" + c.ToString)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub

    Private Sub Calcul_Simple_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class