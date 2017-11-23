using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EventSourcing.UserInterface
{
    public partial class AttendanceChangeUserControl : UserControl
    {
        public AttendanceChangeUserControl()
        {
            controller = new CheckInController();
            InitializeComponent();

            presets = new List<string>()
            {
                "None",
                "Dienstgang",
                ""
            };
        }

        CheckInController controller;
        IEnumerable<string> presets;
         
        public CheckInController Controller { get => controller; }
        public IEnumerable<string> Presets { get => presets; }


        private void buttonCommit_Click(object sender, EventArgs e)
        {
            controller.CommitIn(GetTimeStamp(), textBox1.Text);
        }

        private DateTime GetTimeStamp()
        {
            var time = DateTime.Parse(maskedTextBox1.Text);

            var timeStamp = dateTimePicker1.Value;

            timeStamp = timeStamp.AddHours(time.Hour);
            timeStamp = timeStamp.AddMinutes(time.Minute);

            return timeStamp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.CommitOut(GetTimeStamp(), textBox1.Text);
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox.Text;
        }

        private void AddCheckIn_Load(object sender, EventArgs e)
        {
            comboBox.DataSource = presets;
        }


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
