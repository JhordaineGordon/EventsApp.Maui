using EventsApp.Maui.view;

namespace EventsApp.Maui;

public partial class AppShell : Shell
{
	public AppShell(EventDetailsPage eventDetailsPage)
	{
		InitializeComponent();

		Routing.UnRegisterRoute(nameof(eventDetailsPage, typeof(EventDetailsPage)));
	}

    private string nameof(EventDetailsPage eventDetailsPage, Type type)
    {
        throw new NotImplementedException();
    }
}
