Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Threading.Tasks

Namespace CC_Tools
	Friend Class CheckerMethods
		Private Shared rdm As New Random()
		Public Shared Function ValidCC(ByVal CC As String) As Boolean
			Dim nDigits As Integer = CC.Length

			Dim nSum As Integer = 0
			Dim isSecond As Boolean = False
			For i As Integer = nDigits - 1 To 0 Step -1
				Dim d As Integer = AscW(CC.Chars(i)) - AscW("0"c)

				If isSecond = True Then
					d = d * 2
				End If

				nSum += d \ 10 '=> 9/10 => 0.9 => >>> 0 <<<
				nSum += d Mod 10 '=> 0.5 => >>> 5 <<<

				isSecond = Not isSecond
			Next i
			Return (nSum Mod 10 = 0)
		End Function
		Public Shared Function ValidCCUsingRegex(ByVal CC As String) As Boolean
			Dim regexes As New Dictionary(Of String, String)()

			regexes.Add("MasterCard", "^(5[1-5]\d{4}|2(2(2[1-9]\d{2}|[3-9]\d{3})|[3-6]\d{4}|7([01]\d{3}|20\d{2})))")
			regexes.Add("Visa", "^(4\d{12,})")
			regexes.Add("DinersClub", "(^3[689]\d{4})|(^30[0-59]\d{10,})")
			regexes.Add("AmericanExpress", "^3[47]\d{4}")
			regexes.Add("Enroute", "^(2014|2149)")
			regexes.Add("Voyager", "^(8699)")
			regexes.Add("JCB", "^(35(2[89]|[3-8][0-9]))|^(2131|1800)|^(3088|3096|3112|3158|3337)|(2100|1800)")
			regexes.Add("Discover", "^((6011)|(65)|(64[4-9])|(6221(2[6-9])|622[3-9]))")
			regexes.Add("VisaElectron", "^(4026|417500|4508|4844|491[37])")

			For Each value In regexes.Values
				Dim rg As New Regex(value)
				Dim matches = rg.Matches(CC)
				If matches.Count > 0 Then
					Debug.WriteLine($"{CC} = {regexes.FirstOrDefault(x >= x.Value = value).Key}")
					Return True
				End If

			Next value
			Return False
		End Function
		Public Shared Function RandomCardGenerator(Optional ByVal length As Integer = 16, Optional ByVal bin As String = "", Optional ByVal cvv As String = "", Optional ByVal [date] As String = "", Optional ByVal onlyvalid As Boolean = True, Optional ByVal validregex As Boolean = True, Optional ByVal addExpirationDate As Boolean = True, Optional ByVal addCVV As Boolean = True) As String
			Const MAX_ATTEMPTS As Integer = 10
			Dim attempts As Integer = 0

			Dim rdm As New Random()

			Dim expirationdate = If([date].Length = 7, [date], RandomDate())
			Dim cvv_card = If(cvv.Length = 3, cvv, RandomCVV(cvv))

			Do
				Thread.Sleep(1)

				If attempts >= MAX_ATTEMPTS Then
					Return Nothing
				End If

				attempts += 1

				Dim rand_card = ""
				Dim bin_ = bin

				Do While bin_.Length < 6 ' 6 digits bin
					bin_ &= rdm.Next(0, 10)
				Loop

				For j As Integer = 0 To (length - bin_.Length) - 1
					rand_card &= rdm.Next(0, 10)
				Next j

				Dim cc = bin_ & rand_card
				Dim final_card = cc & (If(addExpirationDate, "|" & expirationdate, "")) + (If(addCVV, "|" & cvv_card, "")) & ControlChars.Lf
				Debug.Write(final_card)

				If validregex AndAlso onlyvalid AndAlso ValidCC(cc) AndAlso ValidCCUsingRegex(cc) Then 'both
					Return final_card

				ElseIf (Not validregex) AndAlso onlyvalid AndAlso ValidCC(cc) Then 'only luhn
					Return final_card

				ElseIf validregex AndAlso (Not onlyvalid) AndAlso ValidCCUsingRegex(cc) Then 'only regex
					Return final_card

				ElseIf (Not validregex) AndAlso (Not onlyvalid) Then 'no verification
					Return final_card
				End If

			Loop
		End Function

		Private Shared Function RandomCVV(ByVal cvv As String) As String
			Dim cvv_ = cvv
			Do While cvv_.Length < 3
				cvv_ &= rdm.Next(0, 10)
			Loop

			Return cvv_
		End Function

		Private Shared Function RandomDate() As String
			Dim month = rdm.Next(1, 13).ToString()
			If month.Length = 1 Then
				month = "0" & month
			End If

			Return $"{month}|{rdm.Next(2023, 2028)}"
		End Function
	End Class
End Namespace
