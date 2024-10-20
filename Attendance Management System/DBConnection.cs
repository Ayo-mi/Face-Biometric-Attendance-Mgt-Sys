using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Attendance_Management_System
{
    class DBConnection
    {
        private DBString connStr;
        internal DBConnection()
        {
            connStr = new DBString();
            Server = connStr.Server;
            DatabaseName = connStr.Database;
            UserName = connStr.User;
            Password = connStr.Password;
        }

        public string Server { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public MySqlConnection Connection { get; set; }

        private static DBConnection _instance = null;
        public static DBConnection Instance()
        {
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        public bool IsConnect()
        {
            try
            {            
                if (Connection == null)
                {
                    if (String.IsNullOrEmpty(DatabaseName))
                        return false;
                    string connstring = string.Format("Server={0}; port=3308; database={1}; UID={2}; password={3}", Server, DatabaseName, UserName, Password);
                    Connection = new MySqlConnection(connstring);
                    Connection.Open();
                }
                if (Connection.State == System.Data.ConnectionState.Closed)
                    Open();
            }catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "Database Connection Error");
                return false;
            }
            return true;
        }

        public void Close()
        {
            Connection.Close();
        }

        public void Open()
        {
            Connection.Open();
        }

        public Object Select(String stmt, Hashtable attr)
        {
            MySqlDataReader data = null;
            if (IsConnect())
            {
                try
                {
                    string cmdText = stmt;
                    MySqlCommand cmd = new MySqlCommand(cmdText, Connection);
                    if(attr.Count > 0)
                    {
                        foreach(DictionaryEntry element in attr)
                        {
                            cmd.Parameters.AddWithValue((string)element.Key, element.Value);
                        }
                    }
                    //

                     data = cmd.ExecuteReader();
                                      
                }
                catch (MySqlException ex)
                {
                    //MessageBox.Show(ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("No connection found, check your server is running properly and try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return data;
        }

        public bool Operation(String stmt, Hashtable attr)
        {
            bool status = false;

            if (IsConnect())
            {
                try
                {
                    string cmdText = stmt;
                    MySqlCommand cmd = new MySqlCommand(cmdText, Connection);

                    if (attr.Count > 0)
                    {
                        foreach (DictionaryEntry element in attr)
                        {
                            cmd.Parameters.AddWithValue((string)element.Key, element.Value);
                        }
                    }
                    //cmd.Parameters.AddWithValue("@id", StuId);
                    //cmd.Parameters.AddWithValue("@psw", psw1.Text.Trim());

                    int row = cmd.ExecuteNonQuery();

                    if (row > 0)
                    {
                        status = true;
                    }
                    else
                    {
                        status = false;
                    }

                    Close();
                }
                catch (MySqlException e)
                {
                    //MessageBox.Show(e.Message, "Error");
                    status = false;
                }
            }
            else
            {
                MessageBox.Show("No connection found, check your server is running properly and try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return status;
        }

        public string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }

    }
}
