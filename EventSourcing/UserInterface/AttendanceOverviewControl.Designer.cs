namespace EventSourcing.UserInterface
{
    partial class AttendanceOverviewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dataGridViewOverview = new System.Windows.Forms.DataGridView();
            this.panelLowerHalf = new System.Windows.Forms.Panel();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.buttonManuallyCommit = new System.Windows.Forms.Button();
            this.buttonCommitAttendanceChange = new System.Windows.Forms.Button();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOverview)).BeginInit();
            this.panelLowerHalf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.dataGridViewOverview);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelLowerHalf);
            this.splitContainer.Size = new System.Drawing.Size(566, 279);
            this.splitContainer.SplitterDistance = 244;
            this.splitContainer.TabIndex = 0;
            // 
            // dataGridViewOverview
            // 
            this.dataGridViewOverview.AllowUserToAddRows = false;
            this.dataGridViewOverview.AllowUserToDeleteRows = false;
            this.dataGridViewOverview.AutoGenerateColumns = false;
            this.dataGridViewOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOverview.DataSource = this.attendanceBindingSource;
            this.dataGridViewOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOverview.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOverview.Name = "dataGridViewOverview";
            this.dataGridViewOverview.Size = new System.Drawing.Size(566, 244);
            this.dataGridViewOverview.TabIndex = 1;
            // 
            // panelLowerHalf
            // 
            this.panelLowerHalf.Controls.Add(this.comboBox);
            this.panelLowerHalf.Controls.Add(this.buttonManuallyCommit);
            this.panelLowerHalf.Controls.Add(this.buttonCommitAttendanceChange);
            this.panelLowerHalf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLowerHalf.Location = new System.Drawing.Point(0, 0);
            this.panelLowerHalf.Name = "panelLowerHalf";
            this.panelLowerHalf.Size = new System.Drawing.Size(566, 31);
            this.panelLowerHalf.TabIndex = 0;
            // 
            // comboBox
            // 
            this.comboBox.DataSource = this.userBindingSource;
            this.comboBox.DisplayMember = "Nick";
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(4, 4);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(152, 21);
            this.comboBox.TabIndex = 5;
            this.comboBox.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            // 
            // buttonManuallyCommit
            // 
            this.buttonManuallyCommit.Location = new System.Drawing.Point(473, 3);
            this.buttonManuallyCommit.Name = "buttonManuallyCommit";
            this.buttonManuallyCommit.Size = new System.Drawing.Size(90, 23);
            this.buttonManuallyCommit.TabIndex = 4;
            this.buttonManuallyCommit.Text = "More";
            this.buttonManuallyCommit.UseVisualStyleBackColor = true;
            this.buttonManuallyCommit.Click += new System.EventHandler(this.buttonManuallyCommit_Click);
            // 
            // buttonCommitAttendanceChange
            // 
            this.buttonCommitAttendanceChange.Location = new System.Drawing.Point(392, 3);
            this.buttonCommitAttendanceChange.Name = "buttonCommitAttendanceChange";
            this.buttonCommitAttendanceChange.Size = new System.Drawing.Size(75, 23);
            this.buttonCommitAttendanceChange.TabIndex = 0;
            this.buttonCommitAttendanceChange.Text = "Commit";
            this.buttonCommitAttendanceChange.UseVisualStyleBackColor = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(DomainModel.Users.User);
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataSource = typeof(DomainModel.Attendance.Attendance);
            // 
            // AttendanceOverviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Name = "AttendanceOverviewControl";
            this.Size = new System.Drawing.Size(566, 279);
            this.Load += new System.EventHandler(this.AttendanceOverviewControl_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOverview)).EndInit();
            this.panelLowerHalf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dataGridViewOverview;
        private System.Windows.Forms.Panel panelLowerHalf;
        private System.Windows.Forms.Button buttonCommitAttendanceChange;
        private System.Windows.Forms.Button buttonManuallyCommit;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
    }
}
