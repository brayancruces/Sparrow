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
    public partial class FormDashboard : Form
    {
        IUsuarioService usuarioService;
        public FormDashboard()
        {
            usuarioService = new UsuarioService();
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

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            usuarioService.CerrarSesion();
            this.Close();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario = usuarioService.ObtenerUsuario(SessionHelper.userID.Value);
            this.labelBienvenido.Text = "Bienvenido " + usuario.nombre + " " + usuario.apellido;
            this.labelRol.Text = "Rol: " + usuario.Rol.nombre;
        }
    }
}
