using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Modelo 
{
    //[Serializable()]
    public class Jugador 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Posicion { get; }
        public Jugador Capitan { get; set; }
        public DateTime FechaAlta { get; set; }
        public int Salario { get; set; }
        public Equipo Equipo { get; set; }
        public double Altura { get; set; }

        public Jugador()
        {

        }

        private Jugador(int id, string nombre, string apellido, string posicion, Jugador capitan, DateTime fechaAlta, int salario, Equipo equipo, double altura)
            : this (id,nombre,apellido,posicion,fechaAlta,salario,equipo,altura)
        {
            Capitan = capitan;
        }

        private Jugador(int id, string nombre, string apellido, string posicion, DateTime fechaAlta, int salario, Equipo equipo, double altura)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Posicion = posicion;
            Capitan = this;
            FechaAlta = fechaAlta;
            Salario = salario;
            Equipo = equipo;
            Altura = altura;
        }

        public static Jugador CreateJugador(int id, string nombre, string apellido, string posicion, Jugador capitan, DateTime fechaAlta, int salario, Equipo equipo, double altura)
        {

            return new Jugador(id, nombre, apellido, posicion, capitan, fechaAlta, salario, equipo, altura);
        }

        public static Jugador CreateJugador(int id, string nombre, string apellido, string posicion, DateTime fechaAlta, int salario, Equipo equipo, double altura)
        {

            return new Jugador(id, nombre, apellido, posicion,  fechaAlta, salario, equipo, altura);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("ID: {0} Nombre: {1} Apellidos: {2} Posición: {3} " 
                + " FechaAlta: {4} Salario: {5} Equipo: {6} Altura: {7}" ,Id,Nombre,Apellido,Posicion,
                FechaAlta,Salario,null!=Equipo?Equipo.Nombre:"Ninguno",Altura);
            return sb.ToString();
        }

       /* public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("Nombre", Nombre);
            info.AddValue("Apellido", Apellido);
            info.AddValue("Posicion", Posicion);
            info.AddValue("Capitan", Capitan);
            info.AddValue("FechaAlta", FechaAlta);
            info.AddValue("Salario", Salario);
            info.AddValue("Equipo", Equipo);
            info.AddValue("Altura", Altura);
        }

        public Jugador(SerializationInfo info, StreamingContext context)
        {
            Id = (int)info.GetValue("Id", typeof(int));
            Nombre = (string)info.GetValue("Nombre", typeof(string));
            Apellido = (string)info.GetValue("Apellido", typeof(string));
            Posicion = (string)info.GetValue("Posicion", typeof(string));
            Capitan = (Jugador)info.GetValue("Capitan", typeof(Jugador));
            FechaAlta = (DateTime)info.GetValue("FechaAlta", typeof(DateTime));
            Salario = (int)info.GetValue("Salario", typeof(int));
            Equipo = (Equipo)info.GetValue("Equipo", typeof(Equipo));
            Altura = (double)info.GetValue("Altura", typeof(double));
        }*/
    }
}
