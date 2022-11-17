using ProyectoFinal.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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

        }
    }
}
