using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace DbWebProject
{
    public class DbConnection
    {
        private string DbName;
        private MySqlConnection cnn;
        private string connectionString = null;
        private MySqlCommand mySqlCommand;
        private MySqlDataReader reader;
        private MySqlDataAdapter adapter;



        public DbConnection(string dbName)
        {
            this.DbName = dbName;
            this.connectionString = "server=localhost;database=" + DbName + ";uid=root;pwd=hamedfarahi9223;";
            this.cnn = new MySqlConnection(connectionString);

        }
        /*
        public MySqlDataReader mySqlDataReader(string values,string table)
        {
           

            try
            {
                cnn.Open();
                mySqlCommand = new MySqlCommand("select " + values + " from " + table, cnn);
                try
                {
                    reader.Close();
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }
                catch
                {
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }

            }
            catch
            {
                mySqlCommand = new MySqlCommand("select " + values + " from " + table, cnn);
                try
                {
                    reader.Close();
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }
                catch
                {
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }

            }
        }
        */
        public MySqlDataReader mySqlDataReader(string query, string param1)
        {
            try
            {
                cnn.Open();
                mySqlCommand = new MySqlCommand(query, cnn);
                mySqlCommand.Parameters.AddWithValue("@f", param1);
                try
                {
                    reader.Close();
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }
                catch
                {
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }

            }
            catch
            {
                mySqlCommand = new MySqlCommand(query, cnn);
                mySqlCommand.Parameters.AddWithValue("@f", param1);
                try
                {
                    reader.Close();
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }
                catch
                {
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }

            }
        }

        public MySqlDataAdapter mySqlDataAdapter(string query, string param1)
        {
            try
            {
                cnn.Open();
                mySqlCommand = new MySqlCommand(query, cnn);
                mySqlCommand.Parameters.AddWithValue("@f", param1);
                try
                {
                    adapter.Dispose();
                    adapter = new MySqlDataAdapter(mySqlCommand);
                    return adapter;
                }
                catch
                {
                    adapter = new MySqlDataAdapter(mySqlCommand);
                    return adapter;
                }

            }
            catch
            {
                mySqlCommand = new MySqlCommand(query, cnn);
                mySqlCommand.Parameters.AddWithValue("@f", param1);
                try
                {
                    adapter.Dispose();
                    adapter = new MySqlDataAdapter(mySqlCommand);
                    return adapter;
                }
                catch
                {
                    adapter = new MySqlDataAdapter(mySqlCommand);
                    return adapter;
                }

            }
        }
        public MySqlDataReader mySqlDataReader(string query, string param1, string param2)
        {
            try
            {
                cnn.Open();
                mySqlCommand = new MySqlCommand(query, cnn);
                mySqlCommand.Parameters.AddWithValue("@f", param1);
                mySqlCommand.Parameters.AddWithValue("@b", param2);
                try
                {
                    reader.Close();
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }
                catch
                {
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }

            }
            catch
            {
                mySqlCommand = new MySqlCommand(query, cnn);

                mySqlCommand.Parameters.AddWithValue("@f", param1);
                mySqlCommand.Parameters.AddWithValue("@b", param2);
                try
                {
                    reader.Close();
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }
                catch
                {
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }

            }
        }

        public MySqlDataReader mySqlDataReader(string query, string param1, string param2, string param3)
        {
            try
            {
                cnn.Open();
                mySqlCommand = new MySqlCommand(query, cnn);
                try
                {
                    reader.Close();
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }
                catch
                {
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }

            }
            catch
            {
                mySqlCommand = new MySqlCommand(query, cnn);
                try
                {
                    reader.Close();
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }
                catch
                {
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }

            }
        }

        public MySqlDataReader mySqlDataReader(string query, string param1, string param2, string param3, string param4)
        {
            try
            {
                cnn.Open();
                mySqlCommand = new MySqlCommand(query, cnn);
                mySqlCommand.Parameters.AddWithValue("@a", param1);
                mySqlCommand.Parameters.AddWithValue("@b", param2);
                mySqlCommand.Parameters.AddWithValue("@c", param3);
                mySqlCommand.Parameters.AddWithValue("@d", param4);
                try
                {
                    reader.Close();
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }
                catch
                {
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }

            }
            catch
            {
                mySqlCommand = new MySqlCommand(query, cnn);
                mySqlCommand.Parameters.AddWithValue("@a", param1);
                mySqlCommand.Parameters.AddWithValue("@b", param2);
                mySqlCommand.Parameters.AddWithValue("@c", param3);
                mySqlCommand.Parameters.AddWithValue("@d", param4);
                mySqlCommand.Parameters.AddWithValue("@f", 0);

                try
                {
                    reader.Close();
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }
                catch
                {
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }

            }
        }

        public MySqlDataReader mySqlDataReader(string query, string param1, string param2, string param3, string param4, string param5, string param6)
        {
            try
            {
                cnn.Open();
                mySqlCommand = new MySqlCommand(query, cnn);
                mySqlCommand.Parameters.AddWithValue("@a", param1);
                mySqlCommand.Parameters.AddWithValue("@b", param2);
                mySqlCommand.Parameters.AddWithValue("@c", param3);
                mySqlCommand.Parameters.AddWithValue("@d", param4);
                mySqlCommand.Parameters.AddWithValue("@f", param5);
                mySqlCommand.Parameters.AddWithValue("@g", param6);
                try
                {
                    reader.Close();
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }
                catch
                {
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }

            }
            catch
            {
                mySqlCommand = new MySqlCommand(query, cnn);
                mySqlCommand.Parameters.AddWithValue("@a", param1);
                mySqlCommand.Parameters.AddWithValue("@b", param2);
                mySqlCommand.Parameters.AddWithValue("@c", param3);
                mySqlCommand.Parameters.AddWithValue("@d", param4);
                mySqlCommand.Parameters.AddWithValue("@f", param5);
                mySqlCommand.Parameters.AddWithValue("@g", param6);
                try
                {
                    reader.Close();
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }
                catch (Exception)
                {
                    try
                    {
                        reader = mySqlCommand.ExecuteReader();
                        return reader;
                    }
                    catch
                    {
                        return null;
                    }

                }


            }
        }



        public MySqlDataReader mySqlDataReader(string query, string param1, string param2, string param3, string param4, string param5)
        {
            try
            {
                cnn.Open();
                mySqlCommand = new MySqlCommand(query, cnn);
                mySqlCommand.Parameters.AddWithValue("@a", param1);
                mySqlCommand.Parameters.AddWithValue("@b", param2);
                mySqlCommand.Parameters.AddWithValue("@c", param3);
                mySqlCommand.Parameters.AddWithValue("@d", param4);
                mySqlCommand.Parameters.AddWithValue("@f", param5);
                try
                {
                    reader.Close();
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }
                catch
                {
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }

            }
            catch
            {
                mySqlCommand = new MySqlCommand(query, cnn);
                mySqlCommand.Parameters.AddWithValue("@a", param1);
                mySqlCommand.Parameters.AddWithValue("@b", param2);
                mySqlCommand.Parameters.AddWithValue("@c", param3);
                mySqlCommand.Parameters.AddWithValue("@d", param4);
                mySqlCommand.Parameters.AddWithValue("@f", param5);
                try
                {
                    reader.Close();
                    reader = mySqlCommand.ExecuteReader();
                    return reader;
                }
                catch (Exception)
                {
                    try
                    {
                        reader = mySqlCommand.ExecuteReader();
                        return reader;
                    }
                    catch
                    {
                        return null;
                    }

                }


            }
        }








        public void Closing()
        {
            cnn.Close();
        }


    }
}