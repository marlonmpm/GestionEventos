namespace GestionEventos.API.Entities
{
    public class Participantes
    {
        // Atributos
        public string Nombre { get; set; }
        public string AfiliacionInstitucional { get; set; }
        public string AreaDeInteres { get; set; }
        public string TipoDeParticipacion { get; set; }

        // Constructor
        public Participantes(string nombre, string afiliacion, string area, string tipo)
        {
            Nombre = nombre;
            AfiliacionInstitucional = afiliacion;
            AreaDeInteres = area;
            TipoDeParticipacion = tipo;
        }
    }
}
