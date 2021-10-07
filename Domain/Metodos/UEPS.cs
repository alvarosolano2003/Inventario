using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Metodos
{
    public class UEPS : MetodosInventario<Producto>
    {
        private int[] CantidadComprada;
        private float[] PrecioComprado;
        private int indice = 0;
        public void Compras(int i, float a)
        {
            CantidadComprada[indice] = i;
            PrecioComprado[indice] = a;
            indice++;
        }

        public void Eliminando(Producto t, int i)
        {
            throw new NotImplementedException();
        }

        public void Ventas(Producto[] t, int i)
        {
            throw new NotImplementedException();
        }

        public void Ventas(Producto[] t, int i, float a)
        {
            throw new NotImplementedException();
        }
    }
}
