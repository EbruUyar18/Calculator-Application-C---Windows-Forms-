using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ikinci_hafta_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbEkran.Text += (sender as Button).Text;
            //tbEkran.Text = btn1.Text;
            //tbEkran.Text = "1";
            ////optimize etmek için bileşenin adıyla yazmak daha mantıklı
            //tbEkran.Text = Convert.ToString(1);
        }
        double sayi;
        private void btnIsaretDegis_Click(object sender, EventArgs e)
        {
            sayi=Convert.ToDouble(tbEkran.Text);
            tbEkran.Text=(sayi*-1).ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbEkran.Clear();
        }
        double hafiza;
        private void btnM_Click(object sender, EventArgs e)
        {
            tbEkran.Text=hafiza.ToString();
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            hafiza = 0;
        }

        private void btnMarti_Click(object sender, EventArgs e)
        {
            hafiza += Convert.ToDouble(tbEkran.Text);
        }

        private void btnMeksi_Click(object sender, EventArgs e)
        {
            hafiza -= Convert.ToDouble(tbEkran.Text);
        }
        string islem;
        private void btnTopla_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToDouble(tbEkran.Text);
            tbEkran.Clear();
            islem = (sender as Button).Text;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (islem == "+") tbEkran.Text = Convert.ToString(sayi + Convert.ToDouble(tbEkran.Text));
            if (islem == "-") tbEkran.Text = Convert.ToString(sayi - Convert.ToDouble(tbEkran.Text));
            if (islem == "*") tbEkran.Text = Convert.ToString(sayi * Convert.ToDouble(tbEkran.Text));
            if (islem == "/") tbEkran.Text = Convert.ToString(sayi / Convert.ToDouble(tbEkran.Text));
        }
    }
}
