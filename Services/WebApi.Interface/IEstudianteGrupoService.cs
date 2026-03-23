using WebApi.Modelo;

namespace WebApi.Interface
{
    public interface IEstudianteGrupoService
    {
        Task<IEnumerable<EstudianteGrupo>> GetAllAsync();
        Task<EstudianteGrupo> GetByIdAsync(int id);
        Task<IEnumerable<EstudianteGrupo>> GetByEstudianteIdAsync(int estudianteId);
        Task<IEnumerable<EstudianteGrupo>> GetByGrupoIdAsync(int grupoId);
        Task<EstudianteGrupo> CreateAsync(EstudianteGrupo entity);
        Task<bool> UpdateAsync(EstudianteGrupo entity);
        Task<bool> DeleteAsync(int id);
    }
}