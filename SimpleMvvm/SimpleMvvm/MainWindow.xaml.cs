using System.Windows;

namespace SimpleMvvm;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly MainViewModel viewModel;
    public MainWindow()
    {
        InitializeComponent();

        viewModel = new();
        DataContext = viewModel;
    }

    private void ButtonClicked(object sender, RoutedEventArgs e)
    {
        viewModel.ButtonClicked();
    }
}
