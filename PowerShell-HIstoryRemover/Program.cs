namespace PS_H_REMOVER
{
    class Program
    {
        static void Main(string[] args)
        {
            ClearLog();
        }

        static string GetPowerShellPath()
        {
            return Path.Combine("c:\\Users", Environment.UserName, "AppData\\Roaming\\Microsoft\\Windows\\PowerShell\\PSReadLine\\ConsoleHost_history.txt");
        }

        static void ClearLog()
        {
            try
            {
                File.WriteAllTextAsync(GetPowerShellPath(), string.Empty);
                Console.WriteLine("Clear Log!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}