using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Vistas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Raza : ContentPage
    {
        string raza = "";
        public Raza()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            pikerRaza.SelectedIndex = 0;
            pikerRaza.SelectedItem = pikerRaza.Items.ElementAt(0);

            //imageRaza.Source = ImageSource.FromFile("Humano.png");
            //imageRaza.IsVisible = false;
            
            


        }

        private void pikerRaza_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtInfo.Text = pikerRaza.SelectedItem.ToString();
            switch (pikerRaza.SelectedItem.ToString())
            {
                case "Humano":
                    imageRaza.Source = ImageSource.FromFile("Humano.png");
                    txtInfo.Text = "De todas las razas civilizadas, los humanos son los más adaptables y variados. Es posible encontrar asentamientos humanos en cualquier parte, y la moralidad, costumbres e intereses de esta raza varían enormemente."+
                        "Juega con un humano si quieres…\r\n\r\n✦ Ser un héroe decidido e ingenioso con suficiente determinación como para enfrentarte a cualquier desafío.\r\n✦ Tener la mayor versatilidad y flexibilidad de todas las razas.\r\n✦ Ser capaz de destacar en cualquier clase que elijas.";
                    raza = "Humano";
                    break;
                case "Elfo":
                    imageRaza.Source = ImageSource.FromFile("Elfos.png");
                    txtInfo.Text = "Salvajes y libres, los elfos custodian sus tierras boscosas empleando el sigilo y mortíferas flechas que descienden desde los árboles. Construyen sus hogares en armonía con el bosque, tan perfectamente unidos, que los viajeros a menudo no descubren que han entrado en una comunidad élfica hasta que es demasiado tarde\r\n\r\n"+
                        "Juega con un elfo si quieres…\r\n\r\n✦ Ser rápido, silencioso y salvaje.\r\n✦ Dirigir a tus compañeros a través de los bosques más profundos y atravesar a tus enemigos con flechas.\r\n✦ Ser miembro de una raza que prefiere las clases explorador, pícaro y clérigo.";
                    raza = "Elfo";
                    break;
                case "Enano":
                    imageRaza.Source = ImageSource.FromFile("Enanos.png");
                    txtInfo.Text = "Tallados de los cimientos de roca del universo, los enanos soportaron una era de servidumbre bajo los gigantes antes de ganar la libertad. Sus poderosas ciudades fortificadas de las montañas son testimonio del poder de sus antiguos imperios. Incluso aquellos que viven en las ciudades humanas, se cuentan entre los defensores más firmes contra la oscuridad que amenaza con devorar el mundo."+
                        "\r\n\r\nJuega con un enano si quieres...\r\n\r\n✦ Ser duro, rudo y fuerte como una roca.\r\n✦ Aumentar la gloria de tus antepasados o ser la mano derecha de tu dios.\r\n✦ Ser capaz de soportar tanto daño como eres capaz de causar.\r\n✦ Ser miembro de una raza que prefiere las clases paladín,clérigo y guerrero.";

                    raza = "Enano";
                    break;
                case "Draconido":
                    imageRaza.Source = ImageSource.FromFile("Draconidos.png");
                    txtInfo.Text = "Nacidos para luchar, los dracónidos son una raza errante de mercenarios, soldados y aventureros. Hace mucho tiempo, su imperio aspiró a dominar todo el mundo, pero ahora sólo unos pocos clanes desarraigados de estos honorables luchadores resisten para transmitir las leyendas de su antigua gloria.\r\n\r\n"+
                        "Juega con un dracónido si quieres...\r\n\r\n✦ Tener el aspecto de un dragón.\r\n✦ Ser el orgulloso heredero de un antiguo imperio caído.\r\n✦ Exhalar ácido, frío, fuego, relámpago o veneno.\r\n✦ Ser miembro de una raza que prefiere las clases señor de la guerra, guerrero y paladín.";
                    raza = "Draconido";
                    break;
                case "Mediano":
                    imageRaza.Source = ImageSource.FromFile("Medianos.png");
                    txtInfo.Text = "Los medianos son una raza pequeña, conocida por su ingenio, su veloz astucia y sus nervios de acero. Son un pueblo nómada que recorre los cursos de agua y los pantanos. Nadie ha viajado más lejos ni ha visto más de lo que sucede en el mundo que los medianos.\r\n\r\n"+
                        "Juega con un mediano si quieres...\r\n\r\n✦ Ser un héroe valeroso al que es fácil subestimar.\r\n✦ Ser amable, afectuoso y amistoso.\r\n✦ Ser miembro de una raza que prefiere las clases pícaro, explorador y señor de la guerra";
                    raza = "Mediano";
                    break;
                case "Semielfo":
                    imageRaza.Source = ImageSource.FromFile("Semielfos.png");
                    txtInfo.Text = "Descendientes de elfos y humanos, los semielfos son una raza llena de vida en la cual suelen aparecer los mejores rasgos de elfos y humanos.\r\n\r\n"+
                        "Juega con un semielfo si quieres...\r\n\r\n✦ Ser un líder extrovertido y entusiasta.\r\n✦ Ser un héroe carismático que se siente en casa por igual en dos culturas diferentes.\r\n✦ Ser miembro de una raza que prefiere las clases señor de la guerra, paladín y brujo.";
                    raza = "Semielfo";
                    break;
                case "Tiflin":
                    imageRaza.Source = ImageSource.FromFile("Tiflin.png");
                    txtInfo.Text = "Herederos de un antiguo linaje infernal, los tiflin no tienen reinos propios, sino que viven dentro de los reinos y ciudades humanas. Son descendientes de nobles humanos que negociaron con poderes oscuros, y hace mucho tiempo su imperio subyugó la mitad del mundo. Pero el imperio se derrumbó, y los tiflin fueron abandonados para encontrar su propio camino en un mundo que a menudo les teme y está resentido con ellos\r\n"+
                        "Juega con un tiflin si quieres...\r\n✦ Ser un héroe con un lado oscuro al que derrotar.\r\n✦ Ser bueno engañando, intimidando o persuadiendo a otros para que hagan tu voluntad.\r\n✦ Ser miembro de una raza que prefiere las clases brujo, señor de la guerra y pícaro";
                    raza = "Tiflin";
                    break;
                case "Eladrines":
                    imageRaza.Source = ImageSource.FromFile("Eladrines.png");
                    txtInfo.Text = "Los eladrines son criaturas de magia con fuertes lazos con la Naturaleza, que viven en ciudades en el reino crepuscular de las tierras Salvajes de las hadas. Sus ciudades se encuentran tan próximas al mundo, que a veces cruzan la frontera, apareciendo brevemente en valles de montaña o en profundos claros de bosque antes de desaparecer de nuevo en las tierras Salvajes de las hadas.\r\n\r\n"+
                        "Juega con un eladrín si quieres...\r\n✦ Ser de otro mundo y misterioso.\r\n✦ Ser grácil e inteligente.\r\n✦ Teleportarte por el campo de batalla envuelto en la magia de las tierras Salvajes de las hadas.\r\n✦ Ser miembro de una raza que prefiere las clases mago,pícaro y señor de la guerra.";
                    raza = "Eladrines";
                    break;
                default:
                    break;
            }
        }

        private void btnSiguiente_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Clase());

        }
    }
}