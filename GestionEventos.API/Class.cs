namespace GestionEventos.API;

public class ProgramaEvento
{
    // Propiedades
    public string NombreEvento { get; set; }

    // Constructor
    public ProgramaEvento(string nombreEvento)
    {
        NombreEvento = nombreEvento;
    }

}
