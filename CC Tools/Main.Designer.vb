Namespace CC_Tools
	Partial Public Class Main
		''' <summary>
		''' Variável de designer necessária.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Limpar os recursos que estão sendo usados.
		''' </summary>
		''' <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Código gerado pelo Windows Form Designer"

		''' <summary>
		''' Método necessário para suporte ao Designer - não modifique 
		''' o conteúdo deste método com o editor de código.
		''' </summary>
		Private Sub InitializeComponent()
			Me.txtCheckCCs = New System.Windows.Forms.RichTextBox()
			Me.btnCheck = New System.Windows.Forms.Button()
			Me.btnLoad = New System.Windows.Forms.Button()
			Me.checkingBar = New System.Windows.Forms.ProgressBar()
			Me.txtValidCCs = New System.Windows.Forms.RichTextBox()
			Me.button1 = New System.Windows.Forms.Button()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.button11 = New System.Windows.Forms.Button()
			Me.button4 = New System.Windows.Forms.Button()
			Me.button3 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.txtInvalidCC = New System.Windows.Forms.RichTextBox()
			Me.pnlChecker = New System.Windows.Forms.Panel()
			Me.button12 = New System.Windows.Forms.Button()
			Me.lblInvalid = New System.Windows.Forms.Label()
			Me.lblValid = New System.Windows.Forms.Label()
			Me.pnlGenerator = New System.Windows.Forms.Panel()
			Me.chkValidRegex = New System.Windows.Forms.CheckBox()
			Me.button5 = New System.Windows.Forms.Button()
			Me.button13 = New System.Windows.Forms.Button()
			Me.label7 = New System.Windows.Forms.Label()
			Me.label6 = New System.Windows.Forms.Label()
			Me.chkValidCards = New System.Windows.Forms.CheckBox()
			Me.chkED = New System.Windows.Forms.CheckBox()
			Me.chkCVV = New System.Windows.Forms.CheckBox()
			Me.label5 = New System.Windows.Forms.Label()
			Me.button10 = New System.Windows.Forms.Button()
			Me.txtExpirationDate = New System.Windows.Forms.TextBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.button9 = New System.Windows.Forms.Button()
			Me.txtCVV = New System.Windows.Forms.TextBox()
			Me.button8 = New System.Windows.Forms.Button()
			Me.label3 = New System.Windows.Forms.Label()
			Me.nLength = New System.Windows.Forms.NumericUpDown()
			Me.button7 = New System.Windows.Forms.Button()
			Me.progressBar1 = New System.Windows.Forms.ProgressBar()
			Me.button6 = New System.Windows.Forms.Button()
			Me.label2 = New System.Windows.Forms.Label()
			Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
			Me.txtbin = New System.Windows.Forms.TextBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.btnGenerateCC = New System.Windows.Forms.Button()
			Me.txtNewCards = New System.Windows.Forms.RichTextBox()
			Me.pnlBins = New System.Windows.Forms.Panel()
			Me.lblvalidlog = New System.Windows.Forms.Label()
			Me.lblcheckedlog = New System.Windows.Forms.Label()
			Me.validBinsLog = New System.Windows.Forms.ListBox()
			Me.checkingBinsLog = New System.Windows.Forms.ListBox()
			Me.groupBox5 = New System.Windows.Forms.GroupBox()
			Me.button14 = New System.Windows.Forms.Button()
			Me.txtrandombincheckerpath = New System.Windows.Forms.TextBox()
			Me.btnRandomBinChecker = New System.Windows.Forms.Button()
			Me.groupBox4 = New System.Windows.Forms.GroupBox()
			Me.txtBankCity = New System.Windows.Forms.TextBox()
			Me.label22 = New System.Windows.Forms.Label()
			Me.txtBankPhone = New System.Windows.Forms.TextBox()
			Me.label13 = New System.Windows.Forms.Label()
			Me.txtBankUrl = New System.Windows.Forms.TextBox()
			Me.label20 = New System.Windows.Forms.Label()
			Me.txtBankName = New System.Windows.Forms.TextBox()
			Me.label21 = New System.Windows.Forms.Label()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.txtCountryCurrency = New System.Windows.Forms.TextBox()
			Me.label15 = New System.Windows.Forms.Label()
			Me.txtCountryAlpha2 = New System.Windows.Forms.TextBox()
			Me.label18 = New System.Windows.Forms.Label()
			Me.txtCountryName = New System.Windows.Forms.TextBox()
			Me.label19 = New System.Windows.Forms.Label()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.txtLuhn = New System.Windows.Forms.TextBox()
			Me.label16 = New System.Windows.Forms.Label()
			Me.txtLength = New System.Windows.Forms.TextBox()
			Me.label17 = New System.Windows.Forms.Label()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.txtPrepaid = New System.Windows.Forms.TextBox()
			Me.label12 = New System.Windows.Forms.Label()
			Me.txtBrand = New System.Windows.Forms.TextBox()
			Me.label11 = New System.Windows.Forms.Label()
			Me.txtType = New System.Windows.Forms.TextBox()
			Me.label10 = New System.Windows.Forms.Label()
			Me.txtScheme = New System.Windows.Forms.TextBox()
			Me.label9 = New System.Windows.Forms.Label()
			Me.lblstatus = New System.Windows.Forms.Label()
			Me.label8 = New System.Windows.Forms.Label()
			Me.button16 = New System.Windows.Forms.Button()
			Me.txtBinValidate = New System.Windows.Forms.TextBox()
			Me.label14 = New System.Windows.Forms.Label()
			Me.backgroundWorker1 = New System.ComponentModel.BackgroundWorker()
			Me.Generator = New System.ComponentModel.BackgroundWorker()
			Me.panel1.SuspendLayout()
			Me.pnlChecker.SuspendLayout()
			Me.pnlGenerator.SuspendLayout()
			DirectCast(Me.nLength, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlBins.SuspendLayout()
			Me.groupBox5.SuspendLayout()
			Me.groupBox4.SuspendLayout()
			Me.groupBox3.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' txtCheckCCs
			' 
			Me.txtCheckCCs.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.txtCheckCCs.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.txtCheckCCs.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.txtCheckCCs.ForeColor = System.Drawing.Color.White
			Me.txtCheckCCs.Location = New System.Drawing.Point(3, 3)
			Me.txtCheckCCs.Name = "txtCheckCCs"
			Me.txtCheckCCs.Size = New System.Drawing.Size(833, 281)
			Me.txtCheckCCs.TabIndex = 0
			Me.txtCheckCCs.Text = ""
			' 
			' btnCheck
			' 
			Me.btnCheck.BackColor = System.Drawing.Color.DimGray
			Me.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.btnCheck.Font = New System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.btnCheck.ForeColor = System.Drawing.Color.White
			Me.btnCheck.Location = New System.Drawing.Point(3, 290)
			Me.btnCheck.Name = "btnCheck"
			Me.btnCheck.Size = New System.Drawing.Size(154, 38)
			Me.btnCheck.TabIndex = 1
			Me.btnCheck.Text = "CHECK"
			Me.btnCheck.UseVisualStyleBackColor = False
'			Me.btnCheck.Click += New System.EventHandler(Me.button1_Click)
			' 
			' btnLoad
			' 
			Me.btnLoad.BackColor = System.Drawing.Color.DimGray
			Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.btnLoad.Font = New System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.btnLoad.ForeColor = System.Drawing.Color.White
			Me.btnLoad.Location = New System.Drawing.Point(682, 290)
			Me.btnLoad.Name = "btnLoad"
			Me.btnLoad.Size = New System.Drawing.Size(154, 38)
			Me.btnLoad.TabIndex = 2
			Me.btnLoad.Text = "LOAD FILE"
			Me.btnLoad.UseVisualStyleBackColor = False
'			Me.btnLoad.Click += New System.EventHandler(Me.button2_Click)
			' 
			' checkingBar
			' 
			Me.checkingBar.Location = New System.Drawing.Point(3, 334)
			Me.checkingBar.Name = "checkingBar"
			Me.checkingBar.Size = New System.Drawing.Size(833, 29)
			Me.checkingBar.TabIndex = 3
			' 
			' txtValidCCs
			' 
			Me.txtValidCCs.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.txtValidCCs.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.txtValidCCs.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.txtValidCCs.ForeColor = System.Drawing.Color.Lime
			Me.txtValidCCs.Location = New System.Drawing.Point(4, 369)
			Me.txtValidCCs.Name = "txtValidCCs"
			Me.txtValidCCs.Size = New System.Drawing.Size(409, 266)
			Me.txtValidCCs.TabIndex = 4
			Me.txtValidCCs.Text = ""
			' 
			' button1
			' 
			Me.button1.BackColor = System.Drawing.Color.DimGray
			Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button1.Font = New System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button1.ForeColor = System.Drawing.Color.White
			Me.button1.Location = New System.Drawing.Point(163, 290)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(154, 38)
			Me.button1.TabIndex = 5
			Me.button1.Text = "CLEAR"
			Me.button1.UseVisualStyleBackColor = False
'			Me.button1.Click += New System.EventHandler(Me.button1_Click_1)
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(8)))), (CInt((CByte(8)))), (CInt((CByte(8)))))
			Me.panel1.Controls.Add(Me.button11)
			Me.panel1.Controls.Add(Me.button4)
			Me.panel1.Controls.Add(Me.button3)
			Me.panel1.Controls.Add(Me.button2)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(185, 673)
			Me.panel1.TabIndex = 6
			' 
			' button11
			' 
			Me.button11.BackColor = System.Drawing.Color.Transparent
			Me.button11.FlatAppearance.BorderSize = 0
			Me.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button11.Font = New System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button11.ForeColor = System.Drawing.Color.White
			Me.button11.Location = New System.Drawing.Point(3, 569)
			Me.button11.Name = "button11"
			Me.button11.Size = New System.Drawing.Size(179, 96)
			Me.button11.TabIndex = 11
			Me.button11.Text = "GITHUB"
			Me.button11.UseVisualStyleBackColor = False
