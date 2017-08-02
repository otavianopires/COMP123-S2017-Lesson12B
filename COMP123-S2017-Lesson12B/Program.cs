using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Otaviano Pires Amancio
 * StudentID: 300910504
 * Date: August 2, 2017
 * Description: Demo Application to showcase windows forms andUI Controls
 * Version: 0.1 - Project was created
 */

namespace COMP123_S2017_Lesson12B
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
