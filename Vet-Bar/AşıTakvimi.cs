using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vet_Bar
{
    public partial class AşıTakvimi : Form
    {
        public AşıTakvimi()
        {
            InitializeComponent();
            AsiTakvimiGetir();
            HayvanGetir();
            AsiGetir();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;" +
            "port=5432; Database=KO-SU VET; user ID=postgres; password=enes12");
        public void AsiTakvimiGetir()
        {
            string liste = "select * from asitakvimiview order by asi_tarih";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(liste, baglanti);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView2.Visible = false;
        }

        public void HayvanGetir()
        {
            cbHayvan.Items.Clear();

            baglanti.Open();
            NpgsqlCommand sorgu = new NpgsqlCommand("Select hayvan_ad from hayvanlar order by hayvan_id", baglanti);
            sorgu.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cbHayvan.Items.Add(dr["hayvan_ad"].ToString());
            }
            baglanti.Close();
        }

        public void AsiGetir()
        {
            cbAsiTur.Items.Clear();

            baglanti.Open();
            NpgsqlCommand sorgu = new NpgsqlCommand("Select asi_adi from asilar order by asi_tur_id", baglanti);
            sorgu.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cbAsiTur.Items.Add(dr["asi_adi"].ToString());
            }
            baglanti.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            labelid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbHayvan.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbAsiTur.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtUcret.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void AşıTakvimi_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Columns["hayvan_id"].Visible = false;
            this.dataGridView1.Columns["asi_id"].Visible = false;
            this.dataGridView1.Columns["asi_tur_id"].Visible = false;
            this.dataGridView1.Columns["asi_tutar"].Visible = false;

            dateTimePicker1.MinDate = DateTime.Now;
            NpgsqlCommand sorgu2 = new NpgsqlCommand("Select toplamasi from toplamdeger", baglanti);
            DataTable dt1 = new DataTable();
            NpgsqlDataAdapter adp1 = new NpgsqlDataAdapter(sorgu2);
            adp1.Fill(dt1);

            foreach (DataRow dr in dt1.Rows)
            {
                labeldeger.Text = (dr["toplamasi"].ToString());

            }
            baglanti.Close();


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand sorgu1 = new NpgsqlCommand("insert into  asitakvimi (asi_tur_id,hayvan_id,asi_tarih,asi_tutar) values (@p1,@p2,@p3,@p4)", baglanti);

            sorgu1.Parameters.AddWithValue("@p1", int.Parse(labelasitur.Text));
            sorgu1.Parameters.AddWithValue("@p2", int.Parse(labelhayvan.Text));
            sorgu1.Parameters.AddWithValue("@p3", dateTimePicker1.Value);
            sorgu1.Parameters.AddWithValue("@p4", Convert.ToInt32(txtUcret.Text));

            baglanti.Open();
            sorgu1.ExecuteNonQuery();
            MessageBox.Show("Aşı işlemi başarıyla eklendi.");
            
            baglanti.Close();

            AsiTakvimiGetir();

        }

        private void cbAsiTur_SelectedIndexChanged(object sender, EventArgs e)
        {

            NpgsqlCommand sorgu2 = new NpgsqlCommand("Select asi_tur_id from asilar where asi_adi=@c1", baglanti);
            sorgu2.Parameters.AddWithValue("@c1", cbAsiTur.SelectedItem);
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu2);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                labelasitur.Text = (dr["asi_tur_id"].ToString());
            }
            baglanti.Close();

            if (cbAsiTur.SelectedIndex == 0)
            {
                txtUcret.Text = " ";
                baglanti.Open();
                NpgsqlCommand sorgu = new NpgsqlCommand("Select asi_ucret from asilar where asi_tur_id=1", baglanti);

                sorgu.ExecuteNonQuery();

                DataTable dt1 = new DataTable();
                NpgsqlDataAdapter adp1 = new NpgsqlDataAdapter(sorgu);
                adp1.Fill(dt1);

                foreach (DataRow dr in dt1.Rows)
                {
                    txtUcret.Text=(dr["asi_ucret"].ToString());
                }
                baglanti.Close();
            }
            else if (cbAsiTur.SelectedIndex == 1)
            {
                txtUcret.Text = " ";
                baglanti.Open();
                NpgsqlCommand sorgu = new NpgsqlCommand("Select asi_ucret from asilar where asi_tur_id=2", baglanti);

                sorgu.ExecuteNonQuery();

                DataTable dt1 = new DataTable();
                NpgsqlDataAdapter adp1 = new NpgsqlDataAdapter(sorgu);
                adp1.Fill(dt1);

                foreach (DataRow dr in dt1.Rows)
                {
                    txtUcret.Text = (dr["asi_ucret"].ToString());
                }
                baglanti.Close();
            }
            else if (cbAsiTur.SelectedIndex == 2)
            {
                txtUcret.Text = " ";
                baglanti.Open();
                NpgsqlCommand sorgu = new NpgsqlCommand("Select asi_ucret from asilar where asi_tur_id=3", baglanti);

                sorgu.ExecuteNonQuery();

                DataTable dt1 = new DataTable();
                NpgsqlDataAdapter adp1 = new NpgsqlDataAdapter(sorgu);
                adp1.Fill(dt1);

                foreach (DataRow dr in dt1.Rows)
                {
                    txtUcret.Text = (dr["asi_ucret"].ToString());
                }
                baglanti.Close();
            }
            else if (cbAsiTur.SelectedIndex == 3)
            {
                txtUcret.Text = " ";
                baglanti.Open();
                NpgsqlCommand sorgu = new NpgsqlCommand("Select asi_ucret from asilar where asi_tur_id=4", baglanti);

                sorgu.ExecuteNonQuery();

                DataTable dt1 = new DataTable();
                NpgsqlDataAdapter adp1 = new NpgsqlDataAdapter(sorgu);
                adp1.Fill(dt1);

                foreach (DataRow dr in dt1.Rows)
                {
                    txtUcret.Text = (dr["asi_ucret"].ToString());
                }
                baglanti.Close();
            }
            else if (cbAsiTur.SelectedIndex == 4)
            {
                txtUcret.Text = " ";
                baglanti.Open();
                NpgsqlCommand sorgu = new NpgsqlCommand("Select asi_ucret from asilar where asi_tur_id=5", baglanti);

                sorgu.ExecuteNonQuery();

                DataTable dt1 = new DataTable();
                NpgsqlDataAdapter adp1 = new NpgsqlDataAdapter(sorgu);
                adp1.Fill(dt1);

                foreach (DataRow dr in dt1.Rows)
                {
                    txtUcret.Text = (dr["asi_ucret"].ToString());
                }
                baglanti.Close();
            }
            else if (cbAsiTur.SelectedIndex == 5)
            {
                txtUcret.Text = " ";
                baglanti.Open();
                NpgsqlCommand sorgu = new NpgsqlCommand("Select asi_ucret from asilar where asi_tur_id=6", baglanti);

                sorgu.ExecuteNonQuery();

                DataTable dt1 = new DataTable();
                NpgsqlDataAdapter adp1 = new NpgsqlDataAdapter(sorgu);
                adp1.Fill(dt1);

                foreach (DataRow dr in dt1.Rows)
                {
                    txtUcret.Text = (dr["asi_ucret"].ToString());
                }
                baglanti.Close();
            }
            else if (cbAsiTur.SelectedIndex == 6)
            {
                txtUcret.Text = " ";
                baglanti.Open();
                NpgsqlCommand sorgu = new NpgsqlCommand("Select asi_ucret from asilar where asi_tur_id=7", baglanti);

                sorgu.ExecuteNonQuery();

                DataTable dt1 = new DataTable();
                NpgsqlDataAdapter adp1 = new NpgsqlDataAdapter(sorgu);
                adp1.Fill(dt1);

                foreach (DataRow dr in dt1.Rows)
                {
                    txtUcret.Text = (dr["asi_ucret"].ToString());
                }
                baglanti.Close();
            }
            else if (cbAsiTur.SelectedIndex == 7)
            {
                txtUcret.Text = " ";
                baglanti.Open();
                NpgsqlCommand sorgu = new NpgsqlCommand("Select asi_ucret from asilar where asi_tur_id=8", baglanti);

                sorgu.ExecuteNonQuery();

                DataTable dt1 = new DataTable();
                NpgsqlDataAdapter adp1 = new NpgsqlDataAdapter(sorgu);
                adp1.Fill(dt1);

                foreach (DataRow dr in dt1.Rows)
                {
                    txtUcret.Text = (dr["asi_ucret"].ToString());
                }
                baglanti.Close();
            }
            else if (cbAsiTur.SelectedIndex == 8)
            {
                txtUcret.Text = " ";
                baglanti.Open();
                NpgsqlCommand sorgu = new NpgsqlCommand("Select asi_ucret from asilar where asi_tur_id=9", baglanti);

                sorgu.ExecuteNonQuery();

                DataTable dt1 = new DataTable();
                NpgsqlDataAdapter adp1 = new NpgsqlDataAdapter(sorgu);
                adp1.Fill(dt1);

                foreach (DataRow dr in dt1.Rows)
                {
                    txtUcret.Text = (dr["asi_ucret"].ToString());
                }
                baglanti.Close();
            }
        }

        private void cbHayvan_SelectedIndexChanged(object sender, EventArgs e)
        {
            NpgsqlCommand sorgu2 = new NpgsqlCommand("Select hayvan_id from hayvanlar where hayvan_ad=@c1", baglanti);
            sorgu2.Parameters.AddWithValue("@c1", cbHayvan.SelectedItem);
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu2);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                labelhayvan.Text = (dr["hayvan_id"].ToString());
            }
            baglanti.Close();
            

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand sorgu2 = new NpgsqlCommand("delete from asitakvimi where asi_id=@p1", baglanti);
            sorgu2.Parameters.AddWithValue("@p1", int.Parse(labelid.Text));
            sorgu2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Randevu başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AsiTakvimiGetir();
        }
        int sayac = 1;
        private void btnAsiYapilmayan_Click(object sender, EventArgs e)
        {

            if (sayac == 2)
            {
                //1.tıklayış
                dataGridView2.Visible = true;
                string liste = "select hayvan_id,hayvan_ad,musteriler.musteri_id,musteriler.musteri_ad from hayvanlar join musteriler on musteriler.musteri_id=hayvanlar.musteri_id where hayvan_ad NOT IN (select hayvan_ad from asitakvimiview)";
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(liste, baglanti);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                dataGridView2.DataSource = dataset.Tables[0];
                this.dataGridView2.Columns["musteri_id"].Visible = false;
                this.dataGridView2.Columns["hayvan_id"].Visible = false;
                sayac = 1;
            }

            else
            {
                //2.tıklayış
                string liste = "select * from asitakvimiview order by asi_tarih ";
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(liste, baglanti);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
                dataGridView2.Visible = false;
                sayac++;

            }
        }
        
        private void btnarama_Click(object sender, EventArgs e)
        {
            if (sayac == 2)
            {
                //1.tıklayış
                NpgsqlCommand sorgu = new NpgsqlCommand("select hayvan_ad , asi_adi , asi_tutar from asitakvimiview where asi_adi like '%" + textBox1.Text + "%'", baglanti);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu);
                DataSet ds = new DataSet();
                da.Fill(ds);
                baglanti.Close();
                dataGridView1.DataSource = ds.Tables[0];
                sayac = 1;
            }

            else
            {
                //2.tıklayış
                AsiTakvimiGetir();
                this.dataGridView1.Columns["hayvan_id"].Visible = false;
                this.dataGridView1.Columns["asi_id"].Visible = false;
                this.dataGridView1.Columns["asi_tur_id"].Visible = false;
                this.dataGridView1.Columns["asi_tutar"].Visible = false;
                sayac++;

            }
            

        }
    }
}
