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
    public partial class Prechod2 : Form
    {
        public Prechod2()
        {
            InitializeComponent();
        }

        private void pokracuj(object sender, EventArgs e)
        {
            GameScreen hracka = Application.OpenForms.OfType<GameScreen>().FirstOrDefault();
            if (hracka != null)
            {
                hracka.Show();
            }
            else
            {
                hracka = new GameScreen();
                hracka.Show();
            }
            this.Hide();
        }
    }
}
