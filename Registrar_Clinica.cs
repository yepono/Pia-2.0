﻿using System;
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
    public partial class Registrar_Clinica : Form
    {
        public Registrar_Clinica()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clinica registrada exitosamente");
            this.Close();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
