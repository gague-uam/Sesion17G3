using Sesion17G3.Modelos;
using Sesion17G3.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion17G3.Formularios
{
    public partial class ProductoFrm : Form
    {
        ProductoServicio productos;

        Producto productoSel = new Producto();

        public ProductoFrm()
        {
            InitializeComponent();
            productos = new ProductoServicio();
            Limpiar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try {

                Producto prod = new Producto();
                prod.ID = int.Parse(TbID.Text);
                prod.Nombre = TbNombre.Text;
                prod.Descripcion = TbDescripcion.Text;
                prod.Precio = double.Parse(TbPrecio.Text);
                productos.AgregarProducto(prod);
                MostrarRegistros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Limpiar();
        }

        private void MostrarRegistros()
        {
            DgvRegistros.DataSource = null;
            DgvRegistros.DataSource = productos.Productos();
        }

        private void DgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DgvRegistros_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow index = DgvRegistros.CurrentRow;
            if (index != null)
            {
                AsignarProductos(index);
                TbID.Text = productoSel.ID.ToString();
                TbNombre.Text = productoSel.Nombre;
                TbDescripcion.Text = productoSel.Descripcion;
                TbPrecio.Text = productoSel.Precio.ToString();
                
            }
        }

        private void AsignarProductos(DataGridViewRow row)
        {
            productoSel.ID = int.Parse(row.Cells[0].Value.ToString());
            productoSel.Nombre = row.Cells[1].Value.ToString();
            productoSel.Descripcion = row.Cells[2].Value.ToString();
            productoSel.Precio = double.Parse(row.Cells[3].Value.ToString());
        }

        private void Limpiar()
        {
            TbID.Clear();
            TbNombre.Clear();
            TbDescripcion.Clear();
            TbPrecio.Clear();   
        }
    }
}
