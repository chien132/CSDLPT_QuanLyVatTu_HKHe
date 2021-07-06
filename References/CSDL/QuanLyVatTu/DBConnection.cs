using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace QuanLyVatTu
{
    internal class DBConnection
    {
        public MySqlConnection connection;

        //Constructor
        public DBConnection(string server, string databaseName, string username, string password)
        {
            Initialize(server, databaseName, username, password);
        }

        //Initialize values
        private void Initialize(string server, string databaseName, string username, string password)
        {
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            databaseName + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";CHARSET=UTF8;";
            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        public void Close()
        {
            connection.Close();
        }
    }
}