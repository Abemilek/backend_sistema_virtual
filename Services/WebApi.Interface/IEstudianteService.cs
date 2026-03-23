using WebApi.Modelo;

namespace WebApi.Interface
{
    public interface IEstudianteService
    {
        Task<IEnumerable<Estudiante>> GetAllAsync();
        Task<Estudiante> GetByIdAsync(int id);
        Task<Estudiante> CreateAsync(Estudiante estudiante);
        Task<bool> UpdateAsync(Estudiante estudiante);
        Task<bool> DeleteAsync(int id);
        Task<bool> ChangeStatusAsync(int id, bool estado);
    }
}