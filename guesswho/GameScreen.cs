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

namespace guesswho
{
    public partial class GameScreen : Form
    {
        int ciselko;
        int ciselko2;
        public static int ciselko1;
        public static int ciselkoposli;

        public GameScreen()
        {
            InitializeComponent();
            nacitanie_obrazkov();
            ciselko = new Random().Next(0, 23);
            tvojhrac.ImageLocation = pandrlaci[ciselko];
            this.WindowState = FormWindowState.Maximized;
            nacitanie_vlastnosti();
            nacitanie_vyhry();
            
            textBox2.Text = panacikovia[ciselko2].Meno;


        }
        
        public static List<Panacik> panacikovia = new List<Panacik>();
        string[] pandrlaci =
        {
                "https://i.ibb.co/8DqFHjR/fotor-ai-20230510163746.png",
                "https://i.ibb.co/RPsXzPg/rakosnicek2.jpg",
                "https://i.ibb.co/JqtfzZ2/ferdo.jpg",
                "https://i.ibb.co/F5n7BJC/fotor-ai-20230510165126.png",
                "https://i.ibb.co/cwT9v4V/fotor-ai-20230510165456.jpg",
                "https://i.ibb.co/VLXQFNP/krtko3.jpg",
                "https://i.ibb.co/QcWN1hf/fotor-ai-20230510171217.png",
                "https://i.ibb.co/1dCMQG7/fotor-ai-20230510171528.png",
                "https://i.ibb.co/dKR7yvD/fotor-ai-2023051017293.jpg",
                "https://i.ibb.co/L1NZBjY/pat.png",
                "https://i.ibb.co/805CCvn/mat.jpg",
                "https://i.ibb.co/H4bmFmL/bob.jpg",
                "https://i.ibb.co/02yVVqd/bobek.jpg",
                "https://i.ibb.co/D78CnWB/fotor-ai-20230510194422.jpg",
                "https://i.ibb.co/RpBrG6F/maxipesfik.jpg",
                "https://i.ibb.co/sRxZ1g8/fotor-ai-20230510192641.png",
                "https://i.ibb.co/4PXQ3tj/fotor-ai-20230510191324.png",
                "https://i.ibb.co/g7TJqKx/fotor-ai-20230502191017.jpg",
                "https://i.ibb.co/RC8V6QJ/fotor-ai-202305101917.png",
                "https://i.ibb.co/604542Q/fotor-ai-20230510195647.png",
                "https://i.ibb.co/GW6704y/fotor-ai-2023051018390.jpg",
                "https://i.ibb.co/1qLpTCy/perinbaba2.jpg",
                "https://i.ibb.co/3N2LThx/fotor-ai-20230510181053.png",
                "https://i.ibb.co/NFPGCcK/fotor-ai-20230510175316.jpg",
        };
        string[] preciarknuty =
        {
                "https://i.ibb.co/pQQ37bL/rumcajs.png",
                "https://i.ibb.co/zbqGgVd/rakosnicek2.jpg",
                "https://i.ibb.co/GnC1CJn/ferdo.jpg",
                "https://i.ibb.co/cQgG6tC/vecernicek.png",
                "https://i.ibb.co/4pRxPFr/krakonos.jpg",
                "https://i.ibb.co/PY9DwGr/krtko3.jpg",
                "https://i.ibb.co/BnZMpvZ/matko.png",
                "https://i.ibb.co/B6zSz0z/valibuk.png",
                "https://i.ibb.co/yNnSY2Q/kubko.jpg",
                "https://i.ibb.co/wSg1Knf/pat-new.png",
                "https://i.ibb.co/GQV6TN4/mat.jpg",
                "https://i.ibb.co/pyMKP4C/bob.jpg",
                "https://i.ibb.co/G2gP4tn/bobek.jpg",
                "https://i.ibb.co/hLjQTHK/mach.jpg",
                "https://i.ibb.co/nfbNBkK/maxipesfik.jpg",
                "https://i.ibb.co/3FP1mXC/hurvinek.png",
                "https://i.ibb.co/0tf4X0v/maja.png",
                "https://i.ibb.co/dP5mVYq/amalka.jpg",
                "https://i.ibb.co/56vvfkX/sebestova.png",
                "https://i.ibb.co/VNsZH89/zofka.png",
                "https://i.ibb.co/z2V3rKw/eliska.jpg",
                "https://i.ibb.co/tP0JLqg/perinbaba2.jpg",
                "https://i.ibb.co/YyZc5Z4/popoluska.png",
                "https://i.ibb.co/TT5spW6/makovicka.jpg",
        };
        private void nacitanie_vlastnosti()
        {
            for (int i = 0; i < 25; i++)
            {
                int idecko = i;
                MySqlConnection connection = new MySqlConnection("SERVER=usa.vybrat.eu;PORT=3306;DATABASE=c43guesswho;UID=c43budos;PASSWORD=BziBy_aU7");
                connection.Open();
                MySqlCommand cmd1 = new MySqlCommand("Select Meno, Pohlavie, Vlasy, Oci, Pokryvka, Doplnok, Fuzy from hrac1 where Id=@id", connection);
                cmd1.Parameters.AddWithValue("id", idecko);
                MySqlDataReader reader1;
                reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    panacikovia.Add(new Panacik(reader1["Meno"].ToString(), reader1["Pohlavie"].ToString(), reader1["Vlasy"].ToString(), reader1["Oci"].ToString(), reader1["Pokryvka"].ToString(), reader1["Doplnok"].ToString(), reader1["Fuzy"].ToString()));
                }
            }
        }
        private void nacitanie_vyhry()
        {
            ciselko2 = new Random().Next(0, 23);
            ciselko1 = ciselko;
            ciselkoposli = ciselko2;
        }
        
