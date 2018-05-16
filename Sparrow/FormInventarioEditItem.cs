using Sparrow.Domain;
using Sparrow.Helpers;
using Sparrow.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sparrow
{
    public partial class FormInventarioEditItem : Form
    {
        IProductoService productoService;
        Producto producto;
        public FormInventarioEditItem()
        {
            productoService = new ProductoService();
            producto = productoService.obtenerProducto(SessionHelper.productID.Value);
            InitializeComponent();
        }

        private void FormInventarioEditItem_Load(object sender, EventArgs e)
        {
            tbNombre.Text = producto.nombre;
            cbMedida.SelectedIndex = producto.medidaId - 1;
            cbTipo.SelectedIndex = producto.tipoId - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            producto.nombre = tbNombre.Text;
            producto.medidaId = cbMedida.SelectedIndex + 1;
            producto.tipoId = cbTipo.SelectedIndex + 1;
            productoService.editarProducto(producto);
            SessionHelper.productID = null;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SessionHelper.productID = null;
            this.Close();
        }
    }
}
