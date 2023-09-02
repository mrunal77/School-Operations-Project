
using Microsoft.EntityFrameworkCore;
using School_Api_Project.DbContextDirectory;
using School_Api_Project.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace School_Api_Project.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly MTSchool_DbContext _context;

        protected GenericRepository(MTSchool_DbContext context)
        {
            _context = context;
        }

        public async Task<T> Get(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}