﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class User
    {
      
        public string userName { get; set; }
        public string password { get; set; }
        public int age { get; set; }
        public string job { get; set; }

        public void Login (string loginDate)
        {
            System.Windows.Forms.MessageBox.Show($"{loginDate} tarihinde {userName} adlı kullancı {password} şifresi ile giriş yaptı.");
        }
    }
}
