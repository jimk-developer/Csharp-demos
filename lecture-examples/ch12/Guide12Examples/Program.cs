namespace Guide12Examples;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    ///  The launcher (MainForm) opens each Guide 12 example in section order.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}
