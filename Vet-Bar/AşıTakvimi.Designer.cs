namespace Vet_Bar
{
    partial class AşıTakvimi
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cbHayvan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAsiTur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.labelasitur = new System.Windows.Forms.Label();
            this.labelhayvan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelid = new System.Windows.Forms.Label();
            this.btnAsiYapilmayan = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnarama = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labeldeger = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(646, 454);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(646, 402);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cbHayvan
            // 
            this.cbHayvan.FormattingEnabled = true;
            this.cbHayvan.Location = new System.Drawing.Point(454, 404);
            this.cbHayvan.Name = "cbHayvan";
            this.cbHayvan.Size = new System.Drawing.Size(121, 21);
            this.cbHayvan.TabIndex = 17;
            this.cbHayvan.SelectedIndexChanged += new System.EventHandler(this.cbHayvan_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(372, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Hayvan Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(69, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Aşı ad";
            // 
            // cbAsiTur
            // 
            this.cbAsiTur.FormattingEnabled = true;
            this.cbAsiTur.Location = new System.Drawing.Point(143, 409);
            this.cbAsiTur.Name = "cbAsiTur";
            this.cbAsiTur.Size = new System.Drawing.Size(121, 21);
            this.cbAsiTur.TabIndex = 19;
            this.cbAsiTur.SelectedIndexChanged += new System.EventHandler(this.cbAsiTur_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(370, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "İşlem Ücreti";
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(454, 451);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.ReadOnly = true;
            this.txtUcret.Size = new System.Drawing.Size(121, 20);
            this.txtUcret.TabIndex = 22;
            // 
            // labelasitur
            // 
            this.labelasitur.AutoSize = true;
            this.labelasitur.Location = new System.Drawing.Point(189, 390);
            this.labelasitur.Name = "labelasitur";
            this.labelasitur.Size = new System.Drawing.Size(35, 13);
            this.labelasitur.TabIndex = 23;
            this.labelasitur.Text = "label4";
            this.labelasitur.Visible = false;
            // 
            // labelhayvan
            // 
            this.labelhayvan.AutoSize = true;
            this.labelhayvan.Location = new System.Drawing.Point(486, 388);
            this.labelhayvan.Name = "labelhayvan";
            this.labelhayvan.Size = new System.Drawing.Size(35, 13);
            this.labelhayvan.TabIndex = 24;
            this.labelhayvan.Text = "label5";
            this.labelhayvan.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Aşı Tarihi:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 458);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(189, 433);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(35, 13);
            this.labelid.TabIndex = 27;
            this.labelid.Text = "label5";
            this.labelid.Visible = false;
            // 
            // btnAsiYapilmayan
            // 
            this.btnAsiYapilmayan.Location = new System.Drawing.Point(588, 18);
            this.btnAsiYapilmayan.Name = "btnAsiYapilmayan";
            this.btnAsiYapilmayan.Size = new System.Drawing.Size(133, 23);
            this.btnAsiYapilmayan.TabIndex = 28;
            this.btnAsiYapilmayan.Text = "Aşılanmamış Hayvanlar";
            this.btnAsiYapilmayan.UseVisualStyleBackColor = true;
            this.btnAsiYapilmayan.Click += new System.EventHandler(this.btnAsiYapilmayan_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(59, 47);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(662, 332);
            this.dataGridView2.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(301, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 30;
            // 
            // btnarama
            // 
            this.btnarama.Location = new System.Drawing.Point(424, 18);
            this.btnarama.Name = "btnarama";
            this.btnarama.Size = new System.Drawing.Size(75, 23);
            this.btnarama.TabIndex = 31;
            this.btnarama.Text = "Aşı Ara";
            this.btnarama.UseVisualStyleBackColor = true;
            this.btnarama.Click += new System.EventHandler(this.btnarama_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Aşılanmış Hayvan Sayısı:";
            // 
            // labeldeger
            // 
            this.labeldeger.AutoSize = true;
            this.labeldeger.Location = new System.Drawing.Point(185, 31);
            this.labeldeger.Name = "labeldeger";
            this.labeldeger.Size = new System.Drawing.Size(13, 13);
            this.labeldeger.TabIndex = 33;
            this.labeldeger.Text = "0";
            // 
            // AşıTakvimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(81)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(782, 517);
            this.Controls.Add(this.labeldeger);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnarama);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnAsiYapilmayan);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelhayvan);
            this.Controls.Add(this.labelasitur);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAsiTur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHayvan);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AşıTakvimi";
            this.Text = "AşıTakvimi";
            this.Load += new System.EventHandler(this.AşıTakvimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cbHayvan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAsiTur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label labelasitur;
        private System.Windows.Forms.Label labelhayvan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Button btnAsiYapilmayan;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnarama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labeldeger;
    }
}