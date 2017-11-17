using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainModel.Repositories;
using EventSourcing.JsonPersistence;
using System.IO;

namespace EventSourcing.UserInterface
{
    public partial class AttendanceOverviewControl : UserControl
    {
        private AttendanceOverviewController _controller;
        private IAttendanceRepository _model;

        public AttendanceOverviewControl()
        {
            _controller = new AttendanceOverviewController();

            _model = new AttendanceRepository(new FileInfo("attendance.repository"));

            InitializeComponent();
        }

        private void AttendanceOverviewControl_Load(object sender, EventArgs e)
        {

        }

        private void buttonManuallyCommit_Click(object sender, EventArgs e)
        {

        }
    }
}
