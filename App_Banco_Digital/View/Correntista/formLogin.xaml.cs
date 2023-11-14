using App_Banco_Digital.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_Banco_Digital.View.Correntista;

namespace App_Banco_Digital.View.Correntista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class formLogin : ContentPage
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try {
                Model.Conta conta = await CorrentistaDataService.login(new Model.Correntista { cpf = txtCpf.Text, senha = txtSenha.Text });


                if (conta.id_correntista != null)
                {
                    Navigation.PushAsync(new Area(conta));
                }
                else
                {
                    throw new Exception("Usuário não encontrado!");
                }
            }catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
            
        }

        private async void cadastro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new formCadastro());
        }
    }
}