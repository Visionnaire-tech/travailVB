Public Class Form3

    Private Sub CalculSimpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculSimpleToolStripMenuItem.Click
        Calcul_Simple.Show()
        Me.Hide()

    End Sub

    Private Sub CalculatriceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatriceToolStripMenuItem.Click
        Calculatrice.Show()
        Me.Hide()

    End Sub

    Private Sub ConversionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConversionToolStripMenuItem.Click
        calcul_et_convertisation.Show()
        Me.Hide()


    End Sub

    Private Sub PageDeCouleurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageDeCouleurToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub EncodageEtudiantsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncodageEtudiantsToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub ApparenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApparenceToolStripMenuItem.Click

    End Sub

    Private Sub SilverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SilverToolStripMenuItem.Click
        Me.BackColor = Color.Silver

    End Sub

    Private Sub JauneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JauneToolStripMenuItem.Click
        Me.BackColor = Color.Yellow


    End Sub

    Private Sub VertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VertToolStripMenuItem.Click
        Me.BackColor = Color.Green



    End Sub

    Private Sub RougeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RougeToolStripMenuItem.Click
        Me.BackColor = Color.Yellow

    End Sub

    Private Sub QuiterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuiterToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub VenteDeProduitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VenteDeProduitToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()
    End Sub
End Class