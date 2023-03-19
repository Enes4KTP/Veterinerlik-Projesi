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
    public partial class Kısırlaştırma : Form
    {
        public Kısırlaştırma()
        {
            InitializeComponent();
            KisirlastirmaGetir();
            HayvanGetir();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;" +
            "port=5432; Database=KO-SU VET; user ID=postgres; password=enes12");
      
        public void HayvanGetir()
        {
            cbHayvan.Items.Clear();

            baglanti.Open();
            NpgsqlCommand sorgu = new NpgsqlCommand("Select hayvan_ad from hayvanlar where kisirlastirma_durum='-' ", baglanti);
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
        public void KisirlastirmaGetir()
        {
            string liste = "select * from kisirislem";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(liste, baglanti);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView2.Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand sorgu1 = new NpgsqlCommand("insert into kisirlastirma (kisirlastirma_tutar,hayvan_id) values (@p1,@p2)", baglanti);
            
            sorgu1.Parameters.AddWithValue("@p1", int.Parse(txtUcret.Text));
            sorgu1.Parameters.AddWithValue("@p2", Convert.ToInt32(labelHayvan.Text));

            baglanti.Open();
            sorgu1.ExecuteNonQuery();
            MessageBox.Show("Kısırlaştırma işlemi başarıyla eklendi.");
            NpgsqlCommand komut1 = new NpgsqlCommand("Update hayvanlar set kisirlastirma_durum='+' where hayvan_id=@p1", baglanti);
            komut1.Parameters.AddWithValue("@p1",Convert.ToInt32(labelHayvan.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            KisirlastirmaGetir();
            HayvanGetir();
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
                labelHayvan.Text = (dr["hayvan_id"].ToString());
            }
            baglanti.Close();
        }
        bool ikinci = false;
        private void btnKisirlastirmaYok_Click(object sender, EventArgs e)
        {
            if (!ikinci)
            {
                ikinci = true;
                //1.tıklayış
                dataGridView2.Visible = true;
                string liste = "select * from kisirdegilview";
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(liste, baglanti);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                dataGridView2.DataSource = dataset.Tables[0];
                this.dataGridView2.Columns["hayvan_id"].Visible = false;
            }

            else
            {
                //2.tıklayış
                string liste = "select * from kisirislem ";
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(liste, baglanti);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
                dataGridView2.Visible = false;
            }
        }

        private void Kısırlaştırma_Load(object sender, EventArgs e)
        {
            NpgsqlCommand sorgu2 = new NpgsqlCommand("Select toplamkisirlastirma from toplamdeger", baglanti);
            DataTable dt1 = new DataTable();
            NpgsqlDataAdapter adp1 = new NpgsqlDataAdapter(sorgu2);
            adp1.Fill(dt1);

            foreach (DataRow dr in dt1.Rows)
            {
                labeldeger.Text = (dr["toplamkisirlastirma"].ToString());

            }
            baglanti.Close();

        }
    }
}
