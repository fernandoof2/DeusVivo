using DeusVivo.Domain.Core.Interfaces.Repositorys;
using DeusVivo.Domain.Entitys;

namespace DeusVivo.Infrastructure.Data.Repositorys
{
    public class RepositoryUsuario : RepositoryBase<UsuarioEO>, IRepositoryUsuario
    {
        private readonly SqlContext _sqlContext;

        public RepositoryUsuario(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
