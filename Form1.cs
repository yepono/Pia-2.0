namespace Pia_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnIniDoc_Click_1(object sender, EventArgs e)
        {
            LoadForm(new Doctor_Inicio());
        }

        private void Boton_Citas_Doctor_Click(object sender, EventArgs e)
        {
            LoadForm(new Doctor_Citas());
        }

        private void Boton_Calendario_Doctor_Click(object sender, EventArgs e)
        {
            LoadForm(new Doctor_Calendario());
        }

        private void Boton_Clinicas_Doctor_Click(object sender, EventArgs e)
        {
            LoadForm(new Doctor_Clinicas());
        }

        private void Boton_Notas_Doctor_Click(object sender, EventArgs e)
        {
            LoadForm(new Doctor_Notas());
        }


        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            LoadForm(new Vacaciones_doctor());
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            LoadForm(new Usuario_Usuario());
        }

        private void mainpanel_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
