using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_Banco_Digital.Model;

namespace App_Banco_Digital.View.Correntista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Area : ContentPage
    {
        public Area(Conta conta)
        {
            InitializeComponent();

            NumConta.Text += Convert.ToString(conta.numero);
            Nome.Text += Convert.ToString(conta.saldo);
        }
    }
}