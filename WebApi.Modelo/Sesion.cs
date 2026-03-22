namespace WebApi.Modelo
{
    public class Sesion
    {
        public int SesionId { get; set; }
        public int GrupoAsignaturaId { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public string Tema { get; set; }
        public string LinkVideollamada { get; set; }
    }
}
