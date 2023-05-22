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

        private void nacitanie_obrazkov()
        {
            hrac1_1.ImageLocation = "https://i.ibb.co/8DqFHjR/fotor-ai-20230510163746.png";
            hrac1_4.ImageLocation = "https://i.ibb.co/F5n7BJC/fotor-ai-20230510165126.png";
            hrac1_5.ImageLocation = "https://i.ibb.co/cwT9v4V/fotor-ai-20230510165456.jpg";
            hrac1_7.ImageLocation = "https://i.ibb.co/QcWN1hf/fotor-ai-20230510171217.png";
            hrac1_8.ImageLocation = "https://i.ibb.co/1dCMQG7/fotor-ai-20230510171528.png";
            hrac1_9.ImageLocation = "https://i.ibb.co/dKR7yvD/fotor-ai-2023051017293.jpg";
            hrac1_14.ImageLocation = "https://i.ibb.co/D78CnWB/fotor-ai-20230510194422.jpg";
            hrac1_16.ImageLocation = "https://i.ibb.co/sRxZ1g8/fotor-ai-20230510192641.png";
            hrac1_17.ImageLocation = "https://i.ibb.co/4PXQ3tj/fotor-ai-20230510191324.png";
            hrac1_18.ImageLocation = "https://i.ibb.co/g7TJqKx/fotor-ai-20230502191017.jpg";
            hrac1_19.ImageLocation = "https://i.ibb.co/RC8V6QJ/fotor-ai-202305101917.png";
            hrac1_20.ImageLocation = "https://i.ibb.co/604542Q/fotor-ai-20230510195647.png";
            hrac1_21.ImageLocation = "https://i.ibb.co/GW6704y/fotor-ai-2023051018390.jpg";
        }
        private void hrac1_1_Click(object sender, EventArgs e)
        {
            if(hrac1_1.ImageLocation == "https://i.ibb.co/8DqFHjR/fotor-ai-20230510163746.png")
            {
                hrac1_1.ImageLocation = "https://i.ibb.co/F5n7BJC/fotor-ai-20230510165126.png";
            }
            else if (hrac1_1.ImageLocation == "https://i.ibb.co/F5n7BJC/fotor-ai-20230510165126.png")
            {
                hrac1_1.ImageLocation = "https://i.ibb.co/8DqFHjR/fotor-ai-20230510163746.png";
            }
        }

    }
}
