Imports Newtonsoft.Json
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Net.Http
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace CC_Tools
	Partial Public Class Main
		Inherits Form

		Private CANCEL As Boolean = False
		Private random_bins_path As String
		Private rdm As New Random()
		Private Function CheckBin(ByVal bin As Integer) As Integer
			Dim filename = "\random-bins-results.txt"
			Dim url = "https://lookup.binlist.net/" & bin

			Dim client As New HttpClient()
			client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/107.0.0.0 Safari/537.36 OPR/93.0.0.0")

			checkingBinsLog.Items.Add($"Checking: {bin}")
			lblcheckedlog.Text = "" & (Convert.ToInt32(lblcheckedlog.Text) + 1)

			Dim response = client.GetAsync(url).Result
			If response.IsSuccessStatusCode Then

				Dim results = response.Content.ReadAsStringAsync().Result
				Dim result_bin = JsonConvert.DeserializeObject(Of Bin)(results)

				Dim card_scheme = result_bin.Scheme
				Dim card_type = result_bin.Type
				Dim card_brand = result_bin.Brand
				Dim card_prepaid = result_bin.Prepaid

				Dim country_name = If(result_bin.Country IsNot Nothing, result_bin.Country.Name, "")

				Dim bank_name = If(result_bin.Bank IsNot Nothing, result_bin.Bank.Name, "")
				Dim bank_url = If(result_bin.Bank IsNot Nothing, result_bin.Bank.Url, "")
				Dim bank_phone = If(result_bin.Bank IsNot Nothing, result_bin.Bank.Phone, "")
				Dim bank_city = If(result_bin.Bank IsNot Nothing, result_bin.Bank.City, "")

'INSTANT VB NOTE: The variable text was renamed since Visual Basic does not handle local variables named the same as class members well:
				Dim text_Renamed = $"=====>>> {bin} <<<=====" & ControlChars.CrLf & _
