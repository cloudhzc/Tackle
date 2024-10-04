using Microsoft.UI.Xaml.Controls;

using Tackle.ViewModels;

namespace Tackle.Views;

public sealed partial class Blank2Page : Page
{
    public Blank2ViewModel ViewModel
    {
        get;
    }

    public Blank2Page()
    {
        ViewModel = App.GetService<Blank2ViewModel>();
        InitializeComponent();
    }
}
