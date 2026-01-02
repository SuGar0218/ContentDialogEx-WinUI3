using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using SuGarToolkit.WinUI3.Controls.Dialogs;

namespace SampleApp;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private async void OnShowWindowedContentDialogButtonClick(object sender, RoutedEventArgs e)
    {
        ContentDialogResult result = await new SampleWindowedContentDialog
        {
            Owner = this
        }
        .ShowAsync();
        new ContentDialogWindow
        {
            Header = "上一个对话框的结果",
            Content = result.ToString(),
            Owner = this
        }
        .ShowDialog();
    }

    private void OnShowContentDialogWindowButtonClick(object sender, RoutedEventArgs e)
    {
        new SampleContentDialogWindow
        {
            Owner = this
        }
        .ShowDialog();
    }

    private void OnShowExtendedContentDialogWindowButtonClick(object sender, RoutedEventArgs e)
    {
        new SampleExtendedContentDialogWindow
        {
            Owner = this
        }
        .ShowDialog();
    }

    private void OnShowUacDialogWindowButtonClick(object sender, RoutedEventArgs e)
    {
        new SampleUacWindow
        {
            Owner = this,
            Severity = (InfoBarSeverity) PART_SeverityComboBox.SelectedItem
        }
        .ShowDialog();
    }
}
