using System;
using System.Windows.Forms;

namespace DEMO2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Generated for you by Visual Studio when you create a
            // Windows Forms App project on .NET 10.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
