using EventSourcing.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventSourcing.UserInterface
{
    public partial class AddUserForm : Form
    {
        private AddUserController _controller;
        
        public AddUserForm()
        {
            _controller = new AddUserController();
            InitializeComponent();

            label1.Text = _controller.GuidForNewUser.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.CreateNewUser(textBox1.Text);
        }
    }
}
