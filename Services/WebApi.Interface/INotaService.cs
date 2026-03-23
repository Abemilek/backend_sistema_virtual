using WebApi.Modelo;

namespace WebApi.Interface
{
    public interface INotaService
    {
        Task<IEnumerable<Nota>> GetAllAsync();
        Task<Nota> GetByIdAsync(int id);
        Task<IEnumerable<Nota>> GetByEstudianteIdAsync(int estudianteId);
        Task<IEnumerable<Nota>> GetByEvaluacionIdAsync(int evaluacionId);
        Task<Nota> CreateAsync(Nota entity);
        Task<bool> UpdateAsync(Nota entity);
        Task<bool> DeleteAsync(int id);
    }
}