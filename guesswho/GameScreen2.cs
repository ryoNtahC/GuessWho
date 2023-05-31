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
    public partial class GameScreen2 : Form
    {
        public GameScreen2()
        {
            InitializeComponent();
            nacitanie_obrazkov();
            int ciselko = new Random().Next(0, 23);
            tvojhrac.ImageLocation = pandrlaci[ciselko];

        }
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

        
    }
}
