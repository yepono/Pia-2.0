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
    public partial class Editar_Nota : Form
    {
        public Editar_Nota()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nota editada exitosamente");
            this.Close();

        }
    }
}
