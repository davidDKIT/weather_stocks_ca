using System;
using System.Windows.Forms;

namespace weather_stocks_ca
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new welcome());
        }
    }
}
