using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futbolcu
{
    public partial class Form1 : Form
    {
        //Kişiden oluşturmak istediği futbolcunun adı soyadı forma numarasını ve mevkisini alalım. O oyuncunun diğer özellikleri mevkiiye göre random değer alsın ve form2 de listview ile ekrana 11 oyuncu yazdıralım. 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Kaleci");
            comboBox1.Items.Add("Defans");
            comboBox1.Items.Add("Orta Saha");
            comboBox1.Items.Add("Forvet");
        }
        public List<Futbolcu> kadro = new List<Futbolcu>();
        private void btnFutbolcuOlustur_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || string.IsNullOrEmpty(txtAdSoyad.Text) || string.IsNullOrEmpty(txtForma.Text))
                MessageBox.Show("Lütfen boş bırakmadan giriş yapınız.");
            else
            {
                Random rnd = new Random();

                Futbolcu f = new Futbolcu();
                f.AdSoyad = txtAdSoyad.Text;
                f.FormaNumarasi = txtForma.Text;
                f.Pozisyon = comboBox1.SelectedItem.ToString();

                if (f.Pozisyon == "Kaleci")
                {
                    f.Hiz = rnd.Next(0, 20);
                    f.Kafa = rnd.Next(0, 20);
                    f.Sut = rnd.Next(0, 40);
                    f.OyunGorusu = rnd.Next(0,50);
                    f.Guc = rnd.Next(50, 100);
                    f.Dayaniklilik = rnd.Next(0, 40);
                    f.Sicrama = rnd.Next(70, 100);
                    f.Mental = rnd.Next(70,100);
                }
                if (f.Pozisyon == "Defans")
                {
                    f.Hiz = rnd.Next(40, 90);
                    f.Kafa = rnd.Next(70, 100);
                    f.Sut = rnd.Next(0, 30);
                    f.OyunGorusu = rnd.Next(0, 30);
                    f.Guc = rnd.Next(50, 100);
                    f.Dayaniklilik = rnd.Next(0, 40);
                    f.Sicrama = rnd.Next(60, 90);
                    f.Mental = rnd.Next(60, 90);
                }
                else if (f.Pozisyon == "Orta Saha")
                {
                    f.Hiz = rnd.Next(50, 100);
                    f.Kafa = rnd.Next(50, 70);
                    f.Sut = rnd.Next(60, 100);
                    f.OyunGorusu = rnd.Next(50, 100);
                    f.Guc = rnd.Next(50, 100);
                    f.Dayaniklilik = rnd.Next(60, 90);
                    f.Sicrama = rnd.Next(30, 40);
                    f.Mental = rnd.Next(30, 90);
                }
                else if (f.Pozisyon == "Forvet")
                {
                    f.Hiz = rnd.Next(40, 100);
                    f.Kafa = rnd.Next(70, 100);
                    f.Sut = rnd.Next(70, 100);
                    f.OyunGorusu = rnd.Next(50, 70);
                    f.Guc = rnd.Next(50, 100);
                    f.Dayaniklilik = rnd.Next(50, 100);
                    f.Sicrama = rnd.Next(60, 90);
                    f.Mental = rnd.Next(50, 80);
                }
                kadro.Add(f);
                MessageBox.Show("Futbolcu kadroya eklendi.");

                txtAdSoyad.Text = " ";
                txtForma.Text = " ";
                comboBox1.Text= "Seçiniz";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(this);
            frm2.Show();
            this.Hide();
        }
    }
}
