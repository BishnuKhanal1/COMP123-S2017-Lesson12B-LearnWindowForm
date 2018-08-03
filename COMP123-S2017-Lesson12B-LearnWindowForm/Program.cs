using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Bishnu Khanal
 * Student ID: 
 * Date: August 1st 2018
 * Des: Demo Application to Showcase form and UI controls
 * Version: 0.1- Project was created
 * */
namespace COMP123_S2017_Lesson12B_LearnWindowForm
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
            Application.Run(new DemoForm());
        }
    }
}
