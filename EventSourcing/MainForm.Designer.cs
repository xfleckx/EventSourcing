namespace EventSourcing
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabAttendances = new System.Windows.Forms.TabPage();
            this.attendanceOverviewControl1 = new EventSourcing.UserInterface.AttendanceOverviewControl();
            this.tabUserManagement = new System.Windows.Forms.TabPage();
            this.userControlUserOverview1 = new EventSourcing.UserInterface.UserControlUserOverview();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.statusStrip1.SuspendLayout();
            this.contextMenuUser.SuspendLayout();
            this.tabAttendances.SuspendLayout();
            this.tabUserManagement.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelConnection});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(594, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelConnection
            // 
            this.toolStripStatusLabelConnection.Name = "toolStripStatusLabelConnection";
            this.toolStripStatusLabelConnection.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabelConnection.Text = "Event Store Connection";
            // 
            // contextMenuUser
            // 
            this.contextMenuUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuUser.Name = "contextMenuUser";
            this.contextMenuUser.Size = new System.Drawing.Size(118, 48);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // tabAttendances
            // 
            this.tabAttendances.Controls.Add(this.attendanceOverviewControl1);
            this.tabAttendances.Location = new System.Drawing.Point(4, 22);
            this.tabAttendances.Name = "tabAttendances";
            this.tabAttendances.Padding = new System.Windows.Forms.Padding(3);
            this.tabAttendances.Size = new System.Drawing.Size(586, 213);
            this.tabAttendances.TabIndex = 2;
            this.tabAttendances.Text = "Attendance";
            this.tabAttendances.UseVisualStyleBackColor = true;
            // 
            // attendanceOverviewControl1
            // 
            this.attendanceOverviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendanceOverviewControl1.Location = new System.Drawing.Point(3, 3);
            this.attendanceOverviewControl1.Name = "attendanceOverviewControl1";
            this.attendanceOverviewControl1.Size = new System.Drawing.Size(580, 207);
            this.attendanceOverviewControl1.TabIndex = 0;
            // 
            // tabUserManagement
            // 
            this.tabUserManagement.Controls.Add(this.userControlUserOverview1);
            this.tabUserManagement.Location = new System.Drawing.Point(4, 22);
            this.tabUserManagement.Name = "tabUserManagement";
            this.tabUserManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserManagement.Size = new System.Drawing.Size(586, 213);
            this.tabUserManagement.TabIndex = 1;
            this.tabUserManagement.Text = "User Management";
            this.tabUserManagement.UseVisualStyleBackColor = true;
            // 
            // userControlUserOverview1
            // 
            this.userControlUserOverview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlUserOverview1.Location = new System.Drawing.Point(3, 3);
            this.userControlUserOverview1.Name = "userControlUserOverview1";
            this.userControlUserOverview1.Size = new System.Drawing.Size(580, 207);
            this.userControlUserOverview1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUserManagement);
            this.tabControl1.Controls.Add(this.tabAttendances);
            this.tabControl1.Location = new System.Drawing.Point(0, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(594, 239);
            this.tabControl1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 261);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuUser.ResumeLayout(false);
            this.tabAttendances.ResumeLayout(false);
            this.tabUserManagement.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConnection;
        private System.Windows.Forms.ContextMenuStrip contextMenuUser;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private UserInterface.AttendanceOverviewControl attendanceOverviewControl;
        private System.Windows.Forms.TabPage tabAttendances;
        private UserInterface.AttendanceOverviewControl attendanceOverviewControl1;
        private System.Windows.Forms.TabPage tabUserManagement;
        private UserInterface.UserControlUserOverview userControlUserOverview1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

