namespace WebApi.Modelo
{
    public class Docente
    {
        public int DocenteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Especialidad { get; set; }
        public bool Estado { get; set; } = true;

    }
}
