using System;
using System.Linq;
using System.Windows.Forms;

namespace DorduncuUygulama
{
    public partial class Form1 : Form
    {
        private void UpdateCartTotal()
        {
            var total = listBox3.Items.Cast<int>().Sum();
            textBox11.Text = total.ToString();
        }

        private void UpdateBalance()
        {
            textBox12.Text = label2.Text;
        }

        private void AddItemToCart(string itemName, int price, int quantity)
        {
            if (quantity == 0)
            {
                MessageBox.Show("Lütfen adet kısmını boş bırakmayınız!");
                return;
            }

            if (listBox1.Items.Contains(itemName))
            {
                MessageBox.Show("Ürün Sepetiniz de mevcut!");
                return;
            }

            listBox1.Items.Add(itemName);
            listBox2.Items.Add(quantity);
            listBox3.Items.Add(price * quantity);
            UpdateCartTotal();
        }

        private void PurchaseItems()
        {
            if (!int.TryParse(textBox11.Text, out var total) || total == 0)
            {
                MessageBox.Show("Lütfen sepetinize en az 1 adet ürün ekleyiniz!");
                return;
            }

            if (!int.TryParse(label2.Text, out var balance))
            {
                MessageBox.Show("Bakiye bilgisi geçersiz!");
                return;
            }

            if (balance >= total)
            {
                label2.Text = (balance - total).ToString();
                UpdateBalance();
                MessageBox.Show("Alışveriş gerçekleştirildi");
            }
            else
            {
                MessageBox.Show("Bakiye Yetersiz!");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Hamburger";
            textBox2.Text = "22";
            textBox3.Text = "Patates Kızartması";
            textBox4.Text = "13";
            textBox5.Text = "Coca Cola";
            textBox6.Text = "6";
            textBox7.Text = "Su";
            textBox8.Text = "3";
            textBox9.Text = "Tatlı";
            textBox10.Text = "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddItemToCart(textBox1.Text, int.Parse(textBox2.Text), int.Parse(comboBox1.SelectedItem.ToString()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddItemToCart(textBox3.Text, int.Parse(textBox4.Text), int.Parse(comboBox2.SelectedItem.ToString()));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddItemToCart(textBox5.Text, int.Parse(textBox6.Text), int.Parse(comboBox3.SelectedItem.ToString()));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddItemToCart(textBox7.Text, int.Parse(textBox8.Text), int.Parse(comboBox4.SelectedItem.ToString()));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddItemToCart(textBox9.Text, int.Parse(textBox10.Text), int.Parse(comboBox5.SelectedItem.ToString()));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox13.Text, out var amountToAdd))
            {
                MessageBox.Show("Geçersiz para miktarı!");
                return;
            }

            var currentBalance = int.Parse(label2.Text);
            label2.Text = (currentBalance + amountToAdd).ToString();
            UpdateBalance();
            MessageBox.Show("Para Yükleme İşlemi Başarılı");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PurchaseItems();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(selectedIndex);
                listBox2.Items.RemoveAt(selectedIndex);
                listBox3.Items.RemoveAt(selectedIndex);
                UpdateCartTotal();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            UpdateCartTotal();
        }
    }
}
