namespace Pia_2._0
{
    partial class Usuario_Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario_Doctor));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label2 = new Label();
            rjButton4 = new PIA_1._0.RJButton();
            bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextBox();
            rjButton2 = new PIA_1._0.RJButton();
            rjButton1 = new PIA_1._0.RJButton();
            Citas_Pendientes_Doctor = new Bunifu.UI.WinForms.BunifuDataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Especialidad = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Activo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Citas_Pendientes_Doctor).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("CookieRunOTF Black", 20.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(133, 37);
            label2.TabIndex = 11;
            label2.Text = "Doctores";
            label2.Click += label2_Click;
            // 
            // rjButton4
            // 
            rjButton4.BackColor = Color.FromArgb(14, 40, 65);
            rjButton4.BackgroundColor = Color.FromArgb(14, 40, 65);
            rjButton4.BorderColor = Color.PaleVioletRed;
            rjButton4.BorderRadius = 15;
            rjButton4.BorderSize = 0;
            rjButton4.FlatAppearance.BorderSize = 0;
            rjButton4.FlatStyle = FlatStyle.Flat;
            rjButton4.ForeColor = Color.White;
            rjButton4.Location = new Point(839, 43);
            rjButton4.Name = "rjButton4";
            rjButton4.Size = new Size(116, 40);
            rjButton4.TabIndex = 21;
            rjButton4.Text = "Editar";
            rjButton4.TextColor = Color.White;
            rjButton4.UseVisualStyleBackColor = false;
            rjButton4.Click += rjButton4_Click;
            // 
            // bunifuTextBox1
            // 
            bunifuTextBox1.AcceptsReturn = false;
            bunifuTextBox1.AcceptsTab = false;
            bunifuTextBox1.AnimationSpeed = 200;
            bunifuTextBox1.AutoCompleteMode = AutoCompleteMode.None;
            bunifuTextBox1.AutoCompleteSource = AutoCompleteSource.None;
            bunifuTextBox1.AutoSizeHeight = true;
            bunifuTextBox1.BackColor = Color.Transparent;
            bunifuTextBox1.BackgroundImage = (Image)resources.GetObject("bunifuTextBox1.BackgroundImage");
            bunifuTextBox1.BorderColorActive = Color.DodgerBlue;
            bunifuTextBox1.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            bunifuTextBox1.BorderColorHover = Color.FromArgb(105, 181, 255);
            bunifuTextBox1.BorderColorIdle = Color.Silver;
            bunifuTextBox1.BorderRadius = 15;
            bunifuTextBox1.BorderThickness = 1;
            bunifuTextBox1.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            bunifuTextBox1.CharacterCasing = CharacterCasing.Normal;
            bunifuTextBox1.DefaultFont = new Font("Segoe UI", 9.25F);
            bunifuTextBox1.DefaultText = "";
            bunifuTextBox1.FillColor = Color.White;
            bunifuTextBox1.HideSelection = true;
            bunifuTextBox1.IconLeft = null;
            bunifuTextBox1.IconLeftCursor = Cursors.IBeam;
            bunifuTextBox1.IconPadding = 10;
            bunifuTextBox1.IconRight = null;
            bunifuTextBox1.IconRightCursor = Cursors.IBeam;
            bunifuTextBox1.Location = new Point(12, 51);
            bunifuTextBox1.MaxLength = 32767;
            bunifuTextBox1.MinimumSize = new Size(1, 1);
            bunifuTextBox1.Modified = false;
            bunifuTextBox1.Multiline = false;
            bunifuTextBox1.Name = "bunifuTextBox1";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            bunifuTextBox1.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            bunifuTextBox1.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            bunifuTextBox1.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Empty;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            bunifuTextBox1.OnIdleState = stateProperties4;
            bunifuTextBox1.Padding = new Padding(3);
            bunifuTextBox1.PasswordChar = '\0';
            bunifuTextBox1.PlaceholderForeColor = Color.Silver;
            bunifuTextBox1.PlaceholderText = "Buscar";
            bunifuTextBox1.ReadOnly = false;
            bunifuTextBox1.ScrollBars = ScrollBars.None;
            bunifuTextBox1.SelectedText = "";
            bunifuTextBox1.SelectionLength = 0;
            bunifuTextBox1.SelectionStart = 0;
            bunifuTextBox1.ShortcutsEnabled = true;
            bunifuTextBox1.Size = new Size(260, 32);
            bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            bunifuTextBox1.TabIndex = 19;
            bunifuTextBox1.TextAlign = HorizontalAlignment.Left;
            bunifuTextBox1.TextMarginBottom = 0;
            bunifuTextBox1.TextMarginLeft = 3;
            bunifuTextBox1.TextMarginTop = 1;
            bunifuTextBox1.TextPlaceholder = "Buscar";
            bunifuTextBox1.UseSystemPasswordChar = false;
            bunifuTextBox1.WordWrap = true;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.FromArgb(14, 40, 65);
            rjButton2.BackgroundColor = Color.FromArgb(14, 40, 65);
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 15;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.ForeColor = Color.White;
            rjButton2.Location = new Point(961, 43);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(116, 40);
            rjButton2.TabIndex = 18;
            rjButton2.Text = "Eliminar";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(14, 40, 65);
            rjButton1.BackgroundColor = Color.FromArgb(14, 40, 65);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 15;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(717, 43);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(116, 40);
            rjButton1.TabIndex = 17;
            rjButton1.Text = "Registrar";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click_1;
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
            Citas_Pendientes_Doctor.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Especialidad, Telefono, Correo, Activo });
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
            Citas_Pendientes_Doctor.Location = new Point(12, 86);
            Citas_Pendientes_Doctor.Name = "Citas_Pendientes_Doctor";
            Citas_Pendientes_Doctor.RowHeadersVisible = false;
            Citas_Pendientes_Doctor.RowTemplate.Height = 40;
            Citas_Pendientes_Doctor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Citas_Pendientes_Doctor.Size = new Size(1065, 617);
            Citas_Pendientes_Doctor.TabIndex = 16;
            Citas_Pendientes_Doctor.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkSlateGray;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Especialidad
            // 
            Especialidad.HeaderText = "Especialidad";
            Especialidad.Name = "Especialidad";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            // 
            // Activo
            // 
            Activo.HeaderText = "Activo";
            Activo.Name = "Activo";
            // 
            // Usuario_Doctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 697);
            Controls.Add(rjButton4);
            Controls.Add(bunifuTextBox1);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(Citas_Pendientes_Doctor);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Usuario_Doctor";
            Text = "Usuario_Doctor";
            ((System.ComponentModel.ISupportInitialize)Citas_Pendientes_Doctor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private PIA_1._0.RJButton rjButton4;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private PIA_1._0.RJButton rjButton2;
        private PIA_1._0.RJButton rjButton1;
        private Bunifu.UI.WinForms.BunifuDataGridView Citas_Pendientes_Doctor;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Especialidad;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Activo;
    }
}