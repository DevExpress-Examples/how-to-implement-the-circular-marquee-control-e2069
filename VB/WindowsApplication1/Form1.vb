Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load_1(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			CType(New XtraForm1(), XtraForm1).ShowProgress()
		End Sub

	End Class
End Namespace