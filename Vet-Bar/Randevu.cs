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
    public partial class Randevu : Form
    {
        public Randevu()
        {
            InitializeComponent();
            RandevuGetir();
            MusteriGetir();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;" +
            "port=5432; Database=KO-SU VET; user ID=postgres; password=enes12");

        public void RandevuGetir()
        {
            string liste = "select * from randevuView order by randevu_tarih";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(liste, baglanti);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        public void MusteriGetir()
        {
            cbMus.Items.Clear();

            baglanti.Open();
            NpgsqlCommand sorgu = new NpgsqlCommand("Select musteriBilgi from müsteribilgi", baglanti);
            sorgu.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cbMus.Items.Add(dr["musteriBilgi"].ToString());
            }
            baglanti.Close();
        }
       
        private void btnEkle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand sorgu1 = new NpgsqlCommand("insert into randevu (musteri_id,randevu_tarih) values (@p1,@p2)", baglanti);
            sorgu1.Parameters.AddWithValue("@p1", int.Parse(labelid.Text));
            sorgu1.Parameters.AddWithValue("@p2", dateTimePicker1.Value);

            baglanti.Open();
            sorgu1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Randevu başarıyla eklendi.");
            RandevuGetir();
        }

        private void cbMus_SelectedIndexChanged(object sender, EventArgs e)
        {
            NpgsqlCommand sorgu2 = new NpgsqlCommand("Select musteri_id from müsteribilgi where musteriBilgi=@c1", baglanti);
            sorgu2.Parameters.AddWithValue("@c1", cbMus.SelectedItem);
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sorgu2);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                labelid.Text = (dr["musteri_id"].ToString());
            }
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand sorgu2 = new NpgsqlCommand("delete from randevu where randevu_id=@p1", baglanti);
            sorgu2.Parameters.AddWithValue("@p1", int.Parse(txtID.Text));
            sorgu2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Randevu başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RandevuGetir();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cbMus.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void Randevu_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Columns["randevu_id"].Visible = false;
            dateTimePicker1.MinDate = DateTime.Now;
        }
    }
}
