namespace WebApi.Modelo
{
    public class MaterialCurso
    {
        public int MaterialId { get; set; }
        public int GrupoAsignaturaId { get; set; }
        public string Titulo { get; set; }
        public string LinkRecurso { get; set; }
        public string TipoRecurso { get; set; }
        public DateTime FechaSubida { get; set; } = DateTime.Now;
    }
}
