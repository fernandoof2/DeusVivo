using DeusVivo.Domain.Core.Interfaces.Repositorys;
using DeusVivo.Domain.Entitys;

namespace DeusVivo.Infrastructure.Data.Repositorys
{
    public class RepositoryCompanhia : RepositoryBase<Companhia>, IRepositoryCompanhia
    {
        private readonly SqlContext _sqlContext1;

        public RepositoryCompanhia(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext1 = sqlContext;
        }
    }
}
