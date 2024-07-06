Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or
TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or ComboBox2.Text = "" Or
ComboBox2.Text = "" Then
            MsgBox("Veuillez remplir le(s) champ(s)", vbInformation,
           "Rodrickumba@gmail.com")
            TextBox1.Focus()
            Exit Sub
        End If
        If MsgBox("Voulez-vous enrgeistrer ces informations", vbQuestion + vbYesNo,
       "Rodrickumba@gmail.com") = vbYes Then

            DataGridView1.Rows.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text,
           ComboBox1.Text, ComboBox2.Text, DateTimePicker1.Text, TextBox4.Text, TextBox5.Text,
           DateTimePicker2.Text, TextBox6.Text, TextBox7.Text, ListBox1.Text)
            TextBox1.ResetText()
            TextBox2.ResetText()
            TextBox3.ResetText()
            ComboBox2.ResetText()
            ComboBox2.ResetText()
            TextBox4.ResetText()
            TextBox5.ResetText()
            TextBox6.ResetText()
            TextBox7.ResetText()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Voulez-vous supprimer ces informations", vbQuestion + vbYesNo,
"Rodrickumba@gmail.com") = vbYes Then
            DataGridView1.Rows.Clear()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form3.Show()
        Me.Hide()

    End Sub

End Class