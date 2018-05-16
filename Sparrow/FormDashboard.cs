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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {


            FormInventario formInventario = new FormInventario();

            // And  others 
            this.Hide();

            formInventario.ShowDialog();
            this.Show();

        }

        private void buttonLog_Click(object sender, EventArgs e)
        {

            FormLog formLog = new FormLog();

            // And  others 
            this.Hide();

            formLog.ShowDialog();
            this.Show();


        }
    }
}
