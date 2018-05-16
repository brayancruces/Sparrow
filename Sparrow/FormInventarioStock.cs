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
    public partial class FormInventarioStock : Form
    {
        IProductoService productoService;
        IActividadService actividadService;
        public FormInventarioStock()
        {
            productoService = new ProductoService();
            actividadService = new ActividadService();
            InitializeComponent();
            this.Text = SessionHelper.accion + " Stock";
            this.label1.Text = SessionHelper.accion + " Stock";
            CargarDG();
        }
        public void CargarDG()
        {
            List<Object> aux = new List<object>();
            foreach (var item in SessionHelper.productsIDList)
            {
                Producto p = productoService.obtenerProducto(item);
                aux.Add(new
                {
                    Id = item,
                    producto = p.nombre,
                    Stock = p.stock
                });
                
            }
            dataGridView1.DataSource = aux;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int length = dataGridView1.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                Producto p = productoService.obtenerProducto(Convert.ToInt32(dataGridView1.Rows[i].Cells["ID"].Value));
                p.nombre = dataGridView1.Rows[i].Cells["Producto"].Value.ToString();
                p.stock = SessionHelper.accion == "Carga" ? p.stock + Convert.ToDouble(dataGridView1.Rows[i].Cells["Cantidad"].Value) : p.stock - Convert.ToDouble(dataGridView1.Rows[i].Cells["Cantidad"].Value);
                productoService.editarProducto(p);
                Actividad a = new Actividad
                {
                    fechaHora = DateTime.Now,
                    tipoActividadId = SessionHelper.accion == "Carga" ? 1 : 2,
                    usuarioId = SessionHelper.userID.Value,
                    nota = textBox1.Text                                       
                };
                actividadService.agregarActividad(a);
            }
            SessionHelper.productsIDList.Clear();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SessionHelper.productsIDList.Clear();
            this.Close();
        }
    }
}
