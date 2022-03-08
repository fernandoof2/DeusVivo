using DeusVivo.Domain.Core.Interfaces.Repositorys;
using DeusVivo.Domain.Entitys;

namespace DeusVivo.Infrastructure.Data.Repositorys
{
    public class RepositoryCargo : RepositoryBase<Cargo>, IServiceCargo
    {
        private readonly SqlContext _sqlContext1;

        public RepositoryCargo(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext1 = sqlContext;
        }
    }
}
