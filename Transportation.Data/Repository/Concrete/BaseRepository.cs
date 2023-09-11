using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Transportation.Data.Context;
using Transportation.Data.Repository.Abstract;

namespace Transportation.Data.Repository.Concrete
{
    // Burda Generic bir repository class tanimlayip daha sonradan uygulamaya kolay bir sekilde baska entitylerde eklenirse daha hizli kod yazabilmek icin
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public TransportationDbContext dbContext { get; set; }

        public BaseRepository()
        {
            this.dbContext = new TransportationDbContext();
        }

        //Dependency Injection 

        public virtual async Task<int> InsertAsync(T entity)
        {
            await dbContext.Set<T>().AddAsync(entity);
            // Set Metodu ile T tipi olarak girilen Entity nin icerisine konumlanir.
            return await dbContext.SaveChangesAsync();
        }

        public virtual async Task<int> UpdateAsync(T entity)
        {
            dbContext.Set<T>().Update(entity);
            return await dbContext.SaveChangesAsync();
        }
        public async Task<int> DeleteAsync(T entity)
        {
            dbContext.Set<T>().Remove(entity);
            return await dbContext.SaveChangesAsync(); 
        }
        public async Task<T?> GetByIdAsync(int id)
        {
            return await dbContext.Set<T>().FindAsync(id);
        }
        public async Task<T?> GetBy(Expression<Func<T,bool>> filter)
        {
            return await dbContext.Set<T>().Where(filter).FirstOrDefaultAsync();
        }
        public async Task<ICollection<T>> GetAllAsync()
        {
            return await dbContext.Set<T>().ToListAsync();
        }
        public async Task<ICollection<T>> GetAllAsync(Expression<Func<T,bool>>? filter = null)
        {
            if(filter == null)
            {
                return await dbContext.Set<T>().ToListAsync();
            }
            return await dbContext.Set<T>().Where(filter).ToListAsync();
        }

        public async Task<IQueryable<T>> GetAllInclude(Expression<Func<T,bool>>? filter = null , params Expression<Func<T, bool>>[] include)
        {
            IQueryable<T> query;
            if(filter != null)
            {
                query = dbContext.Set<T>().Where(filter);
            }
            else
            {
                query = dbContext.Set<T>();    
            }
            return include.Aggregate(query,(current,includeProperty) => current.Include(includeProperty));
        }

        public Task<IQueryable<T>> GetAllInclude(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] include)
        {
            throw new NotImplementedException();
        }
    }
}