'			Me.button11.Click += New System.EventHandler(Me.button11_Click)
			' 
			' button4
			' 
			Me.button4.BackColor = System.Drawing.Color.Transparent
			Me.button4.FlatAppearance.BorderSize = 0
			Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button4.Font = New System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button4.ForeColor = System.Drawing.Color.White
			Me.button4.Location = New System.Drawing.Point(3, 234)
			Me.button4.Name = "button4"
			Me.button4.Size = New System.Drawing.Size(179, 96)
			Me.button4.TabIndex = 10
			Me.button4.Text = "BINS"
			Me.button4.UseVisualStyleBackColor = False
'			Me.button4.Click += New System.EventHandler(Me.button4_Click)
			' 
			' button3
			' 
			Me.button3.BackColor = System.Drawing.Color.Transparent
			Me.button3.FlatAppearance.BorderSize = 0
			Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button3.Font = New System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button3.ForeColor = System.Drawing.Color.White
			Me.button3.Location = New System.Drawing.Point(3, 132)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(179, 96)
			Me.button3.TabIndex = 9
			Me.button3.Text = "GENERATOR"
			Me.button3.UseVisualStyleBackColor = False
'			Me.button3.Click += New System.EventHandler(Me.button3_Click)
			' 
			' button2
			' 
			Me.button2.BackColor = System.Drawing.Color.Transparent
			Me.button2.FlatAppearance.BorderSize = 0
			Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button2.Font = New System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button2.ForeColor = System.Drawing.Color.White
			Me.button2.Location = New System.Drawing.Point(3, 30)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(179, 96)
			Me.button2.TabIndex = 8
			Me.button2.Text = "CHECKER"
			Me.button2.UseVisualStyleBackColor = False
'			Me.button2.Click += New System.EventHandler(Me.button2_Click_1)
			' 
			' txtInvalidCC
			' 
			Me.txtInvalidCC.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.txtInvalidCC.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.txtInvalidCC.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.txtInvalidCC.ForeColor = System.Drawing.Color.Red
			Me.txtInvalidCC.Location = New System.Drawing.Point(427, 369)
			Me.txtInvalidCC.Name = "txtInvalidCC"
			Me.txtInvalidCC.Size = New System.Drawing.Size(409, 266)
			Me.txtInvalidCC.TabIndex = 7
			Me.txtInvalidCC.Text = ""
			' 
			' pnlChecker
			' 
			Me.pnlChecker.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(24)))), (CInt((CByte(24)))), (CInt((CByte(24)))))
			Me.pnlChecker.Controls.Add(Me.button12)
			Me.pnlChecker.Controls.Add(Me.lblInvalid)
			Me.pnlChecker.Controls.Add(Me.lblValid)
			Me.pnlChecker.Controls.Add(Me.txtCheckCCs)
			Me.pnlChecker.Controls.Add(Me.txtInvalidCC)
			Me.pnlChecker.Controls.Add(Me.btnCheck)
			Me.pnlChecker.Controls.Add(Me.btnLoad)
			Me.pnlChecker.Controls.Add(Me.button1)
			Me.pnlChecker.Controls.Add(Me.checkingBar)
			Me.pnlChecker.Controls.Add(Me.txtValidCCs)
			Me.pnlChecker.ForeColor = System.Drawing.Color.White
			Me.pnlChecker.Location = New System.Drawing.Point(188, 12)
			Me.pnlChecker.Name = "pnlChecker"
			Me.pnlChecker.Size = New System.Drawing.Size(847, 653)
			Me.pnlChecker.TabIndex = 8
			' 
			' button12
			' 
			Me.button12.BackColor = System.Drawing.Color.DimGray
			Me.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button12.Font = New System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button12.ForeColor = System.Drawing.Color.White
			Me.button12.Location = New System.Drawing.Point(457, 290)
			Me.button12.Name = "button12"
			Me.button12.Size = New System.Drawing.Size(219, 38)
			Me.button12.TabIndex = 10
			Me.button12.Text = "SAVE VALID CARDS"
			Me.button12.UseVisualStyleBackColor = False
