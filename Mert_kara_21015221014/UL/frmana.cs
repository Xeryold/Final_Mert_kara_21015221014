using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mert_kara_21015221014.UL;
using Mert_kara_21015221014.BL;
using System.Security.Cryptography;

namespace Mert_kara_21015221014
{
    public partial class frmana : Form
    {
      
        public frmana()
        {   
            InitializeComponent();
        }
        private void frmana_Load(object sender, EventArgs e)
        {
            DataSet ds = Bllogic.musterigetir("");
            DataSet tds = Bllogic.teknik_getir("");
            DataSet pds = Bllogic.parca_getir("");
            DataSet uds = Bllogic.urun_getir("");
            DataSet ods = Bllogic.onarim_getir("");
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
            if(uds!=null)
                dataGridView2.DataSource=uds.Tables[0];
            if (tds != null)
                dataGridView3.DataSource = tds.Tables[0];
            if (pds != null)
                dataGridView4.DataSource = pds.Tables[0];
            if(ods!=null)
                dataGridView5.DataSource= ods.Tables[0];
        }
        //------------------------------------------------------------------------
        private void mekle(object sender, EventArgs e)
        {
            FrmMusteri frmMusteri = new FrmMusteri();
            frmMusteri.Text = "Musteri Ekle";
            frmMusteri.Musteri = new Musteri(); 
            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = Bllogic.musteriekle(frmMusteri.Musteri);
                if (b)
                {
                    DataSet ds = Bllogic.musterigetir("");
                    if (ds != null)
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataSet ds = Bllogic.musterigetir(m_aranacak.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void duzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            FrmMusteri.guncelleme = true;
            FrmMusteri frmMusteri = new FrmMusteri();
            frmMusteri.Text = "Musteri duzenle";

            // Güncelleme durumunda, mevcut Musteri nesnesini FrmMusteri'ye aktar
            frmMusteri.Musteri = new Musteri()
            {
                Tc = row.Cells[0].Value.ToString(),
                Ad = row.Cells[1].Value.ToString(),
                Soyad = row.Cells[2].Value.ToString(),
                Adres = row.Cells[3].Value.ToString(),
                Tel = row.Cells[4].Value.ToString()
            };

            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = Bllogic.musteriguncelle(frmMusteri.Musteri);
                if (b)
                {
                    DataSet ds = Bllogic.musterigetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var Tc = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi","silmeyi onayla",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = Bllogic.musterisil(Tc);
                if (b)
                {
                    DataSet ds = Bllogic.musterigetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }
        //---------------------------------------------------------------------

        private void t_ekle_Click(object sender, EventArgs e)
        {
            FrmTeknik frmteknik = new FrmTeknik();
            frmteknik.Text = "Musteri Ekle";
            frmteknik.teknik = new teknik() {tid=Guid.NewGuid() };
            var sonuc = frmteknik.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = Bllogic.teknik_ekle(frmteknik.teknik);
                if (b)
                {
                    DataSet ds = Bllogic.teknik_getir("");
                    if (ds != null)
                        dataGridView3.DataSource = ds.Tables[0];
                }
            }
        }

        private void t_duzenle_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView3.SelectedRows[0];
            FrmTeknik.guncelleme = true;
            FrmTeknik frmteknik = new FrmTeknik();
            frmteknik.Text = "Tekniker duzenle";
            frmteknik.teknik = new teknik()
            {
                tid = Guid.Parse(row.Cells[0].Value.ToString()),
                ad = row.Cells[1].Value.ToString(),
                soyad = row.Cells[2].Value.ToString(),
                ilgi = row.Cells[3].Value.ToString()
            };

            var sonuc = frmteknik.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = Bllogic.teknik_guncelle(frmteknik.teknik);
                if (b)
                {
                    DataSet tds = Bllogic.teknik_getir("");
                    if (tds != null)
                        dataGridView3.DataSource = tds.Tables[0];
                }
            }
        }

        private void t_sil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView3.SelectedRows[0];
            var tid = Guid.Parse(row.Cells[0].Value.ToString());

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi", "silmeyi onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = Bllogic.teknik_sil(tid);
                if (b)
                {
                    DataSet tds = Bllogic.teknik_getir("");
                    if (tds != null)
                        dataGridView3.DataSource = tds.Tables[0];
                }
            }
        }

        private void t_ara_Click(object sender, EventArgs e)
        {
            DataSet ds = Bllogic.teknik_getir(t_aranacak.Text);
            if (ds != null)
                dataGridView3.DataSource = ds.Tables[0];
        }
        //---------------------------------------------------------------------------

