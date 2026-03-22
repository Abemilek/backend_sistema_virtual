namespace WebApi.Modelo
{
    public class Log
    {
        public int LogId { get; set; }
        public int UsuarioId { get; set; }
        public string Actividad { get; set; }
        public string IpOrigen { get; set; }
        public DateTime FechaHora { get; set; } = DateTime.Now;
    }
}
