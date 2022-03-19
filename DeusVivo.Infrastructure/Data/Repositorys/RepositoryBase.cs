﻿using DeusVivo.Domain.Core.Interfaces.Repositorys;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DeusVivo.Infrastructure.Data.Repositorys
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext _sqlContext;
        private readonly DbSet<TEntity> _dataset;

        public RepositoryBase(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
            _dataset = sqlContext.Set<TEntity>();
        }

        public TEntity Add(TEntity obj)
        {
            try
            {
                _sqlContext.Set<TEntity>().Add(obj);
                _sqlContext.SaveChangesAsync();

                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na adição do item, msg: " + ex.Message);
            }
        }

        public bool Update(TEntity obj)
        {
            try
            {
                _sqlContext.Entry(obj).State = EntityState.Modified;
                _sqlContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na atualização do item, msg: " + ex.Message);
            }
        }

        public bool Delete(TEntity obj)
        {
            try
            {
                _sqlContext.Set<TEntity>().Remove(obj);
                _sqlContext.SaveChanges();
                return true;
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

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = _dataset;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }
    }
}
