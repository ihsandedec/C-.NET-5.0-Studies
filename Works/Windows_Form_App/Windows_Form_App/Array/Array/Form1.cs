using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int number1;
        int number2;
        int number3;

        string city = "İstanbul";
        string city2 = "Ankara";

        string[] cities = new string[3] { "İstanbul", "Ankara", "Denizli" };
        int[] numbers = new int[3];
        int[] age = {21, 22, 23 };

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // cities[0] = "İstanbul";
            // cities[1] = "Ankara";
            // cities[2] = "Trabzon";
            MessageBox.Show(cities[2]);
        }
    }
}
