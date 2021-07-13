using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using Formatting = Newtonsoft.Json.Formatting;

namespace TaskStarter
{
    internal static class Utiles
    {
        public static string FolderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\TaskStarter";
        public static  string FilePath = $@"{FolderPath}\Profiles.json";

        public static string TrimPath(string path)
        {
            return path.Substring(path.LastIndexOf("\\") + 1);
        }

        public static string TrimExtension(string s)
        {
            return s.Remove(s.LastIndexOf("."), s.Substring(s.LastIndexOf(".")).Length);
        }


        public static void SaveProfiles()
        {
            var data = new List<ProfileData>();
            foreach (var p in ProfileManager.Profiles)
            {
                var datum = new ProfileData(p);
                data.Add(datum);
            }
            WriteToJson(data);
        }

        public static void LoadProfiles()
        {
            try
            {
                ReadJson();
            }
            catch (Exception)
            {
                CreateJson();
            }
        }

        private static void WriteToJson(List<ProfileData> data)
        {
            var jsonToWrite = JsonConvert.SerializeObject(data, Formatting.Indented);
            using (var writer = new StreamWriter(FilePath))
            {
                writer.Write(jsonToWrite);
            }
        }

        private static void ReadJson()
        {
            string jsonFromFile;
            using (var reader = new StreamReader(FilePath))
            {
                jsonFromFile = reader.ReadToEnd();
            }
            var profileData = JsonConvert.DeserializeObject<List<ProfileData>>(jsonFromFile);
            if (profileData == null) return;
            foreach (var profileDatum in profileData)
            {
                ProfileManager.CopyProfile(profileDatum);
            }
        }

        private static void CreateJson()
        {
            Directory.CreateDirectory(FolderPath);
           File.Create(FilePath);
        }

        public static void AddApplicationToStartup()
        {
            using (var key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                key?.SetValue("My Program", "\"" + Application.ExecutablePath + "\"");
            }
        }
    }
}
