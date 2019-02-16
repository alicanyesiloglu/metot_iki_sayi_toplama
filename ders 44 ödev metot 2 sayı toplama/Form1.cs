using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_44_ödev_metot_2_sayı_toplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         int toplam(int t1,int t2)
        {
            int f = t1 + t2;
            return f;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int q = Convert.ToInt16(textBox1.Text);
            int qq = Convert.ToInt16(textBox2.Text);

            label1.Text = toplam(q,qq).ToString();
        }
    }
}
