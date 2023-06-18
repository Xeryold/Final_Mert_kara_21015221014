using Mert_kara_21015221014.BL;
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
    public partial class parcasec : Form
    {
        public string d;
        public parcasec()
        {
            InitializeComponent();
            DataSet ds = Bllogic.parca_getir("");
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            d = row.Cells[0].Value.ToString();
            DialogResult = DialogResult.OK;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
