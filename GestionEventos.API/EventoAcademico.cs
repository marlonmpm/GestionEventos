namespace GestionEventos.API
{
    public class EventoAcademico
    {
        // Atributos
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        public string Ubicacion { get; set; }
        public string Descripcion { get; set; }
        public string Tema { get; set; }

        // Constructor
        public EventoAcademico(string nombre, DateTime fechaInicio, DateTime fechaFinalizacion, string ubicacion, string descripcion, string tema)
        {
            Nombre = nombre;
            FechaInicio = fechaInicio;
            FechaFinalizacion = fechaFinalizacion;
            Ubicacion = ubicacion;
            Descripcion = descripcion;
            Tema = tema;
        }
    }
}
