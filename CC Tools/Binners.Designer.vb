Namespace CC_Tools
	Partial Public Class Binners
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.label1 = New System.Windows.Forms.Label()
			Me.validBinsLog = New System.Windows.Forms.ListBox()
			Me.listBox1 = New System.Windows.Forms.ListBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.listBox2 = New System.Windows.Forms.ListBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.listBox3 = New System.Windows.Forms.ListBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.listBox4 = New System.Windows.Forms.ListBox()
			Me.label5 = New System.Windows.Forms.Label()
			Me.listBox5 = New System.Windows.Forms.ListBox()
			Me.label6 = New System.Windows.Forms.Label()
			Me.label7 = New System.Windows.Forms.Label()
			Me.label8 = New System.Windows.Forms.Label()
			Me.label9 = New System.Windows.Forms.Label()
			Me.label10 = New System.Windows.Forms.Label()
			Me.label11 = New System.Windows.Forms.Label()
			Me.label12 = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
			Me.label1.Location = New System.Drawing.Point(12, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(130, 24)
			Me.label1.TabIndex = 0
			Me.label1.Text = "MasterCard"
			' 
			' validBinsLog
			' 
			Me.validBinsLog.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.validBinsLog.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.validBinsLog.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.validBinsLog.ForeColor = System.Drawing.Color.White
			Me.validBinsLog.FormattingEnabled = True
			Me.validBinsLog.ItemHeight = 19
			Me.validBinsLog.Items.AddRange(New Object() { "2221–2720", "51–55"})
			Me.validBinsLog.Location = New System.Drawing.Point(16, 36)
			Me.validBinsLog.Name = "validBinsLog"
			Me.validBinsLog.Size = New System.Drawing.Size(126, 38)
			Me.validBinsLog.TabIndex = 25
			' 
			' listBox1
			' 
			Me.listBox1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.listBox1.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.listBox1.ForeColor = System.Drawing.Color.White
			Me.listBox1.FormattingEnabled = True
			Me.listBox1.ItemHeight = 19
			Me.listBox1.Items.AddRange(New Object() { "34", "37"})
			Me.listBox1.Location = New System.Drawing.Point(229, 36)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New System.Drawing.Size(186, 38)
			Me.listBox1.TabIndex = 27
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
			Me.label2.Location = New System.Drawing.Point(225, 9)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(190, 24)
			Me.label2.TabIndex = 26
			Me.label2.Text = "AmericanExpress"
			' 
			' listBox2
			' 
			Me.listBox2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.listBox2.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.listBox2.ForeColor = System.Drawing.Color.White
			Me.listBox2.FormattingEnabled = True
			Me.listBox2.ItemHeight = 19
			Me.listBox2.Items.AddRange(New Object() { "4"})
			Me.listBox2.Location = New System.Drawing.Point(16, 117)
			Me.listBox2.Name = "listBox2"
			Me.listBox2.Size = New System.Drawing.Size(126, 38)
			Me.listBox2.TabIndex = 29
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Font = New System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
			Me.label3.Location = New System.Drawing.Point(12, 90)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(58, 24)
			Me.label3.TabIndex = 28
			Me.label3.Text = "Visa"
			Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' listBox3
			' 
			Me.listBox3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.listBox3.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.listBox3.ForeColor = System.Drawing.Color.White
			Me.listBox3.FormattingEnabled = True
			Me.listBox3.ItemHeight = 19
			Me.listBox3.Items.AddRange(New Object() { "6011", "644-649", "65"})
			Me.listBox3.Location = New System.Drawing.Point(229, 117)
			Me.listBox3.Name = "listBox3"
			Me.listBox3.Size = New System.Drawing.Size(126, 57)
			Me.listBox3.TabIndex = 31
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Font = New System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
			Me.label4.Location = New System.Drawing.Point(225, 90)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(106, 24)
			Me.label4.TabIndex = 30
			Me.label4.Text = "Discover"
			Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' listBox4
			' 
			Me.listBox4.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.listBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.listBox4.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.listBox4.ForeColor = System.Drawing.Color.White
			Me.listBox4.FormattingEnabled = True
			Me.listBox4.ItemHeight = 19
			Me.listBox4.Items.AddRange(New Object() { "3528–3589" & ControlChars.Tab, "352820"})
			Me.listBox4.Location = New System.Drawing.Point(16, 185)
			Me.listBox4.Name = "listBox4"
			Me.listBox4.Size = New System.Drawing.Size(126, 38)
			Me.listBox4.TabIndex = 33
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Font = New System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
			Me.label5.Location = New System.Drawing.Point(12, 158)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(46, 24)
			Me.label5.TabIndex = 32
			Me.label5.Text = "JCB"
			Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' listBox5
			' 
			Me.listBox5.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(16)))), (CInt((CByte(16)))))
			Me.listBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.listBox5.Font = New System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.listBox5.ForeColor = System.Drawing.Color.White
			Me.listBox5.FormattingEnabled = True
			Me.listBox5.ItemHeight = 19
			Me.listBox5.Items.AddRange(New Object() { "300-305", "54, 55", "36"})
			Me.listBox5.Location = New System.Drawing.Point(229, 212)
			Me.listBox5.Name = "listBox5"
			Me.listBox5.Size = New System.Drawing.Size(126, 57)
			Me.listBox5.TabIndex = 35
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Font = New System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption
			Me.label6.Location = New System.Drawing.Point(225, 185)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(130, 24)
			Me.label6.TabIndex = 34
			Me.label6.Text = "DinersClub"
			Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Font = New System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label7.ForeColor = System.Drawing.Color.White
			Me.label7.Location = New System.Drawing.Point(142, 14)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(77, 15)
			Me.label7.TabIndex = 36
			Me.label7.Text = "Length: 16"
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Font = New System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label8.ForeColor = System.Drawing.Color.White
			Me.label8.Location = New System.Drawing.Point(421, 14)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(77, 15)
			Me.label8.TabIndex = 37
			Me.label8.Text = "Length: 15"
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Font = New System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label9.ForeColor = System.Drawing.Color.White
			Me.label9.Location = New System.Drawing.Point(76, 95)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(119, 15)
			Me.label9.TabIndex = 38
			Me.label9.Text = "Length: 13 or 16"
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.Font = New System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label10.ForeColor = System.Drawing.Color.White
			Me.label10.Location = New System.Drawing.Point(64, 163)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(119, 15)
			Me.label10.TabIndex = 39
			Me.label10.Text = "Length: 15 or 16"
			' 
			' label11
			' 
			Me.label11.AutoSize = True
			Me.label11.Font = New System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label11.ForeColor = System.Drawing.Color.White
			Me.label11.Location = New System.Drawing.Point(361, 190)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(119, 15)
			Me.label11.TabIndex = 40
			Me.label11.Text = "Length: 14 or 15"
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.Font = New System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label12.ForeColor = System.Drawing.Color.White
			Me.label12.Location = New System.Drawing.Point(337, 95)
			Me.label12.Name = "label12"
			Me.label12.Size = New System.Drawing.Size(77, 15)
			Me.label12.TabIndex = 41
			Me.label12.Text = "Length: 16"
			' 
			' Binners
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(24)))), (CInt((CByte(24)))), (CInt((CByte(24)))))
			Me.ClientSize = New System.Drawing.Size(511, 275)
			Me.Controls.Add(Me.label12)
			Me.Controls.Add(Me.label11)
			Me.Controls.Add(Me.label10)
			Me.Controls.Add(Me.label9)
			Me.Controls.Add(Me.label8)
			Me.Controls.Add(Me.label7)
			Me.Controls.Add(Me.listBox5)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.listBox4)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.listBox3)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.listBox2)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.listBox1)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.validBinsLog)
			Me.Controls.Add(Me.label1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.Name = "Binners"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Some bins"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private validBinsLog As System.Windows.Forms.ListBox
		Private listBox1 As System.Windows.Forms.ListBox
		Private label2 As System.Windows.Forms.Label
		Private listBox2 As System.Windows.Forms.ListBox
		Private label3 As System.Windows.Forms.Label
		Private listBox3 As System.Windows.Forms.ListBox
		Private label4 As System.Windows.Forms.Label
		Private listBox4 As System.Windows.Forms.ListBox
		Private label5 As System.Windows.Forms.Label
		Private listBox5 As System.Windows.Forms.ListBox
		Private label6 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private label9 As System.Windows.Forms.Label
		Private label10 As System.Windows.Forms.Label
		Private label11 As System.Windows.Forms.Label
		Private label12 As System.Windows.Forms.Label
	End Class
End Namespace