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
    public partial class FrmOnarim : Form
    {
        public FrmOnarim()
        {
            InitializeComponent();
        }
        public onarim onarim { get; set; }
        public static bool guncelleme = false;
        private void button1_Click(object sender, EventArgs e)
        {
            onarim.oid = Guid.Parse(oid.Text);
            onarim.tc = tc.Text;
            onarim.seri=seri.Text;
            onarim.tid = Guid.Parse(tid.Text);
            onarim.pid = Guid.Parse(pid.Text);
            onarim.durum = durum.Text;
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmOnarim_Load(object sender, EventArgs e) 
        {
            oid.Text = onarim.oid.ToString();
            if (guncelleme)
            {
                tc.Text = onarim.tc;
                seri.Text = onarim.seri;
                tid.Text =onarim.tid.ToString();
                pid.Text = onarim.pid.ToString();
                durum.Text = onarim.durum;
                guncelleme = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            musterisec musterisec = new musterisec();
            if (musterisec.ShowDialog() == DialogResult.OK)
            {
                tc.Text = musterisec.a;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            urunsec urunsec = new urunsec();
            if (urunsec.ShowDialog() == DialogResult.OK)
            {
                seri.Text = urunsec.b;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tekniksec tekniksec = new tekniksec();
            if (tekniksec.ShowDialog() == DialogResult.OK)
            {
                tid.Text = tekniksec.c;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            parcasec parcasec = new parcasec();
            if (parcasec.ShowDialog() == DialogResult.OK)
            {
                pid.Text = parcasec.d;
            }
        }
    }
}
