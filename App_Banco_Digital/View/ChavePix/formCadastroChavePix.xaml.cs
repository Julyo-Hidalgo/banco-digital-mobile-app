using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_Banco_Digital.Model;
using App_Banco_Digital.Service;

namespace App_Banco_Digital.View.ChavePix
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class formCadastroChavePix : ContentPage
	{
		public formCadastroChavePix ()
		{
			InitializeComponent ();
		}

        private async void btn_salvar_Clicked(object sender, EventArgs e)
        {
			Model.ChavePix chave = new Model.ChavePix();
			chave.chave = txtChave.Text;
			chave.tipo = "CPF";
			chave.id_conta = 1;

			bool? response = await ChavePixDataService.SaveAsyncChavePix(chave);

			if (response == true)
			{
				await DisplayAlert("Cadastro efetuado!", "Tudo certo!", "Ok");

				await Navigation.PopAsync();
			}
        }
    }
}