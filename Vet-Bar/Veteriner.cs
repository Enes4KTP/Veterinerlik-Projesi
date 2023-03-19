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
    public partial class Veteriner : Form
    {
        public Veteriner()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Müşteriler müşteriler = new Müşteriler();
            müşteriler.TopLevel = false; 
            panel2.Controls.Add(müşteriler);
            müşteriler.Show(); 
        }
    

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Hayvanlar hayvanlar = new Hayvanlar();
            hayvanlar.TopLevel = false;
            panel2.Controls.Add(hayvanlar);
            hayvanlar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            AşıTakvimi aşıtakvimi = new AşıTakvimi();
            aşıtakvimi.TopLevel = false;
            panel2.Controls.Add(aşıtakvimi);
            aşıtakvimi.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Randevu çiftleştirme = new Randevu();
            çiftleştirme.TopLevel = false;
            panel2.Controls.Add(çiftleştirme);
            çiftleştirme.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Kısırlaştırma kısırlaştırma = new Kısırlaştırma();
            kısırlaştırma.TopLevel = false;
            panel2.Controls.Add(kısırlaştırma);
            kısırlaştırma.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Fatura gelirgider = new Fatura();
            gelirgider.TopLevel = false;
            panel2.Controls.Add(gelirgider);
            gelirgider.Show();
        }
    }
}
