using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_Banco_Digital.Model;

namespace App_Banco_Digital.View.ChavePix
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChavePix : ContentPage
    {
        public ChavePix()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new formCadastroChavePix());
        }
    }
}