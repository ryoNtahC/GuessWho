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
    public partial class Choose : Form
    {
        public Choose()
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

        private void ist(object sender, EventArgs e)
        {
            this.Hide();
            Rgst register = new Rgst();
            register.Closed += (s, args) => this.Close();
            register.Show();
        }

        private void Choose_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 praca = new Form2();
            praca.Closed += (s, args) => this.Close();
            praca.Show();
        }
    }
}
