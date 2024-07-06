Public Class Calculatrice
    Dim operand1, operand2 As Double
    Dim operation As String
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles cmdsix.Click
        TxtChiffre.Text = TxtChiffre.Text + "6"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles cmdegal.Click
        operand2 = Val(TxtChiffre.Text)
        If operation = "+" Then
            TxtChiffre.Text = operand1 + operand2
        ElseIf operation = "" Then
            TxtChiffre.Text = operand1 - operand2
        ElseIf operation = "*" Then
            TxtChiffre.Text = operand1 * operand2
        Else
            TxtChiffre.Text = operand1 / operand2
        End If
    End Sub

    Private Sub cmdeffacée_Click(sender As Object, e As EventArgs) Handles cmdeffacée.Click
        TxtChiffre.Text = ""
    End Sub

    Private Sub cmdsept_Click(sender As Object, e As EventArgs) Handles cmdsept.Click
        TxtChiffre.Text = TxtChiffre.Text + "7"
    End Sub

    Private Sub cmdhuit_Click(sender As Object, e As EventArgs) Handles cmdhuit.Click
        TxtChiffre.Text = TxtChiffre.Text + "8"
    End Sub

    Private Sub cmdnerf_Click(sender As Object, e As EventArgs) Handles cmdnerf.Click
        TxtChiffre.Text = TxtChiffre.Text + "9"
    End Sub

    Private Sub cmddivision_Click(sender As Object, e As EventArgs) Handles cmddivision.Click
        operand1 = Val(TxtChiffre.Text)
        operation = "+"
        TxtChiffre.Text = ""
        TxtChiffre.Focus()
    End Sub

    Private Sub cmdquatre_Click(sender As Object, e As EventArgs) Handles cmdquatre.Click
        TxtChiffre.Text = TxtChiffre.Text + "4"
    End Sub

    Private Sub cmdcinq_Click(sender As Object, e As EventArgs) Handles cmdcinq.Click
        TxtChiffre.Text = TxtChiffre.Text + "5"
    End Sub

    Private Sub cmdmultiplication_Click(sender As Object, e As EventArgs) Handles cmdmultiplication.Click
        operand1 = Val(TxtChiffre.Text)
        operation = "*"
        TxtChiffre.Text = ""
        TxtChiffre.Focus()
    End Sub

    Private Sub cmdun_Click(sender As Object, e As EventArgs) Handles cmdun.Click
        TxtChiffre.Text = TxtChiffre.Text + "1"
    End Sub

    Private Sub cmddeux_Click(sender As Object, e As EventArgs) Handles cmddeux.Click
        TxtChiffre.Text = TxtChiffre.Text + "2"
    End Sub

    Private Sub cmdtrois_Click(sender As Object, e As EventArgs) Handles cmdtrois.Click
        TxtChiffre.Text = TxtChiffre.Text + "3"
    End Sub

    Private Sub cmdsoustraction_Click(sender As Object, e As EventArgs) Handles cmdsoustraction.Click
        operand1 = Val(TxtChiffre.Text)
        operation = "-"
        TxtChiffre.Text = ""
        TxtChiffre.Focus()
    End Sub

    Private Sub cmdzero_Click(sender As Object, e As EventArgs) Handles cmdzero.Click
        TxtChiffre.Text = TxtChiffre.Text + "0"
    End Sub

    Private Sub cmdpoint_Click(sender As Object, e As EventArgs) Handles cmdpoint.Click
        TxtChiffre.Text = TxtChiffre.Text + "."
    End Sub

    Private Sub cmdaddition_Click(sender As Object, e As EventArgs) Handles cmdaddition.Click
        operand1 = Val(TxtChiffre.Text)
        operation = "+"
        TxtChiffre.Text = ""
        TxtChiffre.Focus()
    End Sub

End Class