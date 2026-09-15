// ---------------------------------------------------------------------------
// Demo 2 - Rainfall Log (WinForms) - application entry point
// Part of the Demo2 project. Open Demo2.slnx in Visual Studio and press F5.
// ---------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Demo2;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.Run(new RainfallForm());
    }
}
