using System;
using System.Windows.Forms;

namespace stajproje1
{
    public partial class UcusBilgileri : Form
    {
        VTIslemleri vtEx = new VTIslemleri();
        public UcusBilgileri()
        {
            Show();
            InitializeComponent();
            TabloGuncelle();
        }
        public void TabloGuncelle()
        {
            dataGridView1.Rows.Clear();
            dataGridView1 = new VTIslemleri().GetAllUcuslar(dataGridView1);
        }
        private void UcusBilgileri_Load(object sender, EventArgs e)
        {
        }

        private void UcusBilgileri_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  int parsedValue;
            if (!int.TryParse(textBox4.Text, out parsedValue))
            {
                MessageBox.Show("Sadece Sayı Değerleri Ekleyiniz");

            }

            if (!int.TryParse(textBox2.Text, out parsedValue))
            {
                MessageBox.Show("Sadece Sayı Değerleri Ekleyiniz");
                return;
            }*/
            string[] bilgiler = {
            dateTimePicker1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text,textBox9.Text
            };
            vtEx.AddUcuslar(bilgiler);
            TabloGuncelle();
        }
    }
}
