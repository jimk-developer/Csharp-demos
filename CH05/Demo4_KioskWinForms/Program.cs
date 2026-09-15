// ---------------------------------------------------------------------------
// Demo 4 - Campus Kiosk Donations (WinForms) - application entry point
// Part of the Demo4 project. Open Demo4.slnx in Visual Studio and press F5.
// ---------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Demo4;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.Run(new KioskForm());
    }
}
