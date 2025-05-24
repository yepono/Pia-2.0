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
    public partial class Editar_Doctor_Clinica : Form
    {
        public Editar_Doctor_Clinica()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se elimino El doctor: De la clinica:");
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
