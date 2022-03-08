using DeusVivo.Domain.Core.Interfaces.Repositorys;
using DeusVivo.Domain.Core.Interfaces.Services;
using DeusVivo.Domain.Entitys;

namespace DeusVivo.Domain.Services
{
    public class ServiceCompanhia : ServiceBase<Companhia>, IServiceCompanhia
    {
        public ServiceCompanhia(IRepositoryBase<Companhia> repository) : base(repository)
        {
        }
    }
}
