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
    public partial class win1 : Form
    {
        public win1()
        {
            InitializeComponent();
            label1.Text = Lgn.tbx1.Text + " Vyhral!";
        }
    }
}
