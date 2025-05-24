using Bunifu.UI.WinForms;
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
    public partial class Usuario_Doctor : Form
    {
        public Usuario_Doctor()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Citas_Pendientes_Doctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            new Registrar_Doctor().Show();

        }

        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            new Registrar_Doctor().Show();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            new Editar_Doctor().Show();
        }
    }
}
