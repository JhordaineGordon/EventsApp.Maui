using EventsApp.Maui.services;
using EventsApp.Maui.view;
using EventsApp.Maui.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EventsApp.Maui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		string dbPath = Path.Combine(FileSystem.AppDataDirectory, "NcuEvents.db3");
		builder.Services.AddSingleton<NcuEvents>(s => ActivatorUtilities.CreateInstance<NcuEvents>(s, dbPath));

		builder.Services.AddSingleton<NcuEvents>();
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<EventDetailsViewModel>();
        builder.Services.AddSingleton<EventslistingViewModel>();

        builder.Services.AddTransient<EventDetailsPage>();



        return builder.Build();
	}
}
