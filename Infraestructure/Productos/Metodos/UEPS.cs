using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Productos.Metodos
{
    public class UEPS : MetodosInventario
    {
        public (decimal[], decimal[]) AsignarValoresUnidad()
        {
            (Producto[] entradas, Producto[] salidas) = GetEntradasYSalidas();
            decimal[] vUnidadSalidas = new decimal[salidas.Length];
            decimal[] vUnidadEntradas = new decimal[entradas.Length];

            for (int i = 0; i < entradas.Length; i++)
            {
                vUnidadEntradas[i] = Math.Round(entradas[i].Precio);

                if (i < salidas.Length)
                {
                    vUnidadSalidas[i] = Math.Round(entradas[entradas.Length - i].Precio);
                }
            }

            return (vUnidadEntradas, vUnidadSalidas);
        }

        public (decimal[], decimal[]) AsignarValoresTotal()
        {
            (Producto[] entradas, Producto[] salidas) = GetEntradasYSalidas();
            (decimal[] vUnidadEntradas, decimal[] vUnidadSalidas) = AsignarValoresUnidad();
            decimal[] vTotalSalidas = new decimal[salidas.Length];
            decimal[] vTotalEntradas = new decimal[entradas.Length];

            for (int i = 0; i < entradas.Length; i++)
            {
                vUnidadEntradas[i] = Math.Round(vUnidadEntradas[i] * entradas[i].Existencia);
            }

            for (int i = 0; i < salidas.Length; i++)
            {
                vUnidadSalidas[i] = Math.Round(vUnidadSalidas[i] * salidas[i].Existencia);
            }

            return (vTotalEntradas, vTotalSalidas);
        }

        public decimal TotalInventario()
        {
            (decimal[] vTotalEntradas, decimal[] vTotalSalidas) = AsignarValoresTotal();
            decimal inventario = 0;

            foreach (decimal e in vTotalEntradas)
            {
                inventario += e;
            }

            foreach (decimal e in vTotalSalidas)
            {
                inventario -= e;
            }

            return inventario;
        }
    }
}
