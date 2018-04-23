Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
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
			Me.components = New System.ComponentModel.Container()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem()
			Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
			Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
			Me.dropDownButton1 = New DevExpress.XtraEditors.DropDownButton()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3, Me.barSubItem1, Me.barButtonItem4, Me.barButtonItem5})
			Me.barManager1.MainMenu = Me.bar1
			Me.barManager1.MaxItemId = 6

			' 
			' bar1
			' 
			Me.bar1.BarName = "Custom 2"
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem1)})
			Me.bar1.OptionsBar.MultiLine = True
			Me.bar1.OptionsBar.UseWholeRow = True
			Me.bar1.Text = "Custom 2"
			' 
			' barSubItem1
			' 
			Me.barSubItem1.Caption = "barSubItem1"
			Me.barSubItem1.Hint = "Menu"
			Me.barSubItem1.Id = 3
			Me.barSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem5)})
			Me.barSubItem1.Name = "barSubItem1"
			' 
			' barButtonItem4
			' 
			Me.barButtonItem4.Caption = "barButtonItem4"
			Me.barButtonItem4.Hint = "Test123"
			Me.barButtonItem4.Id = 4
			Me.barButtonItem4.Name = "barButtonItem4"
			' 
			' barButtonItem5
			' 
			Me.barButtonItem5.Caption = "barButtonItem5"
			Me.barButtonItem5.Hint = "Test1234"
			Me.barButtonItem5.Id = 5
			Me.barButtonItem5.Name = "barButtonItem5"
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(284, 22)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 264)
			Me.barDockControlBottom.Size = New System.Drawing.Size(284, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 242)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(284, 22)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 242)
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "barButtonItem1"
			Me.barButtonItem1.Hint = "Test"
			Me.barButtonItem1.Id = 0
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "barButtonItem2"
			Me.barButtonItem2.Hint = "Test"
			Me.barButtonItem2.Id = 1
			Me.barButtonItem2.Name = "barButtonItem2"
			' 
			' barButtonItem3
			' 
			Me.barButtonItem3.Caption = "barButtonItem3"
			Me.barButtonItem3.Hint = "Test"
			Me.barButtonItem3.Id = 2
			Me.barButtonItem3.Name = "barButtonItem3"
			' 
			' popupMenu1
			' 
			Me.popupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem3)})
			Me.popupMenu1.Manager = Me.barManager1
			Me.popupMenu1.Name = "popupMenu1"
			' 
			' dropDownButton1
			' 
			Me.dropDownButton1.DropDownControl = Me.popupMenu1
			Me.dropDownButton1.Location = New System.Drawing.Point(18, 86)
			Me.dropDownButton1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.dropDownButton1.MenuManager = Me.barManager1
			Me.dropDownButton1.Name = "dropDownButton1"
			Me.dropDownButton1.Size = New System.Drawing.Size(152, 19)
			Me.dropDownButton1.TabIndex = 4
			Me.dropDownButton1.Text = "dropDownButton1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 264)
			Me.Controls.Add(Me.dropDownButton1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.barManager1.SetPopupContextMenu(Me, Me.popupMenu1)
			Me.Text = "Form1"
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private dropDownButton1 As DevExpress.XtraEditors.DropDownButton
		Private popupMenu1 As DevExpress.XtraBars.PopupMenu
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem
		Private bar1 As DevExpress.XtraBars.Bar
		Private barSubItem1 As DevExpress.XtraBars.BarSubItem
		Private barButtonItem4 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem5 As DevExpress.XtraBars.BarButtonItem
	End Class
End Namespace

