﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaUsuário frm = new FormConsultaUsuário()) 
            {
                frm.ShowDialog();
            }
        }
    }
}
