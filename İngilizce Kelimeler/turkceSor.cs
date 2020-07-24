using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections;

namespace İngilizce_Kelimeler
{
    public partial class turkceSor : Form
    {
        static MySqlConnection baglan = new MySqlConnection("server= db4free.net;user=celalssahinn;password=??????database=celalsahin;old guids=true;");
       
       
       
        




        public turkceSor()
        {
            InitializeComponent();
        }

        private void geriDon_Click(object sender, EventArgs e)
        {
            kelimeVeriTabani.turkceSorDogru = 0;
            kelimeVeriTabani.turkceSorYanlis = 0;
            menuSecim ms = new menuSecim();
            ms.Show();
            this.Hide();
        }

        private void turkceSor_Load(object sender, EventArgs e)
        {
            aSec.Enabled = false;
            bSec.Enabled = false;
            cSec.Enabled = false;
            dSec.Enabled = false;
            // soruLabel.Text = kelimeVeriTabani.sorular[0].ToString();
            dogruLabel.Text = kelimeVeriTabani.turkceSorDogru.ToString();
              yanlisLabel.Text = kelimeVeriTabani.turkceSorYanlis.ToString();
           
        }





        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }


        int sayac = 0;
        
        string soru;
        string cevap;
       char dogruSecenek;


        Random rnd = new Random();
        private void baslaButon_Click(object sender, EventArgs e)
        {
            sorularL.Text = kelimeVeriTabani.sorular.Count().ToString();
            cevaplarL.Text = kelimeVeriTabani.cevaplar.Count().ToString();
            siklarL.Text = kelimeVeriTabani.siklar.Count().ToString();
            soruKacinci.Text = (sayac + 1).ToString();
            baslaButon.Enabled=false;
            aSec.Enabled = true;
            bSec.Enabled = true;
            cSec.Enabled = true;
            dSec.Enabled = true;
            if (sayac<kelimeVeriTabani.kelimeSayisi) { 
            baslaButon.Text = "Sonraki";
  


            soru = kelimeVeriTabani.sorular[kelimeVeriTabani.soruSira[sayac]];
            cevap = kelimeVeriTabani.cevaplar[kelimeVeriTabani.soruSira[sayac]];
            dogruSecenek = kelimeVeriTabani.siklar[sayac];
                sayac++;


                soruLabel.Text = soru;
            int uretA, uretB, uretC, uretD;
            uretA = rnd.Next(0, kelimeVeriTabani.kelimeSayisi);
            uretB = rnd.Next(0, kelimeVeriTabani.kelimeSayisi);
            uretC = rnd.Next(0, kelimeVeriTabani.kelimeSayisi);
            uretD = rnd.Next(0, kelimeVeriTabani.kelimeSayisi);
            if (uretA != kelimeVeriTabani.hangiSoru && uretB != kelimeVeriTabani.hangiSoru && uretC != kelimeVeriTabani.hangiSoru && uretD != kelimeVeriTabani.hangiSoru)
            {
                if (dogruSecenek == 'A')
                {
                    aSec.Text = cevap;
                    
                }
                else
                {
                    aSec.Text = kelimeVeriTabani.cevaplar[uretA].ToString();
                }
                if (dogruSecenek == 'B')
                {
                    bSec.Text = cevap;
                }
                else
                {
                    bSec.Text = kelimeVeriTabani.cevaplar[uretB].ToString();
                }
                if (dogruSecenek == 'C')
                {
                    cSec.Text = cevap;
                }
                else
                {
                    cSec.Text = kelimeVeriTabani.cevaplar[uretC].ToString();
                }
                if (dogruSecenek == 'D')
                {
                    dSec.Text = cevap;
                }
                else
                {
                    dSec.Text = kelimeVeriTabani.cevaplar[uretD].ToString();
                }
            }

                sayacL.Text = sayac.ToString();
            }
           
        }
        private void a_Click(object sender, EventArgs e)
        {
            baslaButon.Enabled = true;
            aSec.Enabled = false;
            bSec.Enabled = false;
            cSec.Enabled = false;
            dSec.Enabled = false;
            if (dogruSecenek == 'A')
            {
                kelimeVeriTabani.turkceSorDogru++;
            }
           else
            {
                kelimeVeriTabani.turkceSorYanlis++;
            }
            dogruLabel.Text = kelimeVeriTabani.turkceSorDogru.ToString();
            yanlisLabel.Text = kelimeVeriTabani.turkceSorYanlis.ToString();

        }

        private void b_Click(object sender, EventArgs e)
        {
            baslaButon.Enabled = true;
            aSec.Enabled = false;
            bSec.Enabled = false;
            cSec.Enabled = false;
            dSec.Enabled = false;
            if (dogruSecenek == 'B')
            {
                kelimeVeriTabani.turkceSorDogru++;
            }
            else
            {
                kelimeVeriTabani.turkceSorYanlis++;
            }
            dogruLabel.Text = kelimeVeriTabani.turkceSorDogru.ToString();
            yanlisLabel.Text = kelimeVeriTabani.turkceSorYanlis.ToString();
        }

        private void c_Click(object sender, EventArgs e)
        {
            baslaButon.Enabled = true;
            aSec.Enabled = false;
            bSec.Enabled = false;
            cSec.Enabled = false;
            dSec.Enabled = false;
            if (dogruSecenek == 'C')
            {
                kelimeVeriTabani.turkceSorDogru++;
            }
            else
            {
                kelimeVeriTabani.turkceSorYanlis++;
            }
            dogruLabel.Text = kelimeVeriTabani.turkceSorDogru.ToString();
            yanlisLabel.Text = kelimeVeriTabani.turkceSorYanlis.ToString();
        }

        private void d_Click(object sender, EventArgs e)
        {
            baslaButon.Enabled = true;
            aSec.Enabled = false;
            bSec.Enabled = false;
            cSec.Enabled = false;
            dSec.Enabled = false;
            if (dogruSecenek == 'D')
            {
                kelimeVeriTabani.turkceSorDogru++;
            }
            else
            {
                kelimeVeriTabani.turkceSorYanlis++;
            }
            dogruLabel.Text = kelimeVeriTabani.turkceSorDogru.ToString();
            yanlisLabel.Text = kelimeVeriTabani.turkceSorYanlis.ToString();

        }
    }
}
