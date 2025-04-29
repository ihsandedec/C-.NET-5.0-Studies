using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace escapeCharacter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string simple = "burası 1. satir \n 2.satir";
            string simple2 = "Mevlana der ki \"sevelim, sevilelim\"";
           // MessageBox.Show(simple);
           // MessageBox.Show(simple2);
            string name = "asaf";
            string surname = "dedec";
            string simple3 = $"merhaba benim adım {name}. soyadim {surname} ";
           MessageBox.Show(simple3);
            string simple4 = @"burası 1. satir
burası 2. satir";                                       //-> Normal karakter gibi algilar.
            //MessageBox.Show(simple4);
        }
    }
}
