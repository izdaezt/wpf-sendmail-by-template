using System.Windows;
using Iz.SendmailTool.AppBase.ViewModels;
using Iz.SendmailTool.AppBase.Views;

namespace Iz.SendmailTool.AppBase;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow(MainWindowViewModel mvm)
    {
        InitializeComponent();
        DataContext = mvm;  //Dependency injection
        var ucHome = new UcHome();
        DPanelMain.Children.Add(ucHome);
    }

    private void BtnHome_Click(object sender, RoutedEventArgs e)
    {
        DPanelMain.Children.Clear();
        var ucHome = new UcHome();
        DPanelMain.Children.Add(ucHome);
    }

    private void BtnTemplate_Click(object sender, RoutedEventArgs e)
    {
        DPanelMain.Children.Clear();
        var ucTemplates = new UcListTemplate();
        DPanelMain.Children.Add(ucTemplates);
    }

    private void BtnNewTemplate_Click(object sender, RoutedEventArgs e)
    {
        var newTemplateWindow = new NewTemplateWindow();
        newTemplateWindow.ShowDialog();
    }
}
