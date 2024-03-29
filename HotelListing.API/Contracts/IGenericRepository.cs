﻿using HotelListing.API.Models;

namespace HotelListing.API.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<PagedResult<TResult>> GetAllAsync<TResult>(QueryParameters queryParameters);
        Task<T> AddAsync (T entity);    
        Task<T> UpdateAsync (T entity); // Trevor did not return T
        Task DeleteAsync (int id);
        Task<bool> Exists(int id);  
    }
}
