using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mert_kara_21015221014.UL
{
    public partial class FrmMusteri : Form
    {

        public FrmMusteri()
        {
            InitializeComponent();
           
        }
        public Musteri Musteri { get; set; }
        public static bool guncelleme = false;

        private void button1_Click(object sender, EventArgs e)
        {
           // Musteri sınıfının bir örneği oluşturuldu
            if (!kontrol(tc)) return;
            if (!kontrol(ad)) return;
            if (!kontrol(soyad)) return;
            if (!kontrol(adres)) return;
            if (!kontrol(tel)) return;

            Musteri.Tc = tc.Text;
            Musteri.Ad = ad.Text;
            Musteri.Soyad = soyad.Text;
            Musteri.Adres = adres.Text;
            Musteri.Tel = tel.Text;

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
        public bool kontrol(Control c)
        {
            if (c is TextBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            if (c is RichTextBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            tc.Text = Musteri.Tc;
            if (guncelleme) 
            {
                ad.Text=Musteri.Ad ;
                soyad.Text=Musteri.Soyad ;
                adres.Text= Musteri.Adres ;
                tel.Text= Musteri.Tel  ;
                guncelleme = false;
            }

        }
    }
}
