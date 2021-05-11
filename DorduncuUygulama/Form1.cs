using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DorduncuUygulama
{
    public partial class Form1 : Form
    {

        void SepeteEkle()
        {
            int toplam = 0;
            for (int i = 0; i < listBox3.Items.Count; i++)
            {
                toplam += Convert.ToInt32(listBox3.Items[i]);

            }
            textBox11.Clear();
            textBox11.Text += Convert.ToInt64(toplam);
        }
        void Bakiye()
        {
            textBox12.Clear();
            textBox12.Text = Convert.ToString(label2.Text);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text   = "Hamburger";
            textBox2.Text   = "22";
            textBox3.Text   = "Patates Kızartması";
            textBox4.Text   = "13";
            textBox5.Text   = "Coca Cola";
            textBox6.Text   = "6";
            textBox7.Text   = "Su";
            textBox8.Text   = "3";
            textBox9.Text   = "Tatlı";
            textBox10.Text  = "9"; 
 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = Convert.ToString(textBox1.Text);
            int fiyat = Convert.ToInt16(textBox2.Text);
            int adet = Convert.ToInt16(comboBox1.SelectedItem);
            if (adet==0)
            {
                MessageBox.Show("Lütfen adet kısmını boş bırakmayınız!");
            }
            else
            {
                if (listBox1.Items.Contains(ad))
                {
                    MessageBox.Show("Ürün Sepetiniz de mevcut!");
                }
                else
                {
                    listBox1.Items.Add(ad);
                    listBox2.Items.Add(adet);
                    listBox3.Items.Add(fiyat * adet);
                    SepeteEkle();
                }
            }
            
            
 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string kontroltutar = textBox11.Text;
            if (kontroltutar == "")
            {
                MessageBox.Show("Lütfen sepetinize en az 1 adet ürün ekleyiniz!");
            }
            else
            {
                int tutar = Convert.ToInt32(textBox11.Text);
                int bakiye = Convert.ToInt32(label2.Text);

                if (tutar == 0)
                {
                    MessageBox.Show("Lütfen sepetinize en az 1 adet ürün ekleyiniz!");
                }
                else if (bakiye >= tutar)
                {
                    MessageBox.Show("Alışveriş gerçekleştirildi");
                    int sonuc = (bakiye - tutar);
                    label2.Text = Convert.ToString(sonuc);
                    Bakiye();

                }
                else
                {
                    MessageBox.Show("Bakiye Yetersiz!");
                }
            }
            
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad = Convert.ToString(textBox3.Text);
            int fiyat = Convert.ToInt16(textBox4.Text);
            int adet = Convert.ToInt16(comboBox2.SelectedItem);
            if (adet == 0)
            {
                MessageBox.Show("Lütfen adet kısmını boş bırakmayınız!");
            }
            else
            {
                if (listBox1.Items.Contains(ad))
                {
                    MessageBox.Show("Ürün Sepetiniz de mevcut!");
                }
                else
                {
                    listBox1.Items.Add(ad);
                    listBox2.Items.Add(adet);
                    listBox3.Items.Add(fiyat * adet);
                    SepeteEkle();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ad = Convert.ToString(textBox5.Text);
            int fiyat = Convert.ToInt16(textBox6.Text);
            int adet = Convert.ToInt16(comboBox3.SelectedItem);
            if (adet == 0)
            {
                MessageBox.Show("Lütfen adet kısmını boş bırakmayınız!");
            }
            else
            {
                if (listBox1.Items.Contains(ad))
                {
                    MessageBox.Show("Ürün Sepetiniz de mevcut!");
                }
                else
                {
                    listBox1.Items.Add(ad);
                    listBox2.Items.Add(adet);
                    listBox3.Items.Add(fiyat * adet);
                    SepeteEkle();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ad = Convert.ToString(textBox7.Text);
            int fiyat = Convert.ToInt16(textBox8.Text);
            int adet = Convert.ToInt16(comboBox4.SelectedItem);
            if (adet == 0)
            {
                MessageBox.Show("Lütfen adet kısmını boş bırakmayınız!");
            }
            else
            {
                if (listBox1.Items.Contains(ad))
                {
                    MessageBox.Show("Ürün Sepetiniz de mevcut!");
                }
                else
                {
                    listBox1.Items.Add(ad);
                    listBox2.Items.Add(adet);
                    listBox3.Items.Add(fiyat * adet);
                    SepeteEkle();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ad = Convert.ToString(textBox9.Text);
            int fiyat = Convert.ToInt16(textBox10.Text);
            int adet = Convert.ToInt16(comboBox5.SelectedItem);
            if (adet == 0)
            {
                MessageBox.Show("Lütfen adet kısmını boş bırakmayınız!");
            }
            else
            {
                if (listBox1.Items.Contains(ad))
                {
                    MessageBox.Show("Ürün Sepetiniz de mevcut!");
                }
                else
                {
                    listBox1.Items.Add(ad);
                    listBox2.Items.Add(adet);
                    listBox3.Items.Add(fiyat * adet);
                    SepeteEkle();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int bakiye = Convert.ToInt32(label2.Text);
            int yuklenecek = Convert.ToInt32(textBox13.Text);
            int sonuc = yuklenecek + bakiye;
            label2.Text = Convert.ToString(sonuc);
            Bakiye();
            MessageBox.Show("Para Yükleme İşlemi Başarılı");


        }

        private void button8_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(i);
            listBox2.Items.RemoveAt(i);
            listBox3.Items.RemoveAt(i);
            SepeteEkle();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            SepeteEkle();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
