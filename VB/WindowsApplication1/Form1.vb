Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.Utils

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private helper As ToolTipHelper

		Public Sub New()
			InitializeComponent()

			helper = New ToolTipHelper(barManager1)
			helper.ShowToolTipInMenuItems = True
		End Sub

		Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
			MyBase.OnFormClosing(e)
			helper.ShowToolTipInMenuItems = False
		End Sub
	End Class
End Namespace