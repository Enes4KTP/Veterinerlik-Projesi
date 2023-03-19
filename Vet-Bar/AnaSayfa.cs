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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;" +
            "port=5432; Database=KO-SU VET; user ID=postgres; password=enes12");

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string liste = "Select admin_ad,admin_sifre from admin where admin_ad=@p1 and admin_sifre=@p2";
                NpgsqlParameter prmt1 = new NpgsqlParameter("p1", txtadminad.Text.Trim());
                NpgsqlParameter prmt2 = new NpgsqlParameter("p2", txtadminsifre.Text.Trim());
                NpgsqlCommand komut = new NpgsqlCommand(liste, baglanti);
                komut.Parameters.Add(prmt1);
                komut.Parameters.Add(prmt2);
                DataTable dt = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Veteriner vet = new Veteriner();
                    vet.Show();
                    this.Hide();
                }
                

            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
                baglanti.Close();
            }
        }
    }
}
