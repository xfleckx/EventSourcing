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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dataGridViewOverview = new System.Windows.Forms.DataGridView();
            this.UserColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HourBalanceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelLowerHalf = new System.Windows.Forms.Panel();
            this.buttonManuallyCommit = new System.Windows.Forms.Button();
            this.comboBoxReason = new System.Windows.Forms.ComboBox();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.buttonCommitAttendanceChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOverview)).BeginInit();
            this.panelLowerHalf.SuspendLayout();
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
            this.dataGridViewOverview.AllowUserToDeleteRows = false;
            this.dataGridViewOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserColumn,
            this.AttendanceColumn,
            this.HourBalanceColumn});
            this.dataGridViewOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOverview.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOverview.Name = "dataGridViewOverview";
            this.dataGridViewOverview.Size = new System.Drawing.Size(566, 244);
            this.dataGridViewOverview.TabIndex = 1;
            // 
            // UserColumn
            // 
            this.UserColumn.HeaderText = "User";
            this.UserColumn.Name = "UserColumn";
            this.UserColumn.ReadOnly = true;
            // 
            // AttendanceColumn
            // 
            this.AttendanceColumn.HeaderText = "Current Month";
            this.AttendanceColumn.Name = "AttendanceColumn";
            this.AttendanceColumn.ReadOnly = true;
            // 
            // HourBalanceColumn
            // 
            this.HourBalanceColumn.HeaderText = "Balance";
            this.HourBalanceColumn.Name = "HourBalanceColumn";
            this.HourBalanceColumn.ReadOnly = true;
            // 
            // panelLowerHalf
            // 
            this.panelLowerHalf.Controls.Add(this.buttonManuallyCommit);
            this.panelLowerHalf.Controls.Add(this.comboBoxReason);
            this.panelLowerHalf.Controls.Add(this.comboBoxMode);
            this.panelLowerHalf.Controls.Add(this.comboBoxUser);
            this.panelLowerHalf.Controls.Add(this.buttonCommitAttendanceChange);
            this.panelLowerHalf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLowerHalf.Location = new System.Drawing.Point(0, 0);
            this.panelLowerHalf.Name = "panelLowerHalf";
            this.panelLowerHalf.Size = new System.Drawing.Size(566, 31);
            this.panelLowerHalf.TabIndex = 0;
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
            // comboBoxReason
            // 
            this.comboBoxReason.FormattingEnabled = true;
            this.comboBoxReason.Location = new System.Drawing.Point(232, 3);
            this.comboBoxReason.Name = "comboBoxReason";
            this.comboBoxReason.Size = new System.Drawing.Size(154, 21);
            this.comboBoxReason.TabIndex = 3;
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Location = new System.Drawing.Point(131, 3);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(95, 21);
            this.comboBoxMode.TabIndex = 2;
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(4, 3);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUser.TabIndex = 1;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dataGridViewOverview;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HourBalanceColumn;
        private System.Windows.Forms.Panel panelLowerHalf;
        private System.Windows.Forms.ComboBox comboBoxReason;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Button buttonCommitAttendanceChange;
        private System.Windows.Forms.Button buttonManuallyCommit;
    }
}
