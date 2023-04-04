using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repository
{
    public class ListRepository<T,Tkey> :IRepository<T,Tkey> where T :class , IEntity, new()
    {
        protected readonly List<T> _items = new List<T>();
        private Tkey _key;
        public T createItem()
        {
            // return new T();
            return default;
            // return default T();
        }

        public void AddItem(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }
        public T GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }
        public void PrintItem()
        {
            foreach(T item in _items)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _items.ToList();
        }
    }
}
