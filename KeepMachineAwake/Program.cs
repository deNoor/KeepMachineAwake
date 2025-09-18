namespace KeepMachineAwake;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        using var singleInstanceMutex = new Mutex(true, "67aebf76-44fd-430d-93cb-2aab0eed88e5", out var createdNew);
        if (!createdNew)
        {
            return;
        }
        try
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
        finally
        {
            singleInstanceMutex.ReleaseMutex();
        }
    }
}
