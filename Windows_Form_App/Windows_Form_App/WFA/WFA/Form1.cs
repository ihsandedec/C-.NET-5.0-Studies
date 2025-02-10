using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıp Butonu Bulun ");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

      

        private void btnTrue_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Beni Buldun !");
        }

        private void btnFalse_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Aramaya Devam Et !");

        }

        private void btnFalse2_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Aramaya Devam Et !");

        }

        private void btnFalse3_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Aramaya Devam Et !");

        }

        private void btnClick_MouseHover(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Red;
        }

        private void btnClick_MouseLeave(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.White;
        }
    }
}