'			Me.button12.Click += New System.EventHandler(Me.button12_Click)
			' 
			' lblInvalid
			' 
			Me.lblInvalid.AutoSize = True
			Me.lblInvalid.Font = New System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.lblInvalid.ForeColor = System.Drawing.Color.Red
			Me.lblInvalid.Location = New System.Drawing.Point(430, 636)
			Me.lblInvalid.Name = "lblInvalid"
			Me.lblInvalid.Size = New System.Drawing.Size(14, 15)
			Me.lblInvalid.TabIndex = 9
			Me.lblInvalid.Text = "0"
			' 
			' lblValid
			' 
			Me.lblValid.AutoSize = True
			Me.lblValid.Font = New System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.lblValid.ForeColor = System.Drawing.Color.Lime
			Me.lblValid.Location = New System.Drawing.Point(4, 637)
			Me.lblValid.Name = "lblValid"
			Me.lblValid.Size = New System.Drawing.Size(14, 15)
			Me.lblValid.TabIndex = 8
			Me.lblValid.Text = "0"
			' 
			' pnlGenerator
			' 
			Me.pnlGenerator.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(24)))), (CInt((CByte(24)))), (CInt((CByte(24)))))
			Me.pnlGenerator.Controls.Add(Me.chkValidRegex)
			Me.pnlGenerator.Controls.Add(Me.button5)
			Me.pnlGenerator.Controls.Add(Me.button13)
			Me.pnlGenerator.Controls.Add(Me.label7)
			Me.pnlGenerator.Controls.Add(Me.label6)
			Me.pnlGenerator.Controls.Add(Me.chkValidCards)
			Me.pnlGenerator.Controls.Add(Me.chkED)
			Me.pnlGenerator.Controls.Add(Me.chkCVV)
			Me.pnlGenerator.Controls.Add(Me.label5)
			Me.pnlGenerator.Controls.Add(Me.button10)
			Me.pnlGenerator.Controls.Add(Me.txtExpirationDate)
			Me.pnlGenerator.Controls.Add(Me.label4)
			Me.pnlGenerator.Controls.Add(Me.button9)
			Me.pnlGenerator.Controls.Add(Me.txtCVV)
			Me.pnlGenerator.Controls.Add(Me.button8)
			Me.pnlGenerator.Controls.Add(Me.label3)
			Me.pnlGenerator.Controls.Add(Me.nLength)
			Me.pnlGenerator.Controls.Add(Me.button7)
			Me.pnlGenerator.Controls.Add(Me.progressBar1)
			Me.pnlGenerator.Controls.Add(Me.button6)
			Me.pnlGenerator.Controls.Add(Me.label2)
			Me.pnlGenerator.Controls.Add(Me.numericUpDown1)
			Me.pnlGenerator.Controls.Add(Me.txtbin)
			Me.pnlGenerator.Controls.Add(Me.label1)
			Me.pnlGenerator.Controls.Add(Me.btnGenerateCC)
			Me.pnlGenerator.Controls.Add(Me.txtNewCards)
			Me.pnlGenerator.Location = New System.Drawing.Point(188, 12)
			Me.pnlGenerator.Name = "pnlGenerator"
			Me.pnlGenerator.Size = New System.Drawing.Size(847, 653)
			Me.pnlGenerator.TabIndex = 9
			' 
			' chkValidRegex
			' 
			Me.chkValidRegex.AutoSize = True
			Me.chkValidRegex.Checked = True
			Me.chkValidRegex.CheckState = System.Windows.Forms.CheckState.Checked
			Me.chkValidRegex.Font = New System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.chkValidRegex.ForeColor = System.Drawing.Color.White
			Me.chkValidRegex.Location = New System.Drawing.Point(7, 400)
			Me.chkValidRegex.Name = "chkValidRegex"
			Me.chkValidRegex.Size = New System.Drawing.Size(161, 28)
			Me.chkValidRegex.TabIndex = 27
			Me.chkValidRegex.Text = "Valid Regex"
			Me.chkValidRegex.UseVisualStyleBackColor = True
			' 
			' button5
			' 
			Me.button5.BackColor = System.Drawing.Color.Red
			Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button5.Font = New System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button5.ForeColor = System.Drawing.Color.White
			Me.button5.Location = New System.Drawing.Point(7, 514)
			Me.button5.Name = "button5"
			Me.button5.Size = New System.Drawing.Size(119, 32)
			Me.button5.TabIndex = 25
			Me.button5.Text = "CANCEL"
			Me.button5.UseVisualStyleBackColor = False
'			Me.button5.Click += New System.EventHandler(Me.button5_Click_1)
			' 
			' button13
			' 
			Me.button13.BackColor = System.Drawing.Color.DimGray
			Me.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button13.Font = New System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button13.ForeColor = System.Drawing.Color.White
			Me.button13.Location = New System.Drawing.Point(282, 30)
			Me.button13.Name = "button13"
			Me.button13.Size = New System.Drawing.Size(35, 31)
			Me.button13.TabIndex = 24
			Me.button13.Text = "?"
			Me.button13.UseVisualStyleBackColor = False
'			Me.button13.Click += New System.EventHandler(Me.button13_Click)
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label7.ForeColor = System.Drawing.Color.White
			Me.label7.Location = New System.Drawing.Point(237, 5)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(141, 15)
			Me.label7.TabIndex = 23
			Me.label7.Text = "These fields are optional"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label6.ForeColor = System.Drawing.Color.White
			Me.label6.Location = New System.Drawing.Point(4, 186)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(105, 15)
			Me.label6.TabIndex = 22
			Me.label6.Text = "(Format: 02|2025)"
			' 
			' chkValidCards
			' 
			Me.chkValidCards.AutoSize = True
			Me.chkValidCards.Checked = True
			Me.chkValidCards.CheckState = System.Windows.Forms.CheckState.Checked
			Me.chkValidCards.Font = New System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.chkValidCards.ForeColor = System.Drawing.Color.White
			Me.chkValidCards.Location = New System.Drawing.Point(7, 369)
			Me.chkValidCards.Name = "chkValidCards"
			Me.chkValidCards.Size = New System.Drawing.Size(197, 28)
			Me.chkValidCards.TabIndex = 21
			Me.chkValidCards.Text = "Luhn Algorithm"
			Me.chkValidCards.UseVisualStyleBackColor = True
			' 
			' chkED
			' 
			Me.chkED.AutoSize = True
			Me.chkED.Checked = True
			Me.chkED.CheckState = System.Windows.Forms.CheckState.Checked
			Me.chkED.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.chkED.ForeColor = System.Drawing.Color.White
			Me.chkED.Location = New System.Drawing.Point(278, 153)
			Me.chkED.Name = "chkED"
			Me.chkED.Size = New System.Drawing.Size(75, 29)
			Me.chkED.TabIndex = 20
			Me.chkED.Text = "ADD"
			Me.chkED.UseVisualStyleBackColor = True
			' 
			' chkCVV
			' 
			Me.chkCVV.AutoSize = True
			Me.chkCVV.Checked = True
			Me.chkCVV.CheckState = System.Windows.Forms.CheckState.Checked
			Me.chkCVV.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.chkCVV.ForeColor = System.Drawing.Color.White
			Me.chkCVV.Location = New System.Drawing.Point(278, 92)
			Me.chkCVV.Name = "chkCVV"
			Me.chkCVV.Size = New System.Drawing.Size(75, 29)
			Me.chkCVV.TabIndex = 19
			Me.chkCVV.Text = "ADD"
			Me.chkCVV.UseVisualStyleBackColor = True
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label5.ForeColor = System.Drawing.Color.White
			Me.label5.Location = New System.Drawing.Point(3, 125)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(137, 24)
			Me.label5.TabIndex = 18
			Me.label5.Text = "Expiration Date"
			' 
			' button10
			' 
			Me.button10.BackColor = System.Drawing.Color.DimGray
			Me.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button10.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button10.ForeColor = System.Drawing.Color.White
			Me.button10.Location = New System.Drawing.Point(159, 152)
			Me.button10.Name = "button10"
			Me.button10.Size = New System.Drawing.Size(113, 31)
			Me.button10.TabIndex = 17
			Me.button10.Text = "random"
			Me.button10.UseVisualStyleBackColor = False
