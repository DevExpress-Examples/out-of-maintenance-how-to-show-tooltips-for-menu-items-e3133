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
	Public Class ToolTipHelper
		Private manager As BarManager
		Private _TooltipItem As BarItemLink

		Public Sub New(ByVal manager As BarManager)
			Me.manager = manager
		End Sub

		Public WriteOnly Property ShowToolTipInMenuItems() As Boolean
			Set(ByVal value As Boolean)
				RemoveHandler manager.HighlightedLinkChanged, AddressOf OnHighlightedLinkChanged
				If value Then
					AddHandler manager.HighlightedLinkChanged, AddressOf OnHighlightedLinkChanged
				End If
			End Set
		End Property


		Private Property TooltipItem() As BarItemLink
			Get
				Return _TooltipItem
			End Get
			Set(ByVal value As BarItemLink)
				_TooltipItem = value
				OnToolTipItemChanged()
			End Set
		End Property

		Private Sub OnHighlightedLinkChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.HighlightedLinkChangedEventArgs)
			If e.Link IsNot Nothing AndAlso e.Link.IsLinkInMenu Then
				TooltipItem = e.Link
			Else
				TooltipItem = Nothing
			End If
		End Sub

		Private Sub OnToolTipItemChanged()
			ToolTipController.DefaultController.HideHint()
			If TooltipItem IsNot Nothing Then
				ShowItemSuperTip(TooltipItem)
			End If
		End Sub
		Private Sub ShowItemSuperTip(ByVal item As BarItemLink)
			Dim args As New ToolTipControllerShowEventArgs()
			args.ToolTipType = ToolTipType.SuperTip
			args.SuperTip = New SuperToolTip()
			args.SuperTip.Items.Add(item.Item.Hint)
			ToolTipController.DefaultController.ShowHint(args)

		End Sub


	End Class
End Namespace
