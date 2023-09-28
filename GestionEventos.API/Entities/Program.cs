namespace GestionEventos.API.Entities
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Crear una instancia de ProgramaEvento
            ProgramaEvento miEvento = new ProgramaEvento();

            // Configurar los detalles del evento
            miEvento.NombreEvento = "Comic Con";
            miEvento.FechaInicio = new DateTime(2023, 10, 15);
            miEvento.FechaFinalizacion = new DateTime(2023, 10, 17);
            miEvento.Ubicacion = "Medellin";
            miEvento.Descripcion = "Un festival geek sobre Anime/Manga y cultura Asiatica en general";

            // Agregar sesiones al evento
            miEvento.AgregarSesion(new Sesion("Sesión 1", new DateTime(2023, 10, 15, 9, 0, 0), new DateTime(2023, 10, 15, 10, 30, 0), "Evanna Lynch ", "Harry Potter"));
            miEvento.AgregarSesion(new Sesion("Sesión 2", new DateTime(2023, 10, 15, 11, 0, 0), new DateTime(2023, 10, 15, 12, 30, 0), "Mario Castañeda", "La voz de Goku"));

            // Mostrar el programa del evento
            Console.WriteLine("Programa del Evento: " + miEvento.NombreEvento);
            foreach (var sesion in miEvento.Sesiones)
            {
                Console.WriteLine("Sesión: " + sesion.NombreSesion);
                Console.WriteLine("Hora de Inicio: " + sesion.HoraInicio.ToShortTimeString()); //Conversion de dato a ShorTime
                Console.WriteLine("Hora de Finalización: " + sesion.HoraFinalizacion.ToShortTimeString());// Conversion de dato a ShorTime
                Console.WriteLine("Ponente: " + sesion.Ponente);
                Console.WriteLine("Tema: " + sesion.Tema);
                Console.WriteLine();
            }
        }
    }
}