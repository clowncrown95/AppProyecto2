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
    public partial class rolOT : ContentPage
    {
        public rolOT()
        {
            InitializeComponent();
        }

        private async void btnGet3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new rolOT1());
        }

        private void btnPost3_Clicked(object sender, EventArgs e)
        {

        }

        private void btnPut3_Clicked(object sender, EventArgs e)
        {

        }

        private void btnDelete3_Clicked(object sender, EventArgs e)
        {

        }
    }
}