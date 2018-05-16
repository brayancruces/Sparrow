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
        public FormInventario()
        {
            InitializeComponent();
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            FormInventarioEditItem formInventarioEditItem = new FormInventarioEditItem();

            formInventarioEditItem.ShowDialog();
       
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
    }
}
