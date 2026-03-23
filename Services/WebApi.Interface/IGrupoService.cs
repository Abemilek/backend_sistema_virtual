using WebApi.Modelo;

namespace WebApi.Interface
{
    public interface IGrupoService
    {
        Task<IEnumerable<Grupo>> GetAllAsync();
        Task<Grupo> GetByIdAsync(int id);
        Task<Grupo> CreateAsync(Grupo entity);
        Task<bool> UpdateAsync(Grupo entity);
        Task<bool> DeleteAsync(int id);
    }
}