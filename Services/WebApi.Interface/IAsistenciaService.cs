using WebApi.Modelo;

namespace WebApi.Interface
{
    public interface IAsistenciaService
    {
        Task<IEnumerable<Asistencia>> GetAllAsync();

        Task<Asistencia> GetByIdAsync(int id);

        Task<IEnumerable<Asistencia>> GetByEstudianteIdAsync(int estudianteId);

        Task<IEnumerable<Asistencia>> GetBySesionIdAsync(int sesionId);

        Task<Asistencia> CreateAsync(Asistencia asistencia);

        Task<bool> UpdateAsync(Asistencia asistencia);

        Task<bool> DeleteAsync(int id);
    }
}