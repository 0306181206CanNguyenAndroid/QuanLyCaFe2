﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new fLogin());
            //Application.Run(new Order());
            //Application.Run(new Customers());
            //Application.Run(new QuanLyHoaDon());

            //Application.Run(new QuanLyNhanVien());
            Application.Run(new fLogin());
        }
    }
}
