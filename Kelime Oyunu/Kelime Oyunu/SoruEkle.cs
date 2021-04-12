using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelime_Oyunu
{
    public partial class SoruEkle : Form
    {
        MySqlConnection baglanti;
        public SoruEkle()
        {
            InitializeComponent();
            OpenConnection();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_add_cevap.Text != "" && txt_add_soru.Text != "")
            {

                try
                {

                    string sql = "";
                    string sql2 = "";

                    if ((txt_add_cevap.Text).Length == 4)
                    {
                        sql2 = "ALTER TABLE dort_harfli AUTO_INCREMENT = 1;";
                        sql = "INSERT INTO dort_harfli (soru_dort,cevap_dort) VALUES" + "('" + txt_add_soru.Text.ToString() + "','" + txt_add_cevap.Text.ToString() + "')";
                     
                    }
                    else if ((txt_add_cevap.Text).Length == 5)
                    {
                        sql2 = "ALTER TABLE bes_harfli AUTO_INCREMENT = 1;";
                        sql = "INSERT INTO bes_harfli (soru_bes,cevap_bes) VALUES" + "('" + txt_add_soru.Text.ToString() + "','" + txt_add_cevap.Text.ToString() + "')";
                       
                    }
                    else if ((txt_add_cevap.Text).Length == 6)
                    {
                        sql2 = "ALTER TABLE alti_harfli AUTO_INCREMENT = 1;";
                        sql = "INSERT INTO alti_harfli (soru_alti,cevap_alti) VALUES" + "('" + txt_add_soru.Text.ToString() + "','" + txt_add_cevap.Text.ToString() + "')";
                        
                    }
                    else if ((txt_add_cevap.Text).Length == 7)
                    {
                        sql2 = "ALTER TABLE yedi_harfli AUTO_INCREMENT = 1;";
                        sql = "INSERT INTO yedi_harfli (soru_yedi,cevap_yedi) VALUES" + "('" + txt_add_soru.Text.ToString() + "','" + txt_add_cevap.Text.ToString() + "')";
                     
                    }
                    else if ((txt_add_cevap.Text).Length == 8)
                    {
                        sql2 = "ALTER TABLE sekiz_harfli AUTO_INCREMENT = 1;";
                        sql = "INSERT INTO sekiz_harfli (soru_sekiz,cevap_sekiz) VALUES" + "('" + txt_add_soru.Text.ToString() + "','" + txt_add_cevap.Text.ToString() + "')";
                       
                    }
                    else if ((txt_add_cevap.Text).Length == 9)
                    {
                        sql2 = "ALTER TABLE dokuz_harfli AUTO_INCREMENT = 1;";
                        sql = "INSERT INTO dokuz_harfli (soru_dokuz,cevap_dokuz) VALUES" + "('" + txt_add_soru.Text.ToString() + "','" + txt_add_cevap.Text.ToString() + "')";
                        
                    }
                    else if ((txt_add_cevap.Text).Length == 10)
                    {
                        sql2 = "ALTER TABLE on_harfli AUTO_INCREMENT = 1;";
                        sql = "INSERT INTO on_harfli (soru_on,cevap_on) VALUES" + "('" + txt_add_soru.Text.ToString() + "','" + txt_add_cevap.Text.ToString() + "')";
         
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz Bilgiler Formata Uygun Değil", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    kayitbasarili();

                    MySqlCommand cmd = new MySqlCommand(sql, baglanti);

                    MySqlCommand cmd2 = new MySqlCommand(sql2, baglanti);

                    cmd2.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
               

                }
                catch (Exception)
                {

                    MessageBox.Show("Kayıt Yaparken Bir Sorun Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        void kayitbasarili()
        {
            MessageBox.Show("Kayıt Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_add_soru.Text = "";
            txt_add_cevap.Text = "";
        }

        void OpenConnection()
        {
            string bag;
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();

            build.UserID = "root";
            build.Password = "1234";
            build.Database = "kelime_oyunu";
            build.Server = "localhost";

            bag = build.ToString();
            baglanti = new MySqlConnection(bag);
            baglanti.Open();
        }

        private void SoruEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
