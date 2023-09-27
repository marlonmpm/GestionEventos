using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionEventos.API.Entities
{
//    Evento Académico: Representa un evento específico, como una conferencia o simposio.Debe
//contener atributos como nombre del evento, fecha de inicio y finalización, ubicación,
//descripción y tema del evento
    public class Academico
    {
        public string nombreEvento, ubicacion, descripcion, temaEvento;
        public DateTime fechaInicio,fechaFinalizacion;


        public Academico(string nombreEventoAp,string ubicacionAp, string descripcionAp, 
            string temaEventoAp, DateTime fechaInicioAp, DateTime fechaFinalizacionAp)
        {
            this.nombreEvento = nombreEventoAp;
            this.ubicacion = ubicacionAp;
            this.descripcion = descripcionAp;
            this.temaEvento = temaEventoAp;
            this.fechaInicio = fechaInicioAp;
            this.fechaFinalizacion = fechaFinalizacionAp;
        }

        public override string ToString()
        {
            string mensaje;
            mensaje = "\nInformacion del Evento Academico. Conferencia o simposio : " 
                + "\nNombre del evento" + nombreEvento +
                "\nUbicacion del evento: " + ubicacion + "\nDescripcion del evento: " + descripcion +
                "\nTema del evento: " + temaEvento + "\nFecha de inicio del evento: " + fechaInicio +
                "\nFecha de cierre del evento: " + fechaFinalizacion;

            return mensaje;
        }

    }
}
