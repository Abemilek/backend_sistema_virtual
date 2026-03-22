namespace WebApi.Modelo
{
    public class Asistencia
    {
        public int AsistenciaId { get; set; }
        public int EstudianteId { get; set; }
        public int SesionId { get; set; }
        public int TipoAsistenciaId { get; set; }
        public string Observacion { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }

}
