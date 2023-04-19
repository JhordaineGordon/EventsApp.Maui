using CommunityToolkit.Mvvm.ComponentModel;
using EventsApp.Maui.Models;
using EventsApp.Maui.ViewModels;
using System.Diagnostics;

namespace EventsApp.Maui
{
    public partial class BaseViewModel : ObservableObject

    {
        [ObservableProperty]
        string title;

        [ObservableProperty]
        bool isBusy;
        private object events;
        private bool IsRefreshing;

        public bool notBusy => isBusy;

        //private readonly bool IsBusy;

        
        }
    }



