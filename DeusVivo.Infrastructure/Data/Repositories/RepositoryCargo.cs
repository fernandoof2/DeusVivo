using DeusVivo.Domain.Core.Interfaces.Repositories;
using DeusVivo.Domain.Entitys;

namespace DeusVivo.Infrastructure.Data.Repositories
{
    public class RepositoryCargo : RepositoryBase<CargoEO>, IRepositoryCargo
    {
        private readonly SqlContext _sqlContext;

        public RepositoryCargo(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
