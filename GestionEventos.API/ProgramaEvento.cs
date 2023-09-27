namespace GestionEventos.API;
using System.Collections.Generic;

public class ProgramaEvento
{
    // Atribtutos
    public int Id { get; set; } // PK
    public string NombreEvento { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFinalizacion { get; set; }
    public string Ubicacion { get; set; }
    public string Descripcion { get; set; }
    public string Tema { get; set; }
    public List<Sesion> Sesiones { get; set; }  //Lista que va a contener las sesiones

    // Constructor
    public ProgramaEvento()
    {
        Sesiones = new List<Sesion>();
    }

    // Método para agregar una sesión al programa
    public void AgregarSesion(Sesion sesion)
    {
        Sesiones.Add(sesion);
    }
}