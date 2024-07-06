Public Class calcul_et_convertisation
    Dim chif1, chif2 As Double
    Private Sub CalculConv_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        actualis()
    End Sub
    Private Sub calcul_et_convertisation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chif1 = 0
        chif2 = 0
    End Sub

    Sub actualis()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        LblResulat.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        chif1 = TextBox1.Text
        chif2 = TextBox2.Text
        LblResulat.Text = Val(chif1) + Val(chif2)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        chif1 = TextBox1.Text
        chif2 = TextBox2.Text
        LblResulat.Text = Val(chif1) - Val(chif2)
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        LblResulat.Text = Val(LblResulat.Text) / Val(2850) & " " & "$"
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        LblResulat.Text = Val(LblResulat.Text) / Val(0.93) & " " & "€"
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        LblResulat.Text = Val(LblResulat.Text) / Val(0.79) & " " & "L"
    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        LblResulat.Text = Val(LblResulat.Text) / Val(18.04) & " " & "K"
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        actualis()
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        chif1 = TextBox1.Text
        chif2 = TextBox2.Text
        LblResulat.Text = Val(chif1) ^ Val(chif2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        chif1 = TextBox1.Text
        chif2 = TextBox2.Text
        LblResulat.Text = Val(chif1) * Val(chif2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        chif1 = TextBox1.Text
        chif2 = TextBox2.Text
        LblResulat.Text = Val(chif1) / Val(chif2)
    End Sub
End Class