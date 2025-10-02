using Iz.SendmailTool.Domain.Templates;

namespace Iz.SendmailTool.AppBase.ViewModels;

public class NewTemplateWindowViewModel : ViewModelBase
{
    private string _title = "New Template";
    private Template _model = new();

    public string Title
    {
        get
        {
            return _title;
        }
        set
        {
            SetProperty(ref _title, value);
            RaisePropertyChanged(nameof(Title));
        }
    }

    public Template Model
    {
        get { return _model; }
        set
        {
            SetProperty(ref _model, value);
            RaisePropertyChanged(nameof(Model));
        }
    }

    public NewTemplateWindowViewModel()
    {

    }
}
