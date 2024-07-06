Public Class Form4

    Private Sub VenteProduit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbSexe.Items.Add("M")
        CmbSexe.Items.Add("F")
    End Sub

    Private Sub CmbDesig_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDesig.SelectedIndexChanged
        If CmbDesig.Text = "RIZ" Then
            TxtPU.Text = 1500
            TxtCode.Text = "P001"
        ElseIf CmbDesig.Text = "SAVON" Then
            TxtPU.Text = 500
            TxtCode.Text = "P002"
        ElseIf CmbDesig.Text = "SARDINE" Then
            TxtPU.Text = 1250
            TxtCode.Text = "P003"
        ElseIf CmbDesig.Text = "PAIN" Then
            TxtPU.Text = 300
            TxtCode.Text = "P004"
        Else
            TxtPU.Text = 2500
            TxtCode.Text = "P005"
        End If
        TxtQte.Focus()
    End Sub

    Private Sub TxtQte_TextChanged(sender As Object, e As EventArgs) Handles TxtQte.TextChanged
        TxtPT.Text = Val(TxtPU.Text) * Val(TxtQte.Text)
    End Sub

    Private Sub RbnDollar_CheckedChanged(sender As Object, e As EventArgs) Handles RbnDollar.CheckedChanged
        TxtResultat.Text = Val(TxtPT.Text) / Val(2750) & " " & "$"
    End Sub

    Private Sub CmdAjouter_Click(sender As Object, e As EventArgs) Handles CmdAjouter.Click
        DataGridView1.Rows.Add(TxtNum.Text, TxtNPN.Text, CmbSexe.Text, TxtTeleph.Text,
TxtAdres.Text, TxtCode.Text, CmbDesig.Text, TxtPU.Text, TxtQte.Text, TxtPT.Text)
        TxtNum.ResetText()
        TxtNPN.ResetText()
        CmbSexe.ResetText()
        TxtTeleph.ResetText()
        TxtAdres.ResetText()
        TxtCode.ResetText()
        CmbDesig.ResetText()
        TxtPU.ResetText()
        TxtQte.ResetText()
        TxtPT.ResetText()
        TxtResultat.ResetText()
        RbnDollar.Checked = False
        TxtNum.Focus()
    End Sub

    Private Sub CmdQuitter_Click(sender As Object, e As EventArgs) Handles CmdQuitter.Click
        Application.Exit()

    End Sub
    Private Sub RbnEuro_CheckedChanged(sender As Object, e As EventArgs) Handles RbnEuro.CheckedChanged
        TxtResultat.Text = Val(TxtPT.Text) / Val(0.93) & " " & "€"
    End Sub

    Private Sub BtnLivre_CheckedChanged(sender As Object, e As EventArgs) Handles BtnLivre.CheckedChanged
        TxtResultat.Text = Val(TxtPT.Text) / Val(0.79) & " " & "livre"
    End Sub

    Private Sub BtnRand_CheckedChanged(sender As Object, e As EventArgs) Handles BtnRand.CheckedChanged
        TxtResultat.Text = Val(TxtPT.Text) / Val(18.04) & " " & "Rand"
    End Sub

End Class
