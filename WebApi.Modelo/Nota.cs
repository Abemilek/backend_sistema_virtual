namespace WebApi.Modelo
{
    public class Nota
    {
        public int NotaId { get; set; }
        public int EvaluacionId { get; set; }
        public int EstudianteId { get; set; }
        public decimal PuntajeObtenido { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
        public string ComentarioDocente { get; set; }
    }

}
