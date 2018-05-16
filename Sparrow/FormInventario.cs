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
    public partial class FormInventario : Form
    {
        IProductoService productoService;
        int productId;

        public FormInventario()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            productoService = new ProductoService();
            CargarDG();
        }

        public void CargarDG()
        {
            this.dataGridView1.DataSource = productoService.ListarProductos();
        }

        public void CargarFiltros()
        {
            string ingredientes = checkIngrediente.Checked ? checkIngrediente.Text : null;
            string elaborados = checkProductoEl.Checked ? checkProductoEl.Text : null;
            string unitarios = checkProductoUnit.Checked ? checkProductoUnit.Text : null;
            bool activada = checkActiva.Checked;
            var data = productoService.ListarProductos(ingredientes, elaborados, unitarios,activada);
            this.dataGridView1.DataSource = data;
        }

        public void Clean()
        {
            tbNombre.Clear();
            tbStock.Clear();
            tbStockAlerta.Clear();
            cbMedida.SelectedIndex = -1;
            cbTipo.SelectedIndex = -1;
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            

            FormInventarioEditItem formInventarioEditItem = new FormInventarioEditItem();

            formInventarioEditItem.ShowDialog();
            CargarDG();
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInventarioStock formInventarioStock = new FormInventarioStock();

            formInventarioStock.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormInventarioStock formInventarioStock = new FormInventarioStock();

            formInventarioStock.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormInventarioCosto formInventarioCosto= new FormInventarioCosto();

            formInventarioCosto.ShowDialog();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int length = dataGridView1.SelectedRows.Count;
            for (int i = 0; i < length; i++)
            {
                productId = Convert.ToInt32(dataGridView1.SelectedRows[i].Cells["ID"].Value);
                productoService.eliminarProducto(productId);
            }
            CargarDG();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.medidaId = cbMedida.SelectedIndex + 1;
            producto.nombre = tbNombre.Text;
            producto.tipoId = cbTipo.SelectedIndex + 1;
            producto.stock = Convert.ToDouble(tbStock.Text);
            if (checkAlerta.Checked)
            {
                producto.alertaStock = Convert.ToDouble(tbStockAlerta.Text);
            }
            producto.costoUnitario = 0;
            productoService.agregarProducto(producto);
            CargarDG();
            Clean();
        }

        private void checkAlerta_CheckedChanged(object sender, EventArgs e)
        {
            tbStockAlerta.Enabled = checkAlerta.Checked;
            tbStockAlerta.Text = checkAlerta.Checked ? tbStockAlerta.Text : null;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                SessionHelper.productID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                btnEditItem.Enabled = true;
            }
            else
            {
                btnEditItem.Enabled = false;
            }
        }

       

        private void checkIngrediente_CheckedChanged(object sender, EventArgs e)
        {
            CargarFiltros();
        }

        private void checkProductoEl_CheckedChanged(object sender, EventArgs e)
        {
            CargarFiltros();
        }

        private void checkProductoUnit_CheckedChanged(object sender, EventArgs e)
        {
            CargarFiltros();
        }

        private void checkActiva_CheckedChanged(object sender, EventArgs e)
        {
            CargarFiltros();
        }

        private void checkDesac_CheckedChanged(object sender, EventArgs e)
        {
            CargarFiltros();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkIngrediente.Checked = false;
            checkProductoEl.Checked = false;
            checkProductoUnit.Checked = false;
            checkAlerta.Checked = false;
            CargarDG();
        }
    }
}
