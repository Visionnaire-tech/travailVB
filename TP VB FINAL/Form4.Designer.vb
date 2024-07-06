<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.BtnLivre = New System.Windows.Forms.RadioButton()
        Me.RbnDollar = New System.Windows.Forms.RadioButton()
        Me.TxtResultat = New System.Windows.Forms.TextBox()
        Me.CmbDesig = New System.Windows.Forms.ComboBox()
        Me.TxtQte = New System.Windows.Forms.TextBox()
        Me.TxtPU = New System.Windows.Forms.TextBox()
        Me.TxtPT = New System.Windows.Forms.TextBox()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RbnEuro = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom_postnom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adresse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Désignation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmdQuitter = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbSexe = New System.Windows.Forms.ComboBox()
        Me.TxtAdres = New System.Windows.Forms.TextBox()
        Me.TxtTeleph = New System.Windows.Forms.TextBox()
        Me.TxtNPN = New System.Windows.Forms.TextBox()
        Me.TxtNum = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRand = New System.Windows.Forms.RadioButton()
        Me.CmdAjouter = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnKwanza = New System.Windows.Forms.RadioButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnLivre
        '
        Me.BtnLivre.AutoSize = True
        Me.BtnLivre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLivre.Location = New System.Drawing.Point(466, 48)
        Me.BtnLivre.Name = "BtnLivre"
        Me.BtnLivre.Size = New System.Drawing.Size(52, 20)
        Me.BtnLivre.TabIndex = 4
        Me.BtnLivre.TabStop = True
        Me.BtnLivre.Text = "Livre"
        Me.BtnLivre.UseVisualStyleBackColor = True
        '
        'RbnDollar
        '
        Me.RbnDollar.AutoSize = True
        Me.RbnDollar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbnDollar.Location = New System.Drawing.Point(103, 48)
        Me.RbnDollar.Name = "RbnDollar"
        Me.RbnDollar.Size = New System.Drawing.Size(59, 20)
        Me.RbnDollar.TabIndex = 2
        Me.RbnDollar.TabStop = True
        Me.RbnDollar.Text = "Dollar"
        Me.RbnDollar.UseVisualStyleBackColor = True
        '
        'TxtResultat
        '
        Me.TxtResultat.Location = New System.Drawing.Point(406, 12)
        Me.TxtResultat.Name = "TxtResultat"
        Me.TxtResultat.Size = New System.Drawing.Size(176, 22)
        Me.TxtResultat.TabIndex = 1
        '
        'CmbDesig
        '
        Me.CmbDesig.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbDesig.FormattingEnabled = True
        Me.CmbDesig.Items.AddRange(New Object() {"RIZ", "SAVON", "SARDINE", "PAIN"})
        Me.CmbDesig.Location = New System.Drawing.Point(189, 69)
        Me.CmbDesig.Name = "CmbDesig"
        Me.CmbDesig.Size = New System.Drawing.Size(210, 24)
        Me.CmbDesig.TabIndex = 20
        '
        'TxtQte
        '
        Me.TxtQte.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQte.Location = New System.Drawing.Point(189, 138)
        Me.TxtQte.Name = "TxtQte"
        Me.TxtQte.Size = New System.Drawing.Size(210, 22)
        Me.TxtQte.TabIndex = 19
        '
        'TxtPU
        '
        Me.TxtPU.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPU.Location = New System.Drawing.Point(189, 103)
        Me.TxtPU.Name = "TxtPU"
        Me.TxtPU.Size = New System.Drawing.Size(210, 22)
        Me.TxtPU.TabIndex = 18
        '
        'TxtPT
        '
        Me.TxtPT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPT.Location = New System.Drawing.Point(189, 168)
        Me.TxtPT.Name = "TxtPT"
        Me.TxtPT.Size = New System.Drawing.Size(210, 22)
        Me.TxtPT.TabIndex = 17
        '
        'TxtCode
        '
        Me.TxtCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCode.Location = New System.Drawing.Point(189, 28)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(210, 22)
        Me.TxtCode.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Quantité"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Prix Unitaire"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Designation"
        '
        'RbnEuro
        '
        Me.RbnEuro.AutoSize = True
        Me.RbnEuro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbnEuro.Location = New System.Drawing.Point(282, 48)
        Me.RbnEuro.Name = "RbnEuro"
        Me.RbnEuro.Size = New System.Drawing.Size(53, 20)
        Me.RbnEuro.TabIndex = 3
        Me.RbnEuro.TabStop = True
        Me.RbnEuro.Text = "Euro"
        Me.RbnEuro.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(330, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Resultat"
        '
        'Num
        '
        Me.Num.HeaderText = "Num"
        Me.Num.Name = "Num"
        '
        'Nom_postnom
        '
        Me.Nom_postnom.HeaderText = "Nom  Postnom"
        Me.Nom_postnom.Name = "Nom_postnom"
        '
        'Sexe
        '
        Me.Sexe.HeaderText = "Sexe"
        Me.Sexe.Name = "Sexe"
        '
        'Adresse
        '
        Me.Adresse.HeaderText = "Adresse"
        Me.Adresse.Name = "Adresse"
        '
        'Code
        '
        Me.Code.HeaderText = "Code"
        Me.Code.Name = "Code"
        '
        'Désignation
        '
        Me.Désignation.HeaderText = "Désignation"
        Me.Désignation.Name = "Désignation"
        '
        'PU
        '
        Me.PU.HeaderText = "PU"
        Me.PU.Name = "PU"
        '
        'Qte
        '
        Me.Qte.HeaderText = "Qte"
        Me.Qte.Name = "Qte"
        '
        'PT
        '
        Me.PT.HeaderText = "PT"
        Me.PT.Name = "PT"
        '
        'CmdQuitter
        '
        Me.CmdQuitter.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdQuitter.Location = New System.Drawing.Point(550, 471)
        Me.CmdQuitter.Name = "CmdQuitter"
        Me.CmdQuitter.Size = New System.Drawing.Size(104, 23)
        Me.CmdQuitter.TabIndex = 11
        Me.CmdQuitter.Text = "Quitter"
        Me.CmdQuitter.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Num, Me.Nom_postnom, Me.Sexe, Me.Adresse, Me.Code, Me.Désignation, Me.PU, Me.Qte, Me.PT})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 322)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(913, 133)
        Me.DataGridView1.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Prix Total"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbSexe)
        Me.GroupBox1.Controls.Add(Me.TxtAdres)
        Me.GroupBox1.Controls.Add(Me.TxtTeleph)
        Me.GroupBox1.Controls.Add(Me.TxtNPN)
        Me.GroupBox1.Controls.Add(Me.TxtNum)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(437, 224)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Encodage des clients "
        '
        'CmbSexe
        '
        Me.CmbSexe.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSexe.FormattingEnabled = True
        Me.CmbSexe.Location = New System.Drawing.Point(176, 104)
        Me.CmbSexe.Name = "CmbSexe"
        Me.CmbSexe.Size = New System.Drawing.Size(210, 24)
        Me.CmbSexe.TabIndex = 10
        '
        'TxtAdres
        '
        Me.TxtAdres.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdres.Location = New System.Drawing.Point(176, 173)
        Me.TxtAdres.Name = "TxtAdres"
        Me.TxtAdres.Size = New System.Drawing.Size(210, 22)
        Me.TxtAdres.TabIndex = 9
        '
        'TxtTeleph
        '
        Me.TxtTeleph.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTeleph.Location = New System.Drawing.Point(176, 138)
        Me.TxtTeleph.Name = "TxtTeleph"
        Me.TxtTeleph.Size = New System.Drawing.Size(210, 22)
        Me.TxtTeleph.TabIndex = 8
        '
        'TxtNPN
        '
        Me.TxtNPN.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNPN.Location = New System.Drawing.Point(176, 68)
        Me.TxtNPN.Name = "TxtNPN"
        Me.TxtNPN.Size = New System.Drawing.Size(210, 22)
        Me.TxtNPN.TabIndex = 7
        '
        'TxtNum
        '
        Me.TxtNum.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNum.Location = New System.Drawing.Point(176, 31)
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.Size = New System.Drawing.Size(210, 22)
        Me.TxtNum.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Adresse"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Téléphone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Sexe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom   Postnom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Num Client"
        '
        'BtnRand
        '
        Me.BtnRand.AutoSize = True
        Me.BtnRand.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRand.Location = New System.Drawing.Point(627, 48)
        Me.BtnRand.Name = "BtnRand"
        Me.BtnRand.Size = New System.Drawing.Size(56, 20)
        Me.BtnRand.TabIndex = 5
        Me.BtnRand.TabStop = True
        Me.BtnRand.Text = "Rand"
        Me.BtnRand.UseVisualStyleBackColor = True
        '
        'CmdAjouter
        '
        Me.CmdAjouter.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAjouter.Location = New System.Drawing.Point(345, 471)
        Me.CmdAjouter.Name = "CmdAjouter"
        Me.CmdAjouter.Size = New System.Drawing.Size(115, 23)
        Me.CmdAjouter.TabIndex = 10
        Me.CmdAjouter.Text = "Ajouter"
        Me.CmdAjouter.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmbDesig)
        Me.GroupBox2.Controls.Add(Me.TxtQte)
        Me.GroupBox2.Controls.Add(Me.TxtPU)
        Me.GroupBox2.Controls.Add(Me.TxtPT)
        Me.GroupBox2.Controls.Add(Me.TxtCode)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(478, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(447, 224)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Encodage des produits"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 16)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Code Produit"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnKwanza)
        Me.GroupBox3.Controls.Add(Me.BtnRand)
        Me.GroupBox3.Controls.Add(Me.BtnLivre)
        Me.GroupBox3.Controls.Add(Me.RbnEuro)
        Me.GroupBox3.Controls.Add(Me.RbnDollar)
        Me.GroupBox3.Controls.Add(Me.TxtResultat)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 242)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(913, 74)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Convertier le montant total"
        '
        'btnKwanza
        '
        Me.btnKwanza.AutoSize = True
        Me.btnKwanza.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKwanza.Location = New System.Drawing.Point(813, 48)
        Me.btnKwanza.Name = "btnKwanza"
        Me.btnKwanza.Size = New System.Drawing.Size(72, 20)
        Me.btnKwanza.TabIndex = 6
        Me.btnKwanza.TabStop = True
        Me.btnKwanza.Text = "Kwanza"
        Me.btnKwanza.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 502)
        Me.Controls.Add(Me.CmdQuitter)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CmdAjouter)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnLivre As System.Windows.Forms.RadioButton
    Friend WithEvents RbnDollar As System.Windows.Forms.RadioButton
    Friend WithEvents TxtResultat As System.Windows.Forms.TextBox
    Friend WithEvents CmbDesig As System.Windows.Forms.ComboBox
    Friend WithEvents TxtQte As System.Windows.Forms.TextBox
    Friend WithEvents TxtPU As System.Windows.Forms.TextBox
    Friend WithEvents TxtPT As System.Windows.Forms.TextBox
    Friend WithEvents TxtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RbnEuro As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nom_postnom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sexe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Adresse As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Désignation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmdQuitter As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbSexe As System.Windows.Forms.ComboBox
    Friend WithEvents TxtAdres As System.Windows.Forms.TextBox
    Friend WithEvents TxtTeleph As System.Windows.Forms.TextBox
    Friend WithEvents TxtNPN As System.Windows.Forms.TextBox
    Friend WithEvents TxtNum As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnRand As System.Windows.Forms.RadioButton
    Friend WithEvents CmdAjouter As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnKwanza As System.Windows.Forms.RadioButton
End Class
