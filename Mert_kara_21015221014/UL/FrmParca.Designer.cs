namespace Mert_kara_21015221014.UL
{
    partial class FrmParca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pid = new System.Windows.Forms.TextBox();
            this.pad = new System.Windows.Forms.TextBox();
            this.pmodel = new System.Windows.Forms.TextBox();
            this.pmarka = new System.Windows.Forms.ComboBox();
            this.fiyat = new System.Windows.Forms.NumericUpDown();
            this.stok = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parça İd:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parça Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parça Marka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parça Model:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fiyat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stok:";
            // 
            // pid
            // 
            this.pid.Location = new System.Drawing.Point(86, 9);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(152, 20);
            this.pid.TabIndex = 6;
            // 
            // pad
            // 
            this.pad.Location = new System.Drawing.Point(85, 44);
            this.pad.Name = "pad";
            this.pad.Size = new System.Drawing.Size(153, 20);
            this.pad.TabIndex = 7;
            // 
            // pmodel
            // 
            this.pmodel.Location = new System.Drawing.Point(85, 141);
            this.pmodel.Name = "pmodel";
            this.pmodel.Size = new System.Drawing.Size(153, 20);
            this.pmodel.TabIndex = 8;
            // 
            // pmarka
            // 
            this.pmarka.FormattingEnabled = true;
            this.pmarka.Items.AddRange(new object[] {
            "HP",
            "Lenovo",
            "Dell",
            "Msi",
            "Retro"});
            this.pmarka.Location = new System.Drawing.Point(86, 93);
            this.pmarka.Name = "pmarka";
            this.pmarka.Size = new System.Drawing.Size(152, 21);
            this.pmarka.TabIndex = 9;
            // 
            // fiyat
            // 
            this.fiyat.DecimalPlaces = 2;
            this.fiyat.Location = new System.Drawing.Point(85, 184);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(153, 20);
            this.fiyat.TabIndex = 10;
            // 
            // stok
            // 
            this.stok.Location = new System.Drawing.Point(85, 229);
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(153, 20);
            this.stok.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Onay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmParca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 451);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stok);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.pmarka);
            this.Controls.Add(this.pmodel);
            this.Controls.Add(this.pad);
            this.Controls.Add(this.pid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmParca";
            this.Text = "FrmParca";
            this.Load += new System.EventHandler(this.FrmParca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pid;
        private System.Windows.Forms.TextBox pad;
        private System.Windows.Forms.TextBox pmodel;
        private System.Windows.Forms.ComboBox pmarka;
        private System.Windows.Forms.NumericUpDown fiyat;
        private System.Windows.Forms.NumericUpDown stok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}