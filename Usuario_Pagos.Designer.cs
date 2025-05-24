namespace Pia_2._0
{
    partial class Usuario_Pagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label2 = new Label();
            Citas_Pendientes_Doctor = new Bunifu.UI.WinForms.BunifuDataGridView();
            Paciente = new DataGridViewTextBoxColumn();
            Doctor = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Ganancia = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Citas_Pendientes_Doctor).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(94, 37);
            label2.TabIndex = 5;
            label2.Text = "Pagos";
            // 
            // Citas_Pendientes_Doctor
            // 
            Citas_Pendientes_Doctor.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(203, 211, 211);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            Citas_Pendientes_Doctor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            Citas_Pendientes_Doctor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Citas_Pendientes_Doctor.BackgroundColor = SystemColors.ButtonHighlight;
            Citas_Pendientes_Doctor.BorderStyle = BorderStyle.None;
            Citas_Pendientes_Doctor.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Citas_Pendientes_Doctor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(37, 63, 63);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Citas_Pendientes_Doctor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Citas_Pendientes_Doctor.ColumnHeadersHeight = 40;
            Citas_Pendientes_Doctor.Columns.AddRange(new DataGridViewColumn[] { Paciente, Doctor, Monto, Ganancia, Fecha });
            Citas_Pendientes_Doctor.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(203, 211, 211);
            Citas_Pendientes_Doctor.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Citas_Pendientes_Doctor.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            Citas_Pendientes_Doctor.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(130, 149, 149);
            Citas_Pendientes_Doctor.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.White;
            Citas_Pendientes_Doctor.CurrentTheme.BackColor = Color.DarkSlateGray;
            Citas_Pendientes_Doctor.CurrentTheme.GridColor = Color.FromArgb(192, 202, 202);
            Citas_Pendientes_Doctor.CurrentTheme.HeaderStyle.BackColor = Color.DarkSlateGray;
            Citas_Pendientes_Doctor.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            Citas_Pendientes_Doctor.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            Citas_Pendientes_Doctor.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(37, 63, 63);
            Citas_Pendientes_Doctor.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            Citas_Pendientes_Doctor.CurrentTheme.Name = null;
            Citas_Pendientes_Doctor.CurrentTheme.RowsStyle.BackColor = Color.FromArgb(213, 219, 219);
            Citas_Pendientes_Doctor.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Citas_Pendientes_Doctor.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            Citas_Pendientes_Doctor.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(130, 149, 149);
            Citas_Pendientes_Doctor.CurrentTheme.RowsStyle.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(213, 219, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(130, 149, 149);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Citas_Pendientes_Doctor.DefaultCellStyle = dataGridViewCellStyle3;
            Citas_Pendientes_Doctor.EnableHeadersVisualStyles = false;
            Citas_Pendientes_Doctor.GridColor = Color.FromArgb(192, 202, 202);
            Citas_Pendientes_Doctor.HeaderBackColor = Color.DarkSlateGray;
            Citas_Pendientes_Doctor.HeaderBgColor = Color.Empty;
            Citas_Pendientes_Doctor.HeaderForeColor = Color.White;
            Citas_Pendientes_Doctor.Location = new Point(12, 55);
            Citas_Pendientes_Doctor.Name = "Citas_Pendientes_Doctor";
            Citas_Pendientes_Doctor.RowHeadersVisible = false;
            Citas_Pendientes_Doctor.RowTemplate.Height = 40;
            Citas_Pendientes_Doctor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Citas_Pendientes_Doctor.Size = new Size(1065, 630);
            Citas_Pendientes_Doctor.TabIndex = 4;
            Citas_Pendientes_Doctor.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkSlateGray;
            // 
            // Paciente
            // 
            Paciente.HeaderText = "Paciente";
            Paciente.Name = "Paciente";
            // 
            // Doctor
            // 
            Doctor.HeaderText = "Doctor";
            Doctor.Name = "Doctor";
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            // 
            // Ganancia
            // 
            Ganancia.HeaderText = "Ganancia";
            Ganancia.Name = "Ganancia";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Usuario_Pagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 697);
            Controls.Add(label2);
            Controls.Add(Citas_Pendientes_Doctor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Usuario_Pagos";
            Text = "Usuario_Pagos";
            Load += Usuario_Pagos_Load;
            ((System.ComponentModel.ISupportInitialize)Citas_Pendientes_Doctor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Bunifu.UI.WinForms.BunifuDataGridView Citas_Pendientes_Doctor;
        private DataGridViewTextBoxColumn Paciente;
        private DataGridViewTextBoxColumn Doctor;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Ganancia;
        private DataGridViewTextBoxColumn Fecha;
    }
}