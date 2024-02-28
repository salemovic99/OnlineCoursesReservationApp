using Microsoft.EntityFrameworkCore;
using OnlineCoursesReservation.Data;

namespace OnlineCoursesReservation_DataAccess.Services.Repositories
{
    public class BaseRepositoy<T> : IBaseRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<T> _dbset;

        public BaseRepositoy(ApplicationDbContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }

        public async Task<bool> Add(T entity)
        {
            try
            {
                await _dbset.AddAsync(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> Delete(int id)
        {
            try
            {

                var entity = await GetByIdAsync(id);
                if (entity == null)
                {
                    return false;
                }

                _dbset.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _dbset.ToListAsync();

        public async Task<T> GetByIdAsync(int id) => await _dbset.FindAsync(id);


        public async Task<bool> Update(T entity)
        {
            try
            {
                if (entity == null)
                {
                    return false;
                }

                _dbset.Update(entity);

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
