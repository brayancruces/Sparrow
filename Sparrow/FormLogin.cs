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
    public partial class FormLogin : Form
    {
        IUsuarioService usuarioService;
        public FormLogin()
        {
            usuarioService = new UsuarioService();
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            FormDashboard formDashboard = new FormDashboard();
            if (usuarioService.IniciarSesion(username,password))
            {
                lblError.Visible = false;
                this.Hide();
                formDashboard.ShowDialog();
                this.Show();
            }
            else
            {
                lblError.Visible = true;
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
