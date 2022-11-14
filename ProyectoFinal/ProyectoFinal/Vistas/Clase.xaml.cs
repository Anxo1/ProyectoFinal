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
    public partial class Clase : ContentPage
    {
        public Clase()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            pikerClase.SelectedIndex = 0;
            pikerClase.SelectedItem = pikerClase.Items.ElementAt(0);
        }

        private void pikerClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtInfo.Text = pikerClase.SelectedItem.ToString();
            switch (pikerClase.SelectedItem.ToString())
            {
                case "Guerrero":
                    imageClase.Source = ImageSource.FromFile("Guerrero.png");

                    txtInfo.Text = "Los guerreros son combatientes expertos y decididos, entrenados para proteger a los otros miembros de sus grupos de aventureros. Los guerreros definen la primera línea golpeando y tajando a sus enemigos hasta hacerlos caer mientras rechazan sus ataques empleando pesadas armaduras. Los guerreros esgrimen sus armas por oro, por gloria, por deber o incluso por el simple placer del ejercicio marcial desenfrenado." +
                        "\r\nRASGOS DE CLASE\r\n-Rol: defensor.Ers muy duro y tienes aptitudes excecionales para contener a los enemigos en el cuerpo a cuerpo.\r\n-Fuente de poder: marcial. Te has convertido en un experto en el combate gracias a incontables horas de práctica, determinación y pura dureza física.\r\n-Características clave: Fuerza, Destreza, Sabiduría,Constitución.\r\n-Competencias con armadura: tela, cuero, pieles, cota de nmallas, escamas; escudo ligero, escudo pesado\r\n-Competencias con armas: sencillas cuerpo a cuerpo, militares cuerpo a cuerpo, sencillas a distancia, militares adistancia" +
                        "";
                    break;
                case "Brujo":
                    imageClase.Source = ImageSource.FromFile("Brujo.png");
                    txtInfo.Text = "Los brujos canalizan poder arcano arrebatado a entidades primigenias. Entran en comunión con inteligencias infernales y espíritus feéricos, azotan a sus enemigos con potentes nexplosiones de poder sobrenatural, y los acosan con maldiciones embrujadoras."
                        + "\r\nRASGOS DE CLASE\r\n-Rol: pegador. Tus poderes de ataque causan mucho daño y con frecuencia debilitan u obstaculizan de algún modo al objetivo. Puedes eludir ataques volando, teleportándote o volviéndote invisible.\r\n-Fuente de poder: arcano. Obtienes tu poder mágico de un pacto forjado con alguna poderosa fuerza sobrenatural o una entidad ignota.\r\n-Características clave: Carisma, Constitución, Inteligencia.\r\n-Competencias con armadura: tela, cuero\r\n-Competencias con armas: sencillas cuerpo a cuerpo, sencillas a distancia.\r\n-Utensilios: cetros, varitas" +
                        "";
                    break;
                case "Clerigo":
                    imageClase.Source = ImageSource.FromFile("Clerigo.png");
                    txtInfo.Text = "Los clérigos son líderes de batalla revestidos de poder divino. Aplastan a sus enemigos con plegarias mágicas, mejoran y curan a sus compañeros, y avanzan dirigiendo a los demás a la victoria con una maza en una mano y un símbolo sagrado en la otra. Los clérigos abarcan toda la gama, desde los humildes servidores de la gente común hasta los crueles ejecutores de los dioses malignos."+
                        "\r\nRASGOS DE CLASE\r\n-Rol: líder. Diriges escudando a tus aliados con tus plegarias,curaciones, y utilizando poderes que mejoran los ataques de tus aliados.\r\n-Fuente de poder: divino. Has recibido la autoridad de esgrimir poder divino en nombre de un dios, fe o filosofía.\r\n-Características clave: Sabiduría, Fuerza, Carisma\r\n-Competencias con armadura: tela, cuero, pieles, cota de nmallas\r\n-Competencias con armas: sencillas cuerpo a cuerpo, sencillas a distancia";
                    break;
                case "Explorador":
                    imageClase.Source = ImageSource.FromFile("Hesplorador.png");
                    txtInfo.Text = "Los exploradores son luchadores vigilantes que vagan por lugares lejanos para proteger una región, un principio o un modo de vida. Maestros del arco y la espada, los exploradores destacan sobre todo en los asaltos de guerrilla, y pueden eliminar rápida y silenciosamente a sus enemigos. Los exploradores tienden emboscadas mortíferas y son expertos en evitar el peligro."+
                        "\r\nRASGOS DE CLASE\r\n-Rol: pegador. Te concentras bien en los ataques a distancia o en la lucha cuerpo a cuerpo con dos armas para infligir una gran cantidad de daño aun único enemigo cada vez. Tus ataques confían en la velocidad y la movilidad, ya que prefieres emplear tácticas de guerrilla siempre que te sea posible.\r\n-Fuente de poder: marcial. Tus talentos se basan en un intenso entrenamiento y práctica, confianza en ti mismo y unas capacidades innatas.\r\n-Características clave: Fuerza, Destreza, Sabiduría.\r\n-Competencias con armadura: tela, cuero, pieles\r\n-Competencias con armas: sencillas cuerpo a cuerpo, militares cuerpo a cuerpo, sencillas a distancia, militares a distancia";
                    break;
                case "Mago":
                    imageClase.Source = ImageSource.FromFile("Mago.png");
                    txtInfo.Text = "Los magos son criaturas de la magia arcana. Apelan al auténtico poder que impregna el cosmos, investigan rituales esotéricos que pueden alterar el espacio y el tiempo, y arrojan bolas de fuego que incineran a enemigos agolpados. Los magos esgrimen conjuros del mismo modo que los luchadores blanden sus espadas."+
                        "\r\n-Rol: controlador. Ejerces el control mediante efectos mágicos que cubren grandes zonas, a veces entorpeciendo a tus enemigos y a veces consumiéndolos con llamas.\r\n-Fuente de poder: arcano. Canalizas fuerzas arcanas gracias a un extenso estudio, conocimientos ocultos y una intrincada preparación. Para ti, la magia es una forma de arte, un método poderoso y expresivo mediante el cual tratas de controlar el mundo que te rodea.\r\n-Características clave: Inteligencia, Sabiduría, Destreza.\r\n-Competencias con armadura: tela\r\n-Competencias con armas: bastón, daga";
                    break;
                case "Paladin":
                    imageClase.Source = ImageSource.FromFile("Paladin.png");
                    txtInfo.Text = "Los paladines son guerreros indomables que han jurado dedicar sus proezas a algo mayor que ellos mismos. Los paladines aplastan a sus enemigos con autoridad divina, potencian la valentía de los compañeros cercanos, y relucen como si fueran un faro de inextinguible esperanza. Los paladines se transfiguran en el campo de batalla, como ejemplo de los valores divinos en acción."+
                        "\r\nRASGOS DE CLASE\r\n-Rol: defensor. Eres extremadamente resistente, con muchos puntos de golpe y la aptitud de llevar la armadura más pesada. Puedes lanzar audaces desafíos a los enemigos y obligarlos a luchar contra ti en vez de contra tus aliados.\r\n-Fuente de poder: divina. Eres un combatiente divino, un cruzado y protector de tu fe.\r\n-Características clave: Fuerza, Carisma, Sabiduría.\r\n-Competencias con armadura: tela, cuero, pieles, cota de mallas, escamas, completa; escudo ligero, escudo pesado\r\n-Competencias con armas: sencillas cuerpo a cuerpo, militares cuerpo a cuerpo, sencillas a distancia\r\n-Utensilio: símbolo sagrado";
                    break;
                case "Picaro":
                    imageClase.Source = ImageSource.FromFile("Picaro.png");
                    txtInfo.Text = "Los pícaros son adversarios astutos y escurridizos. Se deslizan entrando y saliendo de las sombras a su antojo, cruzando por cualquier parte del campo de batalla sin temor a las represalias, y aparecen repentinamente sólo para clavar una hoja letal."+
                        "\r\nRASGOS DE CLASE\r\n-Rol: pegador. Te lanzas velozmente para atacar, causas grandes daños, y tras ello te retiras aun lugar seguro. Obtienes los mejores resultados cuando trabajas con un defensor para flanquear enemigos.\r\n-Fuente de poder: marcial. Tus talentos dependen de un amplio entrenamiento y una práctica constante, capacidades innatas y una agilidad natural.\r\n-Características clave: Destreza, Fuerza, Carisma.\r\n-Competencias con armadura: tela, cuero\r\n-Competencias con armas: ballesta de mano, daga, espada corta, honda, shuriken.\r\n-Utensilio: símbolo sagrado";
                    break;
                case "Señor de la guerra":
                    imageClase.Source = ImageSource.FromFile("Senordelaguerra.png");
                    txtInfo.Text = "Los señores de la guerra son líderes de batalla hábiles y competentes. Se yerguen en la primera línea dando órdenes y potenciando a sus aliados, mientras dirigen la batalla con un arma en la mano. Los señores de la guerra saben cómo organizar un equipo para ganar una lucha."+
                        "\r\nRASGOS DE LA CLASE\r\n-Rol: líder. Eres un comandante que inspira a las tropas, y un maestro en las tácticas de batalla.\r\n-Fuente de poder: marcial. Te has convertido en un experto en táctica gracias a incontables horas de práctica, determinación y pura dureza física.\r\n-Características clave: Fuerza, Inteligencia, Carisma.\r\n-Competencias con armadura: tela, cuero, pieles, cota de mallas; escudo ligero\r\n-Competencias con armas: sencillas cuerpo a cuerpo, militares cuerpo a cuerpo, sencillas a distancia";
                    break;

                default:
                    break;

            }

        }

        private void btnSiguiente_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PersonajeFinal());

        }
    }
}