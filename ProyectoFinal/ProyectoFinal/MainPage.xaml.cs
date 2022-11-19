using ProyectoFinal.Vistas;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace ProyectoFinal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Raza());
        }

        private void btnLista_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaPersonajes());
        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {
            System.Environment.Exit(0);

        }
    }
}
