using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ControlDeUsuarios
{
    public partial class MenuOpciones : Form
    {

        Usuario usuario = new Usuario();
        public MenuOpciones()
        {
            InitializeComponent();
            lbl_user.Text = usuario.usuario;
        }

        private void MenuOpciones_Load(object sender, EventArgs e)
        {

        }


        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quiere cerrar la instancia?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void btn_cerrarSesion_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quiere cerrar la Sesion?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                Form formulario = new InicioSesion();
                formulario.Show();
            }
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMostrador_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();
                                                                                     
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            
            else
            {
                formulario.BringToFront();
            }
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<UsuariosLista>();
        }

        private void btn_registros_Click(object sender, EventArgs e)
        {
            AbrirFormulario<RegistrosDePersonal>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Acceso>();
        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<About>();
        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
