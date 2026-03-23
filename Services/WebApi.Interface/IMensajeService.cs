using WebApi.Modelo;

namespace WebApi.Interface
{
    public interface IMensajeService
    {
        Task<IEnumerable<Mensaje>> GetAllAsync();
        Task<Mensaje> GetByIdAsync(int id);
        Task<IEnumerable<Mensaje>> GetByUsuarioIdAsync(int usuarioId);
        Task<Mensaje> CreateAsync(Mensaje entity);
        Task<bool> MarkAsReadAsync(int id);
        Task<bool> DeleteAsync(int id);
    }
}