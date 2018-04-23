Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraSpellChecker
Imports System.IO
Imports System.Reflection

Namespace WindowsApplication27
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim dictionary As New SpellCheckerISpellDictionary()
			Dim affStream As Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("english.aff")
			Dim dicStream As Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("american.xlg")
			Dim alphStream As Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("EnglishAlphabet.txt")
			dictionary.LoadFromStream(dicStream, affStream, alphStream)
			spellChecker1.Dictionaries.Add(dictionary)
		End Sub
	End Class
End Namespace