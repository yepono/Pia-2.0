using Pia_2._0.DAO;
using Pia_2._0.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pia_2._0
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txt2Id_Usuario.Visible = false;
            txt2Contrasena.Visible = false;
            rjButton5.Visible = false;
            rjButton3.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void rjButton5_Click(object sender, EventArgs e)
        {


            txtId_Usuario.Visible = true;
            txtContrasena.Visible = true;
            txt2Id_Usuario.Visible = false;
            txt2Contrasena.Visible = false;
            rjButton5.Visible = false;
            rjButton4.Visible = true;
            rjButton3.Visible = false;
            rjButton1.Visible = true;


        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            int id_usuario;
            string contrasena = txtContrasena.Text.Trim(); // trim remueve los espacios en blanco


            if (int.TryParse(txtId_Usuario.Text, out id_usuario))
            {
                Usuario usuario = UsuarioDAO.Login(id_usuario, contrasena);

                if (usuario == null)
                {
                    MessageBox.Show("Id o contraseña incorrectos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (usuario.EsActivo == false)
                {
                    MessageBox.Show("Usuario inactivo, acceso denegado.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //Application.Exit();
                    return;
                }

                if (usuario.Rol != "Doctor")
                {
                    MessageBox.Show("Id y Contraseña no coinciden con el tipo de usuario.");
                    return;
                }

                if (txtId_Usuario.Text == (usuario.IdUsuario).ToString())
                {

                    MessageBox.Show("Bienvenido Doctor");
                    new Form2().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos. Por favor, intente nuevamente.");
                }

            }
            else
            {
                MessageBox.Show("Por favor ingresa un ID de usuario válido (número entero).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            int id_usuario;
            string contrasena = txt2Contrasena.Text.Trim(); // trim remueve los espacios en blanco


            if (int.TryParse(txt2Id_Usuario.Text, out id_usuario))
            {
                Usuario usuario = UsuarioDAO.Login(id_usuario, contrasena);

                if (usuario == null)
                {
                    MessageBox.Show("Id o contraseña incorrectos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (usuario.EsActivo == false)
                {
                    MessageBox.Show("Usuario inactivo, acceso denegado.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //Application.Exit();
                    return;
                }

                if (usuario.Rol != "Admin")
                {
                    MessageBox.Show("Id y Contraseña no coinciden con el tipo de usuario.");
                    return;
                }

                if (txt2Id_Usuario.Text == (usuario.IdUsuario).ToString())
                {

                    MessageBox.Show("Bienvenido Administrador");
                    new Form2().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos. Por favor, intente nuevamente.");
                }

            }
            else
            {
                MessageBox.Show("Por favor ingresa un ID de usuario válido (número entero).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //doctor
        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //doctor
        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            txtId_Usuario.Visible = false;
            txtContrasena.Visible = false;
            txt2Id_Usuario.Visible = true;
            txt2Contrasena.Visible = true;
            rjButton5.Visible = true;
            rjButton4.Visible = false;
            rjButton3.Visible = true;
            rjButton1.Visible = false;
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}