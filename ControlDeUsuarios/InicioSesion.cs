using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeUsuarios
{
    public partial class InicioSesion : Form
    {
        Usuario usuar = new Usuario();
        
        public InicioSesion()
        {
            InitializeComponent();
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {
            
            if(txt_password.Text.Equals(usuar.usuario) && txt_user.Text.Equals(usuar.contrasena))
            {
                Form formulario = new MenuOpciones();
                formulario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos!!");
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
