using DeusVivo.Domain.Core.Interfaces.Repositories;
using DeusVivo.Domain.Entitys;

namespace DeusVivo.Infrastructure.Data.Repositories
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
