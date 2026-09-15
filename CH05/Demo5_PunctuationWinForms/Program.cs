// ---------------------------------------------------------------------------
// Demo 5 - Punctuation Counter (WinForms) - application entry point
// Part of the Demo5 project. Open Demo5.slnx in Visual Studio and press F5.
// ---------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Demo5;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.Run(new PunctuationForm());
    }
}
