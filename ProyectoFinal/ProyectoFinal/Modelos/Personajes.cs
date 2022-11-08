using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Modelos
{
    class Personajes
    {
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

        Personajes crearPersonaje(string raza, string clase)
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
                            break;
                        case "Clerigo":
                            break;
                        case "Explorador":
                            break;
                        case "Guerrero":
                            //HUMANO GUERERO
                            personaje.Informacion = "";
                            //Puntuacion de caracteristicas
                            personaje.fuerza = 16;
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
                            return personaje;
                            break;
                        case "Mago":
                            break;
                        case "Paladin":
                            break;
                        case "Picaro":
                            break;
                        case "Señor de la guerra":
                            break;
                        default:
                            break;
                    }
                    break;
                case "Elfo":
                    switch (clase)
                    {
                        case "Brujo":
                            break;
                        case "Clerigo":
                            break;
                        case "Explorador":
                            break;
                        case "Guerrero":
                            break;
                        case "Mago":
                            break;
                        case "Paladin":
                            break;
                        case "Picaro":
                            break;
                        case "Señor de la guerra":
                            break;
                        default:
                            break;
                    }
                    break;
                case "Enano":
                    switch (clase)
                    {
                        case "Brujo":
                            break;
                        case "Clerigo":
                            break;
                        case "Explorador":
                            break;
                        case "Guerrero":
                            break;
                        case "Mago":
                            break;
                        case "Paladin":
                            break;
                        case "Picaro":
                            break;
                        case "Señor de la guerra":
                            break;
                        default:
                            break;
                    }
                    break;
                case "Eladrines":
                    switch (clase)
                    {
                        case "Brujo":
                            break;
                        case "Clerigo":
                            break;
                        case "Explorador":
                            break;
                        case "Guerrero":
                            break;
                        case "Mago":
                            break;
                        case "Paladin":
                            break;
                        case "Picaro":
                            break;
                        case "Señor de la guerra":
                            break;
                        default:
                            break;
                    }
                    break;
                case "Draconidos":
                    switch (clase)
                    {
                        case "Brujo":
                            break;
                        case "Clerigo":
                            break;
                        case "Explorador":
                            break;
                        case "Guerrero":
                            break;
                        case "Mago":
                            break;
                        case "Paladin":
                            break;
                        case "Picaro":
                            break;
                        case "Señor de la guerra":
                            break;
                        default:
                            break;
                    }
                    break;
                case "Semielfo":
                    switch (clase)
                    {
                        case "Brujo":
                            break;
                        case "Clerigo":
                            break;
                        case "Explorador":
                            break;
                        case "Guerrero":
                            break;
                        case "Mago":
                            break;
                        case "Paladin":
                            break;
                        case "Picaro":
                            break;
                        case "Señor de la guerra":
                            break;
                        default:
                            break;
                    }
                    break;
                case "Mediano":
                    switch (clase)
                    {
                        case "Brujo":
                            break;
                        case "Clerigo":
                            break;
                        case "Explorador":
                            break;
                        case "Guerrero":
                            break;
                        case "Mago":
                            break;
                        case "Paladin":
                            break;
                        case "Picaro":
                            break;
                        case "Señor de la guerra":
                            break;
                        default:
                            break;
                    }
                    break;
                case "Tiflin":
                    switch (clase)
                    {
                        case "Brujo":
                            break;
                        case "Clerigo":
                            break;
                        case "Explorador":
                            break;
                        case "Guerrero":
                            break;
                        case "Mago":
                            break;
                        case "Paladin":
                            break;
                        case "Picaro":
                            break;
                        case "Señor de la guerra":
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
