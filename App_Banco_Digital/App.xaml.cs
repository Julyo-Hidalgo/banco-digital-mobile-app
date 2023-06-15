using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_Banco_Digital.View.Correntista;

namespace App_Banco_Digital
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new formLogin());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