        private void nacitanie_obrazkov()
        {
            hrac1_1.ImageLocation = pandrlaci[0];
            hrac1_2.ImageLocation = pandrlaci[1];
            hrac1_3.ImageLocation = pandrlaci[2];
            hrac1_4.ImageLocation = pandrlaci[3];
            hrac1_5.ImageLocation = pandrlaci[4];
            hrac1_6.ImageLocation = pandrlaci[5];
            hrac1_7.ImageLocation = pandrlaci[6];
            hrac1_8.ImageLocation = pandrlaci[7];
            hrac1_9.ImageLocation = pandrlaci[8];
            hrac1_10.ImageLocation = pandrlaci[9];
            hrac1_11.ImageLocation = pandrlaci[10];
            hrac1_12.ImageLocation = pandrlaci[11];
            hrac1_13.ImageLocation = pandrlaci[12];
            hrac1_14.ImageLocation = pandrlaci[13];
            hrac1_15.ImageLocation = pandrlaci[14];
            hrac1_16.ImageLocation = pandrlaci[15];
            hrac1_17.ImageLocation = pandrlaci[16];
            hrac1_18.ImageLocation = pandrlaci[17];
            hrac1_19.ImageLocation = pandrlaci[18];
            hrac1_20.ImageLocation = pandrlaci[19];
            hrac1_21.ImageLocation = pandrlaci[20];
            hrac1_22.ImageLocation = pandrlaci[21];
            hrac1_23.ImageLocation = pandrlaci[22];
            hrac1_24.ImageLocation = pandrlaci[23];

        }

        private void hrac1_1_DoubleClick(object sender, EventArgs e)
        {
            {
                
                if (hrac1_1.ImageLocation == pandrlaci[0])
                {
                    hrac1_1.ImageLocation = preciarknuty[0];
                }
                else
                {
                    hrac1_1.ImageLocation = pandrlaci[0];
                }
            }
        }

