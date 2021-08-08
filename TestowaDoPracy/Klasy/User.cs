﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestowaDoPracy.Klasy
{
    public class User
    {
        public static string UserID { get; set; }
        public static string Login { get; set; }
        public static string Password { get; set; }
        public static string Email { get; set; }
        
        public static void ClearTempData()
        {
            UserID = "";
            Login = "";
            Password = "";
            Email = "";
        }
    }
}
