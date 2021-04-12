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
    public partial class Giris : Form
    {
        Form1 frm1;
        SoruEkle SoruEkle;


        public Giris()
        {
            InitializeComponent();
          
        }

        private void btn_basla_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                MessageBox.Show("Kulanıcı Adı Boş Geçilemez");
            }
            else
            {
                frm1 = new Form1(txt_username.Text);
                frm1.ShowDialog() ; 
            }
        }

        private void btn_soru_ekle_Click(object sender, EventArgs e)
        {
            SoruEkle = new SoruEkle();
            SoruEkle.ShowDialog();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
