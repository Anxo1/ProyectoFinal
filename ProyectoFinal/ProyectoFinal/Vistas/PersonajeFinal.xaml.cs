using ProyectoFinal.Data;
using ProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.IO;

namespace ProyectoFinal.Vistas

{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonajeFinal : ContentPage
    {
        private string raza;
        private string clase;
        Personajes personaje;
        static SQLiteHelper db;

       

        public PersonajeFinal(string raza, string clase)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            this.raza = raza;
            this.clase = clase;
            crearPersonaje();
        }
        public static SQLiteHelper SQLiteDB 
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"Personajes.db3"));
                }
                return db;

            }
        }

        void crearPersonaje()
        {
           personaje =  new Personajes();
            personaje = personaje.crearPersonaje(raza,clase);
            personaje.raza = raza;
            personaje.clase = clase;
            puntuacionFuerza.Text = personaje.Fuerza.ToString();
            puntuacionContitucion.Text= personaje.Contitucion.ToString();
            puntuacionCarisma.Text = personaje.Carisma.ToString(); 
            puntuacionDestreza.Text = personaje.Destreza.ToString();
            puntuacionInteligencia.Text = personaje.Inteligencia.ToString();
            puntuacionSabiduria.Text = personaje.Sabiduria.ToString();
            defensaCA.Text = "CA: "+ personaje.Ca.ToString();
            defensaFortaleza.Text = "Fortaleza: " + personaje.Fortaleza.ToString();
            defensaRefeljos.Text= "Reflejos: " + personaje.Refejos.ToString();
            defensaVoluntad.Text = "Voluntad: " + personaje.Voluntad.ToString();   
            habilidadesaAcrobacias.Text = "Acrobacias: " + personaje.Acrobacias.ToString();
            habilidadesaAguante.Text = "Aguante: " + personaje.Aguante.ToString();
            habilidadesaAtletismo.Text = "Atletismo: " + personaje.Atletismo.ToString();
            habilidadesaDiplomacia.Text = "Diplomacia: " + personaje.Diplomacia.ToString(); 
            habilidadesaDungeos.Text = "Dungeos: " + personaje.Dungeos.ToString();
            habilidadesaHistoria.Text = "Historia: " + personaje.Historia.ToString();
            habilidadesaPercepcion.Text = "Percepcion: " + personaje.Percepcion.ToString();
            habilidadesaPerpicacia.Text = "Perpicacia: " + personaje.Perpicacia.ToString();
            habilidadesArcanos.Text = "Arcanos: " + personaje.Arcanos.ToString();
            habilidadesaRecursos.Text = "Recursos: " + personaje.Recursos.ToString();
            habilidadesaReligion.Text = "Religion: " + personaje.Religion.ToString();
            habilidadesaSigilo.Text = "Sigilo: " + personaje.Sigilo.ToString();
            habilidadesEngañar.Text = "Engañar: " + personaje.Engañar.ToString();
            habilidadesHurto.Text = "Hurto: " + personaje.Hurto.ToString();
            habilidadesIntimidar.Text = "Intimidar: " + personaje.Intimidar.ToString();
            habilidadesNaturaleza.Text = "Naturaleza: " + personaje.Naturaleza.ToString();
            habilidadesSanar.Text = "Sanar: " + personaje.Sanar.ToString();
            modificadorCarisma.Text = "mod: " + crearModificador(personaje.Carisma);
            modificadorContitucion.Text = "mod: " + crearModificador(personaje.Contitucion);
            modificadorDestreza.Text = "mod: " + crearModificador(personaje.Destreza);
            modificadorFuerza.Text = "mod: " + crearModificador(personaje.Fuerza);
            modificadorInteligencia.Text = "mod: " + crearModificador(personaje.Inteligencia);
            modificadorSabiduria.Text = "mod: " + crearModificador(personaje.Sabiduria);


        }
       private string crearModificador(int puntuacion)
        {
            if (puntuacion ==1)
            {
                return "-5";
            }
            else if (puntuacion>= 2 && puntuacion <=3)
            {
                return "-4";
            }
            else if (puntuacion >= 4 && puntuacion <= 5)
            {
                return "-3";
            }
            else if (puntuacion >= 6 && puntuacion <= 7)
            {
                return "-2";
            }
            else if (puntuacion >= 8 && puntuacion <= 9)
            {
                return "-1";
            }
            else if (puntuacion >= 10 && puntuacion <= 11)
            {
                return "0";
            }
            else if (puntuacion >= 12 && puntuacion <= 13)
            {
                return "1";
            }
            else if (puntuacion >= 14 && puntuacion <= 15)
            {
                return "2";
            }
            else if (puntuacion >= 16 && puntuacion <= 17)
            {
                return "3";
            }
            else if (puntuacion >= 18 && puntuacion <= 19)
            {
                return "4";
            }
            else if (puntuacion >= 20 && puntuacion <= 21)
            {
                return  "5";
            }
            else if (puntuacion >= 22 && puntuacion <= 23)
            {
                return "6";
            }
            else if (puntuacion >= 24 && puntuacion <= 25)
            {
                return "7";
            }
            else if (puntuacion >= 26 && puntuacion <= 27)
            {
                return "8";
            }
            else if (puntuacion >= 28 && puntuacion <= 29)
            {
                return "9";
            }
            else if(puntuacion >= 30 && puntuacion <= 31)
            {
                return "10";
            }
            else if (puntuacion >= 32 && puntuacion <= 33)
            {
                return "11";
            }
            else
            {
                return "";
            }
           
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            //comprobar que el nombre este puesto
            if (!string.IsNullOrEmpty(txtNombre.Text) )
            {
                personaje.name = txtNombre.Text;

                await PersonajeFinal.SQLiteDB.SavePersonajeAsync(personaje);
                await DisplayAlert("Registro", "Se guardo de manera exitosa el personaje", "Ok");
                Navigation.PushAsync(new MainPage());


            }
            else
            {
                //si esta vacio advertir al ususarios
                await DisplayAlert("Advertencia", "Ingresa el nombre del personaje", "Ok");
            }
        }
    }
}