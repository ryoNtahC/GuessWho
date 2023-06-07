using System;
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
    public partial class Rgst2 : Form
    {
        public Rgst2()
        {
            InitializeComponent();

        }

        MySqlConnection connection = new MySqlConnection("SERVER=usa.vybrat.eu;PORT=3306;DATABASE=c43guesswho;UID=c43budos;PASSWORD=BziBy_aU7");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textusername.Text == "" && textpassword.Text == "" && textpasswordconfirm.Text == "")
            {
                MessageBox.Show("Username and Password are epmty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textpassword.Text == textpasswordconfirm.Text)
            {
                connection.Open();
                string registered = "INSERT INTO uzivatelia VALUES ('" + textusername.Text + "','" + textpassword.Text + "')";
                var cmd = new MySqlCommand(registered, connection);
                cmd.ExecuteNonQuery();
                connection.Close();

                textpassword.Text = "";
                textpasswordconfirm.Text = "";
                textusername.Text = "";

                MessageBox.Show("Account Succesfully Created", "Registration Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords do not match", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textpassword.Text = "";
            textpasswordconfirm.Text = "";
            textpassword.Focus();
        }

        private void ist(object sender, EventArgs e)
        {
            this.Hide();
            Lgn2 login = new Lgn2();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textpassword.PasswordChar = '\0';
                textpasswordconfirm.PasswordChar = '\0';
            }
            else
            {
                textpassword.PasswordChar = '•';
                textpasswordconfirm.PasswordChar = '•';
            }
        }
    }
}
