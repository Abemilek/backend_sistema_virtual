using WebApi.Modelo;

namespace WebApi.Interface
{
    public interface ILogService
    {
        Task<IEnumerable<Log>> GetAllAsync();
        Task<IEnumerable<Log>> GetByUsuarioIdAsync(int usuarioId);
        Task<Log> CreateAsync(Log entity);
    }
}