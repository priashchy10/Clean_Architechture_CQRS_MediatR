using FoodManagement.Core.Entites.Base;
using FoodManagement.Core.Repository.Base;
using FoodManagement.Infrastracture.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagement.Infrastracture.Repository.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public readonly FoodContext _foodContext;

        public Repository(FoodContext foodContext)
        {
            _foodContext = foodContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _foodContext.Set<T>().AddAsync(entity);
            await _foodContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _foodContext.Set<T>().Remove(entity);
            await _foodContext.SaveChangesAsync();
        }

        public async Task<T> FindByIdAsync(int id)
        {
            return await _foodContext.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _foodContext.Set<T>().ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _foodContext.Entry(entity).State = EntityState.Modified;
            await _foodContext.SaveChangesAsync();
        }
    }
}
