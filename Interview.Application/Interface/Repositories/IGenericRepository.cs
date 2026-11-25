using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Application.Interface.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(Guid Id);
        Task<T> CreateAsync(T entity);
        void UpdateAsync(T entity);
        void DeleteAsync(T entity);
        Task<bool> ExistAsync(Guid Id);
    }
}
