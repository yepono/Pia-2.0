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
    public partial class Registrar_Paciente : Form
    {
        public Registrar_Paciente()
        {
            InitializeComponent();
        }

        private void bunifuvScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel9_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paciente Registrado exitosamente");
            this.Close();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuTextBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
