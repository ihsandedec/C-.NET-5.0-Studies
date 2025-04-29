using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int number =0;
        public void Yansit()
        {
            label1.Text = number.ToString();
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            number--;
            Yansit();
        }

        private void btnArti_Click(object sender, EventArgs e)
        {
            number++;
            Yansit();
        }
    }
}
