﻿using RedDS.Services;
using RedDS.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RedDS
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
            MainPage = new NavigationPage(new Views.ListProductView());
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
