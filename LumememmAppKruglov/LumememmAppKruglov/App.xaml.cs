﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LumememmAppKruglov
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new absolute();
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