'			Me.button10.Click += New System.EventHandler(Me.button10_Click)
			' 
			' txtExpirationDate
			' 
			Me.txtExpirationDate.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.txtExpirationDate.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.txtExpirationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.txtExpirationDate.ForeColor = System.Drawing.Color.White
			Me.txtExpirationDate.Location = New System.Drawing.Point(3, 152)
			Me.txtExpirationDate.MaxLength = 7
			Me.txtExpirationDate.Name = "txtExpirationDate"
			Me.txtExpirationDate.Size = New System.Drawing.Size(150, 31)
			Me.txtExpirationDate.TabIndex = 16
			Me.txtExpirationDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label4.ForeColor = System.Drawing.Color.White
			Me.label4.Location = New System.Drawing.Point(3, 64)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(49, 24)
			Me.label4.TabIndex = 15
			Me.label4.Text = "CVV"
			' 
			' button9
			' 
			Me.button9.BackColor = System.Drawing.Color.DimGray
			Me.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button9.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button9.ForeColor = System.Drawing.Color.White
			Me.button9.Location = New System.Drawing.Point(159, 91)
			Me.button9.Name = "button9"
			Me.button9.Size = New System.Drawing.Size(113, 31)
			Me.button9.TabIndex = 14
			Me.button9.Text = "random"
			Me.button9.UseVisualStyleBackColor = False
'			Me.button9.Click += New System.EventHandler(Me.button9_Click)
			' 
			' txtCVV
			' 
			Me.txtCVV.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.txtCVV.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.txtCVV.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.txtCVV.ForeColor = System.Drawing.Color.White
			Me.txtCVV.Location = New System.Drawing.Point(3, 91)
			Me.txtCVV.MaxLength = 3
			Me.txtCVV.Name = "txtCVV"
			Me.txtCVV.Size = New System.Drawing.Size(150, 31)
			Me.txtCVV.TabIndex = 13
			Me.txtCVV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' button8
			' 
			Me.button8.BackColor = System.Drawing.Color.DimGray
			Me.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button8.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button8.ForeColor = System.Drawing.Color.White
			Me.button8.Location = New System.Drawing.Point(384, 604)
			Me.button8.Name = "button8"
			Me.button8.Size = New System.Drawing.Size(113, 31)
			Me.button8.TabIndex = 12
			Me.button8.Text = "COPY"
			Me.button8.UseVisualStyleBackColor = False
'			Me.button8.Click += New System.EventHandler(Me.button8_Click)
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label3.ForeColor = System.Drawing.Color.White
			Me.label3.Location = New System.Drawing.Point(3, 275)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(68, 24)
			Me.label3.TabIndex = 11
			Me.label3.Text = "Length"
			' 
			' nLength
			' 
			Me.nLength.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.nLength.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.nLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.nLength.ForeColor = System.Drawing.Color.White
			Me.nLength.Location = New System.Drawing.Point(7, 302)
			Me.nLength.Minimum = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.nLength.Name = "nLength"
			Me.nLength.Size = New System.Drawing.Size(150, 34)
			Me.nLength.TabIndex = 10
			Me.nLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			Me.nLength.Value = New Decimal(New Integer() { 16, 0, 0, 0})
			' 
			' button7
			' 
			Me.button7.BackColor = System.Drawing.Color.DimGray
			Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button7.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button7.ForeColor = System.Drawing.Color.White
			Me.button7.Location = New System.Drawing.Point(503, 605)
			Me.button7.Name = "button7"
			Me.button7.Size = New System.Drawing.Size(113, 31)
			Me.button7.TabIndex = 9
			Me.button7.Text = "CLEAR"
			Me.button7.UseVisualStyleBackColor = False
'			Me.button7.Click += New System.EventHandler(Me.button7_Click)
			' 
			' progressBar1
			' 
			Me.progressBar1.Location = New System.Drawing.Point(7, 482)
			Me.progressBar1.Name = "progressBar1"
			Me.progressBar1.Size = New System.Drawing.Size(371, 26)
			Me.progressBar1.TabIndex = 8
			' 
			' button6
			' 
			Me.button6.BackColor = System.Drawing.Color.DimGray
			Me.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button6.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button6.ForeColor = System.Drawing.Color.White
			Me.button6.Location = New System.Drawing.Point(163, 30)
			Me.button6.Name = "button6"
			Me.button6.Size = New System.Drawing.Size(113, 31)
			Me.button6.TabIndex = 7
			Me.button6.Text = "random"
			Me.button6.UseVisualStyleBackColor = False
'			Me.button6.Click += New System.EventHandler(Me.button6_Click)
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.ForeColor = System.Drawing.Color.White
			Me.label2.Location = New System.Drawing.Point(3, 211)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(78, 24)
			Me.label2.TabIndex = 6
			Me.label2.Text = "Quantity"
			' 
			' numericUpDown1
			' 
			Me.numericUpDown1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.numericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.numericUpDown1.ForeColor = System.Drawing.Color.White
			Me.numericUpDown1.Location = New System.Drawing.Point(7, 238)
			Me.numericUpDown1.Maximum = New Decimal(New Integer() { 10000, 0, 0, 0})
			Me.numericUpDown1.Minimum = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.numericUpDown1.Name = "numericUpDown1"
			Me.numericUpDown1.Size = New System.Drawing.Size(150, 34)
			Me.numericUpDown1.TabIndex = 5
			Me.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			Me.numericUpDown1.Value = New Decimal(New Integer() { 10, 0, 0, 0})
			' 
			' txtbin
			' 
			Me.txtbin.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.txtbin.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.txtbin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.txtbin.ForeColor = System.Drawing.Color.White
			Me.txtbin.Location = New System.Drawing.Point(7, 30)
			Me.txtbin.MaxLength = 8
			Me.txtbin.Name = "txtbin"
			Me.txtbin.Size = New System.Drawing.Size(150, 31)
			Me.txtbin.TabIndex = 4
			Me.txtbin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.ForeColor = System.Drawing.Color.White
			Me.label1.Location = New System.Drawing.Point(3, 3)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(37, 24)
			Me.label1.TabIndex = 3
			Me.label1.Text = "Bin"
			' 
			' btnGenerateCC
			' 
			Me.btnGenerateCC.BackColor = System.Drawing.Color.DimGray
			Me.btnGenerateCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.btnGenerateCC.Font = New System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.btnGenerateCC.ForeColor = System.Drawing.Color.White
			Me.btnGenerateCC.Location = New System.Drawing.Point(7, 435)
			Me.btnGenerateCC.Name = "btnGenerateCC"
			Me.btnGenerateCC.Size = New System.Drawing.Size(371, 41)
			Me.btnGenerateCC.TabIndex = 2
			Me.btnGenerateCC.Text = "GENERATE NEW CARDS"
			Me.btnGenerateCC.UseVisualStyleBackColor = False
