using DeusVivo.Domain.Core.Interfaces.Repositories;
using DeusVivo.Domain.Entitys;

namespace DeusVivo.Infrastructure.Data.Repositories
{
    public class RepositoryCompanhia : RepositoryBase<CompanhiaEO>, IRepositoryCompanhia
    {
        private readonly SqlContext _sqlContext;

        public RepositoryCompanhia(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
