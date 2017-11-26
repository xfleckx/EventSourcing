using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EventStore.ClientAPI;
using EventSourcing.Commands;
using EventSourcing.Reactors;
using EventSourcing.DomainEvents;
using EventSourcing.UserInterface;
using DomainModel.Users;
using Newtonsoft.Json;

namespace EventSourcing
{
    public partial class MainForm : Form
    {
        private CounterReactor<DemoCommandApplied> counterReactor;
        private IEventStoreConnection _connection;
        private Queue<ADomainEvent> eventCache;

        public MainForm()
        {
            eventCache = new Queue<ADomainEvent>();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var connection = EventStoreConnection.Create(new Uri("tcp://worker:test1234@localhost:1113"));

            connection.Connected += Connection_Connected;
            connection.AuthenticationFailed += Connection_AuthenticationFailed;
            connection.Disconnected += Connection_Disconnected;
            connection.ErrorOccurred += Connection_ErrorOccurred;
            connection.Closed += Connection_Closed;

            var t = connection.ConnectAsync();
        }

        #region Connection callbacks

        private void Connection_Disconnected(object sender, ClientConnectionEventArgs e)
        {
            _connection = null;
            toolStripStatusLabelConnection.Text = $"{e.Connection} to {e.RemoteEndPoint} disconnected";
        }

        private void Connection_ErrorOccurred(object sender, ClientErrorEventArgs e)
        {
            toolStripStatusLabelConnection.Text = $"{e.Connection} failed with {e.Exception}";
        }

        private void Connection_Closed(object sender, ClientClosedEventArgs e)
        {
            toolStripStatusLabelConnection.Text = $"{e.Connection} closed due to  {e.Reason}";
        }

        private void Connection_AuthenticationFailed(object sender, ClientAuthenticationFailedEventArgs e)
        {

            toolStripStatusLabelConnection.Text = $"{e.Connection} failed due to {e.Reason}";
        }

        private void Connection_Connected(object sender, ClientConnectionEventArgs e)
        {
            ReactorProvider.Initialize(e.Connection);

            _connection = e.Connection;
             
            while (eventCache.Any())
            {
                AppendToEventStream(eventCache.Dequeue());
            } 

            toolStripStatusLabelConnection.Text = $"{e.Connection} to {e.RemoteEndPoint} established";
        }

        #endregion

        #region UI Callbacks


        private void button1_Click(object sender, EventArgs e)
        {
            var demo = new DemoCommand("fizz", "buzz");

            demo.CommandSuccessfullApplied += ForwardToEventStore;

            demo.Execute();
        }

        private void ForwardToEventStore(ADomainEvent obj)
        {
            if (_connection == null)
            {
                eventCache.Enqueue(obj);
            }
            else
            {
                AppendToEventStream(obj);
            }
        }

        private void AppendToEventStream(ADomainEvent obj)
        {
            var eventAsJson = JsonConvert.SerializeObject(obj);

            var domainEventType = obj.EventTypeName;

            var domainStream = obj.DomainStreamName;

            var jsonAsBytes = Encoding.UTF8.GetBytes(eventAsJson);
            
            var type = obj.GetType();

            var metaData = new EventMetaData() { 
                TypeIdentifier = type.GetType().FullName,
                AssemblyVersion = type.AssemblyQualifiedName
            };

            var metaDataAsJson = JsonConvert.SerializeObject(metaData);

            var metaDataAsBytes = Encoding.UTF8.GetBytes(metaDataAsJson);
            
            var @event = new EventData(obj.Guid, 
                                        domainEventType, 
                                        true,
                                        jsonAsBytes,
                                        metaDataAsBytes);
            
            _connection.AppendToStreamAsync(domainStream,
                                           ExpectedVersion.Any, 
                                           @event).Wait();
        }

        private void buttonToogleReactor_Click(object sender, EventArgs e)
        {
            counterReactor = ReactorProvider.GetReactor<CounterReactor<DemoCommandApplied>>();
            counterReactor.CountChanged += renderEventCount;
            counterReactor.AttachToStream();
        }

        private void renderEventCount(int count)
        {
            //if (InvokeRequired)
            //    Invoke(new Action(() => { labelEventCount.Text = $"Count of Demo Commands: {count}"; }));
                
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            //var task = Task.Run()
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //var gridView = sender as DataGridView;
            //var users = gridView.SelectedRows.Cast<User>();

            //var userManagementController = new UserManagementContextMenuController()
            //{
            //    SelectedUsers = users
            //};

            //contextMenuUser.Opening += userManagementController.OnOpening;
            //contextMenuUser.ItemClicked += userManagementController.OnItemClicked;

            contextMenuUser.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AddUserForm();

            form.Show();
        }
        
    }
    
}
