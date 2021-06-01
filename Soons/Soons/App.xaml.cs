﻿using Soons.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Soons
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            XF.Material.Forms.Material.Init(this);

            MainPage = new NavigationPage(new Tabbed());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
