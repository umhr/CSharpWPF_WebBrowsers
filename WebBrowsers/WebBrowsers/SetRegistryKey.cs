namespace WebBrowsers
{
    class SetRegistryKey
    {
        // ゴリゴリ★コード_C# : WebBrowserのIEバージョンを最新にする。
        // http://blog.livedoor.jp/tkarasuma/archives/1036522520.html
        static Microsoft.Win32.RegistryKey regkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(FEATURE_BROWSER_EMULATION);
        const string FEATURE_BROWSER_EMULATION = @"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION";
        static string process_name = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";
        static string process_dbg_name = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".vshost.exe";

        static public void Init()
        {
            regkey.SetValue(process_name, 11000, Microsoft.Win32.RegistryValueKind.DWord);
            regkey.SetValue(process_dbg_name, 11000, Microsoft.Win32.RegistryValueKind.DWord);
        }


        static public void Closing()
        {
            regkey.DeleteValue(process_name);
            regkey.DeleteValue(process_dbg_name);
            regkey.Close();
        }

    }
}
