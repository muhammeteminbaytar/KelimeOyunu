using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kelime_Oyunu
{
    public partial class Form1 : Form
    {

        MySqlConnection baglanti;


        int rnd1;
        int rnd2;
        int rnd3;
        int rnd4;
        int rnd5;
        int rnd6;
        int rnd7;
        int rnd8;
        int rnd9;
        int rnd10;
        int rnd11;
        int rnd12;
        int rnd13;
        int rnd14;

        ArrayList Ques;
        ArrayList Ans;

        ArrayList alinanHarf = new ArrayList();

        int soru_index=0;

        int puan = 0;
        int sure = 240;
        int sure_cvp = 20;

        int harfrnd=0;
        int alinanharfindex=0;

       
        public Form1(String UserName)
        {
            InitializeComponent();
            lbl_username.Text = UserName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenConnection();
            sayitut();
            degerAta();
            oyun();
            kutuKur();
            
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
        void sayitut()
        {

            //4 harfli kelimeler
            string sql = "SELECT Max(id_dort) FROM dort_harfli";

            MySqlCommand cmd = new MySqlCommand(sql, baglanti);
            MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();

           
            Random rnd = new Random();

             rnd1 = rnd.Next(1,Int32.Parse(rdr[0].ToString())+1);
             rnd2 = rnd.Next(1,Int32.Parse(rdr[0].ToString()) + 1);
            while (rnd2==rnd1)
            {
                 rnd2 = rnd.Next(1, Int32.Parse(rdr[0].ToString()) + 1);
            }
            rdr.Close();
           

            //5 harfli kelimeler
            sql = "SELECT Max(id_bes) FROM bes_harfli";
            cmd = new MySqlCommand(sql, baglanti);
            rdr = cmd.ExecuteReader();

            rdr.Read();
             rnd3 = rnd.Next(1, Int32.Parse(rdr[0].ToString()) + 1);
             rnd4 = rnd.Next(1, Int32.Parse(rdr[0].ToString()) + 1);
            while (rnd3 == rnd4)
            {
                rnd4 = rnd.Next(1, Int32.Parse(rdr[0].ToString()) + 1);
            }
            rdr.Close();
           

            // 6 harfli kelimeler
            sql = "SELECT Max(id_alti) FROM alti_harfli";
            cmd = new MySqlCommand(sql, baglanti);
            rdr = cmd.ExecuteReader();

            rdr.Read();
            rnd5 = rnd.Next(1, Int32.Parse(rdr[0].ToString()) + 1);
            rnd6 = rnd.Next(1, Int32.Parse(rdr[0].ToString()) + 1);
            while (rnd5 == rnd6)
            {
                rnd6 = rnd.Next(1, Int32.Parse(rdr[0].ToString()) + 1);
            }
            rdr.Close();
           

            // 7 harfli kelimeler
            sql = "SELECT Max(id_yedi) FROM yedi_harfli";
            cmd = new MySqlCommand(sql, baglanti);
            rdr = cmd.ExecuteReader();

            rdr.Read();
             rnd7 = rnd.Next(1, Int32.Parse(rdr[0].ToString()) + 1);
             rnd8 = rnd.Next(1, Int32.Parse(rdr[0].ToString()) + 1);
            while (rnd7 == rnd8)
            {
                rnd8 = rnd.Next(1, Int32.Parse(rdr[0].ToString()) + 1);
            }
            rdr.Close();
         

            // 8 harfli kelimeler
            sql = "SELECT Max(id_sekiz) FROM sekiz_harfli";
            cmd = new MySqlCommand(sql, baglanti);
            rdr = cmd.ExecuteReader();

            rdr.Read();
             rnd9 = rnd.Next(1, Int32.Parse(rdr[0].ToString()) + 1);
             rnd10 = rnd.Next(1, Int32.Parse(rdr[0].ToString()) + 1);
            while (rnd9 == rnd10)
            {
                rnd10 = rnd.Next(1, Int32.Parse(rdr[0].ToString()) + 1);
            }
            rdr.Close();
            

            // 9 harfli kelimeler
            sql = "SELECT Max(id_dokuz) FROM dokuz_harfli";
            cmd = new MySqlCommand(sql, baglanti);
            rdr = cmd.ExecuteReader();

            rdr.Read();
             rnd11 = rnd.Next(1, Int32.Parse(rdr[0].ToString()) + 1);
             rnd12 = rnd.Next(1, Int32.Parse(rdr[0].ToString()) + 1);
            while (rnd11 == rnd12)
            {
                rnd12 = rnd.Next(1, Int32.Parse(rdr[0].ToString()) + 1);
            }
            rdr.Close();
          

            // 10 harfli kelimeler
            sql = "SELECT Max(id_on) FROM on_harfli";
            cmd = new MySqlCommand(sql, baglanti);
            rdr = cmd.ExecuteReader();

            rdr.Read();
             rnd13 = rnd.Next(1, Int32.Parse(rdr[0].ToString()) + 1);
             rnd14 = rnd.Next(1, Int32.Parse(rdr[0].ToString()) + 1);
            while (rnd13 == rnd14)
            {
                rnd14 = rnd.Next(1, Int32.Parse(rdr[0].ToString()) + 1);
            }
            rdr.Close();
          

        }
        void degerAta()
        {
            Ques = new ArrayList();
            Ans = new ArrayList();


            //1 Soru
            string sql = "SELECT soru_dort,cevap_dort FROM dort_harfli WHERE id_dort="+rnd1.ToString();

            MySqlCommand cmd = new MySqlCommand(sql, baglanti);
            MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();

            
            Ques.Add(rdr[0].ToString());
            Ans.Add(rdr[1].ToString());
   
            rdr.Close();

            //2 Soru
             sql = "SELECT soru_dort,cevap_dort FROM dort_harfli WHERE id_dort=" + rnd2.ToString();

             cmd = new MySqlCommand(sql, baglanti);
             rdr = cmd.ExecuteReader();

            rdr.Read();


            Ques.Add(rdr[0].ToString());
            Ans.Add(rdr[1].ToString());

            rdr.Close();

            //3 Soru
            sql = "SELECT soru_bes,cevap_bes FROM bes_harfli WHERE id_bes=" + rnd3.ToString();

            cmd = new MySqlCommand(sql, baglanti);
            rdr = cmd.ExecuteReader();

            rdr.Read();


            Ques.Add(rdr[0].ToString());
            Ans.Add(rdr[1].ToString());

            rdr.Close();
            
            //4 Soru
            sql = "SELECT soru_bes,cevap_bes FROM bes_harfli WHERE id_bes=" + rnd4.ToString();

            cmd = new MySqlCommand(sql, baglanti);
            rdr = cmd.ExecuteReader();

            rdr.Read();


            Ques.Add(rdr[0].ToString());
            Ans.Add(rdr[1].ToString());

            rdr.Close();
            
            //5 Soru
            sql = "SELECT soru_alti,cevap_alti FROM alti_harfli WHERE id_alti=" + rnd5.ToString();

            cmd = new MySqlCommand(sql, baglanti);
            rdr = cmd.ExecuteReader();

            rdr.Read();


            Ques.Add(rdr[0].ToString());
            Ans.Add(rdr[1].ToString());

            rdr.Close();
            
            //6 Soru
            sql = "SELECT soru_alti,cevap_alti FROM alti_harfli WHERE id_alti=" + rnd6.ToString();

            cmd = new MySqlCommand(sql, baglanti);
            rdr = cmd.ExecuteReader();

            rdr.Read();


            Ques.Add(rdr[0].ToString());
            Ans.Add(rdr[1].ToString());

            rdr.Close();
            
            
            //7 Soru
            sql = "SELECT soru_yedi,cevap_yedi FROM yedi_harfli WHERE id_yedi=" + rnd7.ToString();

            cmd = new MySqlCommand(sql, baglanti);
            rdr = cmd.ExecuteReader();

            rdr.Read();


            Ques.Add(rdr[0].ToString());
            Ans.Add(rdr[1].ToString());

            rdr.Close();
            
            
            //8 Soru
            sql = "SELECT soru_yedi,cevap_yedi FROM yedi_harfli WHERE id_yedi=" + rnd8.ToString();

            cmd = new MySqlCommand(sql, baglanti);
            rdr = cmd.ExecuteReader();

            rdr.Read();


            Ques.Add(rdr[0].ToString());
            Ans.Add(rdr[1].ToString());

            rdr.Close();
            
            
            
            //9 Soru
            sql = "SELECT soru_sekiz,cevap_sekiz FROM sekiz_harfli WHERE id_sekiz=" + rnd9.ToString();

            cmd = new MySqlCommand(sql, baglanti);
            rdr = cmd.ExecuteReader();

            rdr.Read();


            Ques.Add(rdr[0].ToString());
            Ans.Add(rdr[1].ToString());

            rdr.Close();
            
            
            //10 Soru
            sql = "SELECT soru_sekiz,cevap_sekiz FROM sekiz_harfli WHERE id_sekiz=" + rnd10.ToString();

            cmd = new MySqlCommand(sql, baglanti);
            rdr = cmd.ExecuteReader();

            rdr.Read();


            Ques.Add(rdr[0].ToString());
            Ans.Add(rdr[1].ToString());

            rdr.Close();
            
            
            
            //11 Soru
            sql = "SELECT soru_dokuz,cevap_dokuz FROM dokuz_harfli WHERE id_dokuz=" + rnd11.ToString();

            cmd = new MySqlCommand(sql, baglanti);
            rdr = cmd.ExecuteReader();

            rdr.Read();


            Ques.Add(rdr[0].ToString());
            Ans.Add(rdr[1].ToString());

            rdr.Close();
            
            
            //12 Soru
            sql = "SELECT soru_dokuz,cevap_dokuz FROM dokuz_harfli WHERE id_dokuz=" + rnd12.ToString();

            cmd = new MySqlCommand(sql, baglanti);
            rdr = cmd.ExecuteReader();

            rdr.Read();


            Ques.Add(rdr[0].ToString());
            Ans.Add(rdr[1].ToString());

            rdr.Close();
            
            
            
            //13 Soru
            sql = "SELECT soru_on,cevap_on FROM on_harfli WHERE id_on=" + rnd13.ToString();

            cmd = new MySqlCommand(sql, baglanti);
            rdr = cmd.ExecuteReader();

            rdr.Read();


            Ques.Add(rdr[0].ToString());
            Ans.Add(rdr[1].ToString());

            rdr.Close();
            
            
            //14 Soru
            sql = "SELECT soru_on,cevap_on FROM on_harfli WHERE id_on=" + rnd14.ToString();

            cmd = new MySqlCommand(sql, baglanti);
            rdr = cmd.ExecuteReader();

            rdr.Read();


            Ques.Add(rdr[0].ToString());
            Ans.Add(rdr[1].ToString());

            rdr.Close();

         


        }

        void oyun()
        {
            timer1.Start();
            txt_soru.Text = Ques[soru_index].ToString();
        }

        void kutuKur()
        {
            if (soru_index == 0 || soru_index == 1)
            {
                txt_harf5.Visible = false;
                txt_harf6.Visible = false;
                txt_harf7.Visible = false;
                txt_harf8.Visible = false;
                txt_harf9.Visible = false;
                txt_harf10.Visible = false;
            }
           else if (soru_index == 2 || soru_index == 3)
            {
                txt_harf5.Visible = true;
                txt_harf6.Visible = false;
                txt_harf7.Visible = false;
                txt_harf8.Visible = false;
                txt_harf9.Visible = false;
                txt_harf10.Visible = false;
            }
            else if (soru_index == 4 || soru_index == 5)
            {

                txt_harf5.Visible = true;
                txt_harf6.Visible = true;
                txt_harf7.Visible = false;
                txt_harf8.Visible = false;
                txt_harf9.Visible = false;
                txt_harf10.Visible = false;
            }
            else if (soru_index == 6 || soru_index == 7)
            {


                txt_harf5.Visible = true;
                txt_harf6.Visible = true;
                txt_harf7.Visible = true;
                txt_harf8.Visible = false;
                txt_harf9.Visible = false;
                txt_harf10.Visible = false;
            }
            else if (soru_index == 8 || soru_index == 9)
            {

                txt_harf5.Visible = true;
                txt_harf6.Visible = true;
                txt_harf7.Visible = true;
                txt_harf8.Visible = true;
                txt_harf9.Visible = false;
                txt_harf10.Visible = false;
            }
            else if (soru_index == 10 || soru_index == 11)
            {

                txt_harf5.Visible = true;
                txt_harf6.Visible = true;
                txt_harf7.Visible = true;
                txt_harf8.Visible = true;
                txt_harf9.Visible = true;
                txt_harf10.Visible = false;
            }
            else 
            {
                txt_harf5.Visible = true;
                txt_harf6.Visible = true;
                txt_harf7.Visible = true;
                txt_harf8.Visible = true;
                txt_harf9.Visible = true;
                txt_harf10.Visible = true;
            }

        }

        private void btn_cevapla_Click(object sender, EventArgs e)
        {

            cevapla();
            alinanHarf.Clear();
            btn_harfal.Enabled = true;
        }

        void cevapla()
        {
            sure_cvp = 20;
            timer2.Stop();

            cevap_kontrol();
            kutu_bosalt();
            soru_index++;
            kutuKur();
            txt_soruSay.Text = "Soru " + (soru_index + 1).ToString();
            if (soru_index == 14)
            {
                MessageBox.Show("Oyun Tamalandı");
                soru_index = 13;
                text_yaz();

                this.Close();
            }
            oyun();
            timer1.Start();
            lbl_cvpsure.Visible = false;

            btn_cevapla.Enabled = false;
        }

        void text_yaz()
        {
            String dosya_yolu = @"C:\Storage\My Project\School Project\Kelime Oyunu\saved.txt";
            string metin = System.IO.File.ReadAllText(dosya_yolu);

            string kayit = " Adı : " + lbl_username.Text + " Tarih : " + DateTime.Now.ToString() + " Puan : " + puan;
            kayit = metin +"\n"+ kayit;
            System.IO.File.WriteAllText(dosya_yolu,kayit);
            MessageBox.Show("Adı: " + lbl_username.Text + "\n" + " Tarih: " + DateTime.Now.ToString() + "\n" + " Puan: " + puan + "\n" + "Kalan: " + lbl_dk.Text.ToString() + ":" + lbl_sn.Text.ToString()) ;
        }
       
        void cevap_kontrol()
        {
           
            
                if (Ans[soru_index].ToString() == (txt_harf1.Text + txt_harf2.Text + txt_harf3.Text + txt_harf4.Text+txt_harf5.Text+ txt_harf6.Text + txt_harf7.Text + txt_harf8.Text + txt_harf9.Text + txt_harf10.Text).ToString())
                {
                    MessageBox.Show("Tebrikler","Doğru Cevap ");
                puan=puan - alinanharfindex * 100;

                if (soru_index == 0 || soru_index == 1)
                    puan = puan + 400;
                else if (soru_index == 2 || soru_index == 3)
                    puan = puan + 500;
                else if (soru_index == 4 || soru_index == 5)
                    puan = puan + 600;
                else if (soru_index == 6 || soru_index == 7)
                    puan = puan + 700;
                else if (soru_index == 8 || soru_index == 9)
                    puan = puan + 800;
                else if (soru_index == 10 || soru_index == 11)
                    puan = puan + 900;
                else if (soru_index == 12 || soru_index == 13)
                    puan = puan + 1000;

                lbl_puan.Text = "Puan " + puan.ToString(); 

            }
                else
                {
                puan = puan + alinanharfindex * 100;
                MessageBox.Show("Maalesef Yanlış \n\n Doğru Cevap : "+Ans[soru_index].ToString(),"Yanlış Cevap");

                if (soru_index == 0 || soru_index == 1)
                    puan = puan - 400;
                else if (soru_index == 2 || soru_index == 3)
                    puan = puan - 500;
                else if (soru_index == 4 || soru_index == 5)
                    puan = puan - 600;
                else if (soru_index == 6 || soru_index == 7)
                    puan = puan - 700;
                else if (soru_index == 8 || soru_index == 9)
                    puan = puan - 800;
                else if (soru_index == 10 || soru_index == 11)
                    puan = puan - 900;
                else if (soru_index == 12 || soru_index == 13)
                    puan = puan - 1000;

                lbl_puan.Text = "Puan " + puan.ToString();
            }
            alinanharfindex = 0;
            
        }
        void kutu_bosalt()
        {
            txt_harf1.Text = "";
            txt_harf2.Text = "";
            txt_harf3.Text = "";
            txt_harf4.Text = "";
            txt_harf5.Text = "";
            txt_harf6.Text = "";
            txt_harf7.Text = "";
            txt_harf8.Text = "";
            txt_harf9.Text = "";
            txt_harf10.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btn_cevapla.Enabled = true;
            timer2.Enabled = true;
            lbl_cvpsure.Visible = true;
            btn_harfal.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure = sure - 1;
            lbl_dk.Text = "0"+(sure / 60).ToString();
            lbl_sn.Text = (sure % 60).ToString();
            if(Int32.Parse(lbl_sn.Text) / 10 < 1)
            {
                if(Int32.Parse(lbl_sn.Text) % 10 != 0)
                lbl_sn.Text = "0"+(sure % 60).ToString();
            }
            if(lbl_sn.Text == "0")
            {
                lbl_sn.Text = "00";
            }

            if (sure == 0)
            {
                timer1.Stop();
                MessageBox.Show("Süre Bitti","Uyarı");
                text_yaz();
                btn_cevapla.Enabled = false;
                btn_harfal.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sure_cvp = sure_cvp - 1;
            lbl_cvpsure.Text = sure_cvp.ToString();

            if (sure_cvp == 0)
            {

                timer2.Stop();
                MessageBox.Show("Cevaplama Süresi Bitti \n\n Doğru Cevap : "+Ans[soru_index]);
                sure_cvp = 20;
                cevap_kontrol();
                kutu_bosalt();

                soru_index++;
                kutuKur();
                txt_soruSay.Text = "Soru " + (soru_index + 1).ToString();
                if (soru_index == 14)
                {
                    MessageBox.Show("Oyun Tamalandı");
                    text_yaz();
                    soru_index = 13;
                }
                oyun();
                timer1.Start();
                lbl_cvpsure.Visible = false;

                btn_cevapla.Enabled = false;


            }
        }

        private void btn_harfal_Click(object sender, EventArgs e)
        {
            rndharfuret();
       
            harfyerlestir();
            alinanharfindex++;
           
        }
        void harfyerlestir()
        {
            try
            {
                string secilensoru = Ans[soru_index].ToString();
                if (harfrnd == 0)
                {
                    txt_harf1.Text = secilensoru[0].ToString();
                }
                else if (harfrnd == 1)
                {
                    txt_harf2.Text = secilensoru[1].ToString();
                }
                else if (harfrnd == 2)
                {
                    txt_harf3.Text = secilensoru[2].ToString();
                }
                else if (harfrnd == 3)
                {
                    txt_harf4.Text = secilensoru[3].ToString();
                }
                else if (harfrnd == 4)
                {
                    txt_harf5.Text = secilensoru[4].ToString();
                }
                else if (harfrnd == 5)
                {
                    txt_harf6.Text = secilensoru[5].ToString();
                }
                else if (harfrnd == 6)
                {
                    txt_harf7.Text = secilensoru[6].ToString();
                }
                else if (harfrnd == 7)
                {
                    txt_harf8.Text = secilensoru[7].ToString();
                }
                else if (harfrnd == 8)
                {
                    txt_harf9.Text = secilensoru[8].ToString();
                }
                else if (harfrnd == 9)
                {
                    txt_harf10.Text = secilensoru[9].ToString();
                }
            }
            catch (InvalidCastException e)
            {
            }
        }
        void rndharfuret()
        {
            int i = 0;

            Random rnd = new Random();

            if (soru_index == 0 || soru_index == 1) 
            {
                harfrnd = rnd.Next(0, 4);
                while (alinanHarf.IndexOf(harfrnd)!=-1)
                {
                   
                    harfrnd = rnd.Next(0, 4);
                    i++;
                    if (i > 12)
                    {
                        break;
                    }
                }

            }
                
            else if (soru_index == 2 || soru_index == 3)
            {
                harfrnd = rnd.Next(0, 5);

                while (alinanHarf.IndexOf(harfrnd) != -1)
                {
                    harfrnd = rnd.Next(0, 5);
                    i++;
                    if (i > 12)
                    {
                        break;
                    }
                }
            }
                
            else if (soru_index == 4 || soru_index == 5)
            {
                harfrnd = rnd.Next(0, 6);

                while (alinanHarf.IndexOf(harfrnd) != -1)
                {
                    harfrnd = rnd.Next(0, 6);
                    i++;
                    if (i > 12)
                    {
                        break;
                    }
                }
            }
            
            else if (soru_index == 6 || soru_index == 7)
            {
                harfrnd = rnd.Next(0, 7);

                while (alinanHarf.IndexOf(harfrnd) != -1)
                {
                    harfrnd = rnd.Next(0, 7);
                    i++;
                    if (i > 12)
                    {
                        break;
                    }
                }
            }
                
            else if (soru_index == 8 || soru_index == 9)
            {
                harfrnd = rnd.Next(0, 8);

                while (alinanHarf.IndexOf(harfrnd) != -1)
                {
                    harfrnd = rnd.Next(0, 8);
                    i++;
                    if (i > 12)
                    {
                        break;
                    }
                }
            }
              
            else if (soru_index == 10 || soru_index == 11)
            {
                harfrnd = rnd.Next(0, 9);

                while (alinanHarf.IndexOf(harfrnd) != -1)
                {
                    harfrnd = rnd.Next(0, 9);
                    i++;
                    if (i > 12)
                    {
                        break;
                    }
                }
            }
                
            else if (soru_index == 12 || soru_index == 13)
            {
                harfrnd = rnd.Next(0, 10);

                while (alinanHarf.IndexOf(harfrnd) != -1)
                {
                    harfrnd = rnd.Next(0, 10);
                    i++;
                    if (i > 12)
                    {
                        break;
                    }
                }
            }

            alinanHarf.Add(harfrnd);
        }

      
    }
}
