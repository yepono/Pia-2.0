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
    public partial class Registrar_Nota : Form
    {
        public Registrar_Nota()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nota registrada exitosamente");
            this.Close();
        }
    }
}
