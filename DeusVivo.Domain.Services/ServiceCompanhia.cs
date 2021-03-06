using DeusVivo.Domain.Core.Interfaces.Repositories;
using DeusVivo.Domain.Core.Interfaces.Services;
using DeusVivo.Domain.Entitys;

namespace DeusVivo.Domain.Services
{
    public class ServiceCompanhia : ServiceBase<CompanhiaEO>, IServiceCompanhia
    {
        public ServiceCompanhia(IRepositoryBase<CompanhiaEO> repository) : base(repository){
        }
    }
}
