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
    public partial class Doctor_Notas : Form
    {
        public Doctor_Notas()
        {
            InitializeComponent();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void rjButton1_Click(object sender, EventArgs e)
        {
            new Editar_Nota().Show();
        }

        private void bunifuShadowPanel2_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            new Registrar_Nota().Show();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            new Ver_Nota().Show();
        }
    }
}
