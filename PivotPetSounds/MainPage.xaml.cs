using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Coding4Fun.Toolkit.Controls;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PivotPetSounds.Resources;
using PivotPetSounds.ViewModels;

namespace PivotPetSounds
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;

            // Sample code to localize the ApplicationBar
            BuildLocalizedApplicationBar();
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        // Sample code for building a localized ApplicationBar
        private void BuildLocalizedApplicationBar()
        {
            // Set the page's ApplicationBar to a new instance of ApplicationBar.
            ApplicationBar = new ApplicationBar();

            // Create a new button and set the text value to the localized string from AppResources.
            ApplicationBarIconButton recordAudioAppBar = new ApplicationBarIconButton(new Uri("/Assets/AppBar/microphone.png", UriKind.Relative));
            recordAudioAppBar.Text = AppResources.AppBarRecord;
            ApplicationBar.Buttons.Add(recordAudioAppBar);

            recordAudioAppBar.Click += RecordAudioClick;

            // Create a new menu item with the localized string from AppResources.
            ApplicationBarMenuItem aboutAppBar = new ApplicationBarMenuItem(AppResources.AppBarAbout);
            ApplicationBar.MenuItems.Add(aboutAppBar);

            aboutAppBar.Click += AboutClick;
        }

        private void AboutClick(object sender, EventArgs e)
        {
            AboutPrompt aboutMe = new AboutPrompt();

            aboutMe.Show("Dźwięki", "@borysrybak", "borys.rybak@gmail.com", "http://fb.com/borys.rybak");
        }

        private void RecordAudioClick(object sender, EventArgs e)
        {
            
        }

        private void LongListSelector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LongListSelector selector = sender as LongListSelector;

            if (selector == null) return;

            SoundData data = selector.SelectedItem as SoundData;

            if (data == null) return;

            AudioPlayer.Source = new Uri(data.FilePath, UriKind.RelativeOrAbsolute);

            selector.SelectedItem = null;
        }
    }
}