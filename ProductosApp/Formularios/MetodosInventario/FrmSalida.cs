using Domain.Entities;
using Infraestructure.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosApp.Formularios.MetodosInventario
{
    public partial class FrmSalida : Form
    {
        public ProductoModel productoModel;
        public FrmSalida()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Producto p = new Producto()
            {
                Existencia = (int)nudExist.Value,
                Naturaleza = Domain.Enums.NaturalezaCuentas.Salida
            };

            productoModel.Add(p);
        }
    }
}
