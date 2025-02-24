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
    public partial class constants : Form
    {
        public constants()
        {
            InitializeComponent();
        }
        const double pi = 3.141;
        private void constants_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pi = 3;   //-> const performans kazandırır cunku ram de daha az yer kaplar. 
        }
    }
}
