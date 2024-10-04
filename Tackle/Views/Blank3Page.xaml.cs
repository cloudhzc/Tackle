using Microsoft.UI.Xaml.Controls;

using Tackle.ViewModels;

namespace Tackle.Views;

public sealed partial class Blank3Page : Page
{
    public Blank3ViewModel ViewModel
    {
        get;
    }

    public Blank3Page()
    {
        ViewModel = App.GetService<Blank3ViewModel>();
        InitializeComponent();
    }
}