'			Me.btnGenerateCC.Click += New System.EventHandler(Me.button5_Click)
			' 
			' txtNewCards
			' 
			Me.txtNewCards.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.txtNewCards.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.txtNewCards.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.txtNewCards.ForeColor = System.Drawing.Color.White
			Me.txtNewCards.Location = New System.Drawing.Point(384, 3)
			Me.txtNewCards.Name = "txtNewCards"
			Me.txtNewCards.Size = New System.Drawing.Size(452, 596)
			Me.txtNewCards.TabIndex = 0
			Me.txtNewCards.Text = ""
			' 
			' pnlBins
			' 
			Me.pnlBins.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(24)))), (CInt((CByte(24)))), (CInt((CByte(24)))))
			Me.pnlBins.Controls.Add(Me.lblvalidlog)
			Me.pnlBins.Controls.Add(Me.lblcheckedlog)
			Me.pnlBins.Controls.Add(Me.validBinsLog)
			Me.pnlBins.Controls.Add(Me.checkingBinsLog)
			Me.pnlBins.Controls.Add(Me.groupBox5)
			Me.pnlBins.Controls.Add(Me.groupBox4)
			Me.pnlBins.Controls.Add(Me.groupBox3)
			Me.pnlBins.Controls.Add(Me.groupBox2)
			Me.pnlBins.Controls.Add(Me.groupBox1)
			Me.pnlBins.Controls.Add(Me.lblstatus)
			Me.pnlBins.Controls.Add(Me.label8)
			Me.pnlBins.Controls.Add(Me.button16)
			Me.pnlBins.Controls.Add(Me.txtBinValidate)
			Me.pnlBins.Controls.Add(Me.label14)
			Me.pnlBins.Location = New System.Drawing.Point(188, 12)
			Me.pnlBins.Name = "pnlBins"
			Me.pnlBins.Size = New System.Drawing.Size(847, 653)
			Me.pnlBins.TabIndex = 24
			' 
			' lblvalidlog
			' 
			Me.lblvalidlog.AutoSize = True
			Me.lblvalidlog.Font = New System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.lblvalidlog.ForeColor = System.Drawing.Color.Lime
			Me.lblvalidlog.Location = New System.Drawing.Point(172, 618)
			Me.lblvalidlog.Name = "lblvalidlog"
			Me.lblvalidlog.Size = New System.Drawing.Size(16, 18)
			Me.lblvalidlog.TabIndex = 26
			Me.lblvalidlog.Text = "0"
			' 
			' lblcheckedlog
			' 
			Me.lblcheckedlog.AutoSize = True
			Me.lblcheckedlog.Font = New System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.lblcheckedlog.ForeColor = System.Drawing.Color.White
			Me.lblcheckedlog.Location = New System.Drawing.Point(11, 616)
			Me.lblcheckedlog.Name = "lblcheckedlog"
			Me.lblcheckedlog.Size = New System.Drawing.Size(16, 18)
			Me.lblcheckedlog.TabIndex = 25
			Me.lblcheckedlog.Text = "0"
			' 
			' validBinsLog
			' 
			Me.validBinsLog.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.validBinsLog.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.validBinsLog.Font = New System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.validBinsLog.ForeColor = System.Drawing.Color.Lime
			Me.validBinsLog.FormattingEnabled = True
			Me.validBinsLog.ItemHeight = 15
			Me.validBinsLog.Location = New System.Drawing.Point(175, 253)
			Me.validBinsLog.Name = "validBinsLog"
			Me.validBinsLog.Size = New System.Drawing.Size(142, 360)
			Me.validBinsLog.TabIndex = 24
			' 
			' checkingBinsLog
			' 
			Me.checkingBinsLog.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.checkingBinsLog.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.checkingBinsLog.Font = New System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkingBinsLog.ForeColor = System.Drawing.Color.White
			Me.checkingBinsLog.FormattingEnabled = True
			Me.checkingBinsLog.ItemHeight = 15
			Me.checkingBinsLog.Location = New System.Drawing.Point(8, 253)
			Me.checkingBinsLog.Name = "checkingBinsLog"
			Me.checkingBinsLog.Size = New System.Drawing.Size(161, 360)
			Me.checkingBinsLog.TabIndex = 23
			' 
			' groupBox5
			' 
			Me.groupBox5.Controls.Add(Me.button14)
			Me.groupBox5.Controls.Add(Me.txtrandombincheckerpath)
			Me.groupBox5.Controls.Add(Me.btnRandomBinChecker)
			Me.groupBox5.Font = New System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox5.ForeColor = System.Drawing.Color.White
			Me.groupBox5.Location = New System.Drawing.Point(8, 131)
			Me.groupBox5.Name = "groupBox5"
			Me.groupBox5.Size = New System.Drawing.Size(309, 116)
			Me.groupBox5.TabIndex = 22
			Me.groupBox5.TabStop = False
			Me.groupBox5.Text = "Random Bin Checker"
			' 
			' button14
			' 
			Me.button14.BackColor = System.Drawing.Color.DimGray
			Me.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button14.Font = New System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button14.ForeColor = System.Drawing.Color.White
			Me.button14.Location = New System.Drawing.Point(231, 49)
			Me.button14.Name = "button14"
			Me.button14.Size = New System.Drawing.Size(72, 30)
			Me.button14.TabIndex = 23
			Me.button14.Text = "..."
			Me.button14.UseVisualStyleBackColor = False
'			Me.button14.Click += New System.EventHandler(Me.button14_Click)
			' 
			' txtrandombincheckerpath
			' 
			Me.txtrandombincheckerpath.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.txtrandombincheckerpath.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.txtrandombincheckerpath.Enabled = False
			Me.txtrandombincheckerpath.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.txtrandombincheckerpath.ForeColor = System.Drawing.Color.White
			Me.txtrandombincheckerpath.Location = New System.Drawing.Point(6, 24)
			Me.txtrandombincheckerpath.MaxLength = 8
			Me.txtrandombincheckerpath.Name = "txtrandombincheckerpath"
			Me.txtrandombincheckerpath.ReadOnly = True
			Me.txtrandombincheckerpath.Size = New System.Drawing.Size(297, 19)
			Me.txtrandombincheckerpath.TabIndex = 16
			Me.txtrandombincheckerpath.Text = "txt file path"
			Me.txtrandombincheckerpath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' btnRandomBinChecker
			' 
			Me.btnRandomBinChecker.BackColor = System.Drawing.Color.Maroon
			Me.btnRandomBinChecker.Enabled = False
			Me.btnRandomBinChecker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.btnRandomBinChecker.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.btnRandomBinChecker.ForeColor = System.Drawing.Color.White
			Me.btnRandomBinChecker.Location = New System.Drawing.Point(6, 61)
			Me.btnRandomBinChecker.Name = "btnRandomBinChecker"
			Me.btnRandomBinChecker.Size = New System.Drawing.Size(143, 49)
			Me.btnRandomBinChecker.TabIndex = 23
			Me.btnRandomBinChecker.Text = "Off"
			Me.btnRandomBinChecker.UseVisualStyleBackColor = False
