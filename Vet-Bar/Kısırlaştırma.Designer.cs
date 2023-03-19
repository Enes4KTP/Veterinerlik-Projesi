namespace Vet_Bar
{
    partial class Kısırlaştırma
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.cbHayvan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHayvan = new System.Windows.Forms.Label();
            this.btnKisirlastirmaYok = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
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
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(646, 419);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cbHayvan
            // 
            this.cbHayvan.FormattingEnabled = true;
            this.cbHayvan.Location = new System.Drawing.Point(155, 421);
            this.cbHayvan.Name = "cbHayvan";
            this.cbHayvan.Size = new System.Drawing.Size(121, 21);
            this.cbHayvan.TabIndex = 10;
            this.cbHayvan.SelectedIndexChanged += new System.EventHandler(this.cbHayvan_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hayvan Ad:";
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(466, 422);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(100, 20);
            this.txtUcret.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "İşlem Ücreti:";
            // 
            // labelHayvan
            // 
            this.labelHayvan.AutoSize = true;
            this.labelHayvan.Location = new System.Drawing.Point(194, 449);
            this.labelHayvan.Name = "labelHayvan";
            this.labelHayvan.Size = new System.Drawing.Size(35, 13);
            this.labelHayvan.TabIndex = 15;
            this.labelHayvan.Text = "label3";
            this.labelHayvan.Visible = false;
            // 
            // btnKisirlastirmaYok
            // 
            this.btnKisirlastirmaYok.Location = new System.Drawing.Point(541, 18);
            this.btnKisirlastirmaYok.Name = "btnKisirlastirmaYok";
            this.btnKisirlastirmaYok.Size = new System.Drawing.Size(180, 23);
            this.btnKisirlastirmaYok.TabIndex = 16;
            this.btnKisirlastirmaYok.Text = "Kisirlaştırma Yapılmamıış Hayvanlar";
            this.btnKisirlastirmaYok.UseVisualStyleBackColor = true;
            this.btnKisirlastirmaYok.Click += new System.EventHandler(this.btnKisirlastirmaYok_Click);
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
            this.dataGridView2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kısırlaştırılmış Hayvan Sayısı:";
            // 
            // labeldeger
            // 
            this.labeldeger.AutoSize = true;
            this.labeldeger.Location = new System.Drawing.Point(201, 28);
            this.labeldeger.Name = "labeldeger";
            this.labeldeger.Size = new System.Drawing.Size(13, 13);
            this.labeldeger.TabIndex = 19;
            this.labeldeger.Text = "0";
            // 
            // Kısırlaştırma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(81)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(782, 517);
            this.Controls.Add(this.labeldeger);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnKisirlastirmaYok);
            this.Controls.Add(this.labelHayvan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHayvan);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kısırlaştırma";
            this.Text = "Kısırlaştırma";
            this.Load += new System.EventHandler(this.Kısırlaştırma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cbHayvan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHayvan;
        private System.Windows.Forms.Button btnKisirlastirmaYok;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labeldeger;
    }
}