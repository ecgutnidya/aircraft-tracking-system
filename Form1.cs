using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stajproje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int kontrol = new VTIslemleri().CheckUser(textBox1.Text, textBox2.Text);
            if (kontrol == 1) // Admin kullanıcısı ise
            {
                new UcusBilgileri();
                Hide();
            }
            else if (kontrol == 0)
            {
                new UcusBilgileriUser().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Bilgiler Yanlış");
            }
        }
    }
}
