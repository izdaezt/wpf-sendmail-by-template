using System.ComponentModel;

namespace Iz.SendmailTool.AppBase.ViewModels;

public class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void RaisePropertyChanged(string property)
    {
        var handler = PropertyChanged;
        handler?.Invoke(this, new PropertyChangedEventArgs(property));
    }

    protected bool SetProperty<T>(ref T storage,T value)
    {
        if(!object.Equals(storage, value))
        {
            storage = value;
            RaisePropertyChanged(nameof(storage));
            return true;            
        }
        return false;
    }
}