'			Me.btnRandomBinChecker.Click += New System.EventHandler(Me.btnRandomBinChecker_Click)
			' 
			' groupBox4
			' 
			Me.groupBox4.Controls.Add(Me.txtBankCity)
			Me.groupBox4.Controls.Add(Me.label22)
			Me.groupBox4.Controls.Add(Me.txtBankPhone)
			Me.groupBox4.Controls.Add(Me.label13)
			Me.groupBox4.Controls.Add(Me.txtBankUrl)
			Me.groupBox4.Controls.Add(Me.label20)
			Me.groupBox4.Controls.Add(Me.txtBankName)
			Me.groupBox4.Controls.Add(Me.label21)
			Me.groupBox4.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox4.ForeColor = System.Drawing.Color.White
			Me.groupBox4.Location = New System.Drawing.Point(449, 404)
			Me.groupBox4.Name = "groupBox4"
			Me.groupBox4.Size = New System.Drawing.Size(271, 133)
			Me.groupBox4.TabIndex = 21
			Me.groupBox4.TabStop = False
			Me.groupBox4.Text = "Bank"
			' 
			' txtBankCity
			' 
			Me.txtBankCity.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.txtBankCity.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.txtBankCity.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.txtBankCity.ForeColor = System.Drawing.Color.White
			Me.txtBankCity.Location = New System.Drawing.Point(75, 98)
			Me.txtBankCity.MaxLength = 8
			Me.txtBankCity.Name = "txtBankCity"
			Me.txtBankCity.ReadOnly = True
			Me.txtBankCity.Size = New System.Drawing.Size(178, 19)
			Me.txtBankCity.TabIndex = 18
			Me.txtBankCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' label22
			' 
			Me.label22.AutoSize = True
			Me.label22.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label22.ForeColor = System.Drawing.Color.White
			Me.label22.Location = New System.Drawing.Point(6, 98)
			Me.label22.Name = "label22"
			Me.label22.Size = New System.Drawing.Size(45, 19)
			Me.label22.TabIndex = 19
			Me.label22.Text = "City"
			' 
			' txtBankPhone
			' 
			Me.txtBankPhone.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.txtBankPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.txtBankPhone.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.txtBankPhone.ForeColor = System.Drawing.Color.White
			Me.txtBankPhone.Location = New System.Drawing.Point(75, 73)
			Me.txtBankPhone.MaxLength = 8
			Me.txtBankPhone.Name = "txtBankPhone"
			Me.txtBankPhone.ReadOnly = True
			Me.txtBankPhone.Size = New System.Drawing.Size(178, 19)
			Me.txtBankPhone.TabIndex = 16
			Me.txtBankPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' label13
			' 
			Me.label13.AutoSize = True
			Me.label13.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label13.ForeColor = System.Drawing.Color.White
			Me.label13.Location = New System.Drawing.Point(6, 73)
			Me.label13.Name = "label13"
			Me.label13.Size = New System.Drawing.Size(54, 19)
			Me.label13.TabIndex = 17
			Me.label13.Text = "Phone"
			' 
			' txtBankUrl
			' 
			Me.txtBankUrl.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.txtBankUrl.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.txtBankUrl.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.txtBankUrl.ForeColor = System.Drawing.Color.White
			Me.txtBankUrl.Location = New System.Drawing.Point(75, 48)
			Me.txtBankUrl.MaxLength = 8
			Me.txtBankUrl.Name = "txtBankUrl"
			Me.txtBankUrl.ReadOnly = True
			Me.txtBankUrl.Size = New System.Drawing.Size(178, 19)
			Me.txtBankUrl.TabIndex = 14
			Me.txtBankUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' label20
			' 
			Me.label20.AutoSize = True
			Me.label20.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label20.ForeColor = System.Drawing.Color.White
			Me.label20.Location = New System.Drawing.Point(6, 48)
			Me.label20.Name = "label20"
			Me.label20.Size = New System.Drawing.Size(36, 19)
			Me.label20.TabIndex = 15
			Me.label20.Text = "Url"
			' 
			' txtBankName
			' 
			Me.txtBankName.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.txtBankName.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.txtBankName.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.txtBankName.ForeColor = System.Drawing.Color.White
			Me.txtBankName.Location = New System.Drawing.Point(75, 22)
			Me.txtBankName.MaxLength = 8
			Me.txtBankName.Name = "txtBankName"
			Me.txtBankName.ReadOnly = True
			Me.txtBankName.Size = New System.Drawing.Size(178, 19)
			Me.txtBankName.TabIndex = 13
			Me.txtBankName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' label21
			' 
			Me.label21.AutoSize = True
			Me.label21.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label21.ForeColor = System.Drawing.Color.White
			Me.label21.Location = New System.Drawing.Point(6, 22)
			Me.label21.Name = "label21"
			Me.label21.Size = New System.Drawing.Size(45, 19)
			Me.label21.TabIndex = 13
			Me.label21.Text = "Name"
			' 
			' groupBox3
			' 
			Me.groupBox3.Controls.Add(Me.txtCountryCurrency)
			Me.groupBox3.Controls.Add(Me.label15)
			Me.groupBox3.Controls.Add(Me.txtCountryAlpha2)
			Me.groupBox3.Controls.Add(Me.label18)
			Me.groupBox3.Controls.Add(Me.txtCountryName)
			Me.groupBox3.Controls.Add(Me.label19)
			Me.groupBox3.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox3.ForeColor = System.Drawing.Color.White
			Me.groupBox3.Location = New System.Drawing.Point(449, 294)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(271, 104)
			Me.groupBox3.TabIndex = 20
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "Country"
			' 
			' txtCountryCurrency
			' 
			Me.txtCountryCurrency.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.txtCountryCurrency.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.txtCountryCurrency.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.txtCountryCurrency.ForeColor = System.Drawing.Color.White
			Me.txtCountryCurrency.Location = New System.Drawing.Point(93, 73)
			Me.txtCountryCurrency.MaxLength = 8
			Me.txtCountryCurrency.Name = "txtCountryCurrency"
			Me.txtCountryCurrency.ReadOnly = True
			Me.txtCountryCurrency.Size = New System.Drawing.Size(160, 19)
			Me.txtCountryCurrency.TabIndex = 16
			Me.txtCountryCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' label15
			' 
			Me.label15.AutoSize = True
			Me.label15.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label15.ForeColor = System.Drawing.Color.White
			Me.label15.Location = New System.Drawing.Point(6, 73)
			Me.label15.Name = "label15"
			Me.label15.Size = New System.Drawing.Size(81, 19)
			Me.label15.TabIndex = 17
			Me.label15.Text = "Currency"
			' 
			' txtCountryAlpha2
			' 
			Me.txtCountryAlpha2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.txtCountryAlpha2.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.txtCountryAlpha2.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.txtCountryAlpha2.ForeColor = System.Drawing.Color.White
			Me.txtCountryAlpha2.Location = New System.Drawing.Point(75, 48)
			Me.txtCountryAlpha2.MaxLength = 8
			Me.txtCountryAlpha2.Name = "txtCountryAlpha2"
			Me.txtCountryAlpha2.ReadOnly = True
			Me.txtCountryAlpha2.Size = New System.Drawing.Size(178, 19)
			Me.txtCountryAlpha2.TabIndex = 14
			Me.txtCountryAlpha2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' label18
			' 
			Me.label18.AutoSize = True
			Me.label18.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label18.ForeColor = System.Drawing.Color.White
			Me.label18.Location = New System.Drawing.Point(6, 48)
			Me.label18.Name = "label18"
			Me.label18.Size = New System.Drawing.Size(63, 19)
			Me.label18.TabIndex = 15
			Me.label18.Text = "Alpha2"
			' 
			' txtCountryName
			' 
			Me.txtCountryName.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.txtCountryName.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.txtCountryName.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.txtCountryName.ForeColor = System.Drawing.Color.White
			Me.txtCountryName.Location = New System.Drawing.Point(75, 22)
			Me.txtCountryName.MaxLength = 8
			Me.txtCountryName.Name = "txtCountryName"
			Me.txtCountryName.ReadOnly = True
			Me.txtCountryName.Size = New System.Drawing.Size(178, 19)
			Me.txtCountryName.TabIndex = 13
			Me.txtCountryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' label19
			' 
			Me.label19.AutoSize = True
			Me.label19.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label19.ForeColor = System.Drawing.Color.White
			Me.label19.Location = New System.Drawing.Point(6, 22)
			Me.label19.Name = "label19"
			Me.label19.Size = New System.Drawing.Size(45, 19)
			Me.label19.TabIndex = 13
			Me.label19.Text = "Name"
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.txtLuhn)
			Me.groupBox2.Controls.Add(Me.label16)
			Me.groupBox2.Controls.Add(Me.txtLength)
			Me.groupBox2.Controls.Add(Me.label17)
			Me.groupBox2.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox2.ForeColor = System.Drawing.Color.White
			Me.groupBox2.Location = New System.Drawing.Point(451, 64)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(271, 85)
			Me.groupBox2.TabIndex = 20
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "General"
			' 
			' txtLuhn
			' 
			Me.txtLuhn.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.txtLuhn.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.txtLuhn.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.txtLuhn.ForeColor = System.Drawing.Color.White
			Me.txtLuhn.Location = New System.Drawing.Point(75, 48)
			Me.txtLuhn.MaxLength = 8
			Me.txtLuhn.Name = "txtLuhn"
			Me.txtLuhn.ReadOnly = True
			Me.txtLuhn.Size = New System.Drawing.Size(178, 19)
			Me.txtLuhn.TabIndex = 14
			Me.txtLuhn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' label16
			' 
			Me.label16.AutoSize = True
			Me.label16.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label16.ForeColor = System.Drawing.Color.White
			Me.label16.Location = New System.Drawing.Point(6, 48)
			Me.label16.Name = "label16"
			Me.label16.Size = New System.Drawing.Size(45, 19)
			Me.label16.TabIndex = 15
			Me.label16.Text = "Luhn"
			' 
			' txtLength
			' 
			Me.txtLength.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.txtLength.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.txtLength.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.txtLength.ForeColor = System.Drawing.Color.White
			Me.txtLength.Location = New System.Drawing.Point(75, 22)
			Me.txtLength.MaxLength = 8
			Me.txtLength.Name = "txtLength"
			Me.txtLength.ReadOnly = True
			Me.txtLength.Size = New System.Drawing.Size(178, 19)
			Me.txtLength.TabIndex = 13
			Me.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' label17
			' 
			Me.label17.AutoSize = True
			Me.label17.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label17.ForeColor = System.Drawing.Color.White
			Me.label17.Location = New System.Drawing.Point(6, 22)
			Me.label17.Name = "label17"
			Me.label17.Size = New System.Drawing.Size(63, 19)
			Me.label17.TabIndex = 13
			Me.label17.Text = "Length"
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.txtPrepaid)
			Me.groupBox1.Controls.Add(Me.label12)
			Me.groupBox1.Controls.Add(Me.txtBrand)
			Me.groupBox1.Controls.Add(Me.label11)
			Me.groupBox1.Controls.Add(Me.txtType)
			Me.groupBox1.Controls.Add(Me.label10)
			Me.groupBox1.Controls.Add(Me.txtScheme)
			Me.groupBox1.Controls.Add(Me.label9)
			Me.groupBox1.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox1.ForeColor = System.Drawing.Color.White
			Me.groupBox1.Location = New System.Drawing.Point(451, 155)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(271, 133)
			Me.groupBox1.TabIndex = 12
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Card"
			' 
			' txtPrepaid
			' 
			Me.txtPrepaid.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.txtPrepaid.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.txtPrepaid.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.txtPrepaid.ForeColor = System.Drawing.Color.White
			Me.txtPrepaid.Location = New System.Drawing.Point(84, 98)
			Me.txtPrepaid.MaxLength = 8
			Me.txtPrepaid.Name = "txtPrepaid"
			Me.txtPrepaid.ReadOnly = True
			Me.txtPrepaid.Size = New System.Drawing.Size(169, 19)
			Me.txtPrepaid.TabIndex = 18
			Me.txtPrepaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label12.ForeColor = System.Drawing.Color.White
			Me.label12.Location = New System.Drawing.Point(6, 98)
			Me.label12.Name = "label12"
			Me.label12.Size = New System.Drawing.Size(72, 19)
			Me.label12.TabIndex = 19
			Me.label12.Text = "Prepaid"
			' 
			' txtBrand
			' 
			Me.txtBrand.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.txtBrand.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.txtBrand.ForeColor = System.Drawing.Color.White
			Me.txtBrand.Location = New System.Drawing.Point(75, 73)
			Me.txtBrand.MaxLength = 8
			Me.txtBrand.Name = "txtBrand"
			Me.txtBrand.ReadOnly = True
			Me.txtBrand.Size = New System.Drawing.Size(178, 19)
			Me.txtBrand.TabIndex = 16
			Me.txtBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' label11
			' 
			Me.label11.AutoSize = True
			Me.label11.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label11.ForeColor = System.Drawing.Color.White
			Me.label11.Location = New System.Drawing.Point(6, 73)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(54, 19)
			Me.label11.TabIndex = 17
			Me.label11.Text = "Brand"
			' 
			' txtType
			' 
			Me.txtType.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.txtType.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.txtType.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.txtType.ForeColor = System.Drawing.Color.White
			Me.txtType.Location = New System.Drawing.Point(75, 48)
			Me.txtType.MaxLength = 8
			Me.txtType.Name = "txtType"
			Me.txtType.ReadOnly = True
			Me.txtType.Size = New System.Drawing.Size(178, 19)
			Me.txtType.TabIndex = 14
			Me.txtType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label10.ForeColor = System.Drawing.Color.White
			Me.label10.Location = New System.Drawing.Point(6, 48)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(45, 19)
			Me.label10.TabIndex = 15
			Me.label10.Text = "Type"
			' 
			' txtScheme
			' 
			Me.txtScheme.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.txtScheme.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.txtScheme.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.txtScheme.ForeColor = System.Drawing.Color.White
			Me.txtScheme.Location = New System.Drawing.Point(75, 22)
			Me.txtScheme.MaxLength = 8
			Me.txtScheme.Name = "txtScheme"
			Me.txtScheme.ReadOnly = True
			Me.txtScheme.Size = New System.Drawing.Size(178, 19)
			Me.txtScheme.TabIndex = 13
			Me.txtScheme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label9.ForeColor = System.Drawing.Color.White
			Me.label9.Location = New System.Drawing.Point(6, 22)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(63, 19)
			Me.label9.TabIndex = 13
			Me.label9.Text = "Scheme"
			' 
			' lblstatus
			' 
			Me.lblstatus.AutoSize = True
			Me.lblstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.lblstatus.ForeColor = System.Drawing.Color.White
			Me.lblstatus.Location = New System.Drawing.Point(3, 64)
			Me.lblstatus.Name = "lblstatus"
			Me.lblstatus.Size = New System.Drawing.Size(65, 24)
			Me.lblstatus.TabIndex = 11
			Me.lblstatus.Text = "Status:"
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label8.ForeColor = System.Drawing.Color.White
			Me.label8.Location = New System.Drawing.Point(453, 18)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(267, 33)
			Me.label8.TabIndex = 9
			Me.label8.Text = "Some informations:"
			' 
			' button16
			' 
			Me.button16.BackColor = System.Drawing.Color.DimGray
			Me.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button16.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button16.ForeColor = System.Drawing.Color.White
			Me.button16.Location = New System.Drawing.Point(163, 30)
			Me.button16.Name = "button16"
			Me.button16.Size = New System.Drawing.Size(113, 31)
			Me.button16.TabIndex = 7
			Me.button16.Text = "Check"
			Me.button16.UseVisualStyleBackColor = False
