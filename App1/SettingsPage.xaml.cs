using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingsPage : Page
    {
        private Scoreboard Scoreboard = new();
        public SettingsPage()
        {
            this.InitializeComponent();
        }

        private void AddCountry(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(CountryName.Text))
            {
                Scoreboard.Countries.Add(CountryName.Text);
            }
        }

        private void AddParticipant(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(ParticipantName.Text) && ParticipantCountry.SelectedItem != null)
            {
                Participant participant = new()
                {
                    Name = ParticipantName.Text,
                    Country = (string)ParticipantCountry.SelectedItem
                };
                Scoreboard.Participants.Add(participant);
            }
        }

        private void ToggleMode(object sender, RoutedEventArgs e)
        {
            if((sender as ToggleSwitch).IsOn)
            {
                CountryPanel.Visibility = Visibility.Visible;
                ParticipantCountry.Visibility = Visibility.Visible;
                ParticipantCountry.SelectedItem = null;
            }
            else
            {
                CountryPanel.Visibility = Visibility.Collapsed;
                ParticipantCountry.Visibility = Visibility.Collapsed;
                ParticipantCountry.Text = "";
            }
        }

        private void MarkFlyout_Opening(object sender, object e)
        {
            if (Marks.SelectedItem == null)
            {
                (sender as CommandBarFlyout).Hide();
            }
        }

        private void AddMark(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(MarkValue.Text))
            {
                Scoreboard.VotingMarks.Add((int)MarkValue.Value);
            }
        }
    }
}
