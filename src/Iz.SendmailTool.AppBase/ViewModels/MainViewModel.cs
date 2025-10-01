using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Iz.SendmailTool.AppBase.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
   
    private string _title = "Main Application";
    public string Title
    {
        get => _title; set => _title = value;
    }
}
