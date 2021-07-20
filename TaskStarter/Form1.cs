using System;
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

        private void ProfilesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _formControls.SelectProfile();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
                //notifyIcon.BalloonTipTitle = "Task Starter";
                //notifyIcon.BalloonTipText = "Task Starter is now minimized";
                notifyIcon.ShowBalloonTip(10, "Task Starter", "Task Starter is now minimized", ToolTipIcon.Info);
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void RemoveTask_Click(object sender, EventArgs e)
        {
            _formControls.RemoveTask();
        }
    }
}
