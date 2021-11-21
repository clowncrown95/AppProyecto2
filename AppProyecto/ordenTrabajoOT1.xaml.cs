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
    public partial class ordenTrabajoOT1 : ContentPage
    {
        public ordenTrabajoOT1()
        {
            InitializeComponent();
        }

        private void btnSave4_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnBack4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}