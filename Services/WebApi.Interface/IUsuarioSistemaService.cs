using WebApi.Modelo;

namespace WebApi.Interface
{
    public interface IUsuarioSistemaService
    {
        Task<IEnumerable<UsuarioSistema>> GetAllAsync();
        Task<UsuarioSistema> GetByIdAsync(int id);
        Task<UsuarioSistema> GetByUsernameAsync(string username);
        Task<UsuarioSistema> CreateAsync(UsuarioSistema entity);
        Task<bool> UpdateAsync(UsuarioSistema entity);
        Task<bool> DeleteAsync(int id);
    }
}