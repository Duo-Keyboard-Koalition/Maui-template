using System;
using VolleyballScoreCounter;
using Microsoft.Maui.Controls;

namespace VolleyballScoreCounter
{
    public partial class MainPage : ContentPage
    {
        int redTeamScore = 0;
        int blueTeamScore = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void onRedClicked(object sender, EventArgs e)
        {
            redTeamScore++;
            RedBtn.Text = $"Red Team Scored: {redTeamScore}";

            SemanticScreenReader.Announce("Red Team scored!");
        }

        private void onBlueClicked(object sender, EventArgs e)
        {
            blueTeamScore++;
            BlueBtn.Text = $"Blue Team Scored: {blueTeamScore}";

            SemanticScreenReader.Announce("Blue Team scored!");
        }
    }
}