        private void y_ekle_Click(object sender, EventArgs e)
        {
            FrmParca frmparca = new FrmParca();
            frmparca.Text = "Parca Ekle";
            frmparca.y_Parca = new y_parca() { pid = Guid.NewGuid() };
            var sonuc = frmparca.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = Bllogic.parca_ekle(frmparca.y_Parca);
                if (b)
                {
                    DataSet ds = Bllogic.parca_getir("");
                    if (ds != null)
                        dataGridView4.DataSource = ds.Tables[0];
                }
            }
        }

        private void y_duzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView4.SelectedRows[0];
            FrmParca.guncelleme = true;
            FrmParca frmparca = new FrmParca();
            frmparca.Text = "parca duzenle";
            frmparca.y_Parca = new y_parca()
            {
                pid = Guid.Parse(row.Cells[0].Value.ToString()),
                pad = row.Cells[1].Value.ToString(),
                pmarka = row.Cells[2].Value.ToString(),
                pmodel = row.Cells[3].Value.ToString(),
                fiyat =double.Parse(row.Cells[4].Value.ToString()),
                stok =int.Parse( row.Cells[5].Value.ToString())
            };

            var sonuc = frmparca.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = Bllogic.parca_guncelle(frmparca.y_Parca);
                if (b)
                {
                    DataSet tds = Bllogic.parca_getir("");
                    if (tds != null)
                        dataGridView4.DataSource = tds.Tables[0];
                }
            }
        }

        private void y_sil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView4.SelectedRows[0];
            var pid = Guid.Parse(row.Cells[0].Value.ToString());

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi", "silmeyi onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = Bllogic.parca_sil(pid);
                if (b)
                {
                    DataSet pds = Bllogic.parca_getir("");
                    if (pds != null)
                        dataGridView4.DataSource = pds.Tables[0];
                }
            }

        }

        private void y_ara_Click(object sender, EventArgs e)
        {
            DataSet ds = Bllogic.parca_getir(y_aranacak.Text);
            if (ds != null)
                dataGridView4.DataSource = ds.Tables[0];
        }
        //--------------------------------------------------------------------------

        private void ur_ekle_Click(object sender, EventArgs e)
        {
            FrmUrunler frmUrunler = new FrmUrunler();
            frmUrunler.Text = "urun Ekle";
            frmUrunler.urun = new urun();
            var sonuc = frmUrunler.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = Bllogic.urun_ekle(frmUrunler.urun);
                if (b)
                {
                    DataSet ds = Bllogic.urun_getir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }
            }
        }

        private void ur_duzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            FrmUrunler.guncelleme = true;
            FrmUrunler frmUrunler = new FrmUrunler();
            frmUrunler.Text = "parca duzenle";
            frmUrunler.urun = new urun()
            {
                seri = row.Cells[0].Value.ToString(),
                Musteriid = row.Cells[1].Value.ToString(),
                marka = row.Cells[2].Value.ToString(),
                model = row.Cells[3].Value.ToString(),
                sorun = row.Cells[4].Value.ToString(),
                garanti =row.Cells[5].Value.ToString(),
                gtarih =DateTime.Parse(row.Cells[6].Value.ToString()),
            };

            var sonuc = frmUrunler.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = Bllogic.urun_guncelle(frmUrunler.urun);
                if (b)
                {
                    DataSet tds = Bllogic.urun_getir("");
                    if (tds != null)
                        dataGridView2.DataSource = tds.Tables[0];
                }
            }
        }

        private void ur_sil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var seri = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi", "silmeyi onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = Bllogic.urun_sil(seri);
                if (b)
                {
                    DataSet pds = Bllogic.urun_getir("");
                    if (pds != null)
                        dataGridView2.DataSource = pds.Tables[0];
                }
            }
        }

        private void ur_ara_Click(object sender, EventArgs e)
        {
            DataSet ds = Bllogic.urun_getir(ur_aranacak.Text);
            if (ds != null)
                dataGridView4.DataSource = ds.Tables[0];
        }
        //--------------------------------------------------------------------------

        private void o_ekle_Click(object sender, EventArgs e)
        {
            FrmOnarim frmOnarim = new FrmOnarim();
            frmOnarim.Text = "Onarim Ekle";
            frmOnarim.onarim = new onarim() { oid = Guid.NewGuid() };
            var sonuc = frmOnarim.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = Bllogic.onarim_ekle(frmOnarim.onarim);
                if (b)
                {
                    DataSet ds = Bllogic.onarim_getir("");
                    if (ds != null)
                        dataGridView5.DataSource = ds.Tables[0];
                }
            }
        }

        private void o_duzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView5.SelectedRows[0];
            FrmOnarim.guncelleme = true;
            FrmOnarim frmOnarim = new FrmOnarim();
            frmOnarim.Text = "parca duzenle";
            frmOnarim.onarim = new onarim()
            {
                oid = Guid.Parse(row.Cells[0].Value.ToString()),
                tc = row.Cells[1].Value.ToString(),
                seri = row.Cells[2].Value.ToString(),
                tid = Guid.Parse(row.Cells[3].Value.ToString()),
                pid = Guid.Parse(row.Cells[4].Value.ToString()),
                durum = row.Cells[5].Value.ToString(),
            };

            var sonuc = frmOnarim.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = Bllogic.onarim_guncelle(frmOnarim.onarim);
                if (b)
                {
                    DataSet tds = Bllogic.onarim_getir("");
                    if (tds != null)
                        dataGridView5.DataSource = tds.Tables[0];
                }
            }
        }

        private void o_sil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView5.SelectedRows[0];
            var oid = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi", "silmeyi onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = Bllogic.onarim_sil(oid);
                if (b)
                {
                    DataSet pds = Bllogic.onarim_getir("");
                    if (pds != null)
                        dataGridView5.DataSource = pds.Tables[0];
                }
            }
        }

        private void o_ara_Click(object sender, EventArgs e)
        {
            DataSet ds = Bllogic.onarim_getir(ur_aranacak.Text);
            if (ds != null)
                dataGridView5.DataSource = ds.Tables[0];
        }
        //--------------------------------------------------------------------------
    }
}
