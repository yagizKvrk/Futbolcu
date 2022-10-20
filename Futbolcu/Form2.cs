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
    public partial class Form2 : Form
    {
        public Form1 frm1;
        public Form2(Form1 frm)
        {
            InitializeComponent();
            frm1= frm;
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Futbolcu f in frm1.kadro)
            {
                string[] ozellikler = { f.AdSoyad, f.FormaNumarasi, f.Pozisyon, f.Hiz.ToString(), f.Kafa.ToString(), f.Sut.ToString(), f.OyunGorusu.ToString(), f.Guc.ToString(), f.Dayaniklilik.ToString(), f.Sicrama.ToString(), f.Mental.ToString() };
                ListViewItem lvi = new ListViewItem(ozellikler);
                listView1.Items.Add(lvi);
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.Close();
        }
    }
}