'			Me.button16.Click += New System.EventHandler(Me.button16_Click)
			' 
			' txtBinValidate
			' 
			Me.txtBinValidate.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.txtBinValidate.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.txtBinValidate.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.txtBinValidate.ForeColor = System.Drawing.Color.White
			Me.txtBinValidate.Location = New System.Drawing.Point(7, 30)
			Me.txtBinValidate.MaxLength = 8
			Me.txtBinValidate.Name = "txtBinValidate"
			Me.txtBinValidate.Size = New System.Drawing.Size(150, 31)
			Me.txtBinValidate.TabIndex = 4
			Me.txtBinValidate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' label14
			' 
			Me.label14.AutoSize = True
			Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label14.ForeColor = System.Drawing.Color.White
			Me.label14.Location = New System.Drawing.Point(3, 3)
			Me.label14.Name = "label14"
			Me.label14.Size = New System.Drawing.Size(37, 24)
			Me.label14.TabIndex = 3
			Me.label14.Text = "Bin"
			' 
			' backgroundWorker1
			' 
'			Me.backgroundWorker1.DoWork += New System.ComponentModel.DoWorkEventHandler(Me.backgroundWorker1_DoWork)
			' 
			' Generator
			' 
			Me.Generator.WorkerSupportsCancellation = True
