namespace WebApi.Modelo
{
    public class Mensaje
    {
        public int MensajeId { get; set; }
        public int UsuarioId { get; set; }
        public string Contenido { get; set; }
        public DateTime FechaEnvio { get; set; } = DateTime.Now;
        public bool Leido { get; set; } = false;
    }
}
