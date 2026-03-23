using WebApi.Modelo;

namespace WebApi.Interface
{
    public interface IMaterialCursoService
    {
        Task<IEnumerable<MaterialCurso>> GetAllAsync();
        Task<MaterialCurso> GetByIdAsync(int id);
        Task<IEnumerable<MaterialCurso>> GetByGrupoAsignaturaIdAsync(int grupoAsignaturaId);
        Task<MaterialCurso> CreateAsync(MaterialCurso entity);
        Task<bool> UpdateAsync(MaterialCurso entity);
        Task<bool> DeleteAsync(int id);
    }
}