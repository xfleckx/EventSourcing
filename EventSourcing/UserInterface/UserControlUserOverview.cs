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
using DomainModel.Users;
using EventSourcing.Commands;
using EventSourcing.DomainEvents;

namespace EventSourcing.UserInterface
{
    public partial class UserControlUserOverview : UserControl
    {
        IUserRepository repository;
        UserOverviewController controller;
        CreateUserCommand createUserCommand;

        public UserOverviewController Controller { get => controller; }

        public UserControlUserOverview()
        {
            InitializeComponent();

            controller = new UserOverviewController();
        }
        
        private void UserControlUserOverview_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            repository = RepositoryManagement.Get<IUserRepository>();

            createUserCommand = new CreateUserCommand(repository);

            userBindingSource.DataSource = repository.All;
        }

        private void dataGridViewUsers_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            Console.Write("Row added");
        }

        private void dataGridViewUsers_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {
            
            Console.Write("Row needed");
        }

        private void dataGridViewUsers_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            Console.Write("CellValue needed");
            if (e.ColumnIndex == 2)
                e.Value = Guid.NewGuid();
        }

        private void dataGridViewUsers_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {

            Console.Write("CellValue pushed");
        }

        private void userBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {

        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            // shortcut for testing...
            createUserCommand.CommandSuccessfullApplied += 
                CreateUserCommand_CommandSuccessfullApplied;

            createUserCommand.Execute();
        }

        private void CreateUserCommand_CommandSuccessfullApplied(DomainEvents.UserCreatedEvent obj)
        {
            var createdEvent = obj as UserCreatedEvent;

            repository.Add(new User() {
                Guid = createdEvent.UserId,
                Name = createdEvent.Name,
                Nick = createdEvent.Nick
            });

            dataGridViewUsers.DataSource = repository.All;
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            CreateGuidIfNecessary();
            
            createUserCommand.Name = textBox2.Text;
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            CreateGuidIfNecessary();

            createUserCommand.Nick = textBox1.Text;
        }

        private void CreateGuidIfNecessary()
        {
            if (createUserCommand.Guid == null || createUserCommand.Guid == Guid.Empty)
            {
                createUserCommand.Guid = Guid.NewGuid();

                textBox3.Text = createUserCommand.Guid.ToString();
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;

            e.Cancel = !repository.NameAvailable(tb.Text);
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;

            e.Cancel = !repository.NickAvailable(tb.Text);
        }

        private void buttonAddUser_Validating(object sender, CancelEventArgs e)
        {
            //e.Cancel = !createUserCommand.Validate(null);
        }

        private void buttonAddUser_Validated(object sender, EventArgs e)
        {
        }
    }
}
