using Sparrow.Domain;
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
    public partial class FormLog : Form
    {
        IActividadService actividadService;
        public FormLog()
        {
            actividadService = new ActividadService();
            InitializeComponent();
            IEnumerable<Object> lista = actividadService.listarActividades();
            dataGridView1.DataSource = lista;
        }

        private void FormLog_Load(object sender, EventArgs e)
        {

        }
    }
}
