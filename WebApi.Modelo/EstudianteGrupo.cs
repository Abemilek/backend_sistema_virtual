namespace WebApi.Modelo
{
    public class EstudianteGrupo
    {
        public int EstudianteGrupoId { get; set; }
        public int EstudianteId { get; set; }
        public int GrupoId { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
        public DateTime? FechaRetiro { get; set; }
        public bool Estado { get; set; } = true;
    }
}
