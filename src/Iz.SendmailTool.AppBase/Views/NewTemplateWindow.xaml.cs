using System.Windows;
using Iz.SendmailTool.AppBase.Controls;
using Iz.SendmailTool.AppBase.ViewModels;

namespace Iz.SendmailTool.AppBase.Views;

/// <summary>
/// Interaction logic for NewTemplateWindow.xaml
/// </summary>
public partial class NewTemplateWindow : Window
{
    public NewTemplateWindow()
    {
        InitializeComponent();
        var uc = new InputControl();
        MainPanel.Children.Clear();    // nếu muốn xóa control cũ
        MainPanel.Children.Add(uc);    // add UC vào panel
    }

    public NewTemplateWindow(NewTemplateWindowViewModel mvm)
    {
        InitializeComponent();
        DataContext = mvm;  //Dependency injection
    }
}
