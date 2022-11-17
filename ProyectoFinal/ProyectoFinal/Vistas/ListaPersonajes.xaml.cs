using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using ProyectoFinal.Data;
using ProyectoFinal.Modelos;
using System.IO;

namespace ProyectoFinal.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaPersonajes : ContentPage
    {
        Personajes personaje;
        static SQLiteHelper db;
        public ListaPersonajes()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            RellenarLista();
        }
        public static SQLiteHelper SQLiteDB
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Personajes.db3"));
                }
                return db;

            }
        }

        //Metodo que rellena el ListView de personajes
        private async void RellenarLista()
        {
            var lista = await ListaPersonajes.SQLiteDB.GetPersonajesAsyncs();
            if (lista != null)
            {
                lstJugadores.ItemsSource = lista;
            }
        }

        private void lstJugadores_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var obj = (Personajes)e.SelectedItem;
            if (!string.IsNullOrEmpty(obj.id.ToString()))
            {
                Navigation.PushAsync(new VerPersonaje(obj.id));
            }

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());

        }
    }
}