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
    public partial class ordenTrabajoOT : ContentPage
    {
        public ordenTrabajoOT()
        {
            InitializeComponent();
        }

        private async void btnGet4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ordenTrabajoOT1());
        }

        private void btnPost4_Clicked(object sender, EventArgs e)
        {

        }

        private void btnPut4_Clicked(object sender, EventArgs e)
        {

        }

        private void btnDelete4_Clicked(object sender, EventArgs e)
        {

        }
    }
}