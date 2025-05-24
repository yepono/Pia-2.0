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
    public partial class Usuario_Pacientes : Form
    {
        public Usuario_Pacientes()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            new Registrar_Paciente().Show();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            new Editar_Paciente().Show();
        }
    }
}
