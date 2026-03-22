namespace WebApi.Modelo
{
    public class Evaluacion
    {
        public int EvaluacionId { get; set; }
        public int GrupoAsignaturaId { get; set; }
        public int TipoEvaluacionId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaEntrega { get; set; }
        public decimal PuntajeMaximo { get; set; }
        public decimal PesoPorcentual { get; set; }
    }
}
