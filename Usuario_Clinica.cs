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
    public partial class Usuario_Clinica : Form
    {
        public Usuario_Clinica()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cambiaste de clinica exitosamente");
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            new Registrar_Clinica().Show();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            new Editar_Clinica().Show();
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            new Registrar_Doctor_Clinica().Show();
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            new Editar_Doctor_Clinica().Show();
        }
    }
}
