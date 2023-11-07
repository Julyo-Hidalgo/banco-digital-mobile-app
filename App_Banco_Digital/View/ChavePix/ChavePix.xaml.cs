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

        private void btn_transacao_Clicked(object sender, EventArgs e)
        {
            Transacao transacao = new Transacao();
            transacao.valor = double.Parse(txtValor.Text);

            int id_conta_destinario = 0;
            int id_conta_remetente = 0;//id da conta usada

            TransacaoCorrentistaAssoc transacaoCorrentista = new TransacaoCorrentistaAssoc();
            transacaoCorrentista.id_conta_remetente = id_conta_remetente;
            transacaoCorrentista.id_conta_destinatario = id_conta_destinario;
        }
    }
}