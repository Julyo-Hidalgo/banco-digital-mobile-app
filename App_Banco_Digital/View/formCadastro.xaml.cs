using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Banco_Digital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class formCadastro : ContentPage
    {
        public formCadastro()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            DisplayAlert("Sucesso", "Cadastro realizado!", "Ok");
        }
    }
}