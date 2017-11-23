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
using DomainModel.Users;

namespace EventSourcing.UserInterface
{
    public partial class AttendanceOverviewControl : UserControl
    {
        private AttendanceOverviewController controller;
        private IAttendanceRepository attendanceRepository;
        private IUserRepository userRepository;

        public AttendanceOverviewControl()
        {
            controller = new AttendanceOverviewController();

            attendanceRepository = RepositoryManagement.Get<IAttendanceRepository>();
            userRepository = RepositoryManagement.Get<IUserRepository>();

            InitializeComponent();
        }

        private void AttendanceOverviewControl_Load(object sender, EventArgs e)
        {
            if(!DesignMode)
                comboBox.DataSource = userRepository.All;
        }

        private void buttonManuallyCommit_Click(object sender, EventArgs e)
        {
            //var form = new AddCheckIn();

            //form.Controller.CheckInCommited += controller.CheckInCommited;
            //form.Controller.CheckOutCommited += controller.CheckOutCommited;

            //form.Show();
        }

        private void comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;

            var user = comboBox.SelectedValue as User;

            if (user == null)
                return;

            var attendances = attendanceRepository.GetAllForUser(user.Guid);

            dataGridViewOverview.DataSource = attendances;
        }
    }
}