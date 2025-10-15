using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDotNet_Example
{
    public class SqlUtility : IDisposable
    {
        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataReader _reader;
        public SqlUtility(string connectionString)
        {
            _connection = new SqlConnection(connectionString);

            if (_connection.State != System.Data.ConnectionState.Open) // connection is Closed initially
                _connection.Open();

        }

        public void Dispose()
        {
            _connection.Dispose();
            _command.Dispose();
            _reader.DisposeAsync();
        }

        public int executeSql(string sql, Dictionary<string, object>? sqlParameters = null)
        {
            _command = createCommand(sql, sqlParameters);
            int effected = _command.ExecuteNonQuery();
            //connection.Close();
            //connection.Dispose();
            //_command.Dispose();
            return effected;
        }
        public List<Dictionary<string, object>> exicuteSqlQuery(string sql, Dictionary<string, object>? sqlParameters = null)
        {
            _command = createCommand(sql, sqlParameters);


            // Execute the command and obtain a reader to stream rows from the result set
            _reader = _command.ExecuteReader();

            // Prepare the container that will hold all result rows
            List<Dictionary<string, object>> data = new List<Dictionary<string, object>>();

            // Read each row in the result set one by one
            while (_reader.Read())
            {
                // For the current row create a dictionary that will map column name -> column value
                Dictionary<string, object> row = new Dictionary<string, object>();

                // Iterate every column in the current row by index (0 .. FieldCount-1)
                for (int i = 0; i < _reader.FieldCount; i++)
                {
                    // reader.GetName(i) => column name at index i
                    // reader.GetValue(i) => value of that column in the current row as object
                    row.Add(_reader.GetName(i), _reader.GetValue(i));
                }

                // Add the populated row dictionary to the list of all rows
                data.Add(row);
            }

            // Return the complete list of rows (each row is a dictionary of columnName->value)
            return data;
        }

        private SqlCommand createCommand(string sql, Dictionary<string, object>? sqlParameters)
        {


            // Create a command associated with the open connection and the provided SQL text
            SqlCommand _command = new SqlCommand(sql, _connection);
            foreach (var item in sqlParameters)
            {
                _command.Parameters.Add(new SqlParameter(item.Key, item.Value));
            }
            return _command;
        }
    }
}
