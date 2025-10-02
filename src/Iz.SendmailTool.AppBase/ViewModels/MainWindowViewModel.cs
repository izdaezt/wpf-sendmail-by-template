namespace Iz.SendmailTool.AppBase.ViewModels;

public class MainWindowViewModel : ViewModelBase
{   
    private string _title = "Main Application";
    public string Title
    {
        get { 
            return _title;
        }
        set { 
            SetProperty(ref _title, value);
            RaisePropertyChanged(nameof(Title));
        }
    }
    public MainWindowViewModel()
    {
         
    }
}
