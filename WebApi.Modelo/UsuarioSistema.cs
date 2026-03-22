namespace WebApi.Modelo
{
    public class UsuarioSistema
    {
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string ContrasenaHash { get; set; }
        public int? EstudianteId { get; set; }
        public int? DocenteId { get; set; }
        public int RolId { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? UltimaConexion { get; set; }
    }
}
