using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ProyectoFinal.Modelos
{
   public class Personajes
    {
        [PrimaryKey,AutoIncrement]
        public int id { get;set; }
        [MaxLength(50)]
        public string name { get;set; }
        [MaxLength(50)]
        public string clase { get; set; }
        [MaxLength(50)]
        public string raza { get; set; }


        string Informacion = "";
        //Puntuacion de caracteristicas
        int fuerza = 0;
        int contitucion = 0;
        int destreza = 0;
        int inteligencia = 0;
        int sabiduria = 0;
        int carisma = 0;
        //Defensas
        int fortaleza = 0;
        int refejos = 0;
        int voluntad = 0;
        int puntos_de_golpe = 0;
        int ca = 0;
        //armadura
        string armadura = "";
        //Habilidades
        int atletismo = 0;
        int resistencia = 0;
        int sanar = 0;
        int intimidar = 0;
        int acrobacias = 0;
        int aguante = 0;
        int arcanos = 0;
        int diplomacia = 0;
        int dungeos = 0;
        int engañar = 0;
        int historia = 0;
        int naturaleza = 0;
        int percepcion = 0;
        int perpicacia = 0;
        int recursos = 0;
        int sigilo = 0;
        int religion = 0;
        int hurto=0;

        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Contitucion { get => contitucion; set => contitucion = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Inteligencia { get => inteligencia; set => inteligencia = value; }
        public int Sabiduria { get => sabiduria; set => sabiduria = value; }
        public int Carisma { get => carisma; set => carisma = value; }
        public int Fortaleza { get => fortaleza; set => fortaleza = value; }
        public int Refejos { get => refejos; set => refejos = value; }
        public int Voluntad { get => voluntad; set => voluntad = value; }
        public int Puntos_de_golpe { get => puntos_de_golpe; set => puntos_de_golpe = value; }
        public int Ca { get => ca; set => ca = value; }
        public string Armadura { get => armadura; set => armadura = value; }
        public int Atletismo { get => atletismo; set => atletismo = value; }
        public int Resistencia { get => resistencia; set => resistencia = value; }
        public int Sanar { get => sanar; set => sanar = value; }
        public int Intimidar { get => intimidar; set => intimidar = value; }
        public int Acrobacias { get => acrobacias; set => acrobacias = value; }
        public int Aguante { get => aguante; set => aguante = value; }
        public int Arcanos { get => arcanos; set => arcanos = value; }
        public int Diplomacia { get => diplomacia; set => diplomacia = value; }
        public int Dungeos { get => dungeos; set => dungeos = value; }
        public int Engañar { get => engañar; set => engañar = value; }
        public int Historia { get => historia; set => historia = value; }
        public int Naturaleza { get => naturaleza; set => naturaleza = value; }
        public int Percepcion { get => percepcion; set => percepcion = value; }
        public int Perpicacia { get => perpicacia; set => perpicacia = value; }
        public int Recursos { get => recursos; set => recursos = value; }
        public int Sigilo { get => sigilo; set => sigilo = value; }
        public int Religion { get => religion; set => religion = value; }
        public int Hurto { get => hurto; set => hurto = value; }

        public Personajes crearPersonaje(string raza, string clase)
        {
            Personajes personaje = new Personajes();
            switch (raza)
            {
                case "Humano":
                    switch (clase)
                    {
                        case "Brujo":
                            //HUMANO BRUJO
                            personaje.Informacion = "Hechizos a voluntad:    \r\nEvocaciones a voluntad: Eldritch Blast Hellish Rebuke Dire Radiance\r\nNivel 1 diario: maldición del sueño oscuro\r\nEncuentro de nivel 1: palabra espantosa\r\n Dotes: 2 hazañas heroicas  ";
                            //Puntuacion de caracteristicas
                            personaje.fuerza = 12;
                            personaje.contitucion = 14;
                            personaje.destreza = 8;
                            personaje.inteligencia = 16;
                            personaje.sabiduria = 14;
                            personaje.carisma = 14;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 15;
                            personaje.voluntad = 14;
                            personaje.puntos_de_golpe = 26;
                            personaje.ca = 11;
                            //armadura
                            personaje.armadura = "ninguan";
                            //Habilidades
                            personaje.atletismo = 2;
                            personaje.resistencia = 2;
                            personaje.sanar = 2;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 8;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 2;
                            personaje.engañar = 7;
                            personaje.historia = 8;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 7;
                            personaje.recursos = 2;
                            personaje.religion = 8;
                            personaje.sigilo = 2;
                            personaje.hurto = 2;
                            return personaje;
                            
                            break;
                        case "Clerigo":
                            //HUMANO CLERIGO
                            personaje.Informacion = "\r\nOraciones a voluntad: Llama sagrada del escudo del sacerdote de la marca justiciera\r\nNivel 1 diario: Faro de esperanza\r\nEncuentro de nivel 1: Trueno colérico  ";
                            //Puntuacion de caracteristicas
                            personaje.fuerza = 12;
                            personaje.contitucion = 12;
                            personaje.destreza = 10;
                            personaje.inteligencia = 10;
                            personaje.sabiduria = 16;
                            personaje.carisma = 16;
                            //Defensas
                            personaje.fortaleza = 12;
                            personaje.refejos = 11;
                            personaje.voluntad = 16;
                            personaje.puntos_de_golpe = 24;
                            personaje.ca = 16;
                            //armadura
                            personaje.armadura = " cota de malla ";
                            //Habilidades
                            personaje.atletismo = 2;
                            personaje.resistencia = 2;
                            personaje.sanar = 8;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 5;
                            personaje.diplomacia = 8;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 8;
                            personaje.recursos = 2;
                            personaje.religion = 5;
                            personaje.sigilo = 2;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Explorador":
                            personaje.Informacion = "Hazañas a voluntad: Ataque cuidadoso Golpe gemelo Hit and Run\r\nNivel 1 diario: Golpe repentino\r\nEncuentro de nivel 1: Golpe de dos colmillos  ";
                            //Puntuacion de caracteristicas
                            personaje.fuerza = 15;
                            personaje.contitucion = 12;
                            personaje.destreza = 15;
                            personaje.inteligencia = 11;
                            personaje.sabiduria = 13;
                            personaje.carisma = 12;
                            //Defensas
                            personaje.fortaleza = 14;
                            personaje.refejos = 14;
                            personaje.voluntad = 12;
                            personaje.puntos_de_golpe = 24;
                            personaje.ca = 14;
                            //armadura
                            personaje.armadura = "cuero";
                            //Habilidades
                            personaje.atletismo = 7;
                            personaje.resistencia = 6;
                            personaje.sanar = 2;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 9;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 6;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 6;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.religion = 2;
                            personaje.sigilo = 7;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Guerrero":
                            //HUMANO GUERERO
                            personaje.Informacion = "";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 16;
                            personaje.contitucion = 16;
                            personaje.destreza = 10;
                            personaje.inteligencia = 12;
                            personaje.sabiduria = 12;
                            personaje.carisma = 10;
                            //Defensas
                            personaje.fortaleza = 16;
                            personaje.refejos = 12;
                            personaje.voluntad = 12;
                            personaje.puntos_de_golpe = 31;
                            personaje.ca = 17;
                            //armadura
                            personaje.armadura = "escamas";
                            //Habilidades
                            personaje.atletismo = 8;
                            personaje.resistencia = 8;
                            personaje.sanar = 6;
                            personaje.intimidar = 5;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 2;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Mago":
                            //HUMANO MAGO
                            personaje.Informacion = "Hechizos a voluntad:    \r\nEvocaciones a voluntad: Onda de trueno Ráfaga abrasadora Rayo de escarcha\r\nNivel 1 diario: Nube helada\r\nEncuentro de nivel 1: Rayo de debilitamiento ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 10;
                            personaje.contitucion = 12;
                            personaje.destreza = 13;
                            personaje.inteligencia = 17;
                            personaje.sabiduria = 15;
                            personaje.carisma = 11;
                            //Defensas
                            personaje.fortaleza = 12;
                            personaje.refejos = 14;
                            personaje.voluntad = 15;
                            personaje.puntos_de_golpe = 22;
                            personaje.ca = 11;
                            //armadura
                            personaje.armadura = "tela";
                            //Habilidades
                            personaje.atletismo = 2;
                            personaje.resistencia = 2;
                            personaje.sanar = 2;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 8;
                            personaje.diplomacia = 5;
                            personaje.dungeos = 7;
                            personaje.engañar = 2;
                            personaje.historia = 8;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 8;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Paladin":
                            //HUMANO PALADIN
                            personaje.Informacion = "Oraciones a voluntad: Golpe debilitador Golpe sagrado Golpe valiente\r\nNivel 1 diario: Sentencia del paladín\r\nEncuentro de nivel 1: Golpe radiante ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 14;
                            personaje.contitucion = 12;
                            personaje.destreza = 12;
                            personaje.inteligencia = 11;
                            personaje.sabiduria = 16;
                            personaje.carisma = 14;
                            //Defensas
                            personaje.fortaleza = 14;
                            personaje.refejos = 13;
                            personaje.voluntad = 15;
                            personaje.puntos_de_golpe = 27;
                            personaje.ca = 18;
                            //armadura
                            personaje.armadura = "escamas";
                            //Habilidades
                            personaje.atletismo = 2;
                            personaje.resistencia = 6;
                            personaje.sanar = 8;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 7;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 8;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 5;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Picaro":
                            //HUMANO PICARO
                            personaje.Informacion = "Hazañas a voluntad: Golpe diestro Astuto Florecimiento Golpe penetrante\r\nNivel 1 diario: Trick Strike\r\nEncuentro de nivel 1: Golpe aturdidor";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 14;
                            personaje.contitucion = 10;
                            personaje.destreza = 18;
                            personaje.inteligencia = 10;
                            personaje.sabiduria = 10;
                            personaje.carisma = 12;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 17;
                            personaje.voluntad = 12;
                            personaje.puntos_de_golpe = 22;
                            personaje.ca = 16;
                            //armadura
                            personaje.armadura = "cuero";
                            //Habilidades
                            personaje.atletismo = 7;
                            personaje.resistencia = 2;
                            personaje.sanar = 2;
                            personaje.intimidar = 6;
                            personaje.acrobacias = 11;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 2;
                            personaje.engañar = 6;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 9;
                            personaje.religion = 2;
                            personaje.hurto = 9;
                           
                            return personaje;

                            break;
                        case "Señor de la guerra":
                            //SEÑOR DE LA GUERRA
                            personaje.Informacion = "Hazañas a voluntad: Viper's Strike Commander's Strike Furious Smash\r\nNivel 1 diario: Embestida del Cuervo Blanco\r\nEncuentro de nivel 1: martillo y yunque ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 17;
                            personaje.contitucion = 13;
                            personaje.destreza = 8;
                            personaje.inteligencia = 12;
                            personaje.sabiduria = 10;
                            personaje.carisma = 15;
                            //Defensas
                            personaje.fortaleza = 15;
                            personaje.refejos = 12;
                            personaje.voluntad = 14;
                            personaje.puntos_de_golpe = 25;
                            personaje.ca = 16;
                            //armadura
                            personaje.armadura = "cota de malla";
                            //Habilidades
                            personaje.atletismo = 9;
                            personaje.resistencia = 2;
                            personaje.sanar = 2;
                            personaje.intimidar = 6;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 6;
                            personaje.dungeos = 6;
                            personaje.engañar = 2;
                            personaje.historia = 8;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 2;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        default:
                            personaje.Informacion = "";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 99;
                            return personaje;
                            break;
                    }
                    break;
                case "Elfo":
                    switch (clase)
                    {
                        case "Brujo":
                            personaje.Informacion = "Hechizos a voluntad:    \r\nEvocaciones a voluntad: Eldritch Blast Eyebite Hellish Rebuke\r\nNivel 1 diario: maldición del sueño oscuro\r\nEncuentro de nivel 1: Abrazo vampírico  ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 10;
                            personaje.contitucion = 12;
                            personaje.destreza = 10;
                            personaje.inteligencia = 17;
                            personaje.sabiduria = 13;
                            personaje.carisma = 14;
                            //Defensas
                            personaje.fortaleza = 12;
                            personaje.refejos = 15;
                            personaje.voluntad = 14;
                            personaje.puntos_de_golpe = 14;
                            personaje.ca = 14;
                            //armadura
                            personaje.armadura = "cuero";
                            //Habilidades
                            personaje.atletismo = 0;
                            personaje.resistencia = 0;
                            personaje.sanar = 0;
                            personaje.intimidar = 0;
                            personaje.acrobacias = 0;
                            personaje.aguante = 0;
                            personaje.arcanos = 8;
                            personaje.diplomacia = 0;
                            personaje.dungeos = 0;
                            personaje.engañar = 7;
                            personaje.historia = 8;
                            personaje.naturaleza = 0;
                            personaje.percepcion = 0;
                            personaje.perpicacia = 0;
                            personaje.recursos = 0;
                            personaje.sigilo = 0;
                            personaje.religion = 8;
                            personaje.hurto = 5;
                            return personaje;
                            break;
                        case "Clerigo":
                            personaje.Informacion = " \r\nOraciones a voluntad: Escudo del sacerdote de la marca justiciera Lanza de la fe\r\nNivel 1 diario: guardián de la fe\r\nEncuentro de nivel 1: causar miedo ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 14;
                            personaje.contitucion = 12;
                            personaje.destreza = 11;
                            personaje.inteligencia = 12;
                            personaje.sabiduria = 16;
                            personaje.carisma = 14;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 12;
                            personaje.voluntad = 16;
                            personaje.puntos_de_golpe = 24;
                            personaje.ca = 16;
                            //armadura
                            personaje.armadura = "cota de malla";
                            //Habilidades
                            personaje.atletismo = 2;
                            personaje.resistencia = 2;
                            personaje.sanar = 8;
                            personaje.intimidar = 0;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 7;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 6;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 6;
                            personaje.hurto = 0;
                            return personaje;
                            break;
                        case "Explorador":
                            personaje.Informacion = "Hazañas a voluntad: Ataque cuidadoso Ataque doble\r\nNivel 1 diario: Dividir el árbol\r\nEncuentro de nivel 1: Fox's Astucia  ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 16;
                            personaje.contitucion = 11;
                            personaje.destreza = 18;
                            personaje.inteligencia = 10;
                            personaje.sabiduria = 14;
                            personaje.carisma = 9;
                            //Defensas
                            personaje.fortaleza = 14;
                            personaje.refejos = 15;
                            personaje.voluntad = 12;
                            personaje.puntos_de_golpe = 23;
                            personaje.ca = 16;
                            //armadura
                            personaje.armadura = "cuero";
                            //Habilidades
                            personaje.atletismo = 8;
                            personaje.resistencia = 2;
                            personaje.sanar = 2;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 9;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 7;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 9;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 9;
                            personaje.religion = 2;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Guerrero":
                            personaje.Informacion = "Hazañas a voluntad: Marea de hendidura de hierro\r\nNivel 1 diario: Amenaza del villano\r\nEncuentro de nivel 1: Ataque de cobertura  ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 18;
                            personaje.contitucion = 10;
                            personaje.destreza = 16;
                            personaje.inteligencia = 10;
                            personaje.sabiduria = 13;
                            personaje.carisma = 8;
                            //Defensas
                            personaje.fortaleza = 16;
                            personaje.refejos = 13;
                            personaje.voluntad = 11;
                            personaje.puntos_de_golpe = 26;
                            personaje.ca = 19;
                            //armadura
                            personaje.armadura = "cota de malla";
                            //Habilidades
                            personaje.atletismo = 9;
                            personaje.resistencia = 2;
                            personaje.sanar = 6;
                            personaje.intimidar = 4;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 2;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Mago":
                            personaje.Informacion = "Hechizos a voluntad:    \r\nEvocaciones a voluntad: Magic Missile Thunderwave\r\nNivel 1 diario: flecha ácida\r\nEncuentro de nivel 1: orbe de fuerza ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 10;
                            personaje.contitucion = 11;
                            personaje.destreza = 16;
                            personaje.inteligencia = 17;
                            personaje.sabiduria = 14;
                            personaje.carisma = 10;
                            //Defensas
                            personaje.fortaleza = 10;
                            personaje.refejos = 13;
                            personaje.voluntad = 14;
                            personaje.puntos_de_golpe = 21;
                            personaje.ca = 13;
                            //armadura
                            personaje.armadura = "tela";
                            //Habilidades
                            personaje.atletismo = 2;
                            personaje.resistencia = 2;
                            personaje.sanar = 2;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 8;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 8;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 7;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 8;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Paladin":
                            personaje.Informacion = " Oraciones a voluntad: Golpe sagrado Golpe reforzador\r\nNivel 1 diario: bajo pena de muerte\r\nEncuentro de nivel 1: Golpe temible ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 14;
                            personaje.contitucion = 12;
                            personaje.destreza = 13;
                            personaje.inteligencia = 8;
                            personaje.sabiduria = 16;
                            personaje.carisma = 16;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 12;
                            personaje.voluntad = 14;
                            personaje.puntos_de_golpe = 27;
                            personaje.ca = 19;
                            //armadura
                            personaje.armadura = "placas";
                            //Habilidades
                            personaje.atletismo = 2;
                            personaje.resistencia = 2;
                            personaje.sanar = 8;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 8;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 8;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 4;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Picaro":
                            personaje.Informacion = " Hazañas a voluntad: Golpe perforante Golpe de respuesta\r\nNivel 1 diario: objetivo fácil\r\nEncuentro de nivel 1: Golpe tortuoso ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 16;
                            personaje.contitucion = 10;
                            personaje.destreza = 18;
                            personaje.inteligencia = 10;
                            personaje.sabiduria = 12;
                            personaje.carisma = 11;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 16;
                            personaje.voluntad = 11;
                            personaje.puntos_de_golpe = 22;
                            personaje.ca = 16;
                            //armadura
                            personaje.armadura = "cuero";
                            //Habilidades
                            personaje.atletismo = 8;
                            personaje.resistencia = 2;
                            personaje.sanar = 2;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 9;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 6;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 6;
                            personaje.recursos = 2;
                            personaje.sigilo = 9;
                            personaje.religion = 2;
                            personaje.hurto = 9;
                            return personaje;
                            break;
                        case "Señor de la guerra":
                            personaje.Informacion = "Hazañas a voluntad: Golpe del comandante Golpe de la víbora\r\nNivel 1 diario: liderar el ataque\r\nEncuentro de nivel 1: Ataque de guardia ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 14;
                            personaje.contitucion = 12;
                            personaje.destreza = 13;
                            personaje.inteligencia = 14;
                            personaje.sabiduria = 14;
                            personaje.carisma = 14;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 12;
                            personaje.voluntad = 13;
                            personaje.puntos_de_golpe = 24;
                            personaje.ca = 17;
                            //armadura
                            personaje.armadura = "cota de mallla";
                            //Habilidades
                            personaje.atletismo = 7;
                            personaje.resistencia = 0;
                            personaje.sanar = 7;
                            personaje.intimidar = 0;
                            personaje.acrobacias = 0;
                            personaje.aguante = 0;
                            personaje.arcanos = 0;
                            personaje.diplomacia = 7;
                            personaje.dungeos = 0;
                            personaje.engañar = 0;
                            personaje.historia = 7;
                            personaje.naturaleza = 0;
                            personaje.percepcion = 0;
                            personaje.perpicacia = 0;
                            personaje.recursos = 0;
                            personaje.sigilo = 0;
                            personaje.religion = 0;
                            personaje.hurto = 0;
                            return personaje;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Enano":
                    switch (clase)
                    {
                        case "Brujo":
                            personaje.Informacion = "Hechizos a voluntad:    \r\nEvocaciones a voluntad: Eldritch Blast Hellish Rebuke\r\nNivel 1 diario: Armadura de Agathys\r\nEncuentro de nivel 1: Witchfire  ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 11;
                            personaje.contitucion = 18;
                            personaje.destreza = 10;
                            personaje.inteligencia = 12;
                            personaje.sabiduria = 12;
                            personaje.carisma = 15;
                            //Defensas
                            personaje.fortaleza = 14;
                            personaje.refejos = 12;
                            personaje.voluntad = 13;
                            personaje.puntos_de_golpe = 30;
                            personaje.ca = 12;
                            //armadura
                            personaje.armadura = "cuero";
                            //Habilidades
                            personaje.atletismo = 0;
                            personaje.resistencia = 0;
                            personaje.sanar = 0;
                            personaje.intimidar = 7;
                            personaje.acrobacias = 0;
                            personaje.aguante = 0;
                            personaje.arcanos = 6;
                            personaje.diplomacia = 0;
                            personaje.dungeos = 0;
                            personaje.engañar = 7;
                            personaje.historia = 0;
                            personaje.naturaleza = 0;
                            personaje.percepcion = 0;
                            personaje.perpicacia = 0;
                            personaje.recursos = 0;
                            personaje.sigilo = 0;
                            personaje.religion = 0;
                            personaje.hurto = 5;
                            return personaje;
                            break;
                        case "Clerigo":
                            personaje.Informacion = "Oraciones a voluntad: Escudo de sacerdote de marca justiciera\r\nNivel 1 diario: Cascada de luz\r\nEncuentro de nivel 1: Golpe curativo  ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 12;
                            personaje.contitucion = 15;
                            personaje.destreza = 10;
                            personaje.inteligencia = 11;
                            personaje.sabiduria = 18;
                            personaje.carisma = 12;
                            //Defensas
                            personaje.fortaleza = 12;
                            personaje.refejos = 10;
                            personaje.voluntad = 16;
                            personaje.puntos_de_golpe = 27;
                            personaje.ca = 16;
                            //armadura
                            personaje.armadura = "cota de malla";
                            //Habilidades
                            personaje.atletismo = 2;
                            personaje.resistencia = 2;
                            personaje.sanar = 9;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 5;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 9;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 5;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Explorador":
                            personaje.Informacion = " Hazañas a voluntad: Nimble Strike Hit and Run\r\nNivel 1 diario: Golpe repentino\r\nEncuentro de nivel 1: Golpe de dos colmillos ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 14;
                            personaje.contitucion = 10;
                            personaje.destreza = 18;
                            personaje.inteligencia = 10;
                            personaje.sabiduria = 13;
                            personaje.carisma = 10;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 15;
                            personaje.voluntad = 11;
                            personaje.puntos_de_golpe = 22;
                            personaje.ca = 17;
                            //armadura
                            personaje.armadura = "oculta";
                            //Habilidades
                            personaje.atletismo = 7;
                            personaje.resistencia = 7;
                            personaje.sanar = 2;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 9;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia =2;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 6;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 2;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Guerrero":
                            personaje.Informacion = " Hazañas a voluntad: Marea de hierro Reaping Strike\r\nNivel 1 diario: Brute Strike\r\nEncuentro de nivel 1: Ataque de paso ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 15;
                            personaje.contitucion = 14;
                            personaje.destreza = 15;
                            personaje.inteligencia = 11;
                            personaje.sabiduria = 15;
                            personaje.carisma = 10;
                            //Defensas
                            personaje.fortaleza = 14;
                            personaje.refejos = 12;
                            personaje.voluntad = 12;
                            personaje.puntos_de_golpe = 29;
                            personaje.ca = 19;
                            //armadura
                            personaje.armadura = "escala";
                            //Habilidades
                            personaje.atletismo = 7;
                            personaje.resistencia = 9;
                            personaje.sanar = 7;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 2;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Mago":
                            personaje.Informacion = "Hechizos a voluntad:    \r\nEvocaciones a voluntad: Misiles mágicos Nube de dagas\r\nNivel 1 diario: flecha ácida\r\nEncuentro de nivel 1: Manos ardientes  ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 8;
                            personaje.contitucion = 12;
                            personaje.destreza = 14;
                            personaje.inteligencia = 18;
                            personaje.sabiduria = 13;
                            personaje.carisma = 10;
                            //Defensas
                            personaje.fortaleza = 11;
                            personaje.refejos = 14;
                            personaje.voluntad = 13;
                            personaje.puntos_de_golpe = 22;
                            personaje.ca = 12;
                            //armadura
                            personaje.armadura = "Tela";
                            //Habilidades
                            personaje.atletismo = 0;
                            personaje.resistencia = 0;
                            personaje.sanar = 0;
                            personaje.intimidar = 0;
                            personaje.acrobacias = 0;
                            personaje.aguante = 0;
                            personaje.arcanos = 9;
                            personaje.diplomacia = 0;
                            personaje.dungeos = 9;
                            personaje.engañar = 0;
                            personaje.historia = 9;
                            personaje.naturaleza = 0;
                            personaje.percepcion = 0;
                            personaje.perpicacia = 0;
                            personaje.recursos = 0;
                            personaje.sigilo = 0;
                            personaje.religion = 9;
                            personaje.hurto = 0;
                            return personaje;
                            break;
                        case "Paladin":
                            personaje.Informacion = "Oraciones a voluntad: Golpe sagrado Golpe reforzador\r\nNivel 1 diario: delirio radiante\r\nEncuentro de nivel 1: Golpe temible  ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 12;
                            personaje.contitucion = 12;
                            personaje.destreza = 10;
                            personaje.inteligencia = 10;
                            personaje.sabiduria = 14;
                            personaje.carisma = 18;
                            //Defensas
                            personaje.fortaleza = 12;
                            personaje.refejos = 11;
                            personaje.voluntad = 15;
                            personaje.puntos_de_golpe = 27;
                            personaje.ca = 17;
                            //armadura
                            personaje.armadura = "escala";
                            //Habilidades
                            personaje.atletismo = 0;
                            personaje.resistencia = 0;
                            personaje.sanar = 0;
                            personaje.intimidar = 9;
                            personaje.acrobacias = 0;
                            personaje.aguante = 0;
                            personaje.arcanos = 0;
                            personaje.diplomacia = 9;
                            personaje.dungeos = 0;
                            personaje.engañar = 0;
                            personaje.historia = 5;
                            personaje.naturaleza = 0;
                            personaje.percepcion = 0;
                            personaje.perpicacia = 0;
                            personaje.recursos = 0;
                            personaje.sigilo = 0;
                            personaje.religion = 5;
                            personaje.hurto = 0;
                            return personaje;
                            break;
                        case "Picaro":
                            personaje.Informacion = " Hazañas a voluntad: Golpe perforante Golpe de respuesta\r\nNivel 1 diario: objetivo fácil\r\nEncuentro de nivel 1: Golpe de posicionamiento ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 14;
                            personaje.contitucion = 12;
                            personaje.destreza = 17;
                            personaje.inteligencia = 10;
                            personaje.sabiduria = 13;
                            personaje.carisma = 12;
                            //Defensas
                            personaje.fortaleza = 12;
                            personaje.refejos = 15;
                            personaje.voluntad = 11;
                            personaje.puntos_de_golpe = 24;
                            personaje.ca = 15;
                            //armadura
                            personaje.armadura = "cuero";
                            //Habilidades
                            personaje.atletismo = 7;
                            personaje.resistencia = 0;
                            personaje.sanar = 0;
                            personaje.intimidar = 6;
                            personaje.acrobacias = 8;
                            personaje.aguante = 0;
                            personaje.arcanos = 0;
                            personaje.diplomacia = 0;
                            personaje.dungeos = 0;
                            personaje.engañar = 6;
                            personaje.historia = 0;
                            personaje.naturaleza = 0;
                            personaje.percepcion = 0;
                            personaje.perpicacia = 0;
                            personaje.recursos = 0;
                            personaje.sigilo = 8;
                            personaje.religion = 0;
                            personaje.hurto = 8;
                            return personaje;
                            break;
                        case "Señor de la guerra":
                            personaje.Informacion = "Hazañas a voluntad: Furious Smash Viper's Strike\r\nNivel 1 diario: Pin the Foe\r\nEncuentro de nivel 1: martillo y yunque  ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 17;
                            personaje.contitucion = 10;
                            personaje.destreza = 11;
                            personaje.inteligencia = 15;
                            personaje.sabiduria = 12;
                            personaje.carisma = 12;
                            //Defensas
                            personaje.fortaleza = 14;
                            personaje.refejos = 12;
                            personaje.voluntad = 12;
                            personaje.puntos_de_golpe = 22;
                            personaje.ca = 16;
                            //armadura
                            personaje.armadura = "cota de malla";
                            //Habilidades
                            personaje.atletismo = 8;
                            personaje.resistencia = 0;
                            personaje.sanar = 0;
                            personaje.intimidar = 6;
                            personaje.acrobacias = 0;
                            personaje.aguante = 0;
                            personaje.arcanos = 0;
                            personaje.diplomacia = 6;
                            personaje.dungeos = 0;
                            personaje.engañar = 0;
                            personaje.historia = 7;
                            personaje.naturaleza = 0;
                            personaje.percepcion = 0;
                            personaje.perpicacia = 0;
                            personaje.recursos = 0;
                            personaje.sigilo = 0;
                            personaje.religion = 0;
                            personaje.hurto = 0;
                            return personaje;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Eladrines":
                    switch (clase)
                    {
                        case "Brujo":
                            personaje.Informacion = "Hechizos a voluntad:    \r\nEvocaciones a voluntad: Eldritch Blast Eyebite Hellish Rebuke\r\nNivel 1 diario: maldición del sueño oscuro\r\nEncuentro de nivel 1: Abrazo vampírico  ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 10;
                            personaje.contitucion = 12;
                            personaje.destreza = 10;
                            personaje.inteligencia = 17;
                            personaje.sabiduria = 13;
                            personaje.carisma = 14;
                            //Defensas
                            personaje.fortaleza = 12;
                            personaje.refejos = 15;
                            personaje.voluntad = 14;
                            personaje.puntos_de_golpe = 14;
                            personaje.ca = 14;
                            //armadura
                            personaje.armadura = "cuero";
                            //Habilidades
                            personaje.atletismo = 0;
                            personaje.resistencia = 0;
                            personaje.sanar = 0;
                            personaje.intimidar = 0;
                            personaje.acrobacias = 0;
                            personaje.aguante = 0;
                            personaje.arcanos = 8;
                            personaje.diplomacia = 0;
                            personaje.dungeos = 0;
                            personaje.engañar = 7;
                            personaje.historia = 8;
                            personaje.naturaleza = 0;
                            personaje.percepcion = 0;
                            personaje.perpicacia = 0;
                            personaje.recursos = 0;
                            personaje.sigilo = 0;
                            personaje.religion = 8;
                            personaje.hurto = 5;
                            return personaje;
                            break;
                        case "Clerigo":
                            personaje.Informacion = " \r\nOraciones a voluntad: Escudo del sacerdote de la marca justiciera Lanza de la fe\r\nNivel 1 diario: guardián de la fe\r\nEncuentro de nivel 1: causar miedo ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 14;
                            personaje.contitucion = 12;
                            personaje.destreza = 11;
                            personaje.inteligencia = 12;
                            personaje.sabiduria = 16;
                            personaje.carisma = 14;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 12;
                            personaje.voluntad = 16;
                            personaje.puntos_de_golpe = 24;
                            personaje.ca = 16;
                            //armadura
                            personaje.armadura = "cota de malla";
                            //Habilidades
                            personaje.atletismo = 2;
                            personaje.resistencia = 2;
                            personaje.sanar = 8;
                            personaje.intimidar = 0;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 7;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 6;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 6;
                            personaje.hurto = 0;
                            return personaje;
                            break;
                        case "Explorador":
                            personaje.Informacion = "Hazañas a voluntad: Ataque cuidadoso Ataque doble\r\nNivel 1 diario: Dividir el árbol\r\nEncuentro de nivel 1: Fox's Astucia  ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 16;
                            personaje.contitucion = 11;
                            personaje.destreza = 18;
                            personaje.inteligencia = 10;
                            personaje.sabiduria = 14;
                            personaje.carisma = 9;
                            //Defensas
                            personaje.fortaleza = 14;
                            personaje.refejos = 15;
                            personaje.voluntad = 12;
                            personaje.puntos_de_golpe = 23;
                            personaje.ca = 16;
                            //armadura
                            personaje.armadura = "cuero";
                            //Habilidades
                            personaje.atletismo = 8;
                            personaje.resistencia = 2;
                            personaje.sanar = 2;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 9;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 7;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 9;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 9;
                            personaje.religion = 2;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Guerrero":
                            personaje.Informacion = "Hazañas a voluntad: Marea de hendidura de hierro\r\nNivel 1 diario: Amenaza del villano\r\nEncuentro de nivel 1: Ataque de cobertura  ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 18;
                            personaje.contitucion = 10;
                            personaje.destreza = 16;
                            personaje.inteligencia = 10;
                            personaje.sabiduria = 13;
                            personaje.carisma = 8;
                            //Defensas
                            personaje.fortaleza = 16;
                            personaje.refejos = 13;
                            personaje.voluntad = 11;
                            personaje.puntos_de_golpe = 26;
                            personaje.ca = 19;
                            //armadura
                            personaje.armadura = "cota de malla";
                            //Habilidades
                            personaje.atletismo = 9;
                            personaje.resistencia = 2;
                            personaje.sanar = 6;
                            personaje.intimidar = 4;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 2;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Mago":
                            personaje.Informacion = "Hechizos a voluntad:    \r\nEvocaciones a voluntad: Magic Missile Thunderwave\r\nNivel 1 diario: flecha ácida\r\nEncuentro de nivel 1: orbe de fuerza ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 10;
                            personaje.contitucion = 11;
                            personaje.destreza = 16;
                            personaje.inteligencia = 17;
                            personaje.sabiduria = 14;
                            personaje.carisma = 10;
                            //Defensas
                            personaje.fortaleza = 10;
                            personaje.refejos = 13;
                            personaje.voluntad = 14;
                            personaje.puntos_de_golpe = 21;
                            personaje.ca = 13;
                            //armadura
                            personaje.armadura = "tela";
                            //Habilidades
                            personaje.atletismo = 2;
                            personaje.resistencia = 2;
                            personaje.sanar = 2;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 8;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 8;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 7;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 8;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Paladin":
                            personaje.Informacion = " Oraciones a voluntad: Golpe sagrado Golpe reforzador\r\nNivel 1 diario: bajo pena de muerte\r\nEncuentro de nivel 1: Golpe temible ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 14;
                            personaje.contitucion = 12;
                            personaje.destreza = 13;
                            personaje.inteligencia = 8;
                            personaje.sabiduria = 16;
                            personaje.carisma = 16;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 12;
                            personaje.voluntad = 14;
                            personaje.puntos_de_golpe = 27;
                            personaje.ca = 19;
                            //armadura
                            personaje.armadura = "placas";
                            //Habilidades
                            personaje.atletismo = 2;
                            personaje.resistencia = 2;
                            personaje.sanar = 8;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 8;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 8;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 4;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Picaro":
                            personaje.Informacion = " Hazañas a voluntad: Golpe perforante Golpe de respuesta\r\nNivel 1 diario: objetivo fácil\r\nEncuentro de nivel 1: Golpe tortuoso ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 16;
                            personaje.contitucion = 10;
                            personaje.destreza = 18;
                            personaje.inteligencia = 10;
                            personaje.sabiduria = 12;
                            personaje.carisma = 11;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 16;
                            personaje.voluntad = 11;
                            personaje.puntos_de_golpe = 22;
                            personaje.ca = 16;
                            //armadura
                            personaje.armadura = "cuero";
                            //Habilidades
                            personaje.atletismo = 8;
                            personaje.resistencia = 2;
                            personaje.sanar = 2;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 9;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 6;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 6;
                            personaje.recursos = 2;
                            personaje.sigilo = 9;
                            personaje.religion = 2;
                            personaje.hurto = 9;
                            return personaje;
                            break;
                        case "Señor de la guerra":
                            personaje.Informacion = "Hazañas a voluntad: Golpe del comandante Golpe de la víbora\r\nNivel 1 diario: liderar el ataque\r\nEncuentro de nivel 1: Ataque de guardia ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 14;
                            personaje.contitucion = 12;
                            personaje.destreza = 13;
                            personaje.inteligencia = 14;
                            personaje.sabiduria = 14;
                            personaje.carisma = 14;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 12;
                            personaje.voluntad = 13;
                            personaje.puntos_de_golpe = 24;
                            personaje.ca = 17;
                            //armadura
                            personaje.armadura = "cota de mallla";
                            //Habilidades
                            personaje.atletismo = 7;
                            personaje.resistencia = 0;
                            personaje.sanar = 7;
                            personaje.intimidar = 0;
                            personaje.acrobacias = 0;
                            personaje.aguante = 0;
                            personaje.arcanos = 0;
                            personaje.diplomacia = 7;
                            personaje.dungeos = 0;
                            personaje.engañar = 0;
                            personaje.historia = 7;
                            personaje.naturaleza = 0;
                            personaje.percepcion = 0;
                            personaje.perpicacia = 0;
                            personaje.recursos = 0;
                            personaje.sigilo = 0;
                            personaje.religion = 0;
                            personaje.hurto = 0;
                            return personaje;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Draconidos":
                    switch (clase)
                    {
                        case "Brujo":
                            personaje.Informacion = "Hechizos a voluntad:    \r\nEvocaciones a voluntad: Eldritch Blast Eyebite Hellish Rebuke\r\nNivel 1 diario: maldición del sueño oscuro\r\nEncuentro de nivel 1: Abrazo vampírico  ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 10;
                            personaje.contitucion = 12;
                            personaje.destreza = 10;
                            personaje.inteligencia = 17;
                            personaje.sabiduria = 13;
                            personaje.carisma = 14;
                            //Defensas
                            personaje.fortaleza = 12;
                            personaje.refejos = 15;
                            personaje.voluntad = 14;
                            personaje.puntos_de_golpe = 14;
                            personaje.ca = 14;
                            //armadura
                            personaje.armadura = "cuero";
                            //Habilidades
                            personaje.atletismo = 0;
                            personaje.resistencia = 0;
                            personaje.sanar = 0;
                            personaje.intimidar = 0;
                            personaje.acrobacias = 0;
                            personaje.aguante = 0;
                            personaje.arcanos = 8;
                            personaje.diplomacia = 0;
                            personaje.dungeos = 0;
                            personaje.engañar = 7;
                            personaje.historia = 8;
                            personaje.naturaleza = 0;
                            personaje.percepcion = 0;
                            personaje.perpicacia = 0;
                            personaje.recursos = 0;
                            personaje.sigilo = 0;
                            personaje.religion = 8;
                            personaje.hurto = 5;
                            return personaje;
                            break;
                        case "Clerigo":
                            personaje.Informacion = " \r\nOraciones a voluntad: Escudo del sacerdote de la marca justiciera Lanza de la fe\r\nNivel 1 diario: guardián de la fe\r\nEncuentro de nivel 1: causar miedo ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 14;
                            personaje.contitucion = 12;
                            personaje.destreza = 11;
                            personaje.inteligencia = 12;
                            personaje.sabiduria = 16;
                            personaje.carisma = 14;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 12;
                            personaje.voluntad = 16;
                            personaje.puntos_de_golpe = 24;
                            personaje.ca = 16;
                            //armadura
                            personaje.armadura = "cota de malla";
                            //Habilidades
                            personaje.atletismo = 2;
                            personaje.resistencia = 2;
                            personaje.sanar = 8;
                            personaje.intimidar = 0;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 7;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 6;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 6;
                            personaje.hurto = 0;
                            return personaje;
                            break;
                        case "Explorador":
                            personaje.Informacion = "Hazañas a voluntad: Ataque cuidadoso Ataque doble\r\nNivel 1 diario: Dividir el árbol\r\nEncuentro de nivel 1: Fox's Astucia  ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 16;
                            personaje.contitucion = 11;
                            personaje.destreza = 18;
                            personaje.inteligencia = 10;
                            personaje.sabiduria = 14;
                            personaje.carisma = 9;
                            //Defensas
                            personaje.fortaleza = 14;
                            personaje.refejos = 15;
                            personaje.voluntad = 12;
                            personaje.puntos_de_golpe = 23;
                            personaje.ca = 16;
                            //armadura
                            personaje.armadura = "cuero";
                            //Habilidades
                            personaje.atletismo = 8;
                            personaje.resistencia = 2;
                            personaje.sanar = 2;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 9;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 7;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 9;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 9;
                            personaje.religion = 2;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Guerrero":
                            personaje.Informacion = "Hazañas a voluntad: Marea de hendidura de hierro\r\nNivel 1 diario: Amenaza del villano\r\nEncuentro de nivel 1: Ataque de cobertura  ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 18;
                            personaje.contitucion = 10;
                            personaje.destreza = 16;
                            personaje.inteligencia = 10;
                            personaje.sabiduria = 13;
                            personaje.carisma = 8;
                            //Defensas
                            personaje.fortaleza = 16;
                            personaje.refejos = 13;
                            personaje.voluntad = 11;
                            personaje.puntos_de_golpe = 26;
                            personaje.ca = 19;
                            //armadura
                            personaje.armadura = "cota de malla";
                            //Habilidades
                            personaje.atletismo = 9;
                            personaje.resistencia = 2;
                            personaje.sanar = 6;
                            personaje.intimidar = 4;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 2;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Mago":
                            personaje.Informacion = "Hechizos a voluntad:    \r\nEvocaciones a voluntad: Magic Missile Thunderwave\r\nNivel 1 diario: flecha ácida\r\nEncuentro de nivel 1: orbe de fuerza ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 10;
                            personaje.contitucion = 11;
                            personaje.destreza = 16;
                            personaje.inteligencia = 17;
                            personaje.sabiduria = 14;
                            personaje.carisma = 10;
                            //Defensas
                            personaje.fortaleza = 10;
                            personaje.refejos = 13;
                            personaje.voluntad = 14;
                            personaje.puntos_de_golpe = 21;
                            personaje.ca = 13;
                            //armadura
                            personaje.armadura = "tela";
                            //Habilidades
                            personaje.atletismo = 2;
                            personaje.resistencia = 2;
                            personaje.sanar = 2;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 8;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 8;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 7;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 8;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Paladin":
                            personaje.Informacion = " Oraciones a voluntad: Golpe sagrado Golpe reforzador\r\nNivel 1 diario: bajo pena de muerte\r\nEncuentro de nivel 1: Golpe temible ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 14;
                            personaje.contitucion = 12;
                            personaje.destreza = 13;
                            personaje.inteligencia = 8;
                            personaje.sabiduria = 16;
                            personaje.carisma = 16;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 12;
                            personaje.voluntad = 14;
                            personaje.puntos_de_golpe = 27;
                            personaje.ca = 19;
                            //armadura
                            personaje.armadura = "placas";
                            //Habilidades
                            personaje.atletismo = 2;
                            personaje.resistencia = 2;
                            personaje.sanar = 8;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 8;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 8;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 4;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Picaro":
                            personaje.Informacion = " Hazañas a voluntad: Golpe perforante Golpe de respuesta\r\nNivel 1 diario: objetivo fácil\r\nEncuentro de nivel 1: Golpe tortuoso ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 16;
                            personaje.contitucion = 10;
                            personaje.destreza = 18;
                            personaje.inteligencia = 10;
                            personaje.sabiduria = 12;
                            personaje.carisma = 11;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 16;
                            personaje.voluntad = 11;
                            personaje.puntos_de_golpe = 22;
                            personaje.ca = 16;
                            //armadura
                            personaje.armadura = "cuero";
                            //Habilidades
                            personaje.atletismo = 8;
                            personaje.resistencia = 2;
                            personaje.sanar = 2;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 9;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 6;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 6;
                            personaje.recursos = 2;
                            personaje.sigilo = 9;
                            personaje.religion = 2;
                            personaje.hurto = 9;
                            return personaje;
                            break;
                        case "Señor de la guerra":
                            personaje.Informacion = "Hazañas a voluntad: Golpe del comandante Golpe de la víbora\r\nNivel 1 diario: liderar el ataque\r\nEncuentro de nivel 1: Ataque de guardia ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 14;
                            personaje.contitucion = 12;
                            personaje.destreza = 13;
                            personaje.inteligencia = 14;
                            personaje.sabiduria = 14;
                            personaje.carisma = 14;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 12;
                            personaje.voluntad = 13;
                            personaje.puntos_de_golpe = 24;
                            personaje.ca = 17;
                            //armadura
                            personaje.armadura = "cota de mallla";
                            //Habilidades
                            personaje.atletismo = 7;
                            personaje.resistencia = 0;
                            personaje.sanar = 7;
                            personaje.intimidar = 0;
                            personaje.acrobacias = 0;
                            personaje.aguante = 0;
                            personaje.arcanos = 0;
                            personaje.diplomacia = 7;
                            personaje.dungeos = 0;
                            personaje.engañar = 0;
                            personaje.historia = 7;
                            personaje.naturaleza = 0;
                            personaje.percepcion = 0;
                            personaje.perpicacia = 0;
                            personaje.recursos = 0;
                            personaje.sigilo = 0;
                            personaje.religion = 0;
                            personaje.hurto = 0;
                            return personaje;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Semielfo":
                    switch (clase)
                    {
                        case "Brujo":
                            personaje.Informacion = "Hechizos a voluntad:    \r\nEvocaciones a voluntad: Eldritch Blast Eyebite Hellish Rebuke\r\nNivel 1 diario: maldición del sueño oscuro\r\nEncuentro de nivel 1: Abrazo vampírico  ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 10;
                            personaje.contitucion = 12;
                            personaje.destreza = 10;
                            personaje.inteligencia = 17;
                            personaje.sabiduria = 13;
                            personaje.carisma = 14;
                            //Defensas
                            personaje.fortaleza = 12;
                            personaje.refejos = 15;
                            personaje.voluntad = 14;
                            personaje.puntos_de_golpe = 14;
                            personaje.ca = 14;
                            //armadura
                            personaje.armadura = "cuero";
                            //Habilidades
                            personaje.atletismo = 0;
                            personaje.resistencia = 0;
                            personaje.sanar = 0;
                            personaje.intimidar = 0;
                            personaje.acrobacias = 0;
                            personaje.aguante = 0;
                            personaje.arcanos = 8;
                            personaje.diplomacia = 0;
                            personaje.dungeos = 0;
                            personaje.engañar = 7;
                            personaje.historia = 8;
                            personaje.naturaleza = 0;
                            personaje.percepcion = 0;
                            personaje.perpicacia = 0;
                            personaje.recursos = 0;
                            personaje.sigilo = 0;
                            personaje.religion = 8;
                            personaje.hurto = 5;
                            return personaje;
                            break;
                        case "Clerigo":
                            personaje.Informacion = " \r\nOraciones a voluntad: Escudo del sacerdote de la marca justiciera Lanza de la fe\r\nNivel 1 diario: guardián de la fe\r\nEncuentro de nivel 1: causar miedo ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 14;
                            personaje.contitucion = 12;
                            personaje.destreza = 11;
                            personaje.inteligencia = 12;
                            personaje.sabiduria = 16;
                            personaje.carisma = 14;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 12;
                            personaje.voluntad = 16;
                            personaje.puntos_de_golpe = 24;
                            personaje.ca = 16;
                            //armadura
                            personaje.armadura = "cota de malla";
                            //Habilidades
                            personaje.atletismo = 2;
                            personaje.resistencia = 2;
                            personaje.sanar = 8;
                            personaje.intimidar = 0;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 7;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 6;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 6;
                            personaje.hurto = 0;
                            return personaje;
                            break;
                        case "Explorador":
                            personaje.Informacion = "Hazañas a voluntad: Ataque cuidadoso Ataque doble\r\nNivel 1 diario: Dividir el árbol\r\nEncuentro de nivel 1: Fox's Astucia  ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 16;
                            personaje.contitucion = 11;
                            personaje.destreza = 18;
                            personaje.inteligencia = 10;
                            personaje.sabiduria = 14;
                            personaje.carisma = 9;
                            //Defensas
                            personaje.fortaleza = 14;
                            personaje.refejos = 15;
                            personaje.voluntad = 12;
                            personaje.puntos_de_golpe = 23;
                            personaje.ca = 16;
                            //armadura
                            personaje.armadura = "cuero";
                            //Habilidades
                            personaje.atletismo = 8;
                            personaje.resistencia = 2;
                            personaje.sanar = 2;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 9;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 7;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 9;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 9;
                            personaje.religion = 2;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Guerrero":
                            personaje.Informacion = "Hazañas a voluntad: Marea de hendidura de hierro\r\nNivel 1 diario: Amenaza del villano\r\nEncuentro de nivel 1: Ataque de cobertura  ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 18;
                            personaje.contitucion = 10;
                            personaje.destreza = 16;
                            personaje.inteligencia = 10;
                            personaje.sabiduria = 13;
                            personaje.carisma = 8;
                            //Defensas
                            personaje.fortaleza = 16;
                            personaje.refejos = 13;
                            personaje.voluntad = 11;
                            personaje.puntos_de_golpe = 26;
                            personaje.ca = 19;
                            //armadura
                            personaje.armadura = "cota de malla";
                            //Habilidades
                            personaje.atletismo = 9;
                            personaje.resistencia = 2;
                            personaje.sanar = 6;
                            personaje.intimidar = 4;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 2;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Mago":
                            personaje.Informacion = "Hechizos a voluntad:    \r\nEvocaciones a voluntad: Magic Missile Thunderwave\r\nNivel 1 diario: flecha ácida\r\nEncuentro de nivel 1: orbe de fuerza ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 10;
                            personaje.contitucion = 11;
                            personaje.destreza = 16;
                            personaje.inteligencia = 17;
                            personaje.sabiduria = 14;
                            personaje.carisma = 10;
                            //Defensas
                            personaje.fortaleza = 10;
                            personaje.refejos = 13;
                            personaje.voluntad = 14;
                            personaje.puntos_de_golpe = 21;
                            personaje.ca = 13;
                            //armadura
                            personaje.armadura = "tela";
                            //Habilidades
                            personaje.atletismo = 2;
                            personaje.resistencia = 2;
                            personaje.sanar = 2;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 8;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 8;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 7;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 8;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Paladin":
                            personaje.Informacion = " Oraciones a voluntad: Golpe sagrado Golpe reforzador\r\nNivel 1 diario: bajo pena de muerte\r\nEncuentro de nivel 1: Golpe temible ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 14;
                            personaje.contitucion = 12;
                            personaje.destreza = 13;
                            personaje.inteligencia = 8;
                            personaje.sabiduria = 16;
                            personaje.carisma = 16;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 12;
                            personaje.voluntad = 14;
                            personaje.puntos_de_golpe = 27;
                            personaje.ca = 19;
                            //armadura
                            personaje.armadura = "placas";
                            //Habilidades
                            personaje.atletismo = 2;
                            personaje.resistencia = 2;
                            personaje.sanar = 8;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 8;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 8;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 4;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Picaro":
                            personaje.Informacion = " Hazañas a voluntad: Golpe perforante Golpe de respuesta\r\nNivel 1 diario: objetivo fácil\r\nEncuentro de nivel 1: Golpe tortuoso ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 16;
                            personaje.contitucion = 10;
                            personaje.destreza = 18;
                            personaje.inteligencia = 10;
                            personaje.sabiduria = 12;
                            personaje.carisma = 11;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 16;
                            personaje.voluntad = 11;
                            personaje.puntos_de_golpe = 22;
                            personaje.ca = 16;
                            //armadura
                            personaje.armadura = "cuero";
                            //Habilidades
                            personaje.atletismo = 8;
                            personaje.resistencia = 2;
                            personaje.sanar = 2;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 9;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 6;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 6;
                            personaje.recursos = 2;
                            personaje.sigilo = 9;
                            personaje.religion = 2;
                            personaje.hurto = 9;
                            return personaje;
                            break;
                        case "Señor de la guerra":
                            personaje.Informacion = "Hazañas a voluntad: Golpe del comandante Golpe de la víbora\r\nNivel 1 diario: liderar el ataque\r\nEncuentro de nivel 1: Ataque de guardia ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 14;
                            personaje.contitucion = 12;
                            personaje.destreza = 13;
                            personaje.inteligencia = 14;
                            personaje.sabiduria = 14;
                            personaje.carisma = 14;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 12;
                            personaje.voluntad = 13;
                            personaje.puntos_de_golpe = 24;
                            personaje.ca = 17;
                            //armadura
                            personaje.armadura = "cota de mallla";
                            //Habilidades
                            personaje.atletismo = 7;
                            personaje.resistencia = 0;
                            personaje.sanar = 7;
                            personaje.intimidar = 0;
                            personaje.acrobacias = 0;
                            personaje.aguante = 0;
                            personaje.arcanos = 0;
                            personaje.diplomacia = 7;
                            personaje.dungeos = 0;
                            personaje.engañar = 0;
                            personaje.historia = 7;
                            personaje.naturaleza = 0;
                            personaje.percepcion = 0;
                            personaje.perpicacia = 0;
                            personaje.recursos = 0;
                            personaje.sigilo = 0;
                            personaje.religion = 0;
                            personaje.hurto = 0;
                            return personaje;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Mediano":
                    switch (clase)
                    {
                        case "Brujo":
                            personaje.Informacion = "Hechizos a voluntad:    \r\nEvocaciones a voluntad: Eldritch Blast Eyebite Hellish Rebuke\r\nNivel 1 diario: maldición del sueño oscuro\r\nEncuentro de nivel 1: Abrazo vampírico  ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 10;
                            personaje.contitucion = 12;
                            personaje.destreza = 10;
                            personaje.inteligencia = 17;
                            personaje.sabiduria = 13;
                            personaje.carisma = 14;
                            //Defensas
                            personaje.fortaleza = 12;
                            personaje.refejos = 15;
                            personaje.voluntad = 14;
                            personaje.puntos_de_golpe = 14;
                            personaje.ca = 14;
                            //armadura
                            personaje.armadura = "cuero";
                            //Habilidades
                            personaje.atletismo = 0;
                            personaje.resistencia = 0;
                            personaje.sanar = 0;
                            personaje.intimidar = 0;
                            personaje.acrobacias = 0;
                            personaje.aguante = 0;
                            personaje.arcanos = 8;
                            personaje.diplomacia = 0;
                            personaje.dungeos = 0;
                            personaje.engañar = 7;
                            personaje.historia = 8;
                            personaje.naturaleza = 0;
                            personaje.percepcion = 0;
                            personaje.perpicacia = 0;
                            personaje.recursos = 0;
                            personaje.sigilo = 0;
                            personaje.religion = 8;
                            personaje.hurto = 5;
                            return personaje;
                            break;
                        case "Clerigo":
                            personaje.Informacion = " \r\nOraciones a voluntad: Escudo del sacerdote de la marca justiciera Lanza de la fe\r\nNivel 1 diario: guardián de la fe\r\nEncuentro de nivel 1: causar miedo ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 14;
                            personaje.contitucion = 12;
                            personaje.destreza = 11;
                            personaje.inteligencia = 12;
                            personaje.sabiduria = 16;
                            personaje.carisma = 14;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 12;
                            personaje.voluntad = 16;
                            personaje.puntos_de_golpe = 24;
                            personaje.ca = 16;
                            //armadura
                            personaje.armadura = "cota de malla";
                            //Habilidades
                            personaje.atletismo = 2;
                            personaje.resistencia = 2;
                            personaje.sanar = 8;
                            personaje.intimidar = 0;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 7;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 6;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 6;
                            personaje.hurto = 0;
                            return personaje;
                            break;
                        case "Explorador":
                            personaje.Informacion = "Hazañas a voluntad: Ataque cuidadoso Ataque doble\r\nNivel 1 diario: Dividir el árbol\r\nEncuentro de nivel 1: Fox's Astucia  ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 16;
                            personaje.contitucion = 11;
                            personaje.destreza = 18;
                            personaje.inteligencia = 10;
                            personaje.sabiduria = 14;
                            personaje.carisma = 9;
                            //Defensas
                            personaje.fortaleza = 14;
                            personaje.refejos = 15;
                            personaje.voluntad = 12;
                            personaje.puntos_de_golpe = 23;
                            personaje.ca = 16;
                            //armadura
                            personaje.armadura = "cuero";
                            //Habilidades
                            personaje.atletismo = 8;
                            personaje.resistencia = 2;
                            personaje.sanar = 2;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 9;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 7;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 9;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 9;
                            personaje.religion = 2;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Guerrero":
                            personaje.Informacion = "Hazañas a voluntad: Marea de hendidura de hierro\r\nNivel 1 diario: Amenaza del villano\r\nEncuentro de nivel 1: Ataque de cobertura  ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 18;
                            personaje.contitucion = 10;
                            personaje.destreza = 16;
                            personaje.inteligencia = 10;
                            personaje.sabiduria = 13;
                            personaje.carisma = 8;
                            //Defensas
                            personaje.fortaleza = 16;
                            personaje.refejos = 13;
                            personaje.voluntad = 11;
                            personaje.puntos_de_golpe = 26;
                            personaje.ca = 19;
                            //armadura
                            personaje.armadura = "cota de malla";
                            //Habilidades
                            personaje.atletismo = 9;
                            personaje.resistencia = 2;
                            personaje.sanar = 6;
                            personaje.intimidar = 4;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 2;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Mago":
                            personaje.Informacion = "Hechizos a voluntad:    \r\nEvocaciones a voluntad: Magic Missile Thunderwave\r\nNivel 1 diario: flecha ácida\r\nEncuentro de nivel 1: orbe de fuerza ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 10;
                            personaje.contitucion = 11;
                            personaje.destreza = 16;
                            personaje.inteligencia = 17;
                            personaje.sabiduria = 14;
                            personaje.carisma = 10;
                            //Defensas
                            personaje.fortaleza = 10;
                            personaje.refejos = 13;
                            personaje.voluntad = 14;
                            personaje.puntos_de_golpe = 21;
                            personaje.ca = 13;
                            //armadura
                            personaje.armadura = "tela";
                            //Habilidades
                            personaje.atletismo = 2;
                            personaje.resistencia = 2;
                            personaje.sanar = 2;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 8;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 8;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 7;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 8;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Paladin":
                            personaje.Informacion = " Oraciones a voluntad: Golpe sagrado Golpe reforzador\r\nNivel 1 diario: bajo pena de muerte\r\nEncuentro de nivel 1: Golpe temible ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 14;
                            personaje.contitucion = 12;
                            personaje.destreza = 13;
                            personaje.inteligencia = 8;
                            personaje.sabiduria = 16;
                            personaje.carisma = 16;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 12;
                            personaje.voluntad = 14;
                            personaje.puntos_de_golpe = 27;
                            personaje.ca = 19;
                            //armadura
                            personaje.armadura = "placas";
                            //Habilidades
                            personaje.atletismo = 2;
                            personaje.resistencia = 2;
                            personaje.sanar = 8;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 8;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 8;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 4;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Picaro":
                            personaje.Informacion = " Hazañas a voluntad: Golpe perforante Golpe de respuesta\r\nNivel 1 diario: objetivo fácil\r\nEncuentro de nivel 1: Golpe tortuoso ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 16;
                            personaje.contitucion = 10;
                            personaje.destreza = 18;
                            personaje.inteligencia = 10;
                            personaje.sabiduria = 12;
                            personaje.carisma = 11;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 16;
                            personaje.voluntad = 11;
                            personaje.puntos_de_golpe = 22;
                            personaje.ca = 16;
                            //armadura
                            personaje.armadura = "cuero";
                            //Habilidades
                            personaje.atletismo = 8;
                            personaje.resistencia = 2;
                            personaje.sanar = 2;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 9;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 6;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 6;
                            personaje.recursos = 2;
                            personaje.sigilo = 9;
                            personaje.religion = 2;
                            personaje.hurto = 9;
                            return personaje;
                            break;
                        case "Señor de la guerra":
                            personaje.Informacion = "Hazañas a voluntad: Golpe del comandante Golpe de la víbora\r\nNivel 1 diario: liderar el ataque\r\nEncuentro de nivel 1: Ataque de guardia ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 14;
                            personaje.contitucion = 12;
                            personaje.destreza = 13;
                            personaje.inteligencia = 14;
                            personaje.sabiduria = 14;
                            personaje.carisma = 14;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 12;
                            personaje.voluntad = 13;
                            personaje.puntos_de_golpe = 24;
                            personaje.ca = 17;
                            //armadura
                            personaje.armadura = "cota de mallla";
                            //Habilidades
                            personaje.atletismo = 7;
                            personaje.resistencia = 0;
                            personaje.sanar = 7;
                            personaje.intimidar = 0;
                            personaje.acrobacias = 0;
                            personaje.aguante = 0;
                            personaje.arcanos = 0;
                            personaje.diplomacia = 7;
                            personaje.dungeos = 0;
                            personaje.engañar = 0;
                            personaje.historia = 7;
                            personaje.naturaleza = 0;
                            personaje.percepcion = 0;
                            personaje.perpicacia = 0;
                            personaje.recursos = 0;
                            personaje.sigilo = 0;
                            personaje.religion = 0;
                            personaje.hurto = 0;
                            return personaje;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Tiflin":
                    switch (clase)
                    {
                        case "Brujo":
                            personaje.Informacion = "Hechizos a voluntad:    \r\nEvocaciones a voluntad: Eldritch Blast Eyebite Hellish Rebuke\r\nNivel 1 diario: maldición del sueño oscuro\r\nEncuentro de nivel 1: Abrazo vampírico  ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 10;
                            personaje.contitucion = 12;
                            personaje.destreza = 10;
                            personaje.inteligencia = 17;
                            personaje.sabiduria = 13;
                            personaje.carisma = 14;
                            //Defensas
                            personaje.fortaleza = 12;
                            personaje.refejos = 15;
                            personaje.voluntad = 14;
                            personaje.puntos_de_golpe = 14;
                            personaje.ca = 14;
                            //armadura
                            personaje.armadura = "cuero";
                            //Habilidades
                            personaje.atletismo = 0;
                            personaje.resistencia = 0;
                            personaje.sanar = 0;
                            personaje.intimidar = 0;
                            personaje.acrobacias = 0;
                            personaje.aguante = 0;
                            personaje.arcanos = 8;
                            personaje.diplomacia = 0;
                            personaje.dungeos = 0;
                            personaje.engañar = 7;
                            personaje.historia = 8;
                            personaje.naturaleza = 0;
                            personaje.percepcion = 0;
                            personaje.perpicacia = 0;
                            personaje.recursos = 0;
                            personaje.sigilo = 0;
                            personaje.religion = 8;
                            personaje.hurto = 5;
                            return personaje;
                            break;
                        case "Clerigo":
                            personaje.Informacion = " \r\nOraciones a voluntad: Escudo del sacerdote de la marca justiciera Lanza de la fe\r\nNivel 1 diario: guardián de la fe\r\nEncuentro de nivel 1: causar miedo ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 14;
                            personaje.contitucion = 12;
                            personaje.destreza = 11;
                            personaje.inteligencia = 12;
                            personaje.sabiduria = 16;
                            personaje.carisma = 14;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 12;
                            personaje.voluntad = 16;
                            personaje.puntos_de_golpe = 24;
                            personaje.ca = 16;
                            //armadura
                            personaje.armadura = "cota de malla";
                            //Habilidades
                            personaje.atletismo = 2;
                            personaje.resistencia = 2;
                            personaje.sanar = 8;
                            personaje.intimidar = 0;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 7;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 6;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 6;
                            personaje.hurto = 0;
                            return personaje;
                            break;
                        case "Explorador":
                            personaje.Informacion = "Hazañas a voluntad: Ataque cuidadoso Ataque doble\r\nNivel 1 diario: Dividir el árbol\r\nEncuentro de nivel 1: Fox's Astucia  ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 16;
                            personaje.contitucion = 11;
                            personaje.destreza = 18;
                            personaje.inteligencia = 10;
                            personaje.sabiduria = 14;
                            personaje.carisma = 9;
                            //Defensas
                            personaje.fortaleza = 14;
                            personaje.refejos = 15;
                            personaje.voluntad = 12;
                            personaje.puntos_de_golpe = 23;
                            personaje.ca = 16;
                            //armadura
                            personaje.armadura = "cuero";
                            //Habilidades
                            personaje.atletismo = 8;
                            personaje.resistencia = 2;
                            personaje.sanar = 2;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 9;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 7;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 9;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 9;
                            personaje.religion = 2;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Guerrero":
                            personaje.Informacion = "Hazañas a voluntad: Marea de hendidura de hierro\r\nNivel 1 diario: Amenaza del villano\r\nEncuentro de nivel 1: Ataque de cobertura  ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 18;
                            personaje.contitucion = 10;
                            personaje.destreza = 16;
                            personaje.inteligencia = 10;
                            personaje.sabiduria = 13;
                            personaje.carisma = 8;
                            //Defensas
                            personaje.fortaleza = 16;
                            personaje.refejos = 13;
                            personaje.voluntad = 11;
                            personaje.puntos_de_golpe = 26;
                            personaje.ca = 19;
                            //armadura
                            personaje.armadura = "cota de malla";
                            //Habilidades
                            personaje.atletismo = 9;
                            personaje.resistencia = 2;
                            personaje.sanar = 6;
                            personaje.intimidar = 4;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 2;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 2;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Mago":
                            personaje.Informacion = "Hechizos a voluntad:    \r\nEvocaciones a voluntad: Magic Missile Thunderwave\r\nNivel 1 diario: flecha ácida\r\nEncuentro de nivel 1: orbe de fuerza ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 10;
                            personaje.contitucion = 11;
                            personaje.destreza = 16;
                            personaje.inteligencia = 17;
                            personaje.sabiduria = 14;
                            personaje.carisma = 10;
                            //Defensas
                            personaje.fortaleza = 10;
                            personaje.refejos = 13;
                            personaje.voluntad = 14;
                            personaje.puntos_de_golpe = 21;
                            personaje.ca = 13;
                            //armadura
                            personaje.armadura = "tela";
                            //Habilidades
                            personaje.atletismo = 2;
                            personaje.resistencia = 2;
                            personaje.sanar = 2;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 8;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 8;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 7;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 8;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Paladin":
                            personaje.Informacion = " Oraciones a voluntad: Golpe sagrado Golpe reforzador\r\nNivel 1 diario: bajo pena de muerte\r\nEncuentro de nivel 1: Golpe temible ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 14;
                            personaje.contitucion = 12;
                            personaje.destreza = 13;
                            personaje.inteligencia = 8;
                            personaje.sabiduria = 16;
                            personaje.carisma = 16;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 12;
                            personaje.voluntad = 14;
                            personaje.puntos_de_golpe = 27;
                            personaje.ca = 19;
                            //armadura
                            personaje.armadura = "placas";
                            //Habilidades
                            personaje.atletismo = 2;
                            personaje.resistencia = 2;
                            personaje.sanar = 8;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 2;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 8;
                            personaje.dungeos = 2;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 8;
                            personaje.recursos = 2;
                            personaje.sigilo = 2;
                            personaje.religion = 4;
                            personaje.hurto = 2;
                            return personaje;
                            break;
                        case "Picaro":
                            personaje.Informacion = " Hazañas a voluntad: Golpe perforante Golpe de respuesta\r\nNivel 1 diario: objetivo fácil\r\nEncuentro de nivel 1: Golpe tortuoso ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 16;
                            personaje.contitucion = 10;
                            personaje.destreza = 18;
                            personaje.inteligencia = 10;
                            personaje.sabiduria = 12;
                            personaje.carisma = 11;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 16;
                            personaje.voluntad = 11;
                            personaje.puntos_de_golpe = 22;
                            personaje.ca = 16;
                            //armadura
                            personaje.armadura = "cuero";
                            //Habilidades
                            personaje.atletismo = 8;
                            personaje.resistencia = 2;
                            personaje.sanar = 2;
                            personaje.intimidar = 2;
                            personaje.acrobacias = 9;
                            personaje.aguante = 2;
                            personaje.arcanos = 2;
                            personaje.diplomacia = 2;
                            personaje.dungeos = 6;
                            personaje.engañar = 2;
                            personaje.historia = 2;
                            personaje.naturaleza = 2;
                            personaje.percepcion = 2;
                            personaje.perpicacia = 6;
                            personaje.recursos = 2;
                            personaje.sigilo = 9;
                            personaje.religion = 2;
                            personaje.hurto = 9;
                            return personaje;
                            break;
                        case "Señor de la guerra":
                            personaje.Informacion = "Hazañas a voluntad: Golpe del comandante Golpe de la víbora\r\nNivel 1 diario: liderar el ataque\r\nEncuentro de nivel 1: Ataque de guardia ";
                            //Puntuacion de caracteristicas
                            personaje.Fuerza = 14;
                            personaje.contitucion = 12;
                            personaje.destreza = 13;
                            personaje.inteligencia = 14;
                            personaje.sabiduria = 14;
                            personaje.carisma = 14;
                            //Defensas
                            personaje.fortaleza = 13;
                            personaje.refejos = 12;
                            personaje.voluntad = 13;
                            personaje.puntos_de_golpe = 24;
                            personaje.ca = 17;
                            //armadura
                            personaje.armadura = "cota de mallla";
                            //Habilidades
                            personaje.atletismo = 7;
                            personaje.resistencia = 0;
                            personaje.sanar = 7;
                            personaje.intimidar = 0;
                            personaje.acrobacias = 0;
                            personaje.aguante = 0;
                            personaje.arcanos = 0;
                            personaje.diplomacia = 7;
                            personaje.dungeos = 0;
                            personaje.engañar = 0;
                            personaje.historia = 7;
                            personaje.naturaleza = 0;
                            personaje.percepcion = 0;
                            personaje.perpicacia = 0;
                            personaje.recursos = 0;
                            personaje.sigilo = 0;
                            personaje.religion = 0;
                            personaje.hurto = 0;
                            return personaje;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            return personaje;
        }

    
        
    }
    
}
