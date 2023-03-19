namespace Vet_Bar
{
    partial class Fatura
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbMusteri = new System.Windows.Forms.ComboBox();
            this.cbHayvan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTutar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.labelmusid = new System.Windows.Forms.Label();
            this.labelhayvanid = new System.Windows.Forms.Label();
            this.labelasitutar = new System.Windows.Forms.Label();
            this.labelkisirtutar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAsi = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbKisirlastirma = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.labelasiid = new System.Windows.Forms.Label();
            this.labelkisirid = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(662, 332);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // cbMusteri
            // 
            this.cbMusteri.FormattingEnabled = true;
            this.cbMusteri.Location = new System.Drawing.Point(148, 395);
            this.cbMusteri.Name = "cbMusteri";
            this.cbMusteri.Size = new System.Drawing.Size(121, 21);
            this.cbMusteri.TabIndex = 9;
            this.cbMusteri.SelectedIndexChanged += new System.EventHandler(this.cbMusteri_SelectedIndexChanged);
            // 
            // cbHayvan
            // 
            this.cbHayvan.FormattingEnabled = true;
            this.cbHayvan.Location = new System.Drawing.Point(148, 424);
            this.cbHayvan.Name = "cbHayvan";
            this.cbHayvan.Size = new System.Drawing.Size(121, 21);
            this.cbHayvan.TabIndex = 10;
            this.cbHayvan.SelectedIndexChanged += new System.EventHandler(this.cbHayvan_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Müşteri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hayvan:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Yapılan İşlemler";
            // 
            // tbTutar
            // 
            this.tbTutar.Location = new System.Drawing.Point(595, 395);
            this.tbTutar.Name = "tbTutar";
            this.tbTutar.Size = new System.Drawing.Size(100, 20);
            this.tbTutar.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Toplam Tutar:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(514, 452);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 18;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Visible = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(595, 452);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 19;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(676, 452);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 20;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // labelmusid
            // 
            this.labelmusid.AutoSize = true;
            this.labelmusid.Location = new System.Drawing.Point(275, 398);
            this.labelmusid.Name = "labelmusid";
            this.labelmusid.Size = new System.Drawing.Size(35, 13);
            this.labelmusid.TabIndex = 21;
            this.labelmusid.Text = "label5";
            this.labelmusid.Visible = false;
            // 
            // labelhayvanid
            // 
            this.labelhayvanid.AutoSize = true;
            this.labelhayvanid.Location = new System.Drawing.Point(275, 432);
            this.labelhayvanid.Name = "labelhayvanid";
            this.labelhayvanid.Size = new System.Drawing.Size(35, 13);
            this.labelhayvanid.TabIndex = 22;
            this.labelhayvanid.Text = "label6";
            this.labelhayvanid.Visible = false;
            // 
            // labelasitutar
            // 
            this.labelasitutar.AutoSize = true;
            this.labelasitutar.Location = new System.Drawing.Point(539, 423);
            this.labelasitutar.Name = "labelasitutar";
            this.labelasitutar.Size = new System.Drawing.Size(35, 13);
            this.labelasitutar.TabIndex = 25;
            this.labelasitutar.Text = "label5";
            this.labelasitutar.Visible = false;
            // 
            // labelkisirtutar
            // 
            this.labelkisirtutar.AutoSize = true;
            this.labelkisirtutar.Location = new System.Drawing.Point(611, 423);
            this.labelkisirtutar.Name = "labelkisirtutar";
            this.labelkisirtutar.Size = new System.Drawing.Size(35, 13);
            this.labelkisirtutar.TabIndex = 26;
            this.labelkisirtutar.Text = "label5";
            this.labelkisirtutar.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAsi);
            this.groupBox1.Location = new System.Drawing.Point(346, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 27);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // rbAsi
            // 
            this.rbAsi.AutoSize = true;
            this.rbAsi.Location = new System.Drawing.Point(6, 7);
            this.rbAsi.Name = "rbAsi";
            this.rbAsi.Size = new System.Drawing.Size(68, 17);
            this.rbAsi.TabIndex = 0;
            this.rbAsi.TabStop = true;
            this.rbAsi.Text = "Aşı İşlemi";
            this.rbAsi.UseVisualStyleBackColor = true;
            this.rbAsi.CheckedChanged += new System.EventHandler(this.rbAsi_CheckedChanged);
            this.rbAsi.Click += new System.EventHandler(this.rbAsi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbKisirlastirma);
            this.groupBox2.Location = new System.Drawing.Point(346, 448);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 27);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // rbKisirlastirma
            // 
            this.rbKisirlastirma.AutoSize = true;
            this.rbKisirlastirma.Location = new System.Drawing.Point(6, 7);
            this.rbKisirlastirma.Name = "rbKisirlastirma";
            this.rbKisirlastirma.Size = new System.Drawing.Size(108, 17);
            this.rbKisirlastirma.TabIndex = 1;
            this.rbKisirlastirma.TabStop = true;
            this.rbKisirlastirma.Text = "Kısırlaştırma İşlemi";
            this.rbKisirlastirma.UseVisualStyleBackColor = true;
            this.rbKisirlastirma.CheckedChanged += new System.EventHandler(this.rbKisirlastirma_CheckedChanged);
            this.rbKisirlastirma.Click += new System.EventHandler(this.rbKisirlastirma_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(364, 482);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 29;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // labelasiid
            // 
            this.labelasiid.AutoSize = true;
            this.labelasiid.Location = new System.Drawing.Point(468, 427);
            this.labelasiid.Name = "labelasiid";
            this.labelasiid.Size = new System.Drawing.Size(35, 13);
            this.labelasiid.TabIndex = 30;
            this.labelasiid.Text = "label5";
            this.labelasiid.Visible = false;
            // 
            // labelkisirid
            // 
            this.labelkisirid.AutoSize = true;
            this.labelkisirid.Location = new System.Drawing.Point(467, 461);
            this.labelkisirid.Name = "labelkisirid";
            this.labelkisirid.Size = new System.Drawing.Size(35, 13);
            this.labelkisirid.TabIndex = 31;
            this.labelkisirid.Text = "label6";
            this.labelkisirid.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 464);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(71, 28);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(13, 13);
            this.labelid.TabIndex = 33;
            this.labelid.Text = "0";
            this.labelid.Visible = false;
            // 
            // Fatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(81)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(782, 517);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelkisirid);
            this.Controls.Add(this.labelasiid);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelkisirtutar);
            this.Controls.Add(this.labelasitutar);
            this.Controls.Add(this.labelhayvanid);
            this.Controls.Add(this.labelmusid);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHayvan);
            this.Controls.Add(this.cbMusteri);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fatura";
            this.Text = "GelirGider";
            this.Load += new System.EventHandler(this.Fatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbMusteri;
        private System.Windows.Forms.ComboBox cbHayvan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label labelmusid;
        private System.Windows.Forms.Label labelhayvanid;
        private System.Windows.Forms.Label labelasitutar;
        private System.Windows.Forms.Label labelkisirtutar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAsi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbKisirlastirma;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label labelasiid;
        private System.Windows.Forms.Label labelkisirid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelid;
    }
}