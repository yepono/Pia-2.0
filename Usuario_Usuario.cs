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
    public partial class Usuario_Usuario : Form
    {
        public Usuario_Usuario()
        {
            InitializeComponent();
        }

        private void artanPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            new Registrar_Usuario().Show();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            new Editar_Usuario().Show();
        }
    }
}
