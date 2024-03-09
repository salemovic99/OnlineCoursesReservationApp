namespace OnlineCoursesReservation_DataAccess.Services.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);

        Task<bool> Add(T entity);

        Task<bool> Delete(T entity);

        Task<bool> Update(T entity);
    }
}
