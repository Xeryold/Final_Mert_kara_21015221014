using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mert_kara_21015221014.UL
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        public urun urun { get; set; }
        public static bool guncelleme = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!kontrol(seri)) return;
            if (!kontrol(tc)) return;
            if (!kontrol(marka)) return;
            if (!kontrol(model)) return;
            if (!kontrol(sorun)) return;
            if (!kontrol(garanti)) return;

            urun.Musteriid = tc.Text;
            urun.seri = seri.Text;
            urun.marka = marka.Text;
            urun.model = model.Text;
            urun.sorun = sorun.Text;
            urun.garanti = garanti.Text;
            urun.gtarih = gtarih.Value;

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public bool kontrol(Control c)
        {
            if (c is TextBox || c is ComboBox|| c is RichTextBox)
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

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            
            if (guncelleme)
            {
                seri.Text = urun.seri.ToString();
                tc.Text = urun.Musteriid;
                marka.Text = urun.marka;
                model.Text = urun.model;
                sorun.Text = urun.sorun;
                garanti.Text = urun.garanti;
                gtarih.Value = urun.gtarih;
                guncelleme = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            musterisec musterisec = new musterisec();
            if (musterisec.ShowDialog() == DialogResult.OK) 
            {
                tc.Text =musterisec.a;
            }
        }
    }
}
