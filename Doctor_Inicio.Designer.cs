namespace Pia_2._0
{
    partial class Doctor_Inicio
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor_Inicio));
            label1 = new Label();
            label2 = new Label();
            bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            bunifuDataGridView3 = new Bunifu.UI.WinForms.BunifuDataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            bunifuPanel4 = new Bunifu.UI.WinForms.BunifuPanel();
            label3 = new Label();
            label4 = new Label();
            bunifuPanel5 = new Bunifu.UI.WinForms.BunifuPanel();
            label5 = new Label();
            bunifuPanel6 = new Bunifu.UI.WinForms.BunifuPanel();
            Boton_Cancelar = new DataGridViewLinkColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Motivo = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bunifuDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bunifuDataGridView3).BeginInit();
            bunifuPanel1.SuspendLayout();
            bunifuPanel2.SuspendLayout();
            bunifuPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 189);
            label1.Name = "label1";
            label1.Size = new Size(202, 32);
            label1.TabIndex = 7;
            label1.Text = "Citas pendientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(621, 189);
            label2.Name = "label2";
            label2.Size = new Size(198, 32);
            label2.TabIndex = 8;
            label2.Text = "Citas concluidas";
            // 
            // bunifuDataGridView1
            // 
            bunifuDataGridView1.AllowCustomTheming = false;
            bunifuDataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            bunifuDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bunifuDataGridView1.BorderStyle = BorderStyle.None;
            bunifuDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            bunifuDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            bunifuDataGridView1.ColumnHeadersHeight = 40;
            bunifuDataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Edad, Motivo, Fecha, Boton_Cancelar });
            bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            bunifuDataGridView1.CurrentTheme.BackColor = Color.White;
            bunifuDataGridView1.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            bunifuDataGridView1.CurrentTheme.Name = null;
            bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = Color.White;
            bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            bunifuDataGridView1.EnableHeadersVisualStyles = false;
            bunifuDataGridView1.GridColor = Color.FromArgb(221, 238, 255);
            bunifuDataGridView1.HeaderBackColor = Color.DodgerBlue;
            bunifuDataGridView1.HeaderBackColor = Color.Empty;
            bunifuDataGridView1.HeaderForeColor = Color.White;
            bunifuDataGridView1.Location = new Point(49, 224);
            bunifuDataGridView1.Name = "bunifuDataGridView1";
            bunifuDataGridView1.ReadOnly = true;
            bunifuDataGridView1.RowHeadersVisible = false;
            bunifuDataGridView1.RowTemplate.Height = 40;
            bunifuDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bunifuDataGridView1.Size = new Size(425, 570);
            bunifuDataGridView1.TabIndex = 9;
            bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            bunifuDataGridView1.CellContentClick += bunifuDataGridView1_CellContentClick;
            // 
            // bunifuDataGridView3
            // 
            bunifuDataGridView3.AllowCustomTheming = false;
            bunifuDataGridView3.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            bunifuDataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            bunifuDataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bunifuDataGridView3.BorderStyle = BorderStyle.None;
            bunifuDataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            bunifuDataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            bunifuDataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            bunifuDataGridView3.ColumnHeadersHeight = 40;
            bunifuDataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            bunifuDataGridView3.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            bunifuDataGridView3.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            bunifuDataGridView3.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            bunifuDataGridView3.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            bunifuDataGridView3.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            bunifuDataGridView3.CurrentTheme.BackColor = Color.White;
            bunifuDataGridView3.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            bunifuDataGridView3.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            bunifuDataGridView3.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            bunifuDataGridView3.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            bunifuDataGridView3.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            bunifuDataGridView3.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            bunifuDataGridView3.CurrentTheme.Name = null;
            bunifuDataGridView3.CurrentTheme.RowsStyle.BackColor = Color.White;
            bunifuDataGridView3.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            bunifuDataGridView3.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            bunifuDataGridView3.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            bunifuDataGridView3.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            bunifuDataGridView3.DefaultCellStyle = dataGridViewCellStyle6;
            bunifuDataGridView3.EnableHeadersVisualStyles = false;
            bunifuDataGridView3.GridColor = Color.FromArgb(221, 238, 255);
            bunifuDataGridView3.HeaderBackColor = Color.DodgerBlue;
            bunifuDataGridView3.HeaderBackColor = Color.Empty;
            bunifuDataGridView3.HeaderForeColor = Color.White;
            bunifuDataGridView3.Location = new Point(621, 224);
            bunifuDataGridView3.Name = "bunifuDataGridView3";
            bunifuDataGridView3.ReadOnly = true;
            bunifuDataGridView3.RowHeadersVisible = false;
            bunifuDataGridView3.RowTemplate.Height = 40;
            bunifuDataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bunifuDataGridView3.Size = new Size(425, 570);
            bunifuDataGridView3.TabIndex = 11;
            bunifuDataGridView3.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Edad";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Motivo";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Fecha";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // bunifuPanel1
            // 
            bunifuPanel1.BackgroundColor = Color.DodgerBlue;
            bunifuPanel1.BackgroundImage = (Image)resources.GetObject("bunifuPanel1.BackgroundImage");
            bunifuPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuPanel1.BorderColor = Color.Transparent;
            bunifuPanel1.BorderRadius = 15;
            bunifuPanel1.BorderThickness = 1;
            bunifuPanel1.Controls.Add(label4);
            bunifuPanel1.Controls.Add(bunifuPanel5);
            bunifuPanel1.Location = new Point(49, 33);
            bunifuPanel1.Name = "bunifuPanel1";
            bunifuPanel1.ShowBorders = true;
            bunifuPanel1.Size = new Size(200, 100);
            bunifuPanel1.TabIndex = 12;
            bunifuPanel1.Click += bunifuPanel1_Click_1;
            // 
            // bunifuPanel2
            // 
            bunifuPanel2.BackgroundColor = Color.DodgerBlue;
            bunifuPanel2.BackgroundImage = (Image)resources.GetObject("bunifuPanel2.BackgroundImage");
            bunifuPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuPanel2.BorderColor = Color.Transparent;
            bunifuPanel2.BorderRadius = 15;
            bunifuPanel2.BorderThickness = 1;
            bunifuPanel2.Controls.Add(label3);
            bunifuPanel2.Controls.Add(bunifuPanel4);
            bunifuPanel2.Location = new Point(450, 33);
            bunifuPanel2.Name = "bunifuPanel2";
            bunifuPanel2.ShowBorders = true;
            bunifuPanel2.Size = new Size(200, 100);
            bunifuPanel2.TabIndex = 13;
            // 
            // bunifuPanel3
            // 
            bunifuPanel3.BackgroundColor = Color.DodgerBlue;
            bunifuPanel3.BackgroundImage = (Image)resources.GetObject("bunifuPanel3.BackgroundImage");
            bunifuPanel3.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuPanel3.BorderColor = Color.Transparent;
            bunifuPanel3.BorderRadius = 15;
            bunifuPanel3.BorderThickness = 1;
            bunifuPanel3.Controls.Add(label5);
            bunifuPanel3.Controls.Add(bunifuPanel6);
            bunifuPanel3.Location = new Point(846, 33);
            bunifuPanel3.Name = "bunifuPanel3";
            bunifuPanel3.ShowBorders = true;
            bunifuPanel3.Size = new Size(200, 100);
            bunifuPanel3.TabIndex = 14;
            // 
            // bunifuPanel4
            // 
            bunifuPanel4.BackgroundColor = Color.AliceBlue;
            bunifuPanel4.BackgroundImage = (Image)resources.GetObject("bunifuPanel4.BackgroundImage");
            bunifuPanel4.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuPanel4.BorderColor = Color.Transparent;
            bunifuPanel4.BorderRadius = 30;
            bunifuPanel4.BorderThickness = 1;
            bunifuPanel4.Location = new Point(107, 15);
            bunifuPanel4.Name = "bunifuPanel4";
            bunifuPanel4.ShowBorders = true;
            bunifuPanel4.Size = new Size(79, 66);
            bunifuPanel4.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(6, 24);
            label3.Name = "label3";
            label3.Size = new Size(95, 42);
            label3.TabIndex = 15;
            label3.Text = "Citas\r\npendientes";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(7, 24);
            label4.Name = "label4";
            label4.Size = new Size(75, 42);
            label4.TabIndex = 17;
            label4.Text = "Pago\r\nMensual";
            // 
            // bunifuPanel5
            // 
            bunifuPanel5.BackgroundColor = Color.AliceBlue;
            bunifuPanel5.BackgroundImage = (Image)resources.GetObject("bunifuPanel5.BackgroundImage");
            bunifuPanel5.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuPanel5.BorderColor = Color.Transparent;
            bunifuPanel5.BorderRadius = 30;
            bunifuPanel5.BorderThickness = 1;
            bunifuPanel5.Location = new Point(108, 15);
            bunifuPanel5.Name = "bunifuPanel5";
            bunifuPanel5.ShowBorders = true;
            bunifuPanel5.Size = new Size(79, 66);
            bunifuPanel5.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(8, 24);
            label5.Name = "label5";
            label5.Size = new Size(94, 42);
            label5.TabIndex = 19;
            label5.Text = "Citas\r\nConcluidas";
            // 
            // bunifuPanel6
            // 
            bunifuPanel6.BackgroundColor = Color.AliceBlue;
            bunifuPanel6.BackgroundImage = (Image)resources.GetObject("bunifuPanel6.BackgroundImage");
            bunifuPanel6.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuPanel6.BorderColor = Color.Transparent;
            bunifuPanel6.BorderRadius = 30;
            bunifuPanel6.BorderThickness = 1;
            bunifuPanel6.Location = new Point(109, 15);
            bunifuPanel6.Name = "bunifuPanel6";
            bunifuPanel6.ShowBorders = true;
            bunifuPanel6.Size = new Size(79, 66);
            bunifuPanel6.TabIndex = 18;
            // 
            // Boton_Cancelar
            // 
            Boton_Cancelar.HeaderText = "";
            Boton_Cancelar.Name = "Boton_Cancelar";
            Boton_Cancelar.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Motivo
            // 
            Motivo.HeaderText = "Motivo";
            Motivo.Name = "Motivo";
            Motivo.ReadOnly = true;
            // 
            // Edad
            // 
            Edad.HeaderText = "Edad";
            Edad.Name = "Edad";
            Edad.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Doctor_Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 697);
            Controls.Add(bunifuPanel3);
            Controls.Add(bunifuPanel2);
            Controls.Add(bunifuPanel1);
            Controls.Add(bunifuDataGridView3);
            Controls.Add(bunifuDataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Doctor_Inicio";
            Text = "Doctor_Inicio";
            ((System.ComponentModel.ISupportInitialize)bunifuDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bunifuDataGridView3).EndInit();
            bunifuPanel1.ResumeLayout(false);
            bunifuPanel1.PerformLayout();
            bunifuPanel2.ResumeLayout(false);
            bunifuPanel2.PerformLayout();
            bunifuPanel3.ResumeLayout(false);
            bunifuPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel4;
        private Label label3;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Motivo;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewLinkColumn Boton_Cancelar;
        private Label label4;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel5;
        private Label label5;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel6;
    }
}