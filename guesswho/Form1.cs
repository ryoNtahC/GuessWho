﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace guesswho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ZacatHru(object sender, EventArgs e)
        {
            this.Hide();
            Choose hraciaplocha = new Choose();
            hraciaplocha.Closed += (s, args) => this.Close();
            hraciaplocha.Show();

        }

        private void rules(object sender, EventArgs e)
        {
            this.Hide();
            Help pravidla = new Help();
            pravidla.Closed += (s, args) => this.Close();
            pravidla.Show();

        }

        private void controls(object sender, EventArgs e)
        {
            this.Hide();
            Ovlad ovladanie = new Ovlad();
            ovladanie.Closed += (s, args) => this.Close();
            ovladanie.Show();
        }
    }
}