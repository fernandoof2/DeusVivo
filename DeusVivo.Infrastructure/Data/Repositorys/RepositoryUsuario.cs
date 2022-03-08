using DeusVivo.Domain.Core.Interfaces.Repositorys;
using DeusVivo.Domain.Entitys;

namespace DeusVivo.Infrastructure.Data.Repositorys
{
    public class RepositoryUsuario : RepositoryBase<Usuario>, IRepositoryUsuario
    {
        private readonly SqlContext _sqlContext1;

        public RepositoryUsuario(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext1 = sqlContext;
        }
    }
}
