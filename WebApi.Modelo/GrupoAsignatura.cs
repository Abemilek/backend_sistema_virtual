namespace WebApi.Modelo
{
    public class GrupoAsignatura
    {
        public int GrupoAsignaturaId { get; set; }
        public int GrupoId { get; set; }
        public int AsignaturaId { get; set; }
        public int DocenteId { get; set; }
        public int AnoLectivo { get; set; }

    }

}
