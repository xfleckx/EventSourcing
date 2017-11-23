using EventSourcing.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventSourcing
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var attendanceRepo = new JsonPersistence.AttendanceRepository(new System.IO.FileInfo("attendance.repository"));

            RepositoryManagement.AttendanceRepository = attendanceRepo;

            var userRepo = new JsonPersistence.UserRepository(new System.IO.FileInfo("user.repository"));
            RepositoryManagement.UserRepository = userRepo;

            Application.Run(new MainForm());

            userRepo.Save();
            attendanceRepo.Save();
        }
    }
}
