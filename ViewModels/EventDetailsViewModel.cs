using System;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsApp.Maui.Models;

namespace EventsApp.Maui.ViewModels
{
    [QueryProperty(nameof(Events), "events")]
    public partial class EventDetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        Events events;
        
    
    }
}
