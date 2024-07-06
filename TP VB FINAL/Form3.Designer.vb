<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculSimpleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatriceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConversionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutilsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageDeCouleurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncodageEtudiantsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VenteDeProduitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApparenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FondDecranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SilverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JauneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RougeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuiterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.OutilsToolStripMenuItem, Me.ApparenceToolStripMenuItem, Me.AideToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(856, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculSimpleToolStripMenuItem, Me.CalculatriceToolStripMenuItem, Me.ConversionToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'CalculSimpleToolStripMenuItem
        '
        Me.CalculSimpleToolStripMenuItem.Name = "CalculSimpleToolStripMenuItem"
        Me.CalculSimpleToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.CalculSimpleToolStripMenuItem.Text = "Calcul Simple"
        '
        'CalculatriceToolStripMenuItem
        '
        Me.CalculatriceToolStripMenuItem.Name = "CalculatriceToolStripMenuItem"
        Me.CalculatriceToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.CalculatriceToolStripMenuItem.Text = "Calculatrice"
        '
        'ConversionToolStripMenuItem
        '
        Me.ConversionToolStripMenuItem.Name = "ConversionToolStripMenuItem"
        Me.ConversionToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ConversionToolStripMenuItem.Text = "Conversion"
        '
        'OutilsToolStripMenuItem
        '
        Me.OutilsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PageDeCouleurToolStripMenuItem, Me.EncodageEtudiantsToolStripMenuItem, Me.VenteDeProduitToolStripMenuItem})
        Me.OutilsToolStripMenuItem.Name = "OutilsToolStripMenuItem"
        Me.OutilsToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.OutilsToolStripMenuItem.Text = "Outils"
        '
        'PageDeCouleurToolStripMenuItem
        '
        Me.PageDeCouleurToolStripMenuItem.Name = "PageDeCouleurToolStripMenuItem"
        Me.PageDeCouleurToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.PageDeCouleurToolStripMenuItem.Text = "page de couleur"
        '
        'EncodageEtudiantsToolStripMenuItem
        '
        Me.EncodageEtudiantsToolStripMenuItem.Name = "EncodageEtudiantsToolStripMenuItem"
        Me.EncodageEtudiantsToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.EncodageEtudiantsToolStripMenuItem.Text = "Encodage Etudiants"
        '
        'VenteDeProduitToolStripMenuItem
        '
        Me.VenteDeProduitToolStripMenuItem.Name = "VenteDeProduitToolStripMenuItem"
        Me.VenteDeProduitToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.VenteDeProduitToolStripMenuItem.Text = "Vente de produit"
        '
        'ApparenceToolStripMenuItem
        '
        Me.ApparenceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FondDecranToolStripMenuItem})
        Me.ApparenceToolStripMenuItem.Name = "ApparenceToolStripMenuItem"
        Me.ApparenceToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ApparenceToolStripMenuItem.Text = "Apparence"
        '
        'FondDecranToolStripMenuItem
        '
        Me.FondDecranToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SilverToolStripMenuItem, Me.JauneToolStripMenuItem, Me.VertToolStripMenuItem, Me.RougeToolStripMenuItem})
        Me.FondDecranToolStripMenuItem.Name = "FondDecranToolStripMenuItem"
        Me.FondDecranToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.FondDecranToolStripMenuItem.Text = "fond d'ecran"
        '
        'SilverToolStripMenuItem
        '
        Me.SilverToolStripMenuItem.Name = "SilverToolStripMenuItem"
        Me.SilverToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.SilverToolStripMenuItem.Text = "Silver"
        '
        'JauneToolStripMenuItem
        '
        Me.JauneToolStripMenuItem.Name = "JauneToolStripMenuItem"
        Me.JauneToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.JauneToolStripMenuItem.Text = "Jaune "
        '
        'VertToolStripMenuItem
        '
        Me.VertToolStripMenuItem.Name = "VertToolStripMenuItem"
        Me.VertToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.VertToolStripMenuItem.Text = "Vert"
        '
        'RougeToolStripMenuItem
        '
        Me.RougeToolStripMenuItem.Name = "RougeToolStripMenuItem"
        Me.RougeToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.RougeToolStripMenuItem.Text = "Rouge"
        '
        'AideToolStripMenuItem
        '
        Me.AideToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuiterToolStripMenuItem})
        Me.AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        Me.AideToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.AideToolStripMenuItem.Text = "Aide"
        '
        'QuiterToolStripMenuItem
        '
        Me.QuiterToolStripMenuItem.Name = "QuiterToolStripMenuItem"
        Me.QuiterToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.QuiterToolStripMenuItem.Text = "Quiter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(438, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(203, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(450, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Bievenue dans La gestionnaire"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(277, 75)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "GESTION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(400, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(336, 56)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "DES PAIEMENT"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(0, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(856, 142)
        Me.Panel1.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TP_VB_FINAL.My.Resources.Resources.gros_plan_mains_aide_smartphone_au_bureau_1421_3646
        Me.PictureBox1.Location = New System.Drawing.Point(194, 285)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(446, 156)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 479)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form3"
        Me.Text = " "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutilsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApparenceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FondDecranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CalculSimpleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculatriceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConversionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PageDeCouleurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EncodageEtudiantsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VenteDeProduitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SilverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JauneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RougeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuiterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
