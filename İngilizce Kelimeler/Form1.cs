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
using MySql.Data;


namespace İngilizce_Kelimeler
{


    public partial class Form1 : Form
    {

        static MySqlConnection baglan = new MySqlConnection("server= db4free.net;user=celalssahinn;password=??????;database=celalsahin;old guids=true;");






        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            yenileOnay.Visible = false;
            kelimeVeriTabani.yenile(dataGrid);

            MySqlCommand fiilKGetir = new MySqlCommand("SELECT fiilKategorileri FROM fiilTurleri" , baglan);


           /* fiilKGetir.ExecuteNonQuery();
            fiilKGetir.Parameters.Clear();*/
            fiilKGetir.CommandType = CommandType.Text;
            MySqlDataReader dr;
            baglan.Open();
             dr = fiilKGetir.ExecuteReader();
            while (dr.Read())
            {
                verbsCategory.Items.Add(dr["fiilKategorileri"]);
            }
            baglan.Close();
        }



        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

      

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ingText.Text !="" && turkText.Text !="")
            {

                kelimeVeriTabani.kelimeEkle(ingText.Text,ingKarsiligiText.Text,turkText.Text,verbsGuncelleTextBox.Text, dataGrid);
                kelimeVeriTabani.yenile(dataGrid);
               
            }

            ingText.Text = "";
            ingKarsiligiText.Text = "";
            turkText.Text = "";
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            yenileOnay.Visible = true;
            yenileOnay.BackColor = Color.Red;
            MessageBox.Show("Yukarıdaki buton yeşil olduğunda yenilemiş olacaktır.");
            kelimeVeriTabani.yenile(dataGrid);
            yenileOnay.BackColor = Color.Green;
            
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
          

            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
               
                MySqlCommand silmeKomutu = new MySqlCommand("DELETE FROM kelimeler where ingilizceKelime ='" + silSecTextBox.Text + "'",baglan);


                silmeKomutu.ExecuteNonQuery();
                silmeKomutu.Parameters.Clear();
                MessageBox.Show("Kelime silindi!");
                kelimeVeriTabani.yenile(dataGrid);
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
        private void label6_Click(object sender, EventArgs e)
        {

        }

       
        


      

        private void ufakAltPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGrid.SelectedCells[0].RowIndex;
            string ingilizceKelime = dataGrid.Rows[secilialan].Cells[0].Value.ToString();
            silSecTextBox.Text = ingilizceKelime;
           
        }

     

        private void label6_Click_1(object sender, EventArgs e)
        {

        }


        private void label11_Click(object sender, EventArgs e)
        {
            mavisim.Visible = true;
            melegim.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            mavisim.Visible = false;
            melegim.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            verbsGuncelleTextBox.Text = verbsCategory.SelectedItem.ToString();
        }

        private void updateVerbs_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)

                baglan.Open();
                MySqlCommand guncelle = new MySqlCommand(" UPDATE kelimeler set verbsCategory='" + (verbsGuncelleTextBox.Text)+ "'WHERE ingilizceKelime='" + (silSecTextBox.Text) + "'",baglan);
                MySqlDataReader verbGuncelle = guncelle.ExecuteReader();
                verbGuncelle.Read();
                MessageBox.Show("Verbs Category değiştirildi!");
                kelimeVeriTabani.yenile(dataGrid);
                verbGuncelle.Close();
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

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            menuSecim m = new menuSecim();
            m.Show();
            this.Hide();
        }

        private void solPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
