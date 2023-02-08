Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks


Namespace CC_Tools

	Partial Public Class Bin

		Public Property Scheme() As String
		Public Property Number() As Number
		Public Property Type() As String
		Public Property Brand() As String
		Public Property Prepaid() As String
		Public Property Country() As Country
		Public Property Bank() As Bank
	End Class

	Partial Public Class Bank
		Public Property Name() As String
		Public Property Url() As String
		Public Property Phone() As String
		Public Property City() As String
	End Class

	Partial Public Class Country
		Public Property Numeric() As String
		Public Property Alpha2() As String
		Public Property Name() As String
		Public Property Emoji() As String
		Public Property Currency() As String
		Public Property Latitude() As String
		Public Property Longitude() As String
	End Class

	Partial Public Class Number
		Public Property Length() As String
		Public Property Luhn() As String
	End Class

End Namespace


