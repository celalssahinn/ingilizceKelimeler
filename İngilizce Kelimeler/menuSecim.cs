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

namespace İngilizce_Kelimeler
{
    public partial class menuSecim : Form
    {

        static MySqlConnection baglan = new MySqlConnection("server= db4free.net;user=celalssahinn;password=??????;database=celalsahin;old guids=true;");
       

        public menuSecim()
        {
            InitializeComponent();
        }
        private void menuSecim_Load(object sender, EventArgs e)
        {
            turkce.Enabled = false;
            abcdSor.Enabled = false;
            ingilizce.Enabled = false;


            MySqlCommand fiilKGetir = new MySqlCommand("SELECT fiilKategorileri FROM fiilTurleri", baglan);


            /* fiilKGetir.ExecuteNonQuery();
             fiilKGetir.Parameters.Clear();*/
            fiilKGetir.CommandType = CommandType.Text;
            MySqlDataReader datareader;
            baglan.Open();
            datareader = fiilKGetir.ExecuteReader();
            while (datareader.Read())
            {
              soruSecimCBox.Items.Add(datareader["fiilKategorileri"]);
            }
            baglan.Close();



        }
        private void addButton_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void turkce_Click(object sender, EventArgs e)
        {

            string soru;
            string cevabi;
            Random rnd = new Random();
          




            // sorular.Add();


            MySqlCommand sorulariGetir = new MySqlCommand("SELECT ingilizceKelime,turkceKarsiligi FROM kelimeler where verbsCategory='" + kelimeVeriTabani.hangiSoruSec + "'", baglan);



            sorulariGetir.CommandType = CommandType.Text;
            MySqlDataReader dr;
            baglan.Open();
            dr = sorulariGetir.ExecuteReader();
            while (dr.Read())
            {
                int i = 0;


                soru = (dr["ingilizceKelime"].ToString());
                cevabi = (dr["turkceKarsiligi"].ToString());
                kelimeVeriTabani.sorular.Add(soru);
                kelimeVeriTabani.cevaplar.Add(cevabi);
                i++;
            }
            baglan.Close();


            //hangiSoruKategoriTextBox.Text = sorular.Count().ToString();
            kelimeVeriTabani.kelimeSayisi = kelimeVeriTabani.sorular.Count();

            
            for (int i = 0; i < kelimeVeriTabani.kelimeSayisi; i++)
            {



                int x = rnd.Next(65, 69);
                char chr = Convert.ToChar(x);
                kelimeVeriTabani.siklar.Add(chr);
            }


          // Random sayıları buradan yerleştirdik (Soru sayısı kadar random sayı bunları soru sorarken kullanacağız) SoruSira ile gönderir
            for (int i = 0; i < kelimeVeriTabani.kelimeSayisi; i++)

            {

                int sayi = rnd.Next(0, kelimeVeriTabani.kelimeSayisi + 1);

                if (kelimeVeriTabani.soruSira.IndexOf(sayi) != -1)
                {

                    i--;

                    continue;

                }

                else

                {

                    kelimeVeriTabani.soruSira.Add(sayi);

                    //listboxa ekleme



                }

            }
            
         
           // soruCountLabel.Text = kelimeVeriTabani.cevaplar[soruSira[0]].ToString();
            // soruSiraCountLAbel.Text = soruSira.Count().ToString();
           // soruLabel.Text = kelimeVeriTabani.sorular[soruSira[0]].ToString();

            
           
            turkceSor ts = new turkceSor();
            ts.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kelimeVeriTabani.hangiSoruSec = soruSecimCBox.SelectedItem.ToString();
            turkce.Enabled = true;
            abcdSor.Enabled = true;
            ingilizce.Enabled = true;

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int uretA, uretB, uretC, uretD;
            while (kelimeVeriTabani.hangiSoru < kelimeVeriTabani.kelimeSayisi)
            {

                uretA = rnd.Next(0, kelimeVeriTabani.kelimeSayisi);
                uretB = rnd.Next(0, kelimeVeriTabani.kelimeSayisi);
                uretC = rnd.Next(0, kelimeVeriTabani.kelimeSayisi);
                uretD = rnd.Next(0, kelimeVeriTabani.kelimeSayisi);
                if (uretA != kelimeVeriTabani.hangiSoru && uretB != kelimeVeriTabani.hangiSoru && uretC != kelimeVeriTabani.hangiSoru && uretD != kelimeVeriTabani.hangiSoru)
                {
                    kelimeVeriTabani.kelimeSoruYolla(kelimeVeriTabani.sorular[kelimeVeriTabani.hangiSoru], kelimeVeriTabani.cevaplar[uretA], kelimeVeriTabani.cevaplar[uretB], kelimeVeriTabani.cevaplar[uretC], kelimeVeriTabani.cevaplar[uretD], kelimeVeriTabani.cevaplar[kelimeVeriTabani.hangiSoru]);
                    kelimeVeriTabani.hangiSoru++;
                }

            }
            MessageBox.Show("Veriler harmanlandı");
        }
    }
}
