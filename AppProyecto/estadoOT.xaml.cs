﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppProyecto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class estadoOT : ContentPage
    {
        public estadoOT()
        {
            InitializeComponent();
        }

        private async void btnGet2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new estadoOT1());
        }

        private void btnPost2_Clicked(object sender, EventArgs e)
        {

        }

        private void btnPut2_Clicked(object sender, EventArgs e)
        {

        }

        private void btnDelete2_Clicked(object sender, EventArgs e)
        {

        }
    }
}