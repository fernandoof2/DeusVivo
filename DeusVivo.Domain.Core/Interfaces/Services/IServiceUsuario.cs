using DeusVivo.Domain.Entitys;

namespace DeusVivo.Domain.Core.Interfaces.Services
{
    public interface IServiceUsuario : IServiceBase<UsuarioEO>
    {
        UsuarioEO GetUserLogin(UsuarioEO usuario);
    }
}
