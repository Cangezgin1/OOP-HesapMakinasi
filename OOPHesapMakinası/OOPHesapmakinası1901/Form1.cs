using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sınıf;

namespace OOPHesapmakinası1901
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
                using (dortislem islem = new dortislem(int.Parse(textBox1.Text), int.Parse(textBox2.Text), comboBox1.Text))
                {
                    sonuclbl.Text = (islem.sonsonuc).ToString();
                }
        }
    }
}
