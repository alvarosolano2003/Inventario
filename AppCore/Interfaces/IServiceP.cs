using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface IServiceP<T>
    {
        void Add(T t);
        int Update(T t);
        bool Delete(T t);
        T[] GetAll();
    }
}
