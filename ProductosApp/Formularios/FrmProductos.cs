using AppCore.Interfaces;
using AppCore.Services;
using Domain.Entities;
using Domain.Enums;
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

namespace ProductosApp.Formularios
{
    public partial class FrmProductos : Form
    {
        private IProductoService productoService;
        public FrmProductos(IProductoService productoService)
        {
            this.productoService = productoService;
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            cmbMeasureUnit.Items.AddRange(Enum.GetValues(typeof(UnidadMedida))
                                              .Cast<object>()
                                              .ToArray()
                                          );
            txtId.Visible = false;
            cmbMeasureUnit.Visible = false;
            dtpFechaCaducidad.Visible = false;
            nudMayor.Visible = false;
            nudMenor.Visible = false;
            btnFind.Visible = false;
            btnCalculoPromedio.Visible = false;
            btnEntraSalida.Visible = false;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto(productoService);
            frmProducto.ShowDialog();
            productoService  =  frmProducto.Services;
        }

        private void CmbFinderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFinderType.SelectedIndex)
            {
                case 0:
                    txtId.Visible = true;
                    btnFind.Visible = true;
                    cmbMeasureUnit.Visible = false;
                    dtpFechaCaducidad.Visible = false;
                    nudMayor.Visible = false;
                    nudMenor.Visible = false;
                    break;
                case 1:
                    nudMayor.Visible = true;
                    nudMenor.Visible = true;
                    btnFind.Visible = true;
                    txtId.Visible = false;
                    cmbMeasureUnit.Visible = false;
                    dtpFechaCaducidad.Visible = false;
                    break;
                case 2:
                    dtpFechaCaducidad.Visible = true;
                    btnFind.Visible = true;
                    txtId.Visible = false;
                    cmbMeasureUnit.Visible = false;
                    nudMayor.Visible = false;
                    nudMenor.Visible = false;
                    break;
                case 3:
                    cmbMeasureUnit.Visible = true;
                    btnFind.Visible = true;
                    txtId.Visible = false;
                    dtpFechaCaducidad.Visible = false;
                    nudMayor.Visible = false;
                    nudMenor.Visible = false;
                    break;                
            }
        }
        private int ValidarPrecios(decimal a, decimal b)
        {
            if (a < b || a == b)
            {
                return 1;
            }
            if (a > b)
            {
                return -1;
            }
            return 0;
        }

        private void nudPrecioInferior_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;
        }

        private void nudPrecioSuperior_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cmbFinderType.SelectedIndex == 0)
            {
                int.TryParse(txtId.Text, out int id);
                if (id > 0 || txtId.Text != "")
                {
                    Producto Tempo = productoService.GetProductoById(id);
                    rtbProductView.Text = "";
                    if (Tempo == null)
                    {
                        rtbProductView.Text = "No se ha encontrado ningún elemento con la característica que esta buscando";
                    }
                    else
                    {
                        rtbProductView.Text = $"Id: {Tempo.Id}, Nombre: {Tempo.Nombre}, Descripcion: {Tempo.Descripcion}, Cantidad: {Tempo.Existencia}, Precio: {Tempo.Precio}, Caducidad: {Tempo.FechaVencimiento}, Unidad de medida: {Tempo.UnidadMedida}";
                    }
                }
            }
            if (cmbFinderType.SelectedIndex == 1)
            {
                int pivote = ValidarPrecios(nudMenor.Value, nudMayor.Value);
                if (pivote == 1)
                {
                    Producto[] Tempo = productoService.GetProductosByRangoPrecio(nudMenor.Value, nudMayor.Value);
                    rtbProductView.Text = "";
                    if (Tempo == null)
                    {
                        rtbProductView.Text = "No se ha encontrado ningún elemento con la característica que esta buscando";
                        return;
                    }
                    else
                    {
                        for (int i = 0; i < Tempo.Length; i++)
                        {
                            string cadena = $"Id: {Tempo[i].Id}, Nombre: {Tempo[i].Nombre}, Descripcion: {Tempo[i].Descripcion}, Cantidad: {Tempo[i].Existencia}, Precio: {Tempo[i].Precio}, Caducidad: {Tempo[i].FechaVencimiento}, Unidad de medida: {Tempo[i].UnidadMedida}";
                            rtbProductView.Text = rtbProductView.Text + @"
" + cadena;
                        }
                        return;
                    }
                }
                MessageBox.Show("Para realizar la busqueda debe de cambiar los valores", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudMenor.Value = 0;
                nudMayor.Value = 0;
            }
            if (cmbFinderType.SelectedIndex == 2)
            {
                if (cmbMeasureUnit.Text == string.Empty)
                {
                    MessageBox.Show("Debe de ingresar una unidad de medida", "Error con la unidad de medida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Producto[] Tempo = productoService.GetProductosByUnidadMedida((UnidadMedida)cmbMeasureUnit.SelectedIndex);
                    rtbProductView.Text = "";
                    if (Tempo == null)
                    {
                        rtbProductView.Text = "No se ha encontrado ningún elemento con la característica que esta buscando";
                    }
                    else
                    {
                        for (int i = 0; i < Tempo.Length; i++)
                        {
                            string cadena = $"Id: {Tempo[i].Id}, Nombre: {Tempo[i].Nombre}, Descripcion: {Tempo[i].Descripcion}, Cantidad: {Tempo[i].Existencia}, Precio: {Tempo[i].Precio}, Caducidad: {Tempo[i].FechaVencimiento}, Unidad de medida: {Tempo[i].UnidadMedida}";
                            rtbProductView.Text = rtbProductView.Text + @"
" + cadena;
                        }
                    }
                }
            }
            if (cmbFinderType.SelectedIndex == 3)
            {
                Producto[] Tempo = productoService.GetProductosByFechaVencimiento(dtpFechaCaducidad.Value);
                rtbProductView.Text = "";
                if (Tempo == null)
                {
                    rtbProductView.Text = "No se ha encontrado ningún elemento con la característica que esta buscando";
                }
                else
                {
                    for (int i = 0; i < Tempo.Length; i++)
                    {
                        string cadena = $"Id: {Tempo[i].Id}, Nombre: {Tempo[i].Nombre}, Descripcion: {Tempo[i].Descripcion}, Cantidad: {Tempo[i].Existencia}, Precio: {Tempo[i].Precio}, Caducidad: {Tempo[i].FechaVencimiento   }, Unidad de medida: {Tempo[i].UnidadMedida}";
                        rtbProductView.Text = rtbProductView.Text + @"
" + cadena;
                    }
                }
            }
        }

        private void nudMayor_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
       {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;
            MessageBox.Show("Solo debe de ingresar números", "Error en el id", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnMetodos_Click(object sender, EventArgs e)
        {
            btnEntraSalida.Visible = true;
            btnCalculoPromedio.Visible = true;
        }

        private void btnEntraSalida_Click(object sender, EventArgs e)
        {

        }
    }
}
