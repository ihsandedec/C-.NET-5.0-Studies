using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.userName = "Asaf";
            user.password = "123";
            user.age = 6;
            user.job = "developer";
            MessageBox.Show($"kullanıcı adı : {user.userName} - password : {user.password}");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
