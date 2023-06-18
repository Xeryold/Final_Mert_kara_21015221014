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
    public partial class FrmParca : Form
    {
        public FrmParca()
        {
            InitializeComponent();
        }
        public y_parca y_Parca { get; set; }
        public static bool guncelleme = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!kontrol(pad)) return;
            if (!kontrol(pmarka)) return;
            if (!kontrol(pmodel)) return;
            if (fiyat.Value == 0) { errorProvider1.SetError(fiyat, "lütfen stok sayisi giriniz"); fiyat.Focus(); return; }
            else { errorProvider1.SetError(fiyat, ""); }
            if (stok.Value == 0) { errorProvider1.SetError(stok, "lütfen stok sayisi giriniz"); stok.Focus(); return; }
            else { errorProvider1.SetError(stok, ""); }

            y_Parca.pad = pad.Text;
            y_Parca.pmarka = pmarka.Text;
            y_Parca.pmodel=pmodel.Text;
            y_Parca.fiyat=(double)fiyat.Value;
            y_Parca.stok = (int)stok.Value;

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
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
            return true;
        }

        private void FrmParca_Load(object sender, EventArgs e)
        {
            pid.Text = y_Parca.pid.ToString();
            if (guncelleme)
            {
                pad.Text = y_Parca.pad;
                pmarka.Text = y_Parca.pmarka;
                pmodel.Text = y_Parca.pmodel;
                fiyat.Value = (decimal)double.Parse(y_Parca.fiyat.ToString());
                stok.Value = y_Parca.stok;
                guncelleme = false;
            }
        }
    }
}