ControlChars.CrLf & _
"BIN: {bin}" & ControlChars.CrLf & _
ControlChars.CrLf & _
"SCHEME: {card_scheme}" & ControlChars.CrLf & _
"TYPE: {card_type}" & ControlChars.CrLf & _
"BRAND: {card_brand}" & ControlChars.CrLf & _
"PREPAID: {card_prepaid}" & ControlChars.CrLf & _
ControlChars.CrLf & _
"COUNTRY: {country_name}" & ControlChars.CrLf & _
ControlChars.CrLf & _
"BANK NAME: {bank_name}" & ControlChars.CrLf & _
"BANK URL: {bank_url}" & ControlChars.CrLf & _
"BANK PHONE: {bank_phone}" & ControlChars.CrLf & _
"BANK CITY: {bank_city}" & ControlChars.CrLf & _
ControlChars.CrLf & _
"=====>>> {bin} <<<=====" & ControlChars.CrLf & _
ControlChars.CrLf & _
""

				If result_bin.Bank IsNot Nothing AndAlso result_bin.Country IsNot Nothing AndAlso (Not String.IsNullOrEmpty(result_bin.Brand)) AndAlso (Not String.IsNullOrEmpty(result_bin.Type)) AndAlso (Not String.IsNullOrEmpty(result_bin.Scheme)) Then
					Using w As StreamWriter = File.AppendText(random_bins_path & filename)
						w.WriteLine(text_Renamed)
					End Using

					validBinsLog.Items.Add(bin)
					lblvalidlog.Text = "" & (Convert.ToInt32(lblvalidlog.Text) + 1)
				End If
			End If
			Return CInt(Math.Truncate(response.StatusCode))
		End Function
		Public Sub New()
			InitializeComponent()
		End Sub


		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCheck.Click
			txtValidCCs.Clear()
			txtInvalidCC.Clear()

			checkingBar.Value = 0
			checkingBar.Maximum = txtCheckCCs.Lines.Length

			Dim validCards = 0
			Dim invalidCards = 0
			For Each line In txtCheckCCs.Lines
				Try
					If String.IsNullOrWhiteSpace(line) OrElse line Is ControlChars.CrLf Then
						Continue For
					Else
						Dim rg As New Regex("\d{12,}") 'simple regex for cc
						Dim cc = rg.Matches(line)(0).Value

						If CheckerMethods.ValidCC(cc) AndAlso CheckerMethods.ValidCCUsingRegex(cc) Then
							txtValidCCs.Text &= $"{line}" & ControlChars.Lf
							validCards += 1
						Else
							txtInvalidCC.Text &= $"{line}" & ControlChars.Lf
							invalidCards += 1
						End If

						checkingBar.Value += 1
					End If
				Catch
					txtInvalidCC.Text &= $"{line}" & ControlChars.Lf
					Debug.WriteLine($"""{line}"" invalid!")
					invalidCards += 1
					Continue For
				End Try
				lblValid.Text = validCards.ToString()
				lblInvalid.Text = invalidCards.ToString()
			Next line
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoad.Click
			Using opf As New OpenFileDialog()
				opf.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
				opf.Filter = "Text files | *.txt; *.png"
				If opf.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					Dim cc() As String = File.ReadAllLines(opf.FileName)
					txtCheckCCs.Text = String.Join(ControlChars.Lf, cc)
				End If
			End Using
		End Sub

		Private Sub button1_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			txtCheckCCs.Clear()
			Dim a = MessageBox.Show("Do you want to clear these textboxes below?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
			If a = System.Windows.Forms.DialogResult.Yes Then
				txtValidCCs.Clear()
				txtInvalidCC.Clear()

				lblInvalid.Text = "0"
				lblValid.Text = "0"
			End If
			checkingBar.Value = 0

		End Sub

		Private Sub button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerateCC.Click 'generate a new card
			Generator.RunWorkerAsync()
			btnGenerateCC.Enabled = False
		End Sub

		Private Sub button2_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			pnlChecker.BringToFront()
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			pnlBins.SendToBack()
			pnlGenerator.BringToFront()
		End Sub

		Private Sub button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button6.Click
			txtbin.Clear()
			For i As Integer = 0 To 5
				txtbin.Text &= rdm.Next(0, 10)
			Next i
		End Sub

		Private Sub button7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button7.Click
			txtNewCards.Clear()
		End Sub

		Private Sub button8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button8.Click
			Clipboard.SetText(txtNewCards.Text)
		End Sub

		Private Sub button10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button10.Click
			Dim month = "" & rdm.Next(1, 13)
			Dim year = rdm.Next(2024, 2027)
			If month.Length < 2 Then
				month = "0" & month
			End If

			txtExpirationDate.Text = $"{month}|{year}"
		End Sub

		Private Sub button9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button9.Click
			txtCVV.Text = "" & rdm.Next(100, 1000)
		End Sub

		Private Sub button11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button11.Click
			Process.Start("https://github.com/1LCB")
		End Sub

		Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button4.Click
			pnlBins.BringToFront()
		End Sub

		Private Sub button16_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button16.Click
			Dim bin = txtBinValidate.Text
			Dim url = "https://lookup.binlist.net/" & bin

			If String.IsNullOrEmpty(bin) Then
				Return
			End If

			Dim client As New HttpClient()

			lblstatus.Text = "Status: Searching..."

			Dim response = client.GetAsync(url).Result
			If response.IsSuccessStatusCode Then
				Dim results = response.Content.ReadAsStringAsync().Result
				Dim result_bin = JsonConvert.DeserializeObject(Of Bin)(results)
				Try
					txtLength.Text = If(result_bin.Number IsNot Nothing, result_bin.Number.Length, "")
					txtLuhn.Text = If(result_bin.Number IsNot Nothing, result_bin.Number.Luhn, "")

					txtScheme.Text = result_bin.Scheme
					txtType.Text = result_bin.Type
					txtBrand.Text = result_bin.Brand
					txtPrepaid.Text = result_bin.Prepaid

					txtCountryName.Text = If(result_bin.Country IsNot Nothing, result_bin.Country.Name, "")
					txtCountryCurrency.Text = If(result_bin.Country IsNot Nothing, result_bin.Country.Currency, "")
					txtCountryAlpha2.Text = If(result_bin.Country IsNot Nothing, result_bin.Country.Alpha2, "")

					txtBankName.Text = If(result_bin.Bank IsNot Nothing, result_bin.Bank.Name, "")
					txtBankUrl.Text = If(result_bin.Bank IsNot Nothing, result_bin.Bank.Url, "")
					txtBankPhone.Text = If(result_bin.Bank IsNot Nothing, result_bin.Bank.Phone, "")
					txtBankCity.Text = If(result_bin.Bank IsNot Nothing, result_bin.Bank.City, "")

					lblstatus.Text = "Status: Found!"
				Catch ex As Exception
					lblstatus.Text = "Status: Error"
				End Try
			Else
				lblstatus.Text = "Status: " & response.StatusCode.ToString()
			End If
		End Sub

		Private Sub button12_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button12.Click
			Using sf As New SaveFileDialog()
				sf.FileName = $"VALID-CCs-{DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss")}"
				sf.DefaultExt = ".txt"
				sf.AddExtension = True
				sf.Filter = "Text files |*.txt"
				If sf.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					File.WriteAllText(sf.FileName, txtValidCCs.Text)
					MessageBox.Show($"Your CCs were saved in" & ControlChars.Lf & """{sf.FileName}""", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information)
				End If
			End Using
		End Sub

		Private Sub btnRandomBinChecker_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRandomBinChecker.Click
			If Not txtrandombincheckerpath.Enabled Then
				Return
			End If

			If btnRandomBinChecker.BackColor = Color.Maroon Then
				btnRandomBinChecker.Text = "On"
				btnRandomBinChecker.BackColor = Color.Lime
				backgroundWorker1.RunWorkerAsync()
				Return
			End If
			btnRandomBinChecker.Text = "Off"
			btnRandomBinChecker.BackColor = Color.Maroon

		End Sub

		Private Sub button14_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button14.Click
			Using fb As New FolderBrowserDialog()
				fb.ShowNewFolderButton = True
				If fb.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					txtrandombincheckerpath.Text = fb.SelectedPath
					random_bins_path = fb.SelectedPath
					btnRandomBinChecker.Enabled = True
					txtrandombincheckerpath.Enabled = True
				End If
			End Using
		End Sub

		Private Sub backgroundWorker1_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles backgroundWorker1.DoWork
			Do While btnRandomBinChecker.Text = "On"
				Dim bin = rdm.Next(40000, 7999999)
				Dim statuscode = CheckBin(bin)
				If statuscode = 429 Then
					Debug.WriteLine("Waiting for 15s...")
					checkingBinsLog.Items.Add("Waiting...")
					Thread.Sleep(15 * 1000)
					CheckBin(bin)
				End If
				Thread.Sleep(3300)
			Loop
		End Sub

		Private Sub CHECKER_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			CheckForIllegalCrossThreadCalls = False
		End Sub

		Private Sub button13_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button13.Click
			Dim b As New Binners()
			b.Show()
		End Sub

		Private Sub Generator_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles Generator.DoWork
			CANCEL = False
			progressBar1.Value = 0

			Dim length = CInt(Math.Truncate(nLength.Value))
			Dim nocards = CInt(Math.Truncate(numericUpDown1.Value))
			progressBar1.Maximum = nocards

			For i As Integer = 0 To nocards - 1
				If CANCEL Then
					Exit For
				End If

				Dim cc = CheckerMethods.RandomCardGenerator(length, txtbin.Text, txtCVV.Text, txtExpirationDate.Text, chkValidCards.Checked, chkValidRegex.Checked, chkED.Checked, chkCVV.Checked)
				If cc Is Nothing Then
					i -= 1
					Continue For
				End If

				txtNewCards.Text &= cc
				progressBar1.Value += 1

				Thread.Sleep(1)
			Next i
			btnGenerateCC.Enabled = True
		End Sub

		Private Sub button5_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles button5.Click
			CANCEL = True
		End Sub
	End Class
End Namespace
