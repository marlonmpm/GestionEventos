namespace GestionEventos.API
{
    public class Sesion
    {
        public string NombreSesion { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFinalizacion { get; set; }
        public string Ponente { get; set; }
        public string Tema { get; set; }

        // Constructor de Sesion
        public Sesion(string nombreSesion, DateTime horaInicio, DateTime horaFinalizacion, string ponente, string tema)
        {
            NombreSesion = nombreSesion;
            HoraInicio = horaInicio;
            HoraFinalizacion = horaFinalizacion;
            Ponente = ponente;
            Tema = tema;
        }
    }
}
