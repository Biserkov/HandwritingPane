using Microsoft.Win32;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        RegistryKey regKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\TabletTip\1.7");
        regKey.SetValue("LastUsedModalityWasHandwriting", 1, RegistryValueKind.DWord);
        foreach (var process in Process.GetProcessesByName("TabTip"))
            process.Kill();
        Process.Start(@"C:\Program Files\Common Files\Microsoft Shared\ink\TabTip.exe");
    }
}