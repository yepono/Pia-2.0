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
    public partial class Registrar_Usuario : Form
    {
        public Registrar_Usuario()
        {
            InitializeComponent();
        }

        private void LimpiarFormulario()
        {
            txtContrasena.Clear();
            DropdownRol.SelectedIndex = -1;
        }

        private void Registrar_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContrasena.Text) || string.IsNullOrWhiteSpace(DropdownRol.Text))
            {
                MessageBox.Show("Se deben llenar todos los campos.");
                return;
            }

            //if (!ValidarCampos())
            //  return;

            Usuario usuario = new Usuario
            {
                Contra = txtContrasena.Text.Trim(),
                Rol = DropdownRol.Text.Trim(),
            };

            // Registro nuevo
            int idGenerado = UsuarioDAO.InsertarUsuario(usuario);
            MessageBox.Show($"Usuario creado exitosamente\n\nID: {idGenerado}\nRol: {usuario.Rol}",
                            "Usuario Creado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            LimpiarFormulario();
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}