using DeusVivo.Application.Dtos;

namespace DeusVivo.Application.Interfaces
{
    public interface IApplicationServiceCompanhia
    {
        void Add(CompanhiaDto CompanhiaDto);
        void Update(CompanhiaDto CompanhiaDto);
        void Delete(CompanhiaDto CompanhiaDto);
        IEnumerable<CompanhiaDto> GetAll();
        CompanhiaDto GetById(int id);
    }
}
