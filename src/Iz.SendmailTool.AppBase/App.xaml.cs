using System.Windows;
using Iz.SendmailTool.AppBase.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace Iz.SendmailTool.AppBase;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private ServiceProvider diContainer;
    public App()
    {
        var services = new ServiceCollection();
        ConfigureServices(services);
        diContainer = services.BuildServiceProvider();
    }
    private void ConfigureServices(ServiceCollection services)
    {
        //services.AddDbContext<ToDoListDBContext>();
        services.AddSingleton<MainWindow>();
        services.AddSingleton<MainViewModel>();
        // services.AddScoped<AboutWindow>();
    }

    private void OnStartup(object sender, StartupEventArgs e)
    {
        var mainWindow = diContainer.GetService<MainWindow>()
            ?? throw new Exception("Missing MainWindow");
        mainWindow.Show();
    }
}
