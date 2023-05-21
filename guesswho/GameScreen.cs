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
    public partial class GameScreen : Form
    {
        public GameScreen()
        {
            InitializeComponent();
           
            
        }

        private void hrac1_1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("SERVER=usa.vybrat.eu;PORT=3306;DATABASE=c43guesswho;UID=c43budos;PASSWORD=BziBy_aU7");
            connection.Open();
        }
    }
}
