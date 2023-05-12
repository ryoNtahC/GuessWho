
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

namespace guesswho
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
         private void Databaza(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("SERVER=usa.vybrat.eu;PORT=3306;DATABASE=c43guesswho;UID=c43budos;PASSWORD=BziBy_aU7");
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    conection.Text = "Connected";
                    conection.ForeColor = Color.Green;

                }
                else
                {
                    conection.Text = "Not Connected";
                    conection.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }   

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ZacatHru(object sender, EventArgs e)
        {
            this.Hide();
            GameScreen hraciaplocha = new GameScreen();
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

        
    }
}
