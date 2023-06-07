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
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace guesswho
{
    public partial class GameScreen2 : Form
    {
        int ciselko3;
        List<string> pandrlaci = new List<string>() { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        List<string> preciarknuty = new List<string>() { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        public GameScreen2()
        {
            InitializeComponent();
            naplnenie_obrazkov();
            nacitanie_obrazkov();
            tvojhrac.ImageLocation = pandrlaci[GameScreen.ciselkoposli+1];
            this.WindowState = FormWindowState.Maximized;
            ciselko3 = GameScreen.ciselko1;
            textBox1.Text = GameScreen.panacikovia[ciselko3].Meno;
            textBox1.SendToBack();
            

        }



        
        private void naplnenie_obrazkov()
        {
            for(int i = 1; i < 25; i++)
            {
                pandrlaci[i] = @"obrazky\normalne\obrazok" + i + ".png";
            }
            for (int i = 1; i < 25; i++)
            {
                preciarknuty[i] = @"obrazky\preciarknute\obraz" + i + ".png";
            }
        }
        
        private void nacitanie_obrazkov()
        {
            hrac1_1.ImageLocation = pandrlaci[1];
            hrac1_2.ImageLocation = pandrlaci[2];
            hrac1_3.ImageLocation = pandrlaci[3];
            hrac1_4.ImageLocation = pandrlaci[4];
            hrac1_5.ImageLocation = pandrlaci[5];
            hrac1_6.ImageLocation = pandrlaci[6];
            hrac1_7.ImageLocation = pandrlaci[7];
            hrac1_8.ImageLocation = pandrlaci[8];
            hrac1_9.ImageLocation = pandrlaci[9];
            hrac1_10.ImageLocation = pandrlaci[10];
            hrac1_11.ImageLocation = pandrlaci[11];
            hrac1_12.ImageLocation = pandrlaci[12];
            hrac1_13.ImageLocation = pandrlaci[13];
            hrac1_14.ImageLocation = pandrlaci[14];
            hrac1_15.ImageLocation = pandrlaci[15];
            hrac1_16.ImageLocation = pandrlaci[16];
            hrac1_17.ImageLocation = pandrlaci[17];
            hrac1_18.ImageLocation = pandrlaci[18];
            hrac1_19.ImageLocation = pandrlaci[19];
            hrac1_20.ImageLocation = pandrlaci[20];
            hrac1_21.ImageLocation = pandrlaci[21];
            hrac1_22.ImageLocation = pandrlaci[22];
            hrac1_23.ImageLocation = pandrlaci[23];
            hrac1_24.ImageLocation = pandrlaci[24];

        }

        private void hrac1_1_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_1.ImageLocation == pandrlaci[1])
                {
                    hrac1_1.ImageLocation = preciarknuty[1];
                }
                else
                {
                    hrac1_1.ImageLocation = pandrlaci[1];
                }
            }
        }

        private void hrac1_2_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_2.ImageLocation == pandrlaci[2])
                {
                    hrac1_2.ImageLocation = preciarknuty[2];
                }
                else
                {
                    hrac1_2.ImageLocation = pandrlaci[2];
                }
            }
        }

        private void hrac1_3_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_3.ImageLocation == pandrlaci[3])
                {
                    hrac1_3.ImageLocation = preciarknuty[3];
                }
                else
                {
                    hrac1_3.ImageLocation = pandrlaci[3];
                }
            }
        }

        private void hrac1_4_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_4.ImageLocation == pandrlaci[4])
                {
                    hrac1_4.ImageLocation = preciarknuty[4];
                }
                else
                {
                    hrac1_4.ImageLocation = pandrlaci[4];
                }
            }
        }

        private void hrac1_5_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_5.ImageLocation == pandrlaci[5])
                {
                    hrac1_5.ImageLocation = preciarknuty[5];
                }
                else
                {
                    hrac1_5.ImageLocation = pandrlaci[5];
                }
            }
        }

        private void hrac1_6_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_6.ImageLocation == pandrlaci[6])
                {
                    hrac1_6.ImageLocation = preciarknuty[6];
                }
                else
                {
                    hrac1_6.ImageLocation = pandrlaci[6];
                }
            }
        }

        private void hrac1_7_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_7.ImageLocation == pandrlaci[7])
                {
                    hrac1_7.ImageLocation = preciarknuty[7];
                }
                else
                {
                    hrac1_7.ImageLocation = pandrlaci[7];
                }
            }
        }

        private void hrac1_8_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_8.ImageLocation == pandrlaci[8])
                {
                    hrac1_8.ImageLocation = preciarknuty[8];
                }
                else
                {
                    hrac1_8.ImageLocation = pandrlaci[8];
                }
            }
        }

        private void hrac1_9_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_9.ImageLocation == pandrlaci[9])
                {
                    hrac1_9.ImageLocation = preciarknuty[9];
                }
                else
                {
                    hrac1_9.ImageLocation = pandrlaci[9];
                }
            }
        }

        private void hrac1_10_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_10.ImageLocation == pandrlaci[10])
                {
                    hrac1_10.ImageLocation = preciarknuty[10];
                }
                else
                {
                    hrac1_10.ImageLocation = pandrlaci[10];
                }
            }
        }

        private void hrac1_11_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_11.ImageLocation == pandrlaci[11])
                {
                    hrac1_11.ImageLocation = preciarknuty[11];
                }
                else
                {
                    hrac1_11.ImageLocation = pandrlaci[11];
                }
            }
        }

        private void hrac1_12_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_12.ImageLocation == pandrlaci[12])
                {
                    hrac1_12.ImageLocation = preciarknuty[12];
                }
                else
                {
                    hrac1_12.ImageLocation = pandrlaci[12];
                }
            }
        }

        private void hrac1_13_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_13.ImageLocation == pandrlaci[13])
                {
                    hrac1_13.ImageLocation = preciarknuty[13];
                }
                else
                {
                    hrac1_13.ImageLocation = pandrlaci[13];
                }
            }
        }

        private void hrac1_14_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_14.ImageLocation == pandrlaci[14])
                {
                    hrac1_14.ImageLocation = preciarknuty[14];
                }
                else
                {
                    hrac1_14.ImageLocation = pandrlaci[14];
                }
            }
        }

        private void hrac1_15_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_15.ImageLocation == pandrlaci[15])
                {
                    hrac1_15.ImageLocation = preciarknuty[15];
                }
                else
                {
                    hrac1_15.ImageLocation = pandrlaci[15];
                }
            }
        }

        private void hrac1_16_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_16.ImageLocation == pandrlaci[16])
                {
                    hrac1_16.ImageLocation = preciarknuty[16];
                }
                else
                {
                    hrac1_16.ImageLocation = pandrlaci[16];
                }
            }
        }

        private void hrac1_17_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_17.ImageLocation == pandrlaci[17])
                {
                    hrac1_17.ImageLocation = preciarknuty[17];
                }
                else
                {
                    hrac1_17.ImageLocation = pandrlaci[17];
                }
            }
        }

        private void hrac1_18_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_18.ImageLocation == pandrlaci[18])
                {
                    hrac1_18.ImageLocation = preciarknuty[18];
                }
                else
                {
                    hrac1_18.ImageLocation = pandrlaci[18];
                }
            }
        }

        private void hrac1_19_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_19.ImageLocation == pandrlaci[19])
                {
                    hrac1_19.ImageLocation = preciarknuty[19];
                }
                else
                {
                    hrac1_19.ImageLocation = pandrlaci[19];
                }
            }
        }

        private void hrac1_20_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_20.ImageLocation == pandrlaci[20])
                {
                    hrac1_20.ImageLocation = preciarknuty[20];
                }
                else
                {
                    hrac1_20.ImageLocation = pandrlaci[20];
                }
            }
        }

        private void hrac1_21_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_21.ImageLocation == pandrlaci[21])
                {
                    hrac1_21.ImageLocation = preciarknuty[21];
                }
                else
                {
                    hrac1_21.ImageLocation = pandrlaci[21];
                }
            }
        }

        private void hrac1_22_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_22.ImageLocation == pandrlaci[22])
                {
                    hrac1_22.ImageLocation = preciarknuty[22];
                }
                else
                {
                    hrac1_22.ImageLocation = pandrlaci[22];
                }
            }
        }

        private void hrac1_23_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_23.ImageLocation == pandrlaci[23])
                {
                    hrac1_23.ImageLocation = preciarknuty[23];
                }
                else
                {
                    hrac1_23.ImageLocation = pandrlaci[23];
                }
            }
        }

        private void hrac1_24_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_24.ImageLocation == pandrlaci[24])
                {
                    hrac1_24.ImageLocation = preciarknuty[24];
                }
                else
                {
                    hrac1_24.ImageLocation = pandrlaci[24];
                }
            }
        }

        private void opytat(object sender, EventArgs e)
        {
            this.Hide();
            Qstion pytaj = new Qstion();
            pytaj.ShowDialog();
            pytaj = null;
            this.Show();

        }

        private void ist(object sender, EventArgs e)
        {


            Prechod2 prechadzam2 = Application.OpenForms.OfType<Prechod2>().FirstOrDefault();
            if (prechadzam2 != null)
            {
                prechadzam2.Show();
            }
            else
            {
                prechadzam2 = new Prechod2();
                prechadzam2.Show();
            }
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hrac1_1_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[0].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[0].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[0].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[0].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[0].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[0].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[0].Fuzy;
        }

        private void hrac1_2_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[1].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[1].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[1].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[1].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[1].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[1].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[1].Fuzy;
        }

        private void hrac1_3_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[2].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[2].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[2].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[2].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[2].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[2].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[2].Fuzy;
        }

        private void hrac1_4_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[3].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[3].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[3].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[3].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[3].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[3].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[3].Fuzy;
        }

        private void hrac1_5_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[4].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[4].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[4].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[4].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[4].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[4].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[4].Fuzy;
        }

        private void hrac1_6_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[5].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[5].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[5].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[5].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[5].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[5].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[5].Fuzy;
        }

        private void hrac1_7_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[6].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[6].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[6].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[6].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[6].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[6].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[6].Fuzy;
        }

        private void hrac1_8_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[7].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[7].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[7].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[7].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[7].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[7].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[7].Fuzy;
        }

        private void hrac1_9_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[8].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[8].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[8].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[8].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[8].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[8].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[8].Fuzy;
        }

        private void hrac1_10_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[9].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[9].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[9].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[9].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[9].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[9].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[9].Fuzy;
        }

        private void hrac1_11_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[10].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[10].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[10].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[10].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[10].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[10].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[10].Fuzy;
        }

        private void hrac1_12_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[11].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[11].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[11].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[11].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[11].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[11].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[11].Fuzy;
        }

        private void hrac1_13_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[12].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[12].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[12].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[12].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[12].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[12].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[12].Fuzy;
        }

        private void hrac1_14_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[13].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[13].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[13].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[13].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[13].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[13].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[13].Fuzy;
        }

        private void hrac1_15_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[14].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[14].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[14].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[14].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[14].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[14].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[14].Fuzy;
        }

        private void hrac1_16_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[15].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[15].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[15].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[15].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[15].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[15].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[15].Fuzy;
        }

        private void hrac1_17_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[16].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[16].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[16].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[16].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[16].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[16].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[16].Fuzy;
        }

        private void hrac1_18_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[17].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[17].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[17].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[17].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[17].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[17].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[17].Fuzy;
        }

        private void hrac1_19_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[18].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[18].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[18].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[18].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[18].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[18].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[18].Fuzy;
        }

        private void hrac1_20_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[19].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[19].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[19].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[19].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[19].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[19].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[19].Fuzy;
        }

        private void hrac1_21_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[20].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[20].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[20].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[20].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[20].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[20].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[20].Fuzy;
        }

        private void hrac1_22_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[21].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[21].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[21].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[21].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[21].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[21].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[21].Fuzy;
        }

        private void hrac1_23_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[22].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[22].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[22].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[22].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[22].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[22].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[22].Fuzy;
        }

        private void hrac1_24_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[23].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[23].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[23].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[23].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[23].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[23].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[23].Fuzy;
        }

        private void tvojhrac_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + GameScreen.panacikovia[GameScreen.ciselkoposli].Meno + "\n" + "Pohlavie: " + GameScreen.panacikovia[GameScreen.ciselkoposli].Pohlavie + "\n" + "Vlasy: " + GameScreen.panacikovia[GameScreen.ciselkoposli].Vlasy + "\n" + "Oči: " + GameScreen.panacikovia[GameScreen.ciselkoposli].Oci + "\n" + "Pokrývka: " + GameScreen.panacikovia[GameScreen.ciselkoposli].Pokryvka + "\n" + "Doplnok: " + GameScreen.panacikovia[GameScreen.ciselkoposli].Doplnok + "\n" + "Fúzy: " + GameScreen.panacikovia[GameScreen.ciselkoposli].Fuzy;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox1.Text)
            {
                this.Hide();
                win2 vyhraj = new win2();
                vyhraj.Closed += (s, args) => this.Close();
                vyhraj.Show();


            }
            else
            {
                MessageBox.Show("Nope", "Zlá voľba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Prechod2 prechadzam = Application.OpenForms.OfType<Prechod2>().FirstOrDefault();
                if (prechadzam != null)
                {
                    prechadzam.Show();
                }
                else
                {
                    prechadzam = new Prechod2();
                    prechadzam.Show();
                }
                textBox2.Text = "";
                this.Hide();
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
