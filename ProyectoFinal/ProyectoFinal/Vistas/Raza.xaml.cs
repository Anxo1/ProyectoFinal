using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Raza : ContentPage
    {
        public Raza()
        {
            InitializeComponent();
            pikerRaza.SelectedIndex = 0;
            pikerRaza.SelectedItem = pikerRaza.Items.ElementAt(0);
        }

        private void pikerRaza_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtInfo.Text = pikerRaza.SelectedItem.ToString();
        }
    }
}