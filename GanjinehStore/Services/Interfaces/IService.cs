using System.Collections.Generic;

namespace GanjinehStore.Services.Interfaces
{
    public interface IService<T> where T: class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Add(T tEntity);
        T Remove(int id);
        T Update(int id, T tEntity);
    }
}
