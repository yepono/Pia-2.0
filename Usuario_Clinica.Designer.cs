namespace Pia_2._0
{
    partial class Usuario_Clinica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario_Clinica));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextBox();
            rjButton1 = new PIA_1._0.RJButton();
            rjButton2 = new PIA_1._0.RJButton();
            rjButton3 = new PIA_1._0.RJButton();
            rjButton4 = new PIA_1._0.RJButton();
            bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            Clinica = new DataGridViewTextBoxColumn();
            Paciente = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            rjButton5 = new PIA_1._0.RJButton();
            rjButton6 = new PIA_1._0.RJButton();
            ((System.ComponentModel.ISupportInitialize)bunifuDataGridView1).BeginInit();
            SuspendLayout();
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
            bunifuTextBox1.BorderRadius = 20;
            bunifuTextBox1.BorderThickness = 1;
            bunifuTextBox1.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            bunifuTextBox1.CharacterCasing = CharacterCasing.Normal;
            bunifuTextBox1.DefaultFont = new Font("Segoe UI", 9.25F);
            bunifuTextBox1.DefaultText = "Buscar";
            bunifuTextBox1.FillColor = Color.White;
            bunifuTextBox1.HideSelection = true;
            bunifuTextBox1.IconLeft = null;
            bunifuTextBox1.IconLeftCursor = Cursors.IBeam;
            bunifuTextBox1.IconPadding = 10;
            bunifuTextBox1.IconRight = null;
            bunifuTextBox1.IconRightCursor = Cursors.IBeam;
            bunifuTextBox1.Lines = new string[]
    {
    "Buscar"
    };
            bunifuTextBox1.Location = new Point(12, 15);
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
            bunifuTextBox1.PlaceholderText = "Enter text";
            bunifuTextBox1.ReadOnly = false;
            bunifuTextBox1.ScrollBars = ScrollBars.None;
            bunifuTextBox1.SelectedText = "";
            bunifuTextBox1.SelectionLength = 0;
            bunifuTextBox1.SelectionStart = 6;
            bunifuTextBox1.ShortcutsEnabled = true;
            bunifuTextBox1.Size = new Size(260, 39);
            bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            bunifuTextBox1.TabIndex = 5;
            bunifuTextBox1.TextAlign = HorizontalAlignment.Left;
            bunifuTextBox1.TextMarginBottom = 0;
            bunifuTextBox1.TextMarginLeft = 3;
            bunifuTextBox1.TextMarginTop = 1;
            bunifuTextBox1.TextPlaceholder = "Enter text";
            bunifuTextBox1.UseSystemPasswordChar = false;
            bunifuTextBox1.WordWrap = true;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.MidnightBlue;
            rjButton1.BackgroundColor = Color.MidnightBlue;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 15;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(278, 15);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(107, 39);
            rjButton1.TabIndex = 6;
            rjButton1.Text = "Cambiar";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.MidnightBlue;
            rjButton2.BackgroundColor = Color.MidnightBlue;
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 15;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.ForeColor = Color.White;
            rjButton2.Location = new Point(391, 15);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(107, 39);
            rjButton2.TabIndex = 7;
            rjButton2.Text = "Registrar";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.MidnightBlue;
            rjButton3.BackgroundColor = Color.MidnightBlue;
            rjButton3.BorderColor = Color.PaleVioletRed;
            rjButton3.BorderRadius = 15;
            rjButton3.BorderSize = 0;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.ForeColor = Color.White;
            rjButton3.Location = new Point(504, 15);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(107, 39);
            rjButton3.TabIndex = 8;
            rjButton3.Text = "Editar";
            rjButton3.TextColor = Color.White;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += rjButton3_Click;
            // 
            // rjButton4
            // 
            rjButton4.BackColor = Color.MidnightBlue;
            rjButton4.BackgroundColor = Color.MidnightBlue;
            rjButton4.BorderColor = Color.PaleVioletRed;
            rjButton4.BorderRadius = 15;
            rjButton4.BorderSize = 0;
            rjButton4.FlatAppearance.BorderSize = 0;
            rjButton4.FlatStyle = FlatStyle.Flat;
            rjButton4.ForeColor = Color.White;
            rjButton4.Location = new Point(617, 15);
            rjButton4.Name = "rjButton4";
            rjButton4.Size = new Size(107, 39);
            rjButton4.TabIndex = 9;
            rjButton4.Text = "Eliminar";
            rjButton4.TextColor = Color.White;
            rjButton4.UseVisualStyleBackColor = false;
            // 
            // bunifuDataGridView1
            // 
            bunifuDataGridView1.AllowCustomTheming = false;
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
            bunifuDataGridView1.Columns.AddRange(new DataGridViewColumn[] { Clinica, Paciente, Fecha, Hora });
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
            bunifuDataGridView1.HeaderBgColor = Color.Empty;
            bunifuDataGridView1.HeaderForeColor = Color.White;
            bunifuDataGridView1.Location = new Point(12, 60);
            bunifuDataGridView1.Name = "bunifuDataGridView1";
            bunifuDataGridView1.RowHeadersVisible = false;
            bunifuDataGridView1.RowTemplate.Height = 40;
            bunifuDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bunifuDataGridView1.Size = new Size(1065, 612);
            bunifuDataGridView1.TabIndex = 10;
            bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Clinica
            // 
            Clinica.HeaderText = "Clinica";
            Clinica.Name = "Clinica";
            // 
            // Paciente
            // 
            Paciente.HeaderText = "Paciente";
            Paciente.Name = "Paciente";
            Paciente.Resizable = DataGridViewTriState.True;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Hora
            // 
            Hora.HeaderText = "Hora";
            Hora.Name = "Hora";
            // 
            // rjButton5
            // 
            rjButton5.BackColor = Color.RoyalBlue;
            rjButton5.BackgroundColor = Color.RoyalBlue;
            rjButton5.BorderColor = Color.PaleVioletRed;
            rjButton5.BorderRadius = 15;
            rjButton5.BorderSize = 0;
            rjButton5.FlatAppearance.BorderSize = 0;
            rjButton5.FlatStyle = FlatStyle.Flat;
            rjButton5.ForeColor = Color.White;
            rjButton5.Location = new Point(730, 15);
            rjButton5.Name = "rjButton5";
            rjButton5.Size = new Size(107, 39);
            rjButton5.TabIndex = 11;
            rjButton5.Text = "Agregar Doctor";
            rjButton5.TextColor = Color.White;
            rjButton5.UseVisualStyleBackColor = false;
            rjButton5.Click += rjButton5_Click;
            // 
            // rjButton6
            // 
            rjButton6.BackColor = Color.RoyalBlue;
            rjButton6.BackgroundColor = Color.RoyalBlue;
            rjButton6.BorderColor = Color.PaleVioletRed;
            rjButton6.BorderRadius = 15;
            rjButton6.BorderSize = 0;
            rjButton6.FlatAppearance.BorderSize = 0;
            rjButton6.FlatStyle = FlatStyle.Flat;
            rjButton6.ForeColor = Color.White;
            rjButton6.Location = new Point(843, 15);
            rjButton6.Name = "rjButton6";
            rjButton6.Size = new Size(107, 39);
            rjButton6.TabIndex = 12;
            rjButton6.Text = "Editar Doctor";
            rjButton6.TextColor = Color.White;
            rjButton6.UseVisualStyleBackColor = false;
            rjButton6.Click += rjButton6_Click;
            // 
            // Usuario_Clinica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 697);
            Controls.Add(rjButton6);
            Controls.Add(rjButton5);
            Controls.Add(bunifuDataGridView1);
            Controls.Add(rjButton4);
            Controls.Add(rjButton3);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(bunifuTextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Usuario_Clinica";
            Text = "Usuario_Clinica";
            ((System.ComponentModel.ISupportInitialize)bunifuDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private PIA_1._0.RJButton rjButton1;
        private PIA_1._0.RJButton rjButton2;
        private PIA_1._0.RJButton rjButton3;
        private PIA_1._0.RJButton rjButton4;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private DataGridViewTextBoxColumn Clinica;
        private DataGridViewTextBoxColumn Paciente;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Hora;
        private PIA_1._0.RJButton rjButton5;
        private PIA_1._0.RJButton rjButton6;
    }
}