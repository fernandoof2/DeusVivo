using DeusVivo.Domain.Entitys;

namespace DeusVivo.Domain.Core.Interfaces.Services
{
    public interface IServiceToken
    {
        string GenerateToken(UsuarioEO usuario, string secret);
    }
}
