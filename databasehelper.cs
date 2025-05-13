using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GuiForDentalA
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString = "server=localhost;database=elem_student_information;uid=root;pwd=mysql123;";
        private static MySqlConnection? connection; // Singleton connection instance

        // Method to get or create a single MySqlConnection instance
        public static MySqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(connectionString);
            }

            if (connection.State == System.Data.ConnectionState.Closed || connection.State == System.Data.ConnectionState.Broken)
            {
                connection.Open();
            }

            return connection;
        }

        // Method to test the database connection
        public static void TestDatabaseConnection()
        {
            try
            {
                using (var cnn = new MySqlConnection(connectionString))
                {
                    cnn.Open();
                    MessageBox.Show("Connection Open!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cannot open connection! Error: {ex.Message}");
            }
        }

        // Method to execute a query and return a MySqlDataReader
        public static MySqlDataReader ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            try
            {
                var connection = new MySqlConnection(connectionString); // no singleton
                connection.Open();

                var cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddRange(parameters);

                // CommandBehavior.CloseConnection closes the connection when reader is closed
                return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error executing query: {ex.Message}");
            }
        }


        // Method to execute a non-query command (e.g., INSERT, UPDATE, DELETE)
        public static int ExecuteNonQuery(string query, params MySqlParameter[] parameters)
        {
            try
            {
                using (var cmd = new MySqlCommand(query, GetConnection()))
                {
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error executing non-query: {ex.Message}");
            }
        }

        // Method to close the connection
        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}