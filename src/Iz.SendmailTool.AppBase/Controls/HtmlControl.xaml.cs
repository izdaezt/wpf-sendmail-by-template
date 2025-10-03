using System.Windows;
using System.Windows.Controls;

namespace Iz.SendmailTool.AppBase.Controls;

/// <summary>
/// Interaction logic for HtmlCOntrol.xaml
/// </summary>
public partial class HtmlControl : UserControl
{
    private const string initialHtml = @"<!doctype html>
<html>
  <head><meta charset='utf-8'><title>Demo Editor</title></head>
  <body>
    <h1>Edit me!</h1>
    <p>Nội dung có thể chỉnh sửa.</p>
  </body>
</html>";
    public HtmlControl()
    {
        InitializeComponent();
        Loaded += HtmlControl_Loaded;
    }

    private async void HtmlControl_Loaded(object sender, RoutedEventArgs e)
    {
        // Đảm bảo chỉ khởi tạo 1 lần
        if (WebView.CoreWebView2 == null)
        {
            try
            {
                await InitializeAsync();
            }
            catch { }
        }
    }

    private async Task InitializeAsync()
    {
        // Make sure WebView2 runtime is ready
        await WebView.EnsureCoreWebView2Async();
        // load HTML string
        WebView.CoreWebView2.NavigateToString(initialHtml);
        WebView.CoreWebView2.NavigationCompleted += async (s, e) =>
        {
            await WebView.CoreWebView2.ExecuteScriptAsync(@"
                document.body.contentEditable = 'true';
                document.body.style.backgroundColor = 'lightyellow';
                document.designMode = 'on';
            ");
        };
    }
}
