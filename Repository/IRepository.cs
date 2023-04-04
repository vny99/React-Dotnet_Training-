using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repository
{
    public interface IRepository<T,Tkey> where T : class, IEntity, new()
    {
        void AddItem(T item);
        T GetById(int id);
        void PrintItem();
        IEnumerable<T> GetAll();

    }
    public interface IReadRepository< out T,Tkey> where T : class, IEntity, new()
    {
        void PrintItem();
        IEnumerable<T> GetAll();
    }
}