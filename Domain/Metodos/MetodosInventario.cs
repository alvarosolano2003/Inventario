using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Metodos
{
    public interface MetodosInventario<T>
    {
                                                                
        void Ventas(Producto[] t, int i);
      
        void Compras(int i, float a);

        void Eliminando(Producto t, int i);
         

    }
}
