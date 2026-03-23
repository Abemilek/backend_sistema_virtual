using WebApi.Modelo;

namespace WebApi.Interface
{
    public interface IAsignaturaService
    {
        Task<IEnumerable<Asignatura>> GetAllAsync();

        Task<Asignatura> GetByIdAsync(int id);

        Task<Asignatura> CreateAsync(Asignatura asignatura);

        Task<bool> UpdateAsync(Asignatura asignatura);

        Task<bool> DeleteAsync(int id);
    }
}