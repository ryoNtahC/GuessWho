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
            nacitanie_obrazkov();
            
        }
        string[] pandrlaci =
        {
            "https://i.ibb.co/8DqFHjR/fotor-ai-20230510163746.png" , "https://i.ibb.co/F5n7BJC/fotor-ai-20230510165126.png" , "https://i.ibb.co/cwT9v4V/fotor-ai-20230510165456.jpg" , "https://i.ibb.co/QcWN1hf/fotor-ai-20230510171217.png" ,
            "https://i.ibb.co/1dCMQG7/fotor-ai-20230510171528.png" , "https://i.ibb.co/dKR7yvD/fotor-ai-2023051017293.jpg" , "https://i.ibb.co/D78CnWB/fotor-ai-20230510194422.jpg" , "https://i.ibb.co/sRxZ1g8/fotor-ai-20230510192641.png" ,
            "https://i.ibb.co/4PXQ3tj/fotor-ai-20230510191324.png" , "https://i.ibb.co/g7TJqKx/fotor-ai-20230502191017.jpg" , "https://i.ibb.co/RC8V6QJ/fotor-ai-202305101917.png" , "https://i.ibb.co/604542Q/fotor-ai-20230510195647.png" ,
            "https://i.ibb.co/GW6704y/fotor-ai-2023051018390.jpg" , "https://i.ibb.co/3N2LThx/fotor-ai-20230510181053.png" , "https://i.ibb.co/NFPGCcK/fotor-ai-20230510175316.jpg"
        };
        private void nacitanie_obrazkov()
        {
            hrac1_1.ImageLocation = pandrlaci[0];
            hrac1_4.ImageLocation = pandrlaci[1];
            hrac1_5.ImageLocation = pandrlaci[2];
            hrac1_7.ImageLocation = pandrlaci[3];
            hrac1_8.ImageLocation = pandrlaci[4];
            hrac1_9.ImageLocation = pandrlaci[5];
            hrac1_14.ImageLocation = pandrlaci[6];
            hrac1_16.ImageLocation = pandrlaci[7];
            hrac1_17.ImageLocation = pandrlaci[8];
            hrac1_18.ImageLocation = pandrlaci[9];
            hrac1_19.ImageLocation = pandrlaci[10];
            hrac1_20.ImageLocation = pandrlaci[11];
            hrac1_21.ImageLocation = pandrlaci[12];
            hrac1_23.ImageLocation = pandrlaci[13];
            hrac1_24.ImageLocation = pandrlaci[14];

        }
        private void hrac1_1_Click(object sender, EventArgs e)
        {
            if (hrac1_1.ImageLocation == pandrlaci[0])
            {
                hrac1_1.ImageLocation = pandrlaci[1];
            }
            else
            {
                hrac1_1.ImageLocation = pandrlaci[0];
            }
        }
    }
}
