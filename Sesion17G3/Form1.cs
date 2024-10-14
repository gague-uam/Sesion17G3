using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sesion17G3.Modelos;
using Sesion17G3.Servicios; 

namespace Sesion17G3
{
    public partial class Form1 : Form
    {
        ProductoServicios productos;
        public Form1()
        {
            InitializeComponent();
            productos = new ProductoServicios();
        }

        private void MostrarRegistros()
        {
            DgvRegistros.DataSource = null;
            DgvRegistros.DataSource = productos.Productos();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.ID = int.Parse(TbID.Text);
            prod.Nombre = TbNombre.Text;
            prod.Descripcion = TbDescp.Text;
            prod.Precio = double.Parse(TbPrecio.Text); 
            productos.AgregarProducto(prod);
            MostrarRegistros();
        }
    }
}
