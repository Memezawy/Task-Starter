using System.Collections.Generic;
using System.Windows.Forms;

namespace TaskStarter
{
    public class ProfileManager
    {
        public static List<Profile> Profiles = new List<Profile>();
        public static Profile SelectedProfile;


        public static Profile CreateNewProfile(string name)
        {
            if (name == "") { return null; }
            if (SearchProfiles(name) == null)
            {
                var profile = new Profile(name);
                Profiles.Add(profile);
                SelectProfile(name);
                Utiles.SaveProfiles();
                return profile;
            }
            MessageBox.Show("Profile with same name already exists!", "Cannot Add Profile");
            return null;
        }
        public static void DeleteProfile(string name)
        {
            Profiles.Remove(SearchProfiles(name));
            Utiles.SaveProfiles();
        }

        public static void SelectProfile(string name)
        {
            if (SearchProfiles(name) == null) return;
            SelectedProfile = SearchProfiles(name);
        }

        public static void RenameProfile(string profileName, string newName)
        {
            var p = SearchProfiles(profileName);
            p.Name = newName;
        }

        public static Profile SearchProfiles(string name)
        {
            foreach (var profile in Profiles)
            {
                if (name == profile.Name)
                {
                    return profile;
                }
            }
            return null;
        }

        public static Profile CopyProfile(ProfileData p)
        {
            var profile = new Profile(p.ProfileName);
            foreach (var taskData in p.TasksData)
            {
                profile.AddTask(taskData.Path, taskData.Name);
            }
            Profiles.Add(profile);
            Utiles.SaveProfiles();
            return profile;
        }
    }
}
