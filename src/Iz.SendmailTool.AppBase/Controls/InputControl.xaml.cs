using System.Windows;
using System.Windows.Controls;

namespace Iz.SendmailTool.AppBase.Controls;

/// <summary>
/// Interaction logic for InputControl.xaml
/// </summary>
public partial class InputControl : UserControl
{
    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public static readonly DependencyProperty TextProperty =
        DependencyProperty.Register(
            nameof(Text),
            typeof(string),
            typeof(InputControl),
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
        );

    public string Label
    {
        get => (string)GetValue(LabelProperty);
        set => SetValue(LabelProperty, value);
    }

    public static readonly DependencyProperty LabelProperty =
        DependencyProperty.Register(
            nameof(Label),
            typeof(string),
            typeof(InputControl),
            new PropertyMetadata(null));

    public InputControl()
    {
        InitializeComponent();
    }
}
