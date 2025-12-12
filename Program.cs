using System;
using System.Windows.Forms;

namespace CIS285Project
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());  // YOUR MAIN WINDOW
        }
    }
}
