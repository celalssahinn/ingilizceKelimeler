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
using System.Text.RegularExpressions;

namespace İngilizce_Kelimeler
{
    public partial class kullaniciGirisi : Form
    {
        public kullaniciGirisi()
        {
            InitializeComponent();
        }

        private void girisPaneli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void girisPaneli_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        
        private void girisButon_Click(object sender, EventArgs e)
        {

            bekleyiniz.Visible = true;
            MySqlConnection baglan = new MySqlConnection("server= db4free.net;user=celalssahinn;password=??????;database=celalsahin;old guids=true;");
            
            try
            {




                
                baglan.Open();
               

                if (baglan.State != ConnectionState.Closed)
                {

                    kullaniciAdi.Text = Regex.Replace(kullaniciAdi.Text, "'", "&#39;");
                    parola.Text = Regex.Replace(parola.Text, "'", "&#39;");

                    String loginGirisKontrol = ("SELECT * FROM kullanicilar where kullaniciAdi='" + kullaniciAdi.text + "'AND sifre='" + parola.Text + "'");
                                               

                    MySqlCommand komut = new MySqlCommand(loginGirisKontrol, baglan);


                    MySqlDataReader rdr = komut.ExecuteReader();


                    if (rdr.Read())
                    {

                        menuSecim m = new menuSecim();

                        baglan.Close();
                        m.Show();
                        rdr.Close();
                       

                        this.Hide();



                    }

                    else
                    {
                        bekleyiniz.Visible = false;
                        kullaniciAdi.text = "";
                        parola.Text="";
                        
                        MessageBox.Show("Böyle bir kullanıcı bulunmamaktadır");
                        rdr.Close();
                        baglan.Close();
                    }
                }
                

            }
            catch (Exception ex)
            {
                bekleyiniz.Visible = false;
                baglan.Close();
                MessageBox.Show("Veritabanı bağlantısı zaman aşımına uğradı tekrar GİRİŞ butonuna tıklayınız");
            }

            finally{
                
                baglan.Close();
            }
        }
    }
    }

