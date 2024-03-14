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
    public partial class UcusBilgileriUser : Form
    {
        VTIslemleri vtEx = new VTIslemleri();
        public UcusBilgileriUser()
        {
            InitializeComponent();
            TabloGuncelle();
        }
        public void TabloGuncelle()
        {
            dataGridView1.Rows.Clear();
            dataGridView1 = vtEx.GetAllUcuslar(dataGridView1);
        }
    }
}
