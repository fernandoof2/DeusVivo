using DeusVivo.Domain.Core.Interfaces.Repositories;
using DeusVivo.Domain.Core.Interfaces.Services;
using DeusVivo.Domain.Entitys;
using System.Linq.Expressions;

namespace DeusVivo.Domain.Services
{
    public class ServiceUsuario : ServiceBase<UsuarioEO>, IServiceUsuario
    {
        private readonly IRepositoryBase<UsuarioEO> _repository;

        public ServiceUsuario(IRepositoryBase<UsuarioEO> repository) : base(repository){
            _repository = repository;
        }

        public UsuarioEO? GetUserLogin(UsuarioEO usuario)
        {
            Expression<Func<UsuarioEO, bool>> filter = a => 
                                                       a.Login.Contains(usuario.Login.Trim()) && 
                                                       a.Senha.Equals(usuario.Senha.Trim());
            return _repository.Get(filter).FirstOrDefault();
        }
    }
}
