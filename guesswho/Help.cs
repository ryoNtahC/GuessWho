﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guesswho
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void spat(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Closed += (s, args) => this.Close();
            menu.Show();

        }
    }
}
