using System;
using System.ComponentModel.Design;
using System.IO;
using System.Windows.Forms;
using static TaskStarter.Utiles;

namespace TaskStarter
{
    public partial class MainForm : Form
    {
        private readonly FormControls _formControls; 
        public MainForm()
        {
            InitializeComponent();
            _formControls = new FormControls(this);
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (ProfileManager.SelectedProfile == null) { return; }
            ProfileManager.SelectedProfile.StartTasks();
        }

        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            _formControls.AddWebsiteTask();
            SaveProfiles();
        }
        //Remove Task
        private void button1_Click(object sender, EventArgs e)
        {
            _formControls.RemoveTask();
        }

        private void profileCreateBtn_Click(object sender, EventArgs e)
        {
            _formControls.CreateProfile();
        }

        private void selectProfileBtn_Click(object sender, EventArgs e)
        {
            _formControls.DeleteProfile();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _formControls.OnFormLoad();
            AddApplicationToStartup();
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            _formControls.EditProfileName();
        }

        //Add App Task
        private void button1_Click_1(object sender, EventArgs e)
        {
            _formControls.AddProgramTask();
        }

        private void addFolderBtn_Click(object sender, EventArgs e)
        {
            _formControls.AddFolderTask();
        }

        private void taskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProfilesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _formControls.SelectProfile();
        }

        private void profileNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void websiteTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
