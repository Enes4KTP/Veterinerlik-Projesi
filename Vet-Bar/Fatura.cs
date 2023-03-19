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
    public partial class Fatura : Form
    {
        public Fatura()
        {
            InitializeComponent();
            MusteriGetir();
            //HayvanGetir();
            FaturaGetir();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;" +
            "port=5432; Database=KO-SU VET; user ID=postgres; password=enes12");
        private void button1_Click(object sender, EventArgs e)
        {

            string liste = "select * from fatura order by fatura_id";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(liste, baglanti);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
        public void MusteriGetir()
        {
            cbMusteri.Items.Clear();

            baglanti.Open();
            NpgsqlCommand sorgu = new NpgsqlCommand("Select musteriBilgi from müsteribilgi order by musteri_id", baglanti);
            sorgu.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cbMusteri.Items.Add(dr["musteriBilgi"].ToString());
            }
            baglanti.Close();
        }
        

        public void FaturaGetir()
        {
            string liste = "select * from faturaview order by fatura_tarih ";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(liste, baglanti);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            labelid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbMusteri.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbHayvan.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void cbMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            NpgsqlCommand sorgu2 = new NpgsqlCommand("Select musteri_id from müsteribilgi where musteriBilgi=@c1", baglanti);
            sorgu2.Parameters.AddWithValue("@c1", cbMusteri.SelectedItem);
            DataTable dt1 = new DataTable();
            NpgsqlDataAdapter adp1 = new NpgsqlDataAdapter(sorgu2);
            adp1.Fill(dt1);

            foreach (DataRow dr in dt1.Rows)
            {
                labelmusid.Text = (dr["musteri_id"].ToString());
            }
            baglanti.Close();

            int x = cbMusteri.SelectedIndex;

            if (cbMusteri.SelectedIndex == x)
            {
                cbHayvan.Items.Clear();
                baglanti.Open();
                NpgsqlCommand sorgu = new NpgsqlCommand("Select hayvan_ad from hayvanbilgi where musteri = @c1 order by musteri_id", baglanti);
                sorgu.Parameters.AddWithValue("@c1", cbMusteri.SelectedItem);
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
        }


        private void cbHayvan_SelectedIndexChanged(object sender, EventArgs e)
        {
            NpgsqlCommand sorgu2 = new NpgsqlCommand("Select hayvan_id from hayvanlar where hayvan_ad=@c1", baglanti);
            sorgu2.Parameters.AddWithValue("@c1", cbHayvan.SelectedItem);
            DataTable dt1 = new DataTable();
            NpgsqlDataAdapter adp1 = new NpgsqlDataAdapter(sorgu2);
            adp1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                labelhayvanid.Text = (dr["hayvan_id"].ToString());
            }


            NpgsqlCommand sorgu1 = new NpgsqlCommand("Select asi_id from asitakvimi where hayvan_id=@c2", baglanti);
            sorgu1.Parameters.AddWithValue("@c2", int.Parse(labelhayvanid.Text));
            NpgsqlDataAdapter adp2 = new NpgsqlDataAdapter(sorgu1);
            adp2.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                labelasiid.Text = (dr["asi_id"].ToString());
            }
            if (labelasiid.Text == "")
            {
                labelasiid.Text = null;
            }


            NpgsqlCommand sorgu = new NpgsqlCommand("Select kisirlastirma_id from kisirlastirma where hayvan_id=@c3", baglanti);
            sorgu.Parameters.AddWithValue("@c3", int.Parse(labelhayvanid.Text));
            NpgsqlDataAdapter adp3 = new NpgsqlDataAdapter(sorgu);
            adp3.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                labelkisirid.Text = (dr["kisirlastirma_id"].ToString());
            }
            baglanti.Close();

            if (labelkisirid.Text == "")
            {
                labelkisirid.Text = null;
            }
        }

        private void Fatura_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Columns["fatura_id"].Visible = false;
            this.dataGridView1.Columns["hayvan_id"].Visible = false;
            this.dataGridView1.Columns["musteri_id"].Visible = false;
            this.dataGridView1.Columns["toplam_ucret"].Visible = false;
        }


        bool isChecked = false;
        private void rbAsi_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rbAsi.Checked;
            if (rbAsi.Checked == true)
            {

                NpgsqlCommand sorgu2 = new NpgsqlCommand("Select sum(kdvli_asitutar) as toplamtutar from asitakvimifonk where hayvan_id=@c1", baglanti);
                sorgu2.Parameters.AddWithValue("@c1", int.Parse(labelhayvanid.Text));
                DataTable dt1 = new DataTable();
                NpgsqlDataAdapter adp1 = new NpgsqlDataAdapter(sorgu2);
                adp1.Fill(dt1);

                foreach (DataRow dr in dt1.Rows)
                {
                    labelasitutar.Text = (dr["toplamtutar"].ToString());
                }


                baglanti.Close();
                rbAsi.Checked = false;

            }

            else
            {
                if (labelasitutar.Text == null)
                {
                    labelasitutar.Text = "0";
                }
            }

        }

        private void rbAsi_Click(object sender, EventArgs e)
        {
            if (rbAsi.Checked && !isChecked)
                rbAsi.Checked = false;
            else
            {
                rbAsi.Checked = true;
                isChecked = false;
            }
        }

        private void rbKisirlastirma_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rbKisirlastirma.Checked;
            if (rbKisirlastirma.Checked == true)
            {
                NpgsqlCommand sorgu2 = new NpgsqlCommand("Select sum(coalesce(kisirlastirma_tutar,0)) as toplamtutar from kisirview where hayvan_id=@c1", baglanti);
                sorgu2.Parameters.AddWithValue("@c1", int.Parse(labelhayvanid.Text));
                DataTable dt1 = new DataTable();
                NpgsqlDataAdapter adp1 = new NpgsqlDataAdapter(sorgu2);
                adp1.Fill(dt1);

                foreach (DataRow dr in dt1.Rows)
                {
                    labelkisirtutar.Text = (dr["toplamtutar"].ToString());
                }


                baglanti.Close();
                rbKisirlastirma.Checked = false;

            }

            else
            {
                if (labelasitutar.Text == null)
                {
                    labelasitutar.Text = "0";
                }
            }
        }

        private void rbKisirlastirma_Click(object sender, EventArgs e)
        {
            if (rbKisirlastirma.Checked && !isChecked)
                rbKisirlastirma.Checked = false;
            else
            {
                rbKisirlastirma.Checked = true;
                isChecked = false;
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            tbTutar.Text = "";
            if (labelkisirtutar.Text == "")
            {
                labelkisirtutar.Text = "0";
            }
            if (labelasitutar.Text == "")
            {
                labelasitutar.Text = "0";
            }
            int x = 200;
            double sonuc = x + Convert.ToInt32(labelkisirtutar.Text) + Convert.ToDouble(labelasitutar.Text);
            tbTutar.Text = sonuc.ToString();
            btnEkle.Visible = true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand sorgu1 = new NpgsqlCommand("insert into fatura (asi_id,kisirlastirma_id,giris_ucreti,toplam_ucret,musteri_id,hayvan_id,fatura_tarih) values (@p1,@p2,default,@p3,@p4,@p5,@p6)", baglanti);
            if (labelasiid.Text != "")
            {
                sorgu1.Parameters.AddWithValue("@p1", int.Parse(labelasiid.Text));
            }
            else
            {
                sorgu1.Parameters.AddWithValue("@p1", DBNull.Value);
            }
            if (labelkisirid.Text != "")
            {
                sorgu1.Parameters.AddWithValue("@p2", int.Parse(labelkisirid.Text));
            }
            else
            {
                sorgu1.Parameters.AddWithValue("@p2", DBNull.Value);
            }
            sorgu1.Parameters.AddWithValue("@p3", double.Parse(tbTutar.Text));
            sorgu1.Parameters.AddWithValue("@p4", int.Parse(labelmusid.Text));
            sorgu1.Parameters.AddWithValue("@p5", int.Parse(labelhayvanid.Text));
            sorgu1.Parameters.AddWithValue("@p6", dateTimePicker1.Value);

            baglanti.Open();
            sorgu1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Fatura başarıyla eklendi.");
            FaturaGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand sorgu2 = new NpgsqlCommand("delete from fatura where fatura_id=@p1", baglanti);
            sorgu2.Parameters.AddWithValue("@p1", int.Parse(labelid.Text));
            sorgu2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Fatura başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FaturaGetir();
        }

        
    }
}




