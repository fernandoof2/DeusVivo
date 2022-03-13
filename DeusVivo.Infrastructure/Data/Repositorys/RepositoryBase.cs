using DeusVivo.Domain.Core.Interfaces.Repositorys;
using Microsoft.EntityFrameworkCore;

namespace DeusVivo.Infrastructure.Data.Repositorys
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext _sqlContext;

        public RepositoryBase(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public void Add(TEntity obj)
        {
            try
            {
                _sqlContext.Set<TEntity>().Add(obj);
                _sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na adição do item, msg: " + ex.Message);
            }
        }

        public void Update(TEntity obj)
        {
            try
            {
                _sqlContext.Entry(obj).State = EntityState.Modified;
                _sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na atualização do item, msg: " + ex.Message);
            }
        }

        public void Delete(TEntity obj)
        {
            try
            {
                _sqlContext.Set<TEntity>().Remove(obj);
                _sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na exclusão do item, msg: " + ex.Message);
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                return _sqlContext.Set<TEntity>().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na leitura dos itens, msg: " + ex.Message);
            }
        }

        public TEntity GetById(int id)
        {
            try
            {
                var obj = _sqlContext.Set<TEntity>().Find(id);
                if (obj == null) throw new Exception("Item não encontrado.");
                
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na leitura do item, msg: " + ex.Message);
            }
        }
    }
}
