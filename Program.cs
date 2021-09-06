using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Pharmacy_Management;

namespace Pharmacy_Management
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
            Application.Run(new Frm_DangNhap());
        }
    }
}
