using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
namespace Modelo
{
    //[Serializable()]
    public class Partido
    {
        public int Id { get; set; }
        public Equipo Local { get; set; }
        public Equipo Visitante { get; set; }
        public string Resultado { get; set; }
        public DateTime Fecha { get; set; }
        public string Arbitro { get; set; }

        private Partido(int id, Equipo local, Equipo visitante, string resultado, DateTime fecha, string arbitro)
        {
            Id = id;
            Local = local;
            Visitante = visitante;
            Resultado = resultado;
            Fecha = fecha;
            Arbitro = arbitro;
        }

        public Partido()
        {

        }

        public static Partido CreatePartido(int id, Equipo local, Equipo visitante, string resultado, DateTime fecha, string arbitro)
        {
            return new Partido(id, local, visitante, resultado, fecha, arbitro);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("ID: {0}",Id);
            sb.AppendFormat(" Equipo Local: {0}", Local != null ? Local.Nombre : "---");
            sb.AppendFormat(" Equipo Visitante: {0}", Visitante != null ? Visitante.Nombre : "---");
            sb.AppendFormat(" Resultado: {0}", Resultado);
            sb.AppendFormat(" Fecha: {0}", Fecha);
            sb.AppendFormat(" Arbitro: {0}", Arbitro);

            return sb.ToString();
        }

        /*public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("Local", Local);
            info.AddValue("Visitante", Visitante);
            info.AddValue("Resultado", Resultado);
            info.AddValue("Fecha", Fecha);
            info.AddValue("Arbitro", Arbitro);
        }

        public Partido(SerializationInfo info, StreamingContext context)
        {
            Id = (int)info.GetValue("Id", typeof(int));
            Local = (Equipo)info.GetValue("Local", typeof(Equipo));
            Visitante = (Equipo)info.GetValue("Visitante", typeof(Equipo));
            Resultado = (string)info.GetValue("Resultado", typeof(string));
            Fecha = (DateTime)info.GetValue("Fecha", typeof(DateTime));
            Arbitro = (string)info.GetValue("Arbitro", typeof(string));
        }*/
    }
}
