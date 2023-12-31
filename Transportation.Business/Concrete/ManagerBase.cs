﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Transportation.Business.Abstract;
using Transportation.Data.Repository.Abstract;
using Transportation.Data.Repository.Concrete;

namespace Transportation.Business.Concrete
{
    public class ManagerBase<T> : IManagerBase<T> where T: class
    {
        private readonly IBaseRepository<T> _repository;
        // Dependency inversion geregi moduller arasindaki baglantilar zayif olacak ve classlarin soyutlandirilmasi(interfacelere bagli olmasi ilkesi)
        // sirasi ile concrete classlarimizi interfacelere implement edecegiz. Daha sonra servicelerimizi program csdeki service container icerisine lifetime
        // ina gore (addscoped,addtransient yada addsingleton) metholari ile servicelerden uretilen nesnelerin kullanim suresini bildirerek kaydedecegiz.
        // depencylerimizi constructor icerisine enjeksiyon ederek kullanacagiz. Detay icin https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-7.0
        public ManagerBase()
        {
            _repository = new BaseRepository<T>(); 
        }

        public virtual async Task<int> InsertAsync(T entity)
        {
            return await _repository.InsertAsync(entity);
        }
        
        public virtual async Task<int> UpdateAsync(T entity)
        {
            return await _repository.UpdateAsync(entity);
        }

        public virtual async Task<int> DeleteAsync(T entity)
        {
            return await _repository.DeleteAsync(entity);
        }

        public virtual async Task<T?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public virtual async Task<T?> GetBy(Expression<Func<T,bool>> filter)
        {
            return await _repository.GetBy(filter);
        }
        
        public async Task<ICollection<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null)
        {
            return await _repository.GetAllAsync(filter);
        }

        public async Task<IQueryable<T>> GetAllInclude(Expression<Func<T,bool>>? filter = null,params Expression<Func<T, object>>[] include)
        {
            return await _repository.GetAllInclude(filter,include);
        }

       
    }
}
