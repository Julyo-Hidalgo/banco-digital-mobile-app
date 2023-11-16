using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_Banco_Digital.Model;
using App_Banco_Digital.View;
using Xamarin.Essentials;
using App_Banco_Digital.View.ChavePix;
using App_Banco_Digital.View.Transacao;

namespace App_Banco_Digital.View.Correntista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Area : ContentPage
    {
        private Conta contaUsada;
        public Area(Conta conta)
        {
            InitializeComponent();
            contaUsada = conta;
            lblNumConta.Text += Convert.ToString(conta.numero);
            setSaldo(conta);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChavePix.ChavePix());
        }

        private async void novaChave_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChavePix.formCadastroChavePix());
        }

        private void mostrarSaldo_Clicked(object sender, EventArgs e)
        {
            if (lblSaldo.Text == "Saldo: ")
            {
                setSaldo(contaUsada);
            }
            else
            {
                lblSaldo.Text = "Saldo: ";
            }
        }

        public void setSaldo(Conta conta)
        {
            lblSaldo.Text += Convert.ToString(conta.saldo);
        }

        private void btnVerExtrato_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new formExtrato());
        }

        private void pagar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new formCadastroTranscao());
        }
    }
}