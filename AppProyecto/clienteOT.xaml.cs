using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppProyecto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class clienteOT : ContentPage
    {
        public clienteOT()
        {
            InitializeComponent();
        }

        private async void btnGet_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new clienteOT1());
        }

        private async void btnPost_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new estadoOT());
        }

        private async void btnPut_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new equipoOT());
        }

        private async void btnDelete_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new rolOT());
        }
    }
}