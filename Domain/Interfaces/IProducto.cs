using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IProducto<T>
    {
        void Add(T t);
        int Update(T t);
        bool Delete(T t);
        T[] GetAll();
    }
}
