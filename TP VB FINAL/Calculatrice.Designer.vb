<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculatrice
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtChiffre = New System.Windows.Forms.TextBox()
        Me.cmdeffacée = New System.Windows.Forms.Button()
        Me.cmdsept = New System.Windows.Forms.Button()
        Me.cmdhuit = New System.Windows.Forms.Button()
        Me.cmdnerf = New System.Windows.Forms.Button()
        Me.cmddivision = New System.Windows.Forms.Button()
        Me.cmdquatre = New System.Windows.Forms.Button()
        Me.cmdcinq = New System.Windows.Forms.Button()
        Me.cmdsix = New System.Windows.Forms.Button()
        Me.cmdmultiplication = New System.Windows.Forms.Button()
        Me.cmdun = New System.Windows.Forms.Button()
        Me.cmddeux = New System.Windows.Forms.Button()
        Me.cmdtrois = New System.Windows.Forms.Button()
        Me.cmdsoustraction = New System.Windows.Forms.Button()
        Me.cmdzero = New System.Windows.Forms.Button()
        Me.cmdpoint = New System.Windows.Forms.Button()
        Me.cmdegal = New System.Windows.Forms.Button()
        Me.cmdaddition = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculEtConvertisationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtChiffre
        '
        Me.TxtChiffre.Location = New System.Drawing.Point(8, 21)
        Me.TxtChiffre.Multiline = True
        Me.TxtChiffre.Name = "TxtChiffre"
        Me.TxtChiffre.Size = New System.Drawing.Size(260, 46)
        Me.TxtChiffre.TabIndex = 0
        '
        'cmdeffacée
        '
        Me.cmdeffacée.Location = New System.Drawing.Point(12, 77)
        Me.cmdeffacée.Name = "cmdeffacée"
        Me.cmdeffacée.Size = New System.Drawing.Size(37, 28)
        Me.cmdeffacée.TabIndex = 1
        Me.cmdeffacée.Text = "C"
        Me.cmdeffacée.UseVisualStyleBackColor = True
        '
        'cmdsept
        '
        Me.cmdsept.Location = New System.Drawing.Point(12, 111)
        Me.cmdsept.Name = "cmdsept"
        Me.cmdsept.Size = New System.Drawing.Size(37, 28)
        Me.cmdsept.TabIndex = 2
        Me.cmdsept.Text = "7"
        Me.cmdsept.UseVisualStyleBackColor = True
        '
        'cmdhuit
        '
        Me.cmdhuit.Location = New System.Drawing.Point(74, 111)
        Me.cmdhuit.Name = "cmdhuit"
        Me.cmdhuit.Size = New System.Drawing.Size(37, 28)
        Me.cmdhuit.TabIndex = 3
        Me.cmdhuit.Text = "8"
        Me.cmdhuit.UseVisualStyleBackColor = True
        '
        'cmdnerf
        '
        Me.cmdnerf.Location = New System.Drawing.Point(136, 111)
        Me.cmdnerf.Name = "cmdnerf"
        Me.cmdnerf.Size = New System.Drawing.Size(37, 28)
        Me.cmdnerf.TabIndex = 4
        Me.cmdnerf.Text = "9"
        Me.cmdnerf.UseVisualStyleBackColor = True
        '
        'cmddivision
        '
        Me.cmddivision.Location = New System.Drawing.Point(195, 111)
        Me.cmddivision.Name = "cmddivision"
        Me.cmddivision.Size = New System.Drawing.Size(37, 28)
        Me.cmddivision.TabIndex = 5
        Me.cmddivision.Text = "/"
        Me.cmddivision.UseVisualStyleBackColor = True
        '
        'cmdquatre
        '
        Me.cmdquatre.Location = New System.Drawing.Point(12, 156)
        Me.cmdquatre.Name = "cmdquatre"
        Me.cmdquatre.Size = New System.Drawing.Size(37, 28)
        Me.cmdquatre.TabIndex = 6
        Me.cmdquatre.Text = "4"
        Me.cmdquatre.UseVisualStyleBackColor = True
        '
        'cmdcinq
        '
        Me.cmdcinq.Location = New System.Drawing.Point(74, 156)
        Me.cmdcinq.Name = "cmdcinq"
        Me.cmdcinq.Size = New System.Drawing.Size(37, 28)
        Me.cmdcinq.TabIndex = 7
        Me.cmdcinq.Text = "5"
        Me.cmdcinq.UseVisualStyleBackColor = True
        '
        'cmdsix
        '
        Me.cmdsix.Location = New System.Drawing.Point(136, 156)
        Me.cmdsix.Name = "cmdsix"
        Me.cmdsix.Size = New System.Drawing.Size(37, 28)
        Me.cmdsix.TabIndex = 8
        Me.cmdsix.Text = "6"
        Me.cmdsix.UseVisualStyleBackColor = True
        '
        'cmdmultiplication
        '
        Me.cmdmultiplication.Location = New System.Drawing.Point(195, 154)
        Me.cmdmultiplication.Name = "cmdmultiplication"
        Me.cmdmultiplication.Size = New System.Drawing.Size(37, 28)
        Me.cmdmultiplication.TabIndex = 9
        Me.cmdmultiplication.Text = "*"
        Me.cmdmultiplication.UseVisualStyleBackColor = True
        '
        'cmdun
        '
        Me.cmdun.Location = New System.Drawing.Point(12, 197)
        Me.cmdun.Name = "cmdun"
        Me.cmdun.Size = New System.Drawing.Size(37, 28)
        Me.cmdun.TabIndex = 10
        Me.cmdun.Text = "1"
        Me.cmdun.UseVisualStyleBackColor = True
        '
        'cmddeux
        '
        Me.cmddeux.Location = New System.Drawing.Point(74, 197)
        Me.cmddeux.Name = "cmddeux"
        Me.cmddeux.Size = New System.Drawing.Size(37, 28)
        Me.cmddeux.TabIndex = 11
        Me.cmddeux.Text = "2"
        Me.cmddeux.UseVisualStyleBackColor = True
        '
        'cmdtrois
        '
        Me.cmdtrois.Location = New System.Drawing.Point(136, 197)
        Me.cmdtrois.Name = "cmdtrois"
        Me.cmdtrois.Size = New System.Drawing.Size(37, 28)
        Me.cmdtrois.TabIndex = 12
        Me.cmdtrois.Text = "3"
        Me.cmdtrois.UseVisualStyleBackColor = True
        '
        'cmdsoustraction
        '
        Me.cmdsoustraction.Location = New System.Drawing.Point(195, 197)
        Me.cmdsoustraction.Name = "cmdsoustraction"
        Me.cmdsoustraction.Size = New System.Drawing.Size(37, 28)
        Me.cmdsoustraction.TabIndex = 13
        Me.cmdsoustraction.Text = "-"
        Me.cmdsoustraction.UseVisualStyleBackColor = True
        '
        'cmdzero
        '
        Me.cmdzero.Location = New System.Drawing.Point(12, 245)
        Me.cmdzero.Name = "cmdzero"
        Me.cmdzero.Size = New System.Drawing.Size(37, 28)
        Me.cmdzero.TabIndex = 14
        Me.cmdzero.Text = "0"
        Me.cmdzero.UseVisualStyleBackColor = True
        '
        'cmdpoint
        '
        Me.cmdpoint.Location = New System.Drawing.Point(74, 244)
        Me.cmdpoint.Name = "cmdpoint"
        Me.cmdpoint.Size = New System.Drawing.Size(37, 28)
        Me.cmdpoint.TabIndex = 15
        Me.cmdpoint.Text = "."
        Me.cmdpoint.UseVisualStyleBackColor = True
        '
        'cmdegal
        '
        Me.cmdegal.Location = New System.Drawing.Point(136, 245)
        Me.cmdegal.Name = "cmdegal"
        Me.cmdegal.Size = New System.Drawing.Size(37, 28)
        Me.cmdegal.TabIndex = 16
        Me.cmdegal.Text = "="
        Me.cmdegal.UseVisualStyleBackColor = True
        '
        'cmdaddition
        '
        Me.cmdaddition.Location = New System.Drawing.Point(195, 245)
        Me.cmdaddition.Name = "cmdaddition"
        Me.cmdaddition.Size = New System.Drawing.Size(37, 28)
        Me.cmdaddition.TabIndex = 17
        Me.cmdaddition.Text = "+"
        Me.cmdaddition.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(277, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculEtConvertisationToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'CalculEtConvertisationToolStripMenuItem
        '
        Me.CalculEtConvertisationToolStripMenuItem.Name = "CalculEtConvertisationToolStripMenuItem"
        Me.CalculEtConvertisationToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.CalculEtConvertisationToolStripMenuItem.Text = "calcul et convertisation"
        '
        'Calculatrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 285)
        Me.Controls.Add(Me.cmdaddition)
        Me.Controls.Add(Me.cmdegal)
        Me.Controls.Add(Me.cmdpoint)
        Me.Controls.Add(Me.cmdzero)
        Me.Controls.Add(Me.cmdsoustraction)
        Me.Controls.Add(Me.cmdtrois)
        Me.Controls.Add(Me.cmddeux)
        Me.Controls.Add(Me.cmdun)
        Me.Controls.Add(Me.cmdmultiplication)
        Me.Controls.Add(Me.cmdsix)
        Me.Controls.Add(Me.cmdcinq)
        Me.Controls.Add(Me.cmdquatre)
        Me.Controls.Add(Me.cmddivision)
        Me.Controls.Add(Me.cmdnerf)
        Me.Controls.Add(Me.cmdhuit)
        Me.Controls.Add(Me.cmdsept)
        Me.Controls.Add(Me.cmdeffacée)
        Me.Controls.Add(Me.TxtChiffre)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Calculatrice"
        Me.Text = "Calculatrice"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtChiffre As System.Windows.Forms.TextBox
    Friend WithEvents cmdeffacée As System.Windows.Forms.Button
    Friend WithEvents cmdsept As System.Windows.Forms.Button
    Friend WithEvents cmdhuit As System.Windows.Forms.Button
    Friend WithEvents cmdnerf As System.Windows.Forms.Button
    Friend WithEvents cmddivision As System.Windows.Forms.Button
    Friend WithEvents cmdquatre As System.Windows.Forms.Button
    Friend WithEvents cmdcinq As System.Windows.Forms.Button
    Friend WithEvents cmdsix As System.Windows.Forms.Button
    Friend WithEvents cmdmultiplication As System.Windows.Forms.Button
    Friend WithEvents cmdun As System.Windows.Forms.Button
    Friend WithEvents cmddeux As System.Windows.Forms.Button
    Friend WithEvents cmdtrois As System.Windows.Forms.Button
    Friend WithEvents cmdsoustraction As System.Windows.Forms.Button
    Friend WithEvents cmdzero As System.Windows.Forms.Button
    Friend WithEvents cmdpoint As System.Windows.Forms.Button
    Friend WithEvents cmdegal As System.Windows.Forms.Button
    Friend WithEvents cmdaddition As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculEtConvertisationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
