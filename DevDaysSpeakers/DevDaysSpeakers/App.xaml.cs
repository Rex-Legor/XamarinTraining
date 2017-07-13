﻿using DevDaysSpeakers.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DevDaysSpeakers
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SpeakersPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
