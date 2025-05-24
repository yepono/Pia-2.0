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
    public partial class Registrar_Doctor_Clinica : Form
    {
        public Registrar_Doctor_Clinica()
        {
            InitializeComponent();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se agrego El doctor: A la clinica:");
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