'			Me.Generator.DoWork += New System.ComponentModel.DoWorkEventHandler(Me.Generator_DoWork)
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(24)))), (CInt((CByte(24)))), (CInt((CByte(24)))))
			Me.ClientSize = New System.Drawing.Size(1039, 673)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.pnlChecker)
			Me.Controls.Add(Me.pnlBins)
			Me.Controls.Add(Me.pnlGenerator)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.Name = "Main"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "I love life"
'			Me.Load += New System.EventHandler(Me.CHECKER_Load)
			Me.panel1.ResumeLayout(False)
			Me.pnlChecker.ResumeLayout(False)
			Me.pnlChecker.PerformLayout()
			Me.pnlGenerator.ResumeLayout(False)
			Me.pnlGenerator.PerformLayout()
			DirectCast(Me.nLength, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlBins.ResumeLayout(False)
			Me.pnlBins.PerformLayout()
			Me.groupBox5.ResumeLayout(False)
			Me.groupBox5.PerformLayout()
			Me.groupBox4.ResumeLayout(False)
			Me.groupBox4.PerformLayout()
			Me.groupBox3.ResumeLayout(False)
			Me.groupBox3.PerformLayout()
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox2.PerformLayout()
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private txtCheckCCs As System.Windows.Forms.RichTextBox
		Private WithEvents btnCheck As System.Windows.Forms.Button
		Private WithEvents btnLoad As System.Windows.Forms.Button
		Private checkingBar As System.Windows.Forms.ProgressBar
		Private txtValidCCs As System.Windows.Forms.RichTextBox
		Private WithEvents button1 As System.Windows.Forms.Button
		Private panel1 As System.Windows.Forms.Panel
		Private txtInvalidCC As System.Windows.Forms.RichTextBox
		Private WithEvents button4 As System.Windows.Forms.Button
		Private WithEvents button3 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private pnlChecker As System.Windows.Forms.Panel
		Private pnlGenerator As System.Windows.Forms.Panel
		Private txtbin As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label
		Private WithEvents btnGenerateCC As System.Windows.Forms.Button
		Private txtNewCards As System.Windows.Forms.RichTextBox
		Private label2 As System.Windows.Forms.Label
		Private numericUpDown1 As System.Windows.Forms.NumericUpDown
		Private WithEvents button6 As System.Windows.Forms.Button
		Private progressBar1 As System.Windows.Forms.ProgressBar
		Private WithEvents button7 As System.Windows.Forms.Button
		Private label3 As System.Windows.Forms.Label
		Private nLength As System.Windows.Forms.NumericUpDown
		Private WithEvents button8 As System.Windows.Forms.Button
		Private chkED As System.Windows.Forms.CheckBox
		Private chkCVV As System.Windows.Forms.CheckBox
		Private label5 As System.Windows.Forms.Label
		Private WithEvents button10 As System.Windows.Forms.Button
		Private txtExpirationDate As System.Windows.Forms.TextBox
		Private label4 As System.Windows.Forms.Label
		Private WithEvents button9 As System.Windows.Forms.Button
		Private txtCVV As System.Windows.Forms.TextBox
		Private chkValidCards As System.Windows.Forms.CheckBox
		Private lblInvalid As System.Windows.Forms.Label
		Private lblValid As System.Windows.Forms.Label
		Private WithEvents button11 As System.Windows.Forms.Button
		Private label7 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private pnlBins As System.Windows.Forms.Panel
		Private WithEvents button16 As System.Windows.Forms.Button
		Private txtBinValidate As System.Windows.Forms.TextBox
		Private label14 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private lblstatus As System.Windows.Forms.Label
		Private groupBox4 As System.Windows.Forms.GroupBox
		Private txtBankCity As System.Windows.Forms.TextBox
		Private label22 As System.Windows.Forms.Label
		Private txtBankPhone As System.Windows.Forms.TextBox
		Private label13 As System.Windows.Forms.Label
		Private txtBankUrl As System.Windows.Forms.TextBox
		Private label20 As System.Windows.Forms.Label
		Private txtBankName As System.Windows.Forms.TextBox
		Private label21 As System.Windows.Forms.Label
		Private groupBox3 As System.Windows.Forms.GroupBox
		Private txtCountryCurrency As System.Windows.Forms.TextBox
		Private label15 As System.Windows.Forms.Label
		Private txtCountryAlpha2 As System.Windows.Forms.TextBox
		Private label18 As System.Windows.Forms.Label
		Private txtCountryName As System.Windows.Forms.TextBox
		Private label19 As System.Windows.Forms.Label
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private txtLuhn As System.Windows.Forms.TextBox
		Private label16 As System.Windows.Forms.Label
		Private txtLength As System.Windows.Forms.TextBox
		Private label17 As System.Windows.Forms.Label
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private txtPrepaid As System.Windows.Forms.TextBox
		Private label12 As System.Windows.Forms.Label
		Private txtBrand As System.Windows.Forms.TextBox
		Private label11 As System.Windows.Forms.Label
		Private txtType As System.Windows.Forms.TextBox
		Private label10 As System.Windows.Forms.Label
		Private txtScheme As System.Windows.Forms.TextBox
		Private label9 As System.Windows.Forms.Label
		Private WithEvents button12 As System.Windows.Forms.Button
		Private groupBox5 As System.Windows.Forms.GroupBox
		Private WithEvents button14 As System.Windows.Forms.Button
		Private txtrandombincheckerpath As System.Windows.Forms.TextBox
		Private WithEvents btnRandomBinChecker As System.Windows.Forms.Button
		Private WithEvents backgroundWorker1 As System.ComponentModel.BackgroundWorker
		Private checkingBinsLog As System.Windows.Forms.ListBox
		Private validBinsLog As System.Windows.Forms.ListBox
		Private lblvalidlog As System.Windows.Forms.Label
		Private lblcheckedlog As System.Windows.Forms.Label
		Private WithEvents button13 As System.Windows.Forms.Button
		Private WithEvents Generator As System.ComponentModel.BackgroundWorker
		Private WithEvents button5 As System.Windows.Forms.Button
		Private chkValidRegex As System.Windows.Forms.CheckBox
	End Class
End Namespace

