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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void LoadForm(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();

        }

        private void BtnIniDoc_Click(object sender, EventArgs e)
        {
            LoadForm(new Usuario_Inicio());
        }

        private void Boton_Citas_Doctor_Click(object sender, EventArgs e)
        {
            LoadForm(new Usuario_Citas());
        }

        private void Boton_Calendario_Doctor_Click(object sender, EventArgs e)
        {
            LoadForm(new Usuario_Calendario());
        }

        private void Boton_Clinicas_Doctor_Click(object sender, EventArgs e)
        {
            LoadForm(new Usuario_Clinica());
        }

        private void Boton_Notas_Doctor_Click(object sender, EventArgs e)
        {
            LoadForm(new Usuario_Doctor());
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            LoadForm(new Usuario_Pagos());
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            LoadForm(new Usuario_Pacientes());
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            LoadForm(new Usuario_Vacaciones());
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            LoadForm(new Usuario_Usuario());
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
