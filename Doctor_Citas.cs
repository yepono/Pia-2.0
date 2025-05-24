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
    public partial class Doctor_Citas : Form
    {


        public Doctor_Citas()
        {
            InitializeComponent();
            bunifuPanel2.Visible = false;
            bunifuPanel3.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Citas_Concluidas_Doctor.Visible = false;
            Citas_pendientes_boton_doc.Visible = true;
            bunifuPanel1.Visible = false;
            bunifuPanel3.Visible = false;
            bunifuPanel2.Visible = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Citas_Canceladas_Doctor_Click(object sender, EventArgs e)
        {
            bunifuPanel1.Visible = false;
            bunifuPanel2.Visible = false;
            bunifuPanel3.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Citas_pendientes_boton_doc_Click(object sender, EventArgs e)
        {
            Citas_pendientes_boton_doc.Visible = false;
            Citas_Concluidas_Doctor.Visible = true;
            bunifuPanel2.Visible = false;
            bunifuPanel1.Visible = true;
            bunifuPanel3.Visible = false;

        }

        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {

        }

        private void Doctor_Citas_Load(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }
    }
}
