
namespace TaskStarter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StartBtn = new System.Windows.Forms.Button();
            this.AddTaskBtn = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.websiteTextBox = new System.Windows.Forms.TextBox();
            this.removeTaskBtn = new System.Windows.Forms.Button();
            this.taskListBox = new System.Windows.Forms.ListBox();
            this.profileCreateBtn = new System.Windows.Forms.Button();
            this.profileNameTextBox = new System.Windows.Forms.TextBox();
            this.deletProfileBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.addFolderBtn = new System.Windows.Forms.Button();
            this.AddAppButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProfilesComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.StartBtn.FlatAppearance.BorderSize = 6;
            this.StartBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.StartBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.ForeColor = System.Drawing.Color.White;
            this.StartBtn.Location = new System.Drawing.Point(57, 394);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(227, 129);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // AddTaskBtn
            // 
            this.AddTaskBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddTaskBtn.FlatAppearance.BorderSize = 5;
            this.AddTaskBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.AddTaskBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTaskBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTaskBtn.ForeColor = System.Drawing.Color.White;
            this.AddTaskBtn.Location = new System.Drawing.Point(12, 450);
            this.AddTaskBtn.Name = "AddTaskBtn";
            this.AddTaskBtn.Size = new System.Drawing.Size(578, 61);
            this.AddTaskBtn.TabIndex = 4;
            this.AddTaskBtn.Text = "Add Website";
            this.AddTaskBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddTaskBtn.UseVisualStyleBackColor = true;
            this.AddTaskBtn.Click += new System.EventHandler(this.AddTaskBtn_Click);
            // 
            // ofd
            // 
            this.ofd.AddExtension = false;
            this.ofd.DereferenceLinks = false;
            this.ofd.Multiselect = true;
            // 
            // websiteTextBox
            // 
            this.websiteTextBox.BackColor = System.Drawing.Color.Black;
            this.websiteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.websiteTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.websiteTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.websiteTextBox.ForeColor = System.Drawing.Color.White;
            this.websiteTextBox.Location = new System.Drawing.Point(213, 462);
            this.websiteTextBox.Name = "websiteTextBox";
            this.websiteTextBox.Size = new System.Drawing.Size(361, 29);
            this.websiteTextBox.TabIndex = 5;
            // 
            // removeTaskBtn
            // 
            this.removeTaskBtn.BackColor = System.Drawing.Color.Black;
            this.removeTaskBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.removeTaskBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.removeTaskBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.removeTaskBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTaskBtn.ForeColor = System.Drawing.Color.White;
            this.removeTaskBtn.Location = new System.Drawing.Point(423, 233);
            this.removeTaskBtn.Name = "removeTaskBtn";
            this.removeTaskBtn.Size = new System.Drawing.Size(137, 32);
            this.removeTaskBtn.TabIndex = 8;
            this.removeTaskBtn.Text = "Remove Task";
            this.removeTaskBtn.UseVisualStyleBackColor = false;
            this.removeTaskBtn.Click += new System.EventHandler(this.RemoveTask_Click);
            // 
            // taskListBox
            // 
            this.taskListBox.BackColor = System.Drawing.Color.Black;
            this.taskListBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskListBox.ForeColor = System.Drawing.Color.White;
            this.taskListBox.FormattingEnabled = true;
            this.taskListBox.ItemHeight = 28;
            this.taskListBox.Location = new System.Drawing.Point(12, 22);
            this.taskListBox.Name = "taskListBox";
            this.taskListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.taskListBox.Size = new System.Drawing.Size(578, 256);
            this.taskListBox.TabIndex = 10;
            // 
            // profileCreateBtn
            // 
            this.profileCreateBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.profileCreateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.profileCreateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.profileCreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileCreateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.profileCreateBtn.ForeColor = System.Drawing.Color.White;
            this.profileCreateBtn.Location = new System.Drawing.Point(63, 203);
            this.profileCreateBtn.Name = "profileCreateBtn";
            this.profileCreateBtn.Size = new System.Drawing.Size(208, 27);
            this.profileCreateBtn.TabIndex = 12;
            this.profileCreateBtn.Text = "Create New Profile";
            this.profileCreateBtn.UseVisualStyleBackColor = true;
            this.profileCreateBtn.Click += new System.EventHandler(this.profileCreateBtn_Click);
            // 
            // profileNameTextBox
            // 
            this.profileNameTextBox.BackColor = System.Drawing.Color.Black;
            this.profileNameTextBox.ForeColor = System.Drawing.Color.White;
            this.profileNameTextBox.Location = new System.Drawing.Point(6, 79);
            this.profileNameTextBox.Name = "profileNameTextBox";
            this.profileNameTextBox.Size = new System.Drawing.Size(210, 26);
            this.profileNameTextBox.TabIndex = 13;
            // 
            // deletProfileBtn
            // 
            this.deletProfileBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deletProfileBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.deletProfileBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.deletProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletProfileBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletProfileBtn.ForeColor = System.Drawing.Color.White;
            this.deletProfileBtn.Location = new System.Drawing.Point(63, 287);
            this.deletProfileBtn.Name = "deletProfileBtn";
            this.deletProfileBtn.Size = new System.Drawing.Size(208, 27);
            this.deletProfileBtn.TabIndex = 14;
            this.deletProfileBtn.Text = "Delete Profile";
            this.deletProfileBtn.UseVisualStyleBackColor = true;
            this.deletProfileBtn.Click += new System.EventHandler(this.selectProfileBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EditBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.EditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(63, 245);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(208, 27);
            this.EditBtn.TabIndex = 18;
            this.EditBtn.Text = "Rename Profile";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // addFolderBtn
            // 
            this.addFolderBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addFolderBtn.FlatAppearance.BorderSize = 5;
            this.addFolderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.addFolderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addFolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFolderBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFolderBtn.ForeColor = System.Drawing.Color.White;
            this.addFolderBtn.Location = new System.Drawing.Point(12, 375);
            this.addFolderBtn.Name = "addFolderBtn";
            this.addFolderBtn.Size = new System.Drawing.Size(578, 61);
            this.addFolderBtn.TabIndex = 20;
            this.addFolderBtn.Text = "Add Folder";
            this.addFolderBtn.UseVisualStyleBackColor = true;
            this.addFolderBtn.Click += new System.EventHandler(this.addFolderBtn_Click);
            // 
            // AddAppButton
            // 
            this.AddAppButton.BackColor = System.Drawing.SystemColors.WindowText;
            this.AddAppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddAppButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddAppButton.FlatAppearance.BorderSize = 5;
            this.AddAppButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.AddAppButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAppButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAppButton.ForeColor = System.Drawing.Color.White;
            this.AddAppButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddAppButton.Location = new System.Drawing.Point(12, 300);
            this.AddAppButton.Name = "AddAppButton";
            this.AddAppButton.Size = new System.Drawing.Size(578, 61);
            this.AddAppButton.TabIndex = 19;
            this.AddAppButton.Text = "Add Program";
            this.AddAppButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddAppButton.UseVisualStyleBackColor = true;
            this.AddAppButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.websiteTextBox);
            this.groupBox1.Controls.Add(this.removeTaskBtn);
            this.groupBox1.Controls.Add(this.taskListBox);
            this.groupBox1.Controls.Add(this.AddTaskBtn);
            this.groupBox1.Controls.Add(this.AddAppButton);
            this.groupBox1.Controls.Add(this.addFolderBtn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(362, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.groupBox1.Size = new System.Drawing.Size(602, 534);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tasks";
            // 
            // ProfilesComboBox
            // 
            this.ProfilesComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProfilesComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProfilesComboBox.BackColor = System.Drawing.Color.Black;
            this.ProfilesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfilesComboBox.ForeColor = System.Drawing.Color.White;
            this.ProfilesComboBox.FormattingEnabled = true;
            this.ProfilesComboBox.Location = new System.Drawing.Point(8, 21);
            this.ProfilesComboBox.Name = "ProfilesComboBox";
            this.ProfilesComboBox.Size = new System.Drawing.Size(208, 26);
            this.ProfilesComboBox.TabIndex = 22;
            this.ProfilesComboBox.SelectedIndexChanged += new System.EventHandler(this.ProfilesComboBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ProfilesComboBox);
            this.groupBox2.Controls.Add(this.profileNameTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(57, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 122);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profiles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Profile Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Task Starter";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(572, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Issue? Contact me MemezawyBussiness@gmail.com";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Task Starter";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(997, 595);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.profileCreateBtn);
            this.Controls.Add(this.deletProfileBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(250)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Task Starter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button StartBtn;
        public System.Windows.Forms.Button AddTaskBtn;
        public System.Windows.Forms.TextBox websiteTextBox;
        public System.Windows.Forms.Button removeTaskBtn;
        public System.Windows.Forms.ListBox taskListBox;
        public System.Windows.Forms.Button profileCreateBtn;
        public System.Windows.Forms.TextBox profileNameTextBox;
        public System.Windows.Forms.Button deletProfileBtn;
        public System.Windows.Forms.Button EditBtn;
        public System.Windows.Forms.OpenFileDialog ofd;
        public System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Button AddAppButton;
        private System.Windows.Forms.Button addFolderBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox ProfilesComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

