using EventsApp.Maui.services;
using EventsApp.Maui.view;

namespace EventsApp.Maui;

public partial class App : Application
{
	public static NcuEvents NcuEvents {get; private set;}
	
	public App(NcuEvents ncuEvents)
	{ 
	
		InitializeComponent();

		MainPage = new AppShell();
		NcuEvents = ncuEvents;
	}
}
