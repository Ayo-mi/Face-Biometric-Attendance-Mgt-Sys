using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management_System
{
    class DBString
    {
        private string server_name = "localhost";
        private string user = "root";
        private string password = "Pa$$w0rd@5";
        private string database = "attenance_mgt";


        public string Server
        {
            get { return server_name; }
        }

        public string User
        {
            get { return user; }
        }

        public string Password
        {
            get { return password; }
        }

        public string Database
        {
            get { return database; }
        }
    }
}
