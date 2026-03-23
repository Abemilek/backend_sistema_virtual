using WebApi.Modelo;

namespace WebApi.Interface
{
    public interface IRolSistemaService
    {
        Task<IEnumerable<RolSistema>> GetAllAsync();
        Task<RolSistema> GetByIdAsync(int id);
        Task<RolSistema> CreateAsync(RolSistema entity);
        Task<bool> UpdateAsync(RolSistema entity);
        Task<bool> DeleteAsync(int id);
    }
}