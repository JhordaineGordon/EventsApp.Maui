using CommunityToolkit.Mvvm.Input;
using EventsApp.Maui.services;
using SQLite;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EventsApp.Maui.ViewModels
{
    
    public partial class EventslistingViewModel : BaseViewModel
    {
        
        public ObservableCollection<NcuEvents> events { get; private set; } = new ();


        public EventslistingViewModel()
        {
            Title = "Event list";

            
        }
        [RelayCommand]
        async Task Getevents()
        {
            var eventslist = App.NcuEvents.GetEvents();
            foreach (var item in eventslist)
            {
                events.Add(item);
            }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
};
    

