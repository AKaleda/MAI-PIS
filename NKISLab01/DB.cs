using System.Data;
using MySql.Data.MySqlClient;

namespace NKISLab01
{
    //internal class DB
    public class DB
    {
        const String connStringDefault = "Server=localhost" + ";Database=dev"
                            + ";port=3306" + ";User Id=dev" + ";password=userdev";
        MySqlConnection conn;

        public DB(String connString)               // Конструктор класса DB
        {
            if (connString == "") connString = connStringDefault;
            conn = new MySqlConnection(connString);
        }

        public void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }

        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }

        public MySqlConnection getConnection()
        {
            return conn;
        }

        public DataTable GetTableData(String sqlCommand)
        {
            openConnection();
            MySqlCommand cmd = new MySqlCommand();  // Создать объект Command
            cmd.Connection = conn;                  // Связать Command с Connection
            cmd.CommandText = sqlCommand;
            var adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            //table.Locale = System.Globalization.CultureInfo.InvariantCulture;

            adapter.Fill(table);
            adapter.Dispose();
            return table;
        }

        public int Operation(String sqlCommand)
        {
            openConnection();
            int rowCount = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;                  // Связать Command с Connection
            cmd.CommandText = sqlCommand;
            //MessageBox.Show(sqlCommand);
            try
            {
                rowCount = cmd.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Operation: " + ee.Message);
            }
            return rowCount;
        }
    }
}
