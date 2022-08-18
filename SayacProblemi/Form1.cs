using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Problem şöyle:
 * Bir aracın kilometre sayacı 4 rakamına her geldiğinde 
 * atlayarak 5 rakamına geçiyor. Bu araç 1412 km yol yaptığında 
 * sayaç kaç değerini gösterir? 
 */

namespace SayacProblemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int k = 0, i = 0, d0 = 0, d1 = 0, d2 = 0, d3 = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            k = i = 0;
            textBox1.Text = k.ToString();
            textBox2.Text = k.ToString();
            textBox3.Text = k.ToString();
            textBox4.Text = k.ToString();
            textBox8.Text = i.ToString();
            textBox9.Text = i.ToString();
            textBox10.Text = i.ToString();
            textBox11.Text = i.ToString();
            Adimla.Enabled = true;
            Basla.Enabled = true;
            Basla.Text = timer1.Enabled ? "Durdur" : "Başla";
        }

        private void ArayuzuGuncelle(bool durum)
        {
            int it = i, kt = k;
            
            textBox4.Text = (it % 10).ToString();
            textBox3.Text = ((it /= 10) % 10).ToString();
            textBox2.Text = ((it /= 10) % 10).ToString();
            textBox1.Text = ((it /= 10) % 10).ToString();

            textBox11.Text = (kt % 10).ToString();
            textBox10.Text = ((kt /= 10) % 10).ToString();
            textBox9.Text = ((kt /= 10) % 10).ToString();
            textBox8.Text = ((kt /= 10) % 10).ToString();

            Adimla.Enabled = !durum;
            Basla.Text = timer1.Enabled ? "Durdur" : "Başla";
            Basla.Enabled = !durum;
        }

        private void Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = (Convert.ToInt32(textBox7.Text) + 1 > 9 ? 0 : Convert.ToInt32(textBox7.Text) + 1).ToString();
        }

        private void Adimla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            bool durum = CozBakalim(Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text));
            ArayuzuGuncelle(durum);
        }

        private void Sifirla_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Basla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            Basla.Text = timer1.Enabled ? "Durdur" : "Başla";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            bool durum = CozBakalim(Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text));
            ArayuzuGuncelle(durum);
            timer1.Enabled = !durum;
        }

        private bool CozBakalim(int kacakadar, int rakam)
        {
            i++;
            k++;
            int it = i;
            d0 = it % 10;
            d1 = (it /= 10) % 10;
            d2 = (it /= 10) % 10;
            d3 = (it /= 10) % 10;

            i = d0 == rakam ? i + 1 :
                (d1 == rakam ? i + 10 :
                (d2 == rakam ? i + 100 :
                (d3 == rakam ? i + 1000 : i)));

            return k >= kacakadar;
        }
    }
}
