using WebApi.Modelo;

namespace WebApi.Interface
{
    public interface ITipoAsistenciaService
    {
        Task<IEnumerable<TiposAsistencia>> GetAllAsync();
        Task<TiposAsistencia> GetByIdAsync(int id);
        Task<TiposAsistencia> CreateAsync(TiposAsistencia entity);
        Task<bool> UpdateAsync(TiposAsistencia entity);
        Task<bool> DeleteAsync(int id);
    }
}