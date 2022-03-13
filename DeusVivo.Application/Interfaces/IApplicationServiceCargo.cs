using DeusVivo.Application.Dtos;

namespace DeusVivo.Application.Interfaces
{
    public interface IApplicationServiceCargo
    {
        void Add(CargoDto cargoDto);
        void Update(CargoDto cargoDto);
        void Delete(CargoDto cargoDto);
        IEnumerable<CargoDto> GetAll();
        CargoDto GetById(int id);
    }
}
