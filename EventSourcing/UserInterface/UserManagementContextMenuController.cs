using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainModel.Users;

namespace EventSourcing.UserInterface
{
    public class UserManagementContextMenuController
    {
        public IEnumerable<User> SelectedUsers { get; internal set; }

        public void OnItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        internal void OnOpening(object sender, CancelEventArgs e)
        {


        }
    }
}
