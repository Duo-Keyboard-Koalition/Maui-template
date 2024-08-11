using System;
using VolleyballScoreCounter;
using Microsoft.Maui.Controls;
namespace VolleyballScoreCounter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
