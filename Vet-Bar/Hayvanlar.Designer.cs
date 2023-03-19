namespace Vet_Bar
{
    partial class Hayvanlar
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.cbCins = new System.Windows.Forms.ComboBox();
            this.cbTur = new System.Windows.Forms.ComboBox();
            this.cbAdSoyad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labelid = new System.Windows.Forms.Label();
            this.labelTur = new System.Windows.Forms.Label();
            this.labelCins = new System.Windows.Forms.Label();
            this.cbKisir = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnarama = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labeldeger = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cins:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tür:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Hayvan Yaş:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Hayvan Ad:";
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(157, 430);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(100, 20);
            this.txtYas.TabIndex = 19;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(157, 405);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 18;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(468, 482);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_guncelle.TabIndex = 15;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(255, 482);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 14;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // cbCins
            // 
            this.cbCins.FormattingEnabled = true;
            this.cbCins.Location = new System.Drawing.Point(346, 429);
            this.cbCins.Name = "cbCins";
            this.cbCins.Size = new System.Drawing.Size(100, 21);
            this.cbCins.TabIndex = 27;
            this.cbCins.SelectedIndexChanged += new System.EventHandler(this.cbCins_SelectedIndexChanged);
            // 
            // cbTur
            // 
            this.cbTur.FormattingEnabled = true;
            this.cbTur.Location = new System.Drawing.Point(346, 406);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(100, 21);
            this.cbTur.TabIndex = 33;
            this.cbTur.SelectedIndexChanged += new System.EventHandler(this.cbTur_SelectedIndexChanged);
            // 
            // cbAdSoyad
            // 
            this.cbAdSoyad.FormattingEnabled = true;
            this.cbAdSoyad.Location = new System.Drawing.Point(578, 406);
            this.cbAdSoyad.Name = "cbAdSoyad";
            this.cbAdSoyad.Size = new System.Drawing.Size(121, 21);
            this.cbAdSoyad.TabIndex = 42;
            this.cbAdSoyad.SelectedIndexChanged += new System.EventHandler(this.cbAdSoyad_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Müşteri:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(157, 379);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 44;
            this.txtID.Visible = false;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(622, 390);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(35, 13);
            this.labelid.TabIndex = 45;
            this.labelid.Text = "label6";
            this.labelid.Visible = false;
            // 
            // labelTur
            // 
            this.labelTur.AutoSize = true;
            this.labelTur.Location = new System.Drawing.Point(343, 390);
            this.labelTur.Name = "labelTur";
            this.labelTur.Size = new System.Drawing.Size(35, 13);
            this.labelTur.TabIndex = 46;
            this.labelTur.Text = "label6";
            this.labelTur.Visible = false;
            // 
            // labelCins
            // 
            this.labelCins.AutoSize = true;
            this.labelCins.Location = new System.Drawing.Point(400, 390);
            this.labelCins.Name = "labelCins";
            this.labelCins.Size = new System.Drawing.Size(35, 13);
            this.labelCins.TabIndex = 47;
            this.labelCins.Text = "label6";
            this.labelCins.Visible = false;
            // 
            // cbKisir
            // 
            this.cbKisir.FormattingEnabled = true;
            this.cbKisir.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cbKisir.Location = new System.Drawing.Point(578, 430);
            this.cbKisir.Name = "cbKisir";
            this.cbKisir.Size = new System.Drawing.Size(121, 21);
            this.cbKisir.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Kısırlaştırma Durumu:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(334, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 50;
            // 
            // btnarama
            // 
            this.btnarama.Location = new System.Drawing.Point(502, 21);
            this.btnarama.Name = "btnarama";
            this.btnarama.Size = new System.Drawing.Size(75, 20);
            this.btnarama.TabIndex = 51;
            this.btnarama.Text = "Hayvan Ara";
            this.btnarama.UseVisualStyleBackColor = true;
            this.btnarama.Click += new System.EventHandler(this.btnarama_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Hayvan Sayısı:";
            // 
            // labeldeger
            // 
            this.labeldeger.AutoSize = true;
            this.labeldeger.Location = new System.Drawing.Point(139, 31);
            this.labeldeger.Name = "labeldeger";
            this.labeldeger.Size = new System.Drawing.Size(13, 13);
            this.labeldeger.TabIndex = 53;
            this.labeldeger.Text = "0";
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
            this.dataGridView2.TabIndex = 54;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            // 
            // Hayvanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(81)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(782, 517);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.labeldeger);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnarama);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbKisir);
            this.Controls.Add(this.labelCins);
            this.Controls.Add(this.labelTur);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbAdSoyad);
            this.Controls.Add(this.cbTur);
            this.Controls.Add(this.cbCins);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hayvanlar";
            this.Text = "Hayvanlar";
            this.Load += new System.EventHandler(this.Hayvanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.ComboBox cbCins;
        private System.Windows.Forms.ComboBox cbTur;
        private System.Windows.Forms.ComboBox cbAdSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelTur;
        private System.Windows.Forms.Label labelCins;
        private System.Windows.Forms.ComboBox cbKisir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnarama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labeldeger;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}