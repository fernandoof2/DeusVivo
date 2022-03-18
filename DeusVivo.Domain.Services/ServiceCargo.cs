using DeusVivo.Domain.Core.Interfaces.Repositorys;
using DeusVivo.Domain.Core.Interfaces.Services;
using DeusVivo.Domain.Entitys;

namespace DeusVivo.Domain.Services
{
    public class ServiceCargo : ServiceBase<Cargo>, IServiceCargo
    {
        public ServiceCargo(IRepositoryBase<Cargo> repository) : base(repository) {
        }
    }
}
