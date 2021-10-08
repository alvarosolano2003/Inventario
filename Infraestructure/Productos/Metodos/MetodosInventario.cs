using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Productos.Metodos
{
    public class MetodosInventario
    {
        protected ProductoModel productoModel;
        private void Add(Producto p, Producto[] pds)
        {
            if (pds == null)
            {
                pds = new Producto[1];
                pds[pds.Length - 1] = p;
                return;
            }

            Producto[] tmp = new Producto[pds.Length + 1];
            Array.Copy(pds, tmp, pds.Length);
            tmp[tmp.Length - 1] = p;
            pds = tmp;
        }
        public void Ordenamiento(Producto[] arr, int index)
        {
            int posicion;

            for (int i = 0; i < index; i++)
            {
                DateTime valorC = arr[i].FechaDeRegistro;
                posicion = i;

                while (posicion > 0 && arr[i - 1].FechaDeRegistro > valorC)
                {
                    arr[posicion] = arr[posicion - 1];
                    posicion = posicion - 1;
                }

                arr[posicion].FechaDeRegistro = valorC;
            }
        }

        public (Producto[], Producto[]) GetEntradasYSalidas()
        {
            Producto[] arr = productoModel.GetAll();
            Ordenamiento(arr, arr.Length);
            Producto[] arrEntradas = new Producto[0];
            Producto[] arrSalidas = new Producto[0];

            foreach (Producto e in arr)
            {
                if (e.Naturaleza == Domain.Enums.NaturalezaCuentas.Entrada)
                {
                    Add(e, arrEntradas);
                }
                else if (e.Naturaleza == Domain.Enums.NaturalezaCuentas.Salida)
                {
                    Add(e, arrSalidas);
                }
            }

            return (arrEntradas, arrSalidas);
        }
        public int[] GetExistencias()
        {
            Producto[] arr = productoModel.GetAll();
            Ordenamiento(arr, arr.Length);
            //(Producto[] entradas, Producto[] salidas) = GetEntradasYSalidas();
            int[] existencia = new int[arr.Length];
            int existenciaAux = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Naturaleza == Domain.Enums.NaturalezaCuentas.Entrada)
                {
                    existenciaAux += arr[i].Existencia;
                }
                else if (arr[i].Naturaleza == Domain.Enums.NaturalezaCuentas.Salida)
                {
                    existenciaAux -= arr[i].Existencia;
                }

                existencia[i] = existenciaAux;
            }

            return existencia;
        }


    }
}
