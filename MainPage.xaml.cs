using EventsApp.Maui.ViewModels;
using EventsApp.Maui.Models;

namespace EventsApp.Maui;

public partial class MainPage : ContentPage
{
    public MainPage(EventslistingViewModel EventslistingViewModel)
	{
        InitializeComponent();
		BindingContext = EventslistingViewModel;
	}

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }
}