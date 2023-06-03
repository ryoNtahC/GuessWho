using System;
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
    public partial class Prechod : Form
    {
        public Prechod()
        {
            InitializeComponent();
        }

        private void pokracuj(object sender, EventArgs e)
        {

            GameScreen2 hracka2 = Application.OpenForms.OfType<GameScreen2>().FirstOrDefault();
            if (hracka2 != null)
            {
                hracka2.Show();
            }
            else
            {
                hracka2 = new GameScreen2();
                hracka2.Show();
            }
            this.Close();

        }
    }
}
