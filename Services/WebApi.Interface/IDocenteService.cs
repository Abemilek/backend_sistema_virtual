using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Modelo;

namespace WebApi.Interface
{
    public interface IDocenteService
    {
        Task<IEnumerable<Docente>> GetAllAsync();

        Task<Docente> GetByIdAsync(int id);

        Task<Docente> CreateAsync(Docente docente);

        Task<bool> UpdateAsync(Docente docente);

        Task<bool> DeleteAsync(int id);

        Task<bool> ChangeStatusAsync(int id, bool estado);
    }
}