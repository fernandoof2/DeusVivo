using DeusVivo.Domain.Core.Interfaces.Repositories;
using DeusVivo.Domain.Core.Interfaces.Services;
using DeusVivo.Domain.Entitys;

namespace DeusVivo.Domain.Services
{
    public class ServiceCargo : ServiceBase<CargoEO>, IServiceCargo
    {
        public ServiceCargo(IRepositoryBase<CargoEO> repository) : base(repository) {
        }
    }
}
