namespace Mert_kara_21015221014.UL
{
    partial class FrmUrunler
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
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.seri = new System.Windows.Forms.TextBox();
            this.tc = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.sorun = new System.Windows.Forms.RichTextBox();
            this.marka = new System.Windows.Forms.ComboBox();
            this.garanti = new System.Windows.Forms.ComboBox();
            this.gtarih = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Model:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sorun:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Garanti:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "G Tarih:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Onay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // seri
            // 
            this.seri.Location = new System.Drawing.Point(65, 9);
            this.seri.Name = "seri";
            this.seri.Size = new System.Drawing.Size(174, 20);
            this.seri.TabIndex = 9;
            // 
            // tc
            // 
            this.tc.Enabled = false;
            this.tc.Location = new System.Drawing.Point(65, 45);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(174, 20);
            this.tc.TabIndex = 10;
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(65, 112);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(174, 20);
            this.model.TabIndex = 11;
            // 
            // sorun
            // 
            this.sorun.Location = new System.Drawing.Point(65, 155);
            this.sorun.Name = "sorun";
            this.sorun.Size = new System.Drawing.Size(174, 80);
            this.sorun.TabIndex = 12;
            this.sorun.Text = "";
            // 
            // marka
            // 
            this.marka.FormattingEnabled = true;
            this.marka.Items.AddRange(new object[] {
            "HP",
            "dell",
            "lenovo",
            "lg"});
            this.marka.Location = new System.Drawing.Point(65, 76);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(174, 21);
            this.marka.TabIndex = 13;
            // 
            // garanti
            // 
            this.garanti.FormattingEnabled = true;
            this.garanti.Items.AddRange(new object[] {
            "Var",
            "Yok"});
            this.garanti.Location = new System.Drawing.Point(65, 248);
            this.garanti.Name = "garanti";
            this.garanti.Size = new System.Drawing.Size(174, 21);
            this.garanti.TabIndex = 14;
            // 
            // gtarih
            // 
            this.gtarih.Location = new System.Drawing.Point(65, 289);
            this.gtarih.Name = "gtarih";
            this.gtarih.Size = new System.Drawing.Size(174, 20);
            this.gtarih.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(246, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "musteri sec";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 451);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gtarih);
            this.Controls.Add(this.garanti);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.sorun);
            this.Controls.Add(this.model);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.seri);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUrunler";
            this.Text = "FrmUrunler";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox seri;
        private System.Windows.Forms.TextBox tc;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.RichTextBox sorun;
        private System.Windows.Forms.ComboBox marka;
        private System.Windows.Forms.ComboBox garanti;
        private System.Windows.Forms.DateTimePicker gtarih;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button3;
    }
}