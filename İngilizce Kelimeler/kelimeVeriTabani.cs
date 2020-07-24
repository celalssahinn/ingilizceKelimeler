using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace İngilizce_Kelimeler
{
   static class kelimeVeriTabani
    {
        public static int turkceKacinciSoruda=0; //25.12.2019***01:12 degistirildi =0
        public static int turkceSorDogru=0;
        public static int turkceSorYanlis=0;
        public static int kelimeSayisi;
        public static int hangiSoru = 0;
        public static string hangiSoruSec;
        public static List<string> sorular = new List<string>();
        public static List<string> cevaplar = new List<string>();
        public static List<int> soruSira = new List<int>();
        public static List<char> siklar = new List<char>();
        //   public static int[] soruSira = new int[kelimeSayisi];



        //static private MySqlConnection baglan = new MySqlConnection("SERVER=db4free.net;PORT=3306;DATABASE=celalsahin;UID=celalssahinn;PWD=??????;");
        static  MySqlConnection baglan = new MySqlConnection ("server= db4free.net;user=celalssahinn;password=??????;database=celalsahin;old guids=true;");
        static public void yenile(DataGridView dataGridView)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                MySqlDataAdapter sorgu = new MySqlDataAdapter("SELECT ingilizceKelime,ingilizceKarsiligi,turkceKarsiligi,verbsCategory From kelimeler", baglan);

             



                DataTable dataTable = new DataTable();
                sorgu.Fill(dataTable);
                dataGridView.DataSource = dataTable;

                
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                baglan.Close();
            }

        }
        static public void kelimeEkle(string ingKelimee,string ingKarsiligii, string ingTurkcesii,string verbCategoryy, DataGridView dataGrid)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                MySqlCommand commandInsert = new MySqlCommand("INSERT INTO kelimeler(ingilizceKelime,ingilizceKarsiligi,turkceKarsiligi,verbsCategory) VALUES(@ingKelime,@ingKarsiligi,@turkKarsiligi,@verbsCategory)", baglan);
                commandInsert.Parameters.AddWithValue("@ingKelime", ingKelimee);
                commandInsert.Parameters.AddWithValue("@ingKarsiligi", ingKarsiligii);
                commandInsert.Parameters.AddWithValue("@turkKarsiligi", ingTurkcesii);
                commandInsert.Parameters.AddWithValue("@verbsCategory", verbCategoryy);
                commandInsert.ExecuteNonQuery();
                commandInsert.Parameters.Clear();
                MessageBox.Show("Kelime eklendi!");
               

                
            }
            catch(Exception e)
            {
               
                DialogResult hataMesaji = MessageBox.Show("Kayıtlı kelime eklemeye çalıştınız. Hata detayını görmek ister misiniz?", "Hata Mesajı Bildirimi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hataMesaji == DialogResult.Yes)
                {
                    MessageBox.Show("Hatanız : " + e);
                }
            }

            finally
            {
                baglan.Close();
            }
        }
        static public void kelimeSoruYolla(string soru,string aSecenek, string bSecenek, string cSecenek, string dSecenek, string cevap)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                MySqlCommand commandInsert = new MySqlCommand("INSERT INTO turkceSoru(soru,a,b,c,d,dogru) VALUES(@soru,@a,@b,@c,@d,@dogru)", baglan);
                commandInsert.Parameters.AddWithValue("@soru", soru);
                commandInsert.Parameters.AddWithValue("@a", aSecenek);
                commandInsert.Parameters.AddWithValue("@b", bSecenek);
                commandInsert.Parameters.AddWithValue("@c", cSecenek);
                commandInsert.Parameters.AddWithValue("@d", dSecenek);
                commandInsert.Parameters.AddWithValue("@dogru", cevap);
                commandInsert.ExecuteNonQuery();
                commandInsert.Parameters.Clear();
               // MessageBox.Show("Sorular veri tabanında harmanlandı.");



            }
            catch (Exception e)
            {

                DialogResult hataMesaji = MessageBox.Show("Kayıtlı kelime eklemeye çalıştınız. Hata detayını görmek ister misiniz?", "Hata Mesajı Bildirimi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hataMesaji == DialogResult.Yes)
                {
                    MessageBox.Show("Hatanız : " + e);
                }
            }

            finally
            {
                baglan.Close();
            }
        }



    }
}
