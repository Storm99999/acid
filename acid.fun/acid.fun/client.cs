using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO.Compression;

namespace acid.fun
{
    internal class client
    {
        public static void UnRar(string SRC, string DEST)
        {
            ZipFile.ExtractToDirectory(SRC, DEST);
        }

        public static string GetRobloxDirectory()
        {
            string localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string bloxstrapPath = Path.Combine(localAppDataPath, "Bloxstrap");

            if (Directory.Exists(bloxstrapPath))
            {
                return Path.Combine(bloxstrapPath, "Modifications");
            }

            return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Roblox\\Versions\\";
        }



        public static string GetRobloxClientName()
        {
            string localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string bloxstrapPath = Path.Combine(localAppDataPath, "Bloxstrap");

            if (Directory.Exists(bloxstrapPath))
            {
                return "Bloxstrap";
            }

            return "Roblox";
        }

        public static string GetRobloxVersion()
        {
            foreach (var flds in Directory.GetDirectories(GetRobloxDirectory()))
            {
                // most likely wont happen, but just to make sure. 
                var i = new DirectoryInfo(flds);
                if (i.GetFiles().Length == 0 || i.GetDirectories().Length == 0)
                {
                }

                if (i.GetFiles().Length != 0)
                {
                    // Checks for builtinplugins, it's a folder, when that roblox ver is outdated
                    foreach (var fe in Directory.GetFiles(i.FullName))
                    {
                        var fileInfo1 = new FileInfo(fe);
                        if (Directory.Exists(i.FullName + "BuiltInPlugins"))
                        {
                        }
                    }
                }

                if (File.Exists(i.FullName + "\\RobloxPlayerBeta.exe"))
                {
                    return i.FullName;
                }
            }

            return null;
        }

        public static void AddFFlag(string fflag, string value)
        {
            if (GetRobloxClientName() == "Roblox")
            {
                if (!Directory.Exists(GetRobloxVersion() + "\\ClientSettings"))
                {
                    MessageBox.Show("No fflags directory");
                }

                string jsonContent = File.ReadAllText(GetRobloxVersion() + "\\ClientSettings\\ClientAppSettings.json");

                JObject jsonObject = JObject.Parse(jsonContent);

                jsonObject[fflag] = value;

                string updatedJsonContent = JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented);

                File.WriteAllText(GetRobloxVersion() + "\\ClientSettings\\ClientAppSettings.json", updatedJsonContent);
            }

            if (GetRobloxClientName() == "Bloxstrap")
            {
          
                string jsonContent = File.ReadAllText(GetRobloxDirectory() + "\\ClientSettings\\ClientAppSettings.json");

                JObject jsonObject = JObject.Parse(jsonContent);

                jsonObject[fflag] = value;

                string updatedJsonContent = JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented);

                File.WriteAllText(GetRobloxDirectory() + "\\ClientSettings\\ClientAppSettings.json", updatedJsonContent);
            }
        }

        public static void RemoveFFlag(string propertyKey)
        {
            string filePathr = GetRobloxVersion() + "\\ClientSettings\\ClientAppSettings.json";
            string filePath = GetRobloxDirectory() + "\\ClientSettings\\ClientAppSettings.json";

            if (GetRobloxClientName() == "Roblox")
            {
                if (!Directory.Exists(GetRobloxVersion() + "\\ClientSettings"))
                {
                    MessageBox.Show("No fflags directory");
                }

                string jsonContent = File.ReadAllText(filePathr);

                JObject jsonObject = JObject.Parse(jsonContent);

                if (jsonObject.ContainsKey(propertyKey))
                {
                    jsonObject.Property(propertyKey).Remove();

                    string updatedJsonContent = JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented);

                    File.WriteAllText(filePathr, updatedJsonContent);

                }
                else
                {
                }
            }

            if (GetRobloxClientName() == "Bloxstrap")
            {

                string jsonContent = File.ReadAllText(filePath);

                JObject jsonObject = JObject.Parse(jsonContent);

                if (jsonObject.ContainsKey(propertyKey))
                {
                    jsonObject.Property(propertyKey).Remove();

                    string updatedJsonContent = JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented);

                    File.WriteAllText(filePath, updatedJsonContent);

                }
                else
                {
                }
            }
           
        }

        public static string GetStorageFolder() 
        {
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\acidfun"))
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\acidfun";
            }

            return Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        }

        public static void OnLoad()
        {
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\acidfun"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\acidfun");
            }

            var processes = Process.GetProcessesByName("RobloxPlayerBeta");

            foreach (var process in processes)
            {
                try
                {
                    MessageBox.Show("Please close roblox if you're planning to Apply any visual changes.");
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
