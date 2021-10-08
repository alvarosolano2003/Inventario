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
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            FrmEntrada entrada = new FrmEntrada();
            this.Hide();
            entrada.Show();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            FrmSalida salida = new FrmSalida();
            this.Hide();
            salida.Show();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            string mostrar = string.Format(@"{0:20%} {1:30&}", "Juan", "Pedro");
            rbtView.Text = mostrar;
        }
    }
}
