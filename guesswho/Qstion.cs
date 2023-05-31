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
            if (typ_vlastnosti.Text == "pohlavie" || typ_vlastnosti.Text =="vlasy" || typ_vlastnosti.Text =="oči")
            {
                otazka.Text = "Má tvoja postava "+ vlastnosť.Text + " " + typ_vlastnosti.Text + "?";
                otazka.Visible = true;
            }
            else if (typ_vlastnosti.Text == "čiapku" || typ_vlastnosti.Text == "doplnok" || typ_vlastnosti.Text == "fúzy")
            {
                otazka.Text = "Má tvoja postava " + typ_vlastnosti.Text; 
            }
        }
        private void update_comboboxy()
        {
            if(typ_vlastnosti.Text == "pohlavie")
            {
                vlastnosť.Visible = true;
                vlastnosť.Items.Clear();
                vlastnosť.Items.Add("mužské");
                vlastnosť.Items.Add("ženské");
            }
            else if(typ_vlastnosti.Text == "vlasy")
            {
                vlastnosť.Visible = true;
                vlastnosť.Items.Clear();
                vlastnosť.Items.Add("čierne");
                vlastnosť.Items.Add("blond");
                vlastnosť.Items.Add("ryšavé");
                vlastnosť.Items.Add("biele");
                vlastnosť.Items.Add("hnedé");
                vlastnosť.Items.Add("žiadne");
            }
            else if(typ_vlastnosti.Text == "oči")
            {
                vlastnosť.Visible= true;
                vlastnosť.Items.Clear();
                vlastnosť.Items.Add("zelené");
                vlastnosť.Items.Add("modré");
                vlastnosť.Items.Add("hnedé");
            }
            else if(typ_vlastnosti.Text == "čiapku")
            {
                vlastnosť.Items.Clear();
                vlastnosť.Visible= false;
            }
            else if(typ_vlastnosti.Text == "doplnok")
            {
                vlastnosť.Items.Clear();
                vlastnosť.Visible= false;
            }
            else if(typ_vlastnosti.Text == "fúzy")
            {
                vlastnosť.Items.Clear();
                vlastnosť.Visible= false;
            }
        }

        private void potvrdenie_Click(object sender, EventArgs e)
        {
            update_comboboxy();
        }
    }
}
