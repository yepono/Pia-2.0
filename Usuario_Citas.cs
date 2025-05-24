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
    public partial class Usuario_Citas : Form
    {
        public Usuario_Citas()
        {
            InitializeComponent();
        }

        private void artanPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton8_Click(object sender, EventArgs e)
        {
            new Registrar_Cita().Show();
        }

        private void rjButton9_Click(object sender, EventArgs e)
        {
            new Editar_Cita().Show();
        }
    }
}
