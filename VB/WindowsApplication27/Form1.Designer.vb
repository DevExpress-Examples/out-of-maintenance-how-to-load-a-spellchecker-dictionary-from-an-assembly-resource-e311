Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication27
	Partial Public Class Form1
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
			Dim optionsSpelling1 As New DevExpress.XtraSpellChecker.OptionsSpelling()
			Me.spellChecker1 = New DevExpress.XtraSpellChecker.SpellChecker()
			Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' spellChecker1
			' 
			Me.spellChecker1.CheckAsYouTypeOptions.CheckControlsInParentContainer = True
			Me.spellChecker1.Culture = New System.Globalization.CultureInfo("en-US")
			Me.spellChecker1.ParentContainer = Me
			Me.spellChecker1.SpellCheckMode = DevExpress.XtraSpellChecker.SpellCheckMode.AsYouType
			' 
			' memoEdit1
			' 
			Me.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.memoEdit1.EditValue = "wronly speled txt, but some words are correct :)"
			Me.memoEdit1.Location = New System.Drawing.Point(0, 0)
			Me.memoEdit1.Name = "memoEdit1"
			Me.spellChecker1.SetShowSpellCheckMenu(Me.memoEdit1, True)
			Me.memoEdit1.Size = New System.Drawing.Size(411, 140)
			Me.spellChecker1.SetSpellCheckerOptions(Me.memoEdit1, optionsSpelling1)
			Me.memoEdit1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(411, 140)
			Me.Controls.Add(Me.memoEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private spellChecker1 As DevExpress.XtraSpellChecker.SpellChecker
		Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
	End Class
End Namespace

