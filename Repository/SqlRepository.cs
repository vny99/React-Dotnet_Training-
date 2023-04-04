using Microsoft.EntityFrameworkCore;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repository
{
    //public class GenericRepositoryWithRemove<T,Tkey> :GenericRepository<T, Tkey>
    //{
    //    public void RemoveItem(T item)
    //    {
    //        _items.Remove(item);
    //    }
    //}
    public class SqlRepository<T, Tkey> : IRepository<T, Tkey> where T : class, IEntity, new()
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public SqlRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();

        }


        public void AddItem(T item)
        {

            _dbSet.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
           
            return _dbSet.Find(id);
        }
        public void PrintItem()
        {

            _dbContext.SaveChanges();
        }
    }
}
