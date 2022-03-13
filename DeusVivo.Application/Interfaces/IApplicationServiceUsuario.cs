using DeusVivo.Application.Dtos;

namespace DeusVivo.Application.Interfaces
{
    public interface IApplicationServiceUsuario
    {
        void Add(UsuarioDto UsuarioDto);
        void Update(UsuarioDto UsuarioDto);
        void Delete(UsuarioDto UsuarioDto);
        IEnumerable<UsuarioDto> GetAll();
        UsuarioDto GetById(int id);
    }
}
