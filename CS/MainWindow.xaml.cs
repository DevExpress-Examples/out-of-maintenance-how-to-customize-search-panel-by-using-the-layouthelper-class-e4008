using System;
using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Core.Native;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.RichEdit.UI;
using DevExpress.XtraRichEdit.Commands;

namespace RichEditSearchPanelWpf {
    public partial class MainWindow : Window {
        private RichEditSearchPanel searchPanel;
        
        public MainWindow() {
            InitializeComponent();
        }

        private void richEditControl1_Loaded(object sender, RoutedEventArgs e) {
            richEditControl1.CreateCommand(RichEditCommandId.Find).Execute();
            searchPanel = (RichEditSearchPanel)LayoutHelper.FindElementByName(richEditControl1, "SearchPanel");
            searchPanel.LayoutUpdated += searchPanel_LayoutUpdated;
        }

        private void searchPanel_LayoutUpdated(object sender, EventArgs e) {
            TextBlock lbPrompt = LayoutHelper.FindElement(searchPanel, (element) => element is TextBlock && ((TextBlock)element).Text.Contains("Find")) as TextBlock;
            ButtonEdit tbSearchString = (ButtonEdit)LayoutHelper.FindElementByName(searchPanel, "tbSearchString");

            if (lbPrompt != null && tbSearchString != null) {
                lbPrompt.FontSize = 16;
                tbSearchString.EditValue = "test";
                searchPanel.LayoutUpdated -= searchPanel_LayoutUpdated;
            }
        }
    }
}