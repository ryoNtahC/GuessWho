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
    public partial class Qstion : Form
    {
        public Qstion()
        {
            InitializeComponent();
        }

        private void spat(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ano_Click(object sender, EventArgs e)
        {
            odpoved.Text = "Áno";
            odpoved.ForeColor = Color.Green;
            odpoved.Visible = true;
        }

        private void nie_Click(object sender, EventArgs e)
        {
            odpoved.Visible = true;
            odpoved.Text = "Nie";
            odpoved.ForeColor = Color.Red;
            
        }

        private void spytaj_Click(object sender, EventArgs e)
        {
            otazka.Text = "Má tvoja postava" + " " + vlastnosť.Text + " " + typ_vlastnosti.Text + "?";
            otazka.Visible = true;
        }

    }
}
