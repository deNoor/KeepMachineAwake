using Vanara.PInvoke;

namespace KeepMachineAwake;

internal class Program
{
    private static void Main()
    {
        do
        {
            var result = (uint) Kernel32.SetThreadExecutionState(
                Kernel32.EXECUTION_STATE.ES_CONTINUOUS
                | Kernel32.EXECUTION_STATE.ES_SYSTEM_REQUIRED
                | Kernel32.EXECUTION_STATE.ES_DISPLAY_REQUIRED);
            if (result > 0)
            {
                Console.WriteLine($"{DateTime.Now:HH:mm:ss} continuous system and display on.");
                break;
            }
            Console.WriteLine($"{DateTime.Now:HH:mm:ss} failed to {nameof(Kernel32.SetThreadExecutionState)}.");
            Thread.Sleep(TimeSpan.FromMinutes(1));
        } while (true);
        Thread.Sleep(Timeout.InfiniteTimeSpan);
    }
}
