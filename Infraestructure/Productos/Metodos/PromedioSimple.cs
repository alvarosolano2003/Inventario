using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Productos.Metodos
{
    public class PromedioSimple : MetodosInventario
    {
        public decimal CalcularPromedio()
        {
            (Producto[] entradas, Producto[] salidas) = GetEntradasYSalidas();

            decimal promedio = Math.Round((entradas[0].Precio + entradas[1].Precio) / entradas.Length);

            return promedio;
        }

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
                    vUnidadSalidas[i] = CalcularPromedio();
                }
            }

            return (vUnidadEntradas, vUnidadSalidas);
        }

        public (decimal[], decimal[]) AsignarValoresTotal()
        {
            (Producto[] entradas, Producto[] salidas) = GetEntradasYSalidas();
            decimal[] vTotalSalidas = new decimal[salidas.Length];
            decimal[] vTotalEntradas = new decimal[entradas.Length];
            decimal promedio = CalcularPromedio();

            for (int i = 0; i < entradas.Length; i++)
            {
                vTotalEntradas[i] = Math.Round(entradas[i].Existencia * entradas[i].Precio);
            }

            for (int i = 0; i < salidas.Length; i++)
            {
                vTotalSalidas[i] = Math.Round(salidas[i].Existencia * promedio);
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
