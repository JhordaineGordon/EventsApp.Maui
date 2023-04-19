using EventsApp.Maui.ViewModels;

namespace EventsApp.Maui.view;

public partial class EventDetailsPage : ContentPage
{
	public EventDetailsPage(EventDetailsViewModel eventDetailsViewModel)
	{
		InitializeComponent();
		BindingContext = eventDetailsViewModel;
	}
    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}

