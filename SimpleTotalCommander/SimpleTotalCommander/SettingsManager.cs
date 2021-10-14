using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SimpleTotalCommander
{
    class Settings
    {
        private static string settingsFile = @"settings_" + Environment.UserName + ".ini";
        private static Dictionary<string, string> defaultSettings = new Dictionary<string, string>
        {
            { "View As", "0" },
            { "Default Drive", Environment.GetEnvironmentVariable("SystemDrive") + "\\" }
        };

        public static Dictionary<string, string> LoadSettings()
        {
            Dictionary<string, string> ret = null;
            bool settingsExist = CheckForExistingSettings();
            if (settingsExist) ret = LoadSettingsFile();
            else ret = CreateNewSettingsFile();
            return ret;
        }

        private static bool CheckForExistingSettings()
        {
            bool ret = false;
            if(File.Exists(settingsFile))
            {
                try
                {
                    string[] settings = File.ReadAllLines(settingsFile);
                    if (settings.Length == 3 + defaultSettings.Count && settings[0] == "[STC Settings]" && settings[1] == "[User: " + Environment.UserName + "]") ret = true;
                }
                catch(Exception){}
                if (ret == false) File.Delete(settingsFile);
            }
            return ret;
        }
        
        private static Dictionary<string, string> LoadSettingsFile()
        {
            Dictionary<string, string> ret = new Dictionary<string, string>();
            List<string> settings = File.ReadAllLines(settingsFile).Where(s => s.StartsWith(";")).ToList();
            foreach (string s in settings) ret.Add(s.Substring(1, s.IndexOf(":") - 1), s.Substring(s.IndexOf(":") + 2));
            return ret;
        }
        
        private static Dictionary<string, string> CreateNewSettingsFile()
        {
            UpdateSettings(defaultSettings);
            File.Encrypt(settingsFile);
            return defaultSettings;
        }

        public static void UpdateSettings(Dictionary<string, string> settings)
        {
            List<string> lines = new List<string> { "[STC Settings]", "[User: " + Environment.UserName + "]", "" };
            foreach (KeyValuePair<string, string> line in settings) lines.Add(string.Format(";{0}: {1}", line.Key, line.Value));
            File.WriteAllLines(settingsFile, lines);
        }
    }
}
