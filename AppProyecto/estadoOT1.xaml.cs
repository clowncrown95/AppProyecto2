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
    public partial class estadoOT1 : ContentPage
    {
        public estadoOT1()
        {
            InitializeComponent();
        }

        private void btnSave2_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnBack2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}