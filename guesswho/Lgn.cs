﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace guesswho
{
    public partial class Lgn : Form
    {
        public static TextBox tbx1;

        public Lgn()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("SERVER=usa.vybrat.eu;PORT=3306;DATABASE=c43guesswho;UID=c43budos;PASSWORD=BziBy_aU7");

        private void ist(object sender, EventArgs e)
        {
            this.Hide();
            Rgst register = new Rgst();
            register.Closed += (s, args) => this.Close();
            register.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            string loginning = "SELECT * FROM uzivatelia WHERE username= '" + textusername.Text + "' and password= '" + textpassword.Text + "'";
            var cmd = new MySqlCommand(loginning, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                this.Hide();
                Lgn2 login = new Lgn2();
                login.Closed += (s, args) => this.Close();
                login.Show();
                tbx1 = textusername;

            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textpassword.Text = "";
                textusername.Text = "";
                textusername.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textpassword.PasswordChar = '\0';
            }
            else
            {
                textpassword.PasswordChar = '•';
            }
        }
    }
}
