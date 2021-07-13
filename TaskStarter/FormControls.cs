using System;
using System.Windows.Forms;
using static TaskStarter.Utiles;

namespace TaskStarter
{
    internal class FormControls
    {
        private string taskName;
        private readonly MainForm mainForm;

        public FormControls(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        #region Tasks Related

        public void AddProgramTask()
        {
            if (!CheckForProfile()) return;
            mainForm.ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (mainForm.ofd.ShowDialog() != DialogResult.OK) return;
            foreach (var file in mainForm.ofd.FileNames)
            {
                taskName = "Open " + TrimExtension(TrimPath(file));
                ProfileManager.SelectedProfile.AddTask(file, taskName);
            }
            UpdateTasksList();
        }

        public void AddFolderTask()
        {
            if (!CheckForProfile()) return;
            if (mainForm.fbd.ShowDialog() != DialogResult.OK) return;
            taskName = "Open Folder " + mainForm.fbd.SelectedPath;
            ProfileManager.SelectedProfile.AddTask(mainForm.fbd.SelectedPath, taskName);
            UpdateTasksList();
        }

        public void AddWebsiteTask()
        {
            if (!CheckForProfile()) return;
            if (mainForm.websiteTextBox.Text == "") return;
            taskName = "Visit " + mainForm.websiteTextBox.Text;
            ProfileManager.SelectedProfile.AddTask($"www.{mainForm.websiteTextBox.Text}", taskName);
            mainForm.websiteTextBox.Text = "";
            UpdateTasksList();
        }

        public void RemoveTask()
        {
            if (mainForm.taskListBox.SelectedItem == null) return;
            foreach (var item in mainForm.taskListBox.SelectedItems)
            {
                ProfileManager.SelectedProfile.RemoveTask(item.ToString());
            }
            UpdateTasksList();
        }


        public void UpdateTasksList()
        {
            mainForm.taskListBox.Items.Clear();
            foreach (var process in ProfileManager.SelectedProfile.Tasks)
            {
                mainForm.taskListBox.Items.Add(process.Name);
            }
        }

        #endregion

        #region Profile Related

        private void UpdateProfilesList()
        {
            mainForm.ProfilesComboBox.Items.Clear();
            foreach (var profile in ProfileManager.Profiles)
            {
                mainForm.ProfilesComboBox.Items.Add(profile.Name);
            }
        }

        public void CreateProfile()
        {
            if (mainForm.profileNameTextBox.Text == "")
            {
                MessageBox.Show("Please Enter a Profile Name", "Unable to Create Profile");
                return;
            }
            ProfileManager.CreateNewProfile(mainForm.profileNameTextBox.Text);
            mainForm.ProfilesComboBox.Items.Add(mainForm.profileNameTextBox.Text);
            mainForm.ProfilesComboBox.SelectedItem =
                mainForm.ProfilesComboBox.Items[mainForm.ProfilesComboBox.Items.Count - 1];
            mainForm.profileNameTextBox.Text = "";
            UpdateProfilesList();
        }

        public void SelectProfile()
        {
            if (mainForm.ProfilesComboBox.SelectedItem == null) { return; }
            ProfileManager.SelectProfile(mainForm.ProfilesComboBox.SelectedItem.ToString());
            UpdateTasksList();
        }

        public void DeleteProfile()
        {
            if (!CheckForProfile()) return;
            ProfileManager.DeleteProfile(mainForm.ProfilesComboBox.SelectedItem.ToString());
            mainForm.ProfilesComboBox.SelectedItem = mainForm.ProfilesComboBox.Items[0];
            UpdateProfilesList();
            if (mainForm.ProfilesComboBox.Items.Count == 0) mainForm.ProfilesComboBox.SelectedItem = null;
        }

        public void EditProfileName()
        {
            if (!CheckForProfile()) return;
            if (mainForm.profileNameTextBox.Text == "")
            {
                MessageBox.Show("Please Enter A Profile Name", "Profile");
                return;
            }
            ProfileManager.RenameProfile(mainForm.ProfilesComboBox.SelectedItem.ToString(), mainForm.profileNameTextBox.Text);
            mainForm.ProfilesComboBox.SelectedItem = mainForm.ProfilesComboBox.Items[0];
            mainForm.profileNameTextBox.Text = "";
            UpdateProfilesList();
            SaveProfiles();
        }

        #endregion

        private static bool CheckForProfile()
        {
            if (ProfileManager.SelectedProfile != null) return true;
            MessageBox.Show("No Profile Selected!", "No profile selected");
            return false;
        }

        public void OnFormLoad()
        {
            LoadProfiles();
            UpdateProfilesList();
            try
            {
                mainForm.ProfilesComboBox.SelectedItem = mainForm.ProfilesComboBox.Items[0];
            }
            catch (Exception) { }
        }
    }
}
