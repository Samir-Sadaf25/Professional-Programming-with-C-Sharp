using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDotNet_Example
{
    public class SqlUtility
    {
        private readonly string _connectionString;
        public SqlUtility(string connectionString)
        {
            _connectionString = connectionString;

        }
        public int executeSql(string sql)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            using SqlCommand cmd = new SqlCommand(sql, connection);
            int effected = cmd.ExecuteNonQuery();
            //connection.Close();
            //connection.Dispose();
            //cmd.Dispose();
            return effected;
        }
        public List<Dictionary<string, object>> exicuteSqlQuery(string sql)
        {
            // Create and open a connection; using ensures disposal when leaving this scope
            using SqlConnection connection = new SqlConnection(_connectionString);
            if (connection.State != System.Data.ConnectionState.Open) // connection is Closed initially
                connection.Open(); // open the physical connection to the database

            // Create a command associated with the open connection and the provided SQL text
            using SqlCommand cmd = new SqlCommand(sql, connection);

            // Execute the command and obtain a reader to stream rows from the result set
            SqlDataReader reader = cmd.ExecuteReader();

            // Prepare the container that will hold all result rows
            List<Dictionary<string, object>> data = new List<Dictionary<string, object>>();

            // Read each row in the result set one by one
            while (reader.Read())
            {
                // For the current row create a dictionary that will map column name -> column value
                Dictionary<string, object> row = new Dictionary<string, object>();

                // Iterate every column in the current row by index (0 .. FieldCount-1)
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    // reader.GetName(i) => column name at index i
                    // reader.GetValue(i) => value of that column in the current row as object
                    row.Add(reader.GetName(i), reader.GetValue(i));
                }

                // Add the populated row dictionary to the list of all rows
                data.Add(row);
            }

            // Return the complete list of rows (each row is a dictionary of columnName->value)
            return data;
        }


    }
}