        private void hrac1_2_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_2.ImageLocation == pandrlaci[1])
                {
                    hrac1_2.ImageLocation = preciarknuty[1];
                }
                else
                {
                    hrac1_2.ImageLocation = pandrlaci[1];
                }
            }
        }

        private void hrac1_3_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_3.ImageLocation == pandrlaci[2])
                {
                    hrac1_3.ImageLocation = preciarknuty[2];
                }
                else
                {
                    hrac1_3.ImageLocation = pandrlaci[2];
                }
            }
        }

        private void hrac1_4_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_4.ImageLocation == pandrlaci[3])
                {
                    hrac1_4.ImageLocation = preciarknuty[3];
                }
                else
                {
                    hrac1_4.ImageLocation = pandrlaci[3];
                }
            }
        }

        private void hrac1_5_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_5.ImageLocation == pandrlaci[4])
                {
                    hrac1_5.ImageLocation = preciarknuty[4];
                }
                else
                {
                    hrac1_5.ImageLocation = pandrlaci[4];
                }
            }
        }

        private void hrac1_6_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_6.ImageLocation == pandrlaci[5])
                {
                    hrac1_6.ImageLocation = preciarknuty[5];
                }
                else
                {
                    hrac1_6.ImageLocation = pandrlaci[5];
                }
            }
        }

        private void hrac1_7_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_7.ImageLocation == pandrlaci[6])
                {
                    hrac1_7.ImageLocation = preciarknuty[6];
                }
                else
                {
                    hrac1_7.ImageLocation = pandrlaci[6];
                }
            }
        }

        private void hrac1_8_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_8.ImageLocation == pandrlaci[7])
                {
                    hrac1_8.ImageLocation = preciarknuty[7];
                }
                else
                {
                    hrac1_8.ImageLocation = pandrlaci[7];
                }
            }
        }

        private void hrac1_9_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_9.ImageLocation == pandrlaci[8])
                {
                    hrac1_9.ImageLocation = preciarknuty[8];
                }
                else
                {
                    hrac1_9.ImageLocation = pandrlaci[8];
                }
            }
        }

        private void hrac1_10_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_10.ImageLocation == pandrlaci[9])
                {
                    hrac1_10.ImageLocation = preciarknuty[9];
                }
                else
                {
                    hrac1_10.ImageLocation = pandrlaci[9];
                }
            }
        }

        private void hrac1_11_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_11.ImageLocation == pandrlaci[10])
                {
                    hrac1_11.ImageLocation = preciarknuty[10];
                }
                else
                {
                    hrac1_11.ImageLocation = pandrlaci[10];
                }
            }
        }

        private void hrac1_12_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_12.ImageLocation == pandrlaci[11])
                {
                    hrac1_12.ImageLocation = preciarknuty[11];
                }
                else
                {
                    hrac1_12.ImageLocation = pandrlaci[11];
                }
            }
        }

        private void hrac1_13_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_13.ImageLocation == pandrlaci[12])
                {
                    hrac1_13.ImageLocation = preciarknuty[12];
                }
                else
                {
                    hrac1_13.ImageLocation = pandrlaci[12];
                }
            }
        }

        private void hrac1_14_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_14.ImageLocation == pandrlaci[13])
                {
                    hrac1_14.ImageLocation = preciarknuty[13];
                }
                else
                {
                    hrac1_14.ImageLocation = pandrlaci[13];
                }
            }
        }

        private void hrac1_15_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_15.ImageLocation == pandrlaci[14])
                {
                    hrac1_15.ImageLocation = preciarknuty[14];
                }
                else
                {
                    hrac1_15.ImageLocation = pandrlaci[14];
                }
            }
        }

        private void hrac1_16_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_16.ImageLocation == pandrlaci[15])
                {
                    hrac1_16.ImageLocation = preciarknuty[15];
                }
                else
                {
                    hrac1_16.ImageLocation = pandrlaci[15];
                }
            }
        }

        private void hrac1_17_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_17.ImageLocation == pandrlaci[16])
                {
                    hrac1_17.ImageLocation = preciarknuty[16];
                }
                else
                {
                    hrac1_17.ImageLocation = pandrlaci[16];
                }
            }
        }

        private void hrac1_18_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_18.ImageLocation == pandrlaci[17])
                {
                    hrac1_18.ImageLocation = preciarknuty[17];
                }
                else
                {
                    hrac1_18.ImageLocation = pandrlaci[17];
                }
            }
        }

        private void hrac1_19_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_19.ImageLocation == pandrlaci[18])
                {
                    hrac1_19.ImageLocation = preciarknuty[18];
                }
                else
                {
                    hrac1_19.ImageLocation = pandrlaci[18];
                }
            }
        }

        private void hrac1_20_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_20.ImageLocation == pandrlaci[19])
                {
                    hrac1_20.ImageLocation = preciarknuty[19];
                }
                else
                {
                    hrac1_20.ImageLocation = pandrlaci[19];
                }
            }
        }

        private void hrac1_21_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_21.ImageLocation == pandrlaci[20])
                {
                    hrac1_21.ImageLocation = preciarknuty[20];
                }
                else
                {
                    hrac1_21.ImageLocation = pandrlaci[20];
                }
            }
        }

        private void hrac1_22_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_22.ImageLocation == pandrlaci[21])
                {
                    hrac1_22.ImageLocation = preciarknuty[21];
                }
                else
                {
                    hrac1_22.ImageLocation = pandrlaci[21];
                }
            }
        }

        private void hrac1_23_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_23.ImageLocation == pandrlaci[22])
                {
                    hrac1_23.ImageLocation = preciarknuty[22];
                }
                else
                {
                    hrac1_23.ImageLocation = pandrlaci[22];
                }
            }
        }

        private void hrac1_24_DoubleClick(object sender, EventArgs e)
        {
            {
                if (hrac1_24.ImageLocation == pandrlaci[23])
                {
                    hrac1_24.ImageLocation = preciarknuty[23];
                }
                else
                {
                    hrac1_24.ImageLocation = pandrlaci[23];
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
            Prechod prechadzam = Application.OpenForms.OfType<Prechod>().FirstOrDefault();
            if (prechadzam != null)
            {
                prechadzam.Show();
            }
            else
            {
                prechadzam = new Prechod();
                prechadzam.Show();
            }
            this.Hide();
        }

        private void hrac1_1_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[0].Meno + "\n" + "Pohlavie: " + panacikovia[0].Pohlavie + "\n" + "Vlasy: " + panacikovia[0].Vlasy + "\n" +  "Oči: " + panacikovia[0].Oci + "\n" + "Pokrývka: " + panacikovia[0].Pokryvka + "\n" + "Doplnok: " + panacikovia[0].Doplnok + "\n" + "Fúzy: " + panacikovia[0].Fuzy; 
        }

        private void hrac1_2_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[1].Meno + "\n" + "Pohlavie: " + panacikovia[1].Pohlavie + "\n" + "Vlasy: " + panacikovia[1].Vlasy + "\n" + "Oči: " + panacikovia[1].Oci + "\n" + "Pokrývka: " + panacikovia[1].Pokryvka + "\n" + "Doplnok: " + panacikovia[1].Doplnok + "\n" + "Fúzy: " + panacikovia[1].Fuzy;
        }

        private void hrac1_3_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[2].Meno + "\n" + "Pohlavie: " + panacikovia[2].Pohlavie + "\n" + "Vlasy: " + panacikovia[2].Vlasy + "\n" + "Oči: " + panacikovia[2].Oci + "\n" + "Pokrývka: " + panacikovia[2].Pokryvka + "\n" + "Doplnok: " + panacikovia[2].Doplnok + "\n" + "Fúzy: " + panacikovia[2].Fuzy;
        }

        private void hrac1_4_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[3].Meno + "\n" + "Pohlavie: " + panacikovia[3].Pohlavie + "\n" + "Vlasy: " + panacikovia[3].Vlasy + "\n" + "Oči: " + panacikovia[3].Oci + "\n" + "Pokrývka: " + panacikovia[3].Pokryvka + "\n" + "Doplnok: " + panacikovia[3].Doplnok + "\n" + "Fúzy: " + panacikovia[3].Fuzy;
        }

        private void hrac1_5_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[4].Meno + "\n" + "Pohlavie: " + panacikovia[4].Pohlavie + "\n" + "Vlasy: " + panacikovia[4].Vlasy + "\n" + "Oči: " + panacikovia[4].Oci + "\n" + "Pokrývka: " + panacikovia[4].Pokryvka + "\n" + "Doplnok: " + panacikovia[4].Doplnok + "\n" + "Fúzy: " + panacikovia[4].Fuzy;
        }

        private void hrac1_6_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[5].Meno + "\n" + "Pohlavie: " + panacikovia[5].Pohlavie + "\n" + "Vlasy: " + panacikovia[5].Vlasy + "\n" + "Oči: " + panacikovia[5].Oci + "\n" + "Pokrývka: " + panacikovia[5].Pokryvka + "\n" + "Doplnok: " + panacikovia[5].Doplnok + "\n" + "Fúzy: " + panacikovia[5].Fuzy;
        }

        private void hrac1_7_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[6].Meno + "\n" + "Pohlavie: " + panacikovia[6].Pohlavie + "\n" + "Vlasy: " + panacikovia[6].Vlasy + "\n" + "Oči: " + panacikovia[6].Oci + "\n" + "Pokrývka: " + panacikovia[6].Pokryvka + "\n" + "Doplnok: " + panacikovia[6].Doplnok + "\n" + "Fúzy: " + panacikovia[6].Fuzy;
        }

        private void hrac1_8_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[7].Meno + "\n" + "Pohlavie: " + panacikovia[7].Pohlavie + "\n" + "Vlasy: " + panacikovia[7].Vlasy + "\n" + "Oči: " + panacikovia[7].Oci + "\n" + "Pokrývka: " + panacikovia[7].Pokryvka + "\n" + "Doplnok: " + panacikovia[7].Doplnok + "\n" + "Fúzy: " + panacikovia[7].Fuzy;
        }

        private void hrac1_9_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[8].Meno + "\n" + "Pohlavie: " + panacikovia[8].Pohlavie + "\n" + "Vlasy: " + panacikovia[8].Vlasy + "\n" + "Oči: " + panacikovia[8].Oci + "\n" + "Pokrývka: " + panacikovia[8].Pokryvka + "\n" + "Doplnok: " + panacikovia[8].Doplnok + "\n" + "Fúzy: " + panacikovia[8].Fuzy;
        }

        private void hrac1_10_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[9].Meno + "\n" + "Pohlavie: " + panacikovia[9].Pohlavie + "\n" + "Vlasy: " + panacikovia[9].Vlasy + "\n" + "Oči: " + panacikovia[9].Oci + "\n" + "Pokrývka: " + panacikovia[9].Pokryvka + "\n" + "Doplnok: " + panacikovia[9].Doplnok + "\n" + "Fúzy: " + panacikovia[9].Fuzy;
        }

        private void hrac1_11_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[10].Meno + "\n" + "Pohlavie: " + panacikovia[10].Pohlavie + "\n" + "Vlasy: " + panacikovia[10].Vlasy + "\n" + "Oči: " + panacikovia[10].Oci + "\n" + "Pokrývka: " + panacikovia[10].Pokryvka + "\n" + "Doplnok: " + panacikovia[10].Doplnok + "\n" + "Fúzy: " + panacikovia[10].Fuzy;
        }

        private void hrac1_12_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[11].Meno + "\n" + "Pohlavie: " + panacikovia[11].Pohlavie + "\n" + "Vlasy: " + panacikovia[11].Vlasy + "\n" + "Oči: " + panacikovia[11].Oci + "\n" + "Pokrývka: " + panacikovia[11].Pokryvka + "\n" + "Doplnok: " + panacikovia[11].Doplnok + "\n" + "Fúzy: " + panacikovia[11].Fuzy;
        }

        private void hrac1_13_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[12].Meno + "\n" + "Pohlavie: " + panacikovia[12].Pohlavie + "\n" + "Vlasy: " + panacikovia[12].Vlasy + "\n" + "Oči: " + panacikovia[12].Oci + "\n" + "Pokrývka: " + panacikovia[12].Pokryvka + "\n" + "Doplnok: " + panacikovia[12].Doplnok + "\n" + "Fúzy: " + panacikovia[12].Fuzy;
        }

        private void hrac1_14_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[13].Meno + "\n" + "Pohlavie: " + panacikovia[13].Pohlavie + "\n" + "Vlasy: " + panacikovia[13].Vlasy + "\n" + "Oči: " + panacikovia[13].Oci + "\n" + "Pokrývka: " + panacikovia[13].Pokryvka + "\n" + "Doplnok: " + panacikovia[13].Doplnok + "\n" + "Fúzy: " + panacikovia[13].Fuzy;
        }

        private void hrac1_15_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[14].Meno + "\n" + "Pohlavie: " + panacikovia[14].Pohlavie + "\n" + "Vlasy: " + panacikovia[14].Vlasy + "\n" + "Oči: " + panacikovia[14].Oci + "\n" + "Pokrývka: " + panacikovia[14].Pokryvka + "\n" + "Doplnok: " + panacikovia[14].Doplnok + "\n" + "Fúzy: " + panacikovia[14].Fuzy;
        }

        private void hrac1_16_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[15].Meno + "\n" + "Pohlavie: " + panacikovia[15].Pohlavie + "\n" + "Vlasy: " + panacikovia[15].Vlasy + "\n" + "Oči: " + panacikovia[15].Oci + "\n" + "Pokrývka: " + panacikovia[15].Pokryvka + "\n" + "Doplnok: " + panacikovia[15].Doplnok + "\n" + "Fúzy: " + panacikovia[15].Fuzy;
        }

        private void hrac1_17_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[16].Meno + "\n" + "Pohlavie: " + panacikovia[16].Pohlavie + "\n" + "Vlasy: " + panacikovia[16].Vlasy + "\n" + "Oči: " + panacikovia[16].Oci + "\n" + "Pokrývka: " + panacikovia[16].Pokryvka + "\n" + "Doplnok: " + panacikovia[16].Doplnok + "\n" + "Fúzy: " + panacikovia[16].Fuzy;
        }

        private void hrac1_18_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[17].Meno + "\n" + "Pohlavie: " + panacikovia[17].Pohlavie + "\n" + "Vlasy: " + panacikovia[17].Vlasy + "\n" + "Oči: " + panacikovia[17].Oci + "\n" + "Pokrývka: " + panacikovia[17].Pokryvka + "\n" + "Doplnok: " + panacikovia[17].Doplnok + "\n" + "Fúzy: " + panacikovia[17].Fuzy;
        }

        private void hrac1_19_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[18].Meno + "\n" + "Pohlavie: " + panacikovia[18].Pohlavie + "\n" + "Vlasy: " + panacikovia[18].Vlasy + "\n" + "Oči: " + panacikovia[18].Oci + "\n" + "Pokrývka: " + panacikovia[18].Pokryvka + "\n" + "Doplnok: " + panacikovia[18].Doplnok + "\n" + "Fúzy: " + panacikovia[18].Fuzy;
        }

        private void hrac1_20_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[19].Meno + "\n" + "Pohlavie: " + panacikovia[19].Pohlavie + "\n" + "Vlasy: " + panacikovia[19].Vlasy + "\n" + "Oči: " + panacikovia[19].Oci + "\n" + "Pokrývka: " + panacikovia[19].Pokryvka + "\n" + "Doplnok: " + panacikovia[19].Doplnok + "\n" + "Fúzy: " + panacikovia[19].Fuzy;
        }

        private void hrac1_21_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[20].Meno + "\n" + "Pohlavie: " + panacikovia[20].Pohlavie + "\n" + "Vlasy: " + panacikovia[20].Vlasy + "\n" + "Oči: " + panacikovia[20].Oci + "\n" + "Pokrývka: " + panacikovia[20].Pokryvka + "\n" + "Doplnok: " + panacikovia[20].Doplnok + "\n" + "Fúzy: " + panacikovia[20].Fuzy;
        }

        private void hrac1_22_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[21].Meno + "\n" + "Pohlavie: " + panacikovia[21].Pohlavie + "\n" + "Vlasy: " + panacikovia[21].Vlasy + "\n" + "Oči: " + panacikovia[21].Oci + "\n" + "Pokrývka: " + panacikovia[21].Pokryvka + "\n" + "Doplnok: " + panacikovia[21].Doplnok + "\n" + "Fúzy: " + panacikovia[21].Fuzy;
        }

        private void hrac1_23_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[22].Meno + "\n" + "Pohlavie: " + panacikovia[22].Pohlavie + "\n" + "Vlasy: " + panacikovia[22].Vlasy + "\n" + "Oči: " + panacikovia[22].Oci + "\n" + "Pokrývka: " + panacikovia[22].Pokryvka + "\n" + "Doplnok: " + panacikovia[22].Doplnok + "\n" + "Fúzy: " + panacikovia[22].Fuzy;
        }

        private void hrac1_24_Click(object sender, EventArgs e)
        {

            vlastnosti.Text = "Meno: " + panacikovia[23].Meno + "\n" + "Pohlavie: " + panacikovia[23].Pohlavie + "\n" + "Vlasy: " + panacikovia[23].Vlasy + "\n" + "Oči: " + panacikovia[23].Oci + "\n" + "Pokrývka: " + panacikovia[23].Pokryvka + "\n" + "Doplnok: " + panacikovia[23].Doplnok + "\n" + "Fúzy: " + panacikovia[23].Fuzy;
        }

        private void tvojhrac_Click(object sender, EventArgs e)
        {

                vlastnosti.Text = "Meno: " + panacikovia[ciselko].Meno + "\n" + "Pohlavie: " + panacikovia[ciselko].Pohlavie + "\n" + "Vlasy: " + panacikovia[ciselko].Vlasy + "\n" + "Oči: " + panacikovia[ciselko].Oci + "\n" + "Pokrývka: " + panacikovia[ciselko].Pokryvka + "\n" + "Doplnok: " + panacikovia[ciselko].Doplnok + "\n" + "Fúzy: " + panacikovia[ciselko].Fuzy;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox2.Text)
            {
                this.Hide();
                win1 vyhraj = new win1();
                vyhraj.Closed += (s, args) => this.Close();
                vyhraj.Show();


            }
            else
            {
                MessageBox.Show("Nope", "Zlá voľba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Prechod prechadzam = Application.OpenForms.OfType<Prechod>().FirstOrDefault();
                if (prechadzam != null)
                {
                    prechadzam.Show();
                }
                else
                {
                    prechadzam = new Prechod();
                    prechadzam.Show();
                }
                textBox3.Text = "";
                this.Hide();


            }
        }
    }
}
