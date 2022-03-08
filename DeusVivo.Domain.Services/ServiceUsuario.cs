using DeusVivo.Domain.Core.Interfaces.Repositorys;
using DeusVivo.Domain.Core.Interfaces.Services;
using DeusVivo.Domain.Entitys;

namespace DeusVivo.Domain.Services
{
    public class ServiceUsuario : ServiceBase<Usuario>, IServiceUsuario
    {
        public ServiceUsuario(IRepositoryBase<Usuario> repository) : base(repository)
        {
        }
    }
}
