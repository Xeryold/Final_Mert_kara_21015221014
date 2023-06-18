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
    public partial class FrmTeknik : Form
    {
        public FrmTeknik()
        {
            InitializeComponent();
        }
        public teknik teknik { get; set; }
        public static bool guncelleme = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!kontrol(ad)) return;
            if (!kontrol(soyad)) return;
            if (!kontrol(ilgi)) return;

            teknik.ad = ad.Text;
            teknik.soyad = soyad.Text;
            teknik.ilgi = ilgi.Text;


            DialogResult=DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
            if (c is ComboBox)
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

        private void FrmTeknik_Load(object sender, EventArgs e)
        {
            tid.Text = teknik.tid.ToString();
            if (guncelleme)
            {
                ad.Text = teknik.ad;
                soyad.Text = teknik.soyad;
                ilgi.Text = teknik.ilgi;
                guncelleme = false;
            }
        }
    }
}
