using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodParameters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Attack("ok", 200);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Attack("büyü", 230);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Attack("kılıç", 250);
        }

        public void Attack(string attackStyle, int damage)
        {
            MessageBox.Show($"Düşmana {attackStyle} ile {damage} hasar verildi."  );
        }
    }
}
