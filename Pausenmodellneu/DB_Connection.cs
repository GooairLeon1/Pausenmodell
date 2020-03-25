using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Pausenmodell
{
    public class DB_Connection
    {
        private string connectionString;
        public MySqlConnection connection;

        public DB_Connection(string server, string db, string user, string pwd)
        {
            connection = new MySqlConnection();
            connectionString = $"SERVER={server};DATABASE={db};UID={user};PWD={pwd};PORT=3306;";
        }

        public void Open()
        {
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Close()
        {
            connection.Close();
        }

        public DataTable Querry(string querry)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = new MySqlCommand(querry, connection);
            da.Fill(dt);

            return dt;

        }

        public int GetInt(string querry)
        {
            return Int32.Parse(Querry(querry).Rows[0].ItemArray[0].ToString());
        }

        public String GetString(string querry)
        {
            return Querry(querry).Rows[0].ItemArray[0].ToString();
        }

        public DateTime GetDateTime(string querry)
        {
            return DateTime.Parse(GetString(querry));
        }

        public bool UserExist(string user)
        {
            if (Querry($"SELECT Host, User FROM mysql.user WHERE User LIKE '{user}';").Rows.Count != 0)
                return true;

            return false;
        }

        public void CreateUser(string user, string password)
        {
            Querry($"CREATE USER '{user}' IDENTIFIED BY '{password}';");
        }




        public List<string> GetColumn(string querry, int index)
        {
            List<string> l = new List<string>();
            MySqlDataReader reader = new MySqlCommand(querry, connection).ExecuteReader();
            while (reader.Read())
            {
                l.Add(reader[index].ToString());
            }
            reader.Close();
            return l;
        }


 
    }
}
