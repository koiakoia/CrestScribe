using borkedLabs.CrestScribe.Settings;

namespace borkedLabs.CrestScribe
{
    public static class ScribeSettings
    {
        public static SettingsRoot Settings { get; private set; }

        public static void Load(string file)
        {
            Settings = SettingsRoot.Load(file);
        }
    }
}
