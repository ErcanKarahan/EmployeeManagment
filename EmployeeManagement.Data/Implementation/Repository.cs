using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DataContext;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Data.Implementation
{
    public class Repository<T> : IReposteryBase<T> where T : class, new()
    {
        private readonly EmployeeManagementContext _ctx;
        internal DbSet<T> dbSet;

        public Repository(EmployeeManagementContext ctx)
        {
            _ctx = ctx;
            this.dbSet = _ctx.Set<T>();

        }

        /// <summary>
        /// Add To T Type Entity / Gelen Tipte Veriyi Kayıt Eder
        /// </summary>
        /// <param name="entity"></param>
        public void Add(T entity)
        {
            dbSet.Add(entity);

        }

        public T Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;

            if (filter != null) 
                query = query.Where(filter);

            if (includeProperties!=null)
            {
                foreach (var item in includeProperties.Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);

                }
            }

            if (orderby!=null)
            {
                return orderby(query);

            }

            return query;

        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
                query = query.Where(filter);

            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);

                }
            }

            return GetFirstOrDefault();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);

        }

        public void Update(T entity)
        {
            dbSet.Update(entity);

        }
    }
}
