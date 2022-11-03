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
            switch (pikerRaza.SelectedItem.ToString())
            {
                case "Humano":
                    txtInfo.Text = "De todas las razas civilizadas, los humanos son los más adaptables y variados. Es posible encontrar asentamientos humanos en cualquier parte, y la moralidad, costumbres e intereses de esta raza varían enormemente."+
                        "Juega con un humano si quieres…\r\n\r\n✦ Ser un héroe decidido e ingenioso con suficiente determinación como para enfrentarte a cualquier desafío.\r\n✦ Tener la mayor versatilidad y flexibilidad de todas las razas.\r\n✦ Ser capaz de destacar en cualquier clase que elijas.";
                    break;
                case "Elfo":
                    txtInfo.Text = "Salvajes y libres, los elfos custodian sus tierras boscosas empleando el sigilo y mortíferas flechas que descienden desde los árboles. Construyen sus hogares en armonía con el bosque, tan perfectamente unidos, que los viajeros a menudo no descubren que han entrado en una comunidad élfica hasta que es demasiado tarde\r\n\r\n"+
                        "Juega con un elfo si quieres…\r\n\r\n✦ Ser rápido, silencioso y salvaje.\r\n✦ Dirigir a tus compañeros a través de los bosques más profundos y atravesar a tus enemigos con flechas.\r\n✦ Ser miembro de una raza que prefiere las clases explorador, pícaro y clérigo.";
                    break;
                case "Enano":
                    txtInfo.Text = "";
                    break;
                case "Draconido":
                    txtInfo.Text = "";
                    break;
                case "Mediano":
                    txtInfo.Text = "";
                    break;
                case "Semielfo":
                    txtInfo.Text = "";
                    break;
                case "Tiflin":
                    txtInfo.Text = "";
                    break;
                default:
                    break;
            }
        }
    }
}