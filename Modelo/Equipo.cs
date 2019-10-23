using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
namespace Modelo
{
    //[Serializable()]
    public class Equipo 
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Web { get; set; }
        public int Puntos { get; set; }
        [XmlIgnore]
        public List<Jugador> Jugadores { get; set; }

        public Equipo()
        {

        }

        public static Equipo CreateEquipo(int id, string nombre, string ciudad, string web, int puntos)
        {

            return new Equipo(id, nombre, ciudad, web, puntos);
        }

     
        override public string ToString()
        {
            return "ID= " + ID + " Nom: " + Nombre + " Ciudad: " + Ciudad + " Puntos " + Puntos;
        }

        private Equipo(int id, string nombre, string ciudad, string web, int puntos) : this()
        {
            ID = id;
            Nombre = nombre;
            Ciudad = ciudad;
            Web = web;
            Puntos = puntos;
            Jugadores = new List<Jugador>();
        }
        
        /*public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ID", ID);
            info.AddValue("Nombre", Nombre);
            info.AddValue("Ciudad", Ciudad);
            info.AddValue("Web", Web);
            info.AddValue("Puntos", Puntos);
            info.AddValue("Jugadores", Jugadores);
        }

        public Equipo(SerializationInfo info, StreamingContext context)
        {
            ID = (int)info.GetValue("ID", typeof(int));
            Nombre = (string)info.GetValue("Nombre", typeof(string));
            Ciudad = (string)info.GetValue("Ciudad", typeof(string));
            Web = (string)info.GetValue("Web", typeof(string));
            Puntos = (int)info.GetValue("Puntos", typeof(int));
            Jugadores = (List<Jugador>)info.GetValue("Jugadores", typeof(List<Jugador>));
        }*/

    }
}
