Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Core.Native
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.RichEdit.UI
Imports DevExpress.XtraRichEdit.Commands

Namespace RichEditSearchPanelWpf
	Partial Public Class MainWindow
		Inherits Window
		Private searchPanel As RichEditSearchPanel

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub richEditControl1_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			richEditControl1.CreateCommand(RichEditCommandId.Find).Execute()
			searchPanel = CType(LayoutHelper.FindElementByName(richEditControl1, "SearchPanel"), RichEditSearchPanel)
			AddHandler searchPanel.LayoutUpdated, AddressOf searchPanel_LayoutUpdated
		End Sub

		Private Sub searchPanel_LayoutUpdated(ByVal sender As Object, ByVal e As EventArgs)
            Dim lbPrompt As TextBlock = TryCast(LayoutHelper.FindElement(searchPanel, Function(element) TypeOf element Is TextBlock AndAlso (CType(element, TextBlock)).Text.Contains("Find")), TextBlock)
			Dim tbSearchString As ButtonEdit = CType(LayoutHelper.FindElementByName(searchPanel, "tbSearchString"), ButtonEdit)

			If lbPrompt IsNot Nothing AndAlso tbSearchString IsNot Nothing Then
				lbPrompt.FontSize = 16
				tbSearchString.EditValue = "test"
				RemoveHandler searchPanel.LayoutUpdated, AddressOf searchPanel_LayoutUpdated
			End If
		End Sub
	End Class
End Namespace