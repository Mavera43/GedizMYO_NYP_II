using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GedizMyoHafta3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal sonuc;
            //aşağıda parse yöntemi ile string'i sayıya dönüştürdük.
             sonuc = Math.Round(decimal.Parse(txtSayı1.Text) / decimal.Parse(txtSayı2.Text),2);
            txtSonuc.Text = sonuc.ToString();//sayıyı stringe dönüştürdük

        }
    }
}
