using System;
using System.Collections.Generic;
using APItask.Models;
using Microsoft.Data.Sqlite;

namespace APItask.Infrastructure
{
    public class DB
    {
        private readonly SqliteConnection _dbConnection;

        public DB()
        {
            string projectPath = Environment.CurrentDirectory;

            _dbConnection = new SqliteConnection("Data Source=" + projectPath + "\\APIvalues.db;");

            //_dbConnection = new SqliteConnection("Data Source=C:\\sqlite\\CoinValues.db;");
            try
            {
                _dbConnection.Open();
            }
            catch (Exception ex) { }
        }
        public void RunQuery(string query)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();
                SqliteCommand _dbCommand;
                _dbCommand = _dbConnection.CreateCommand();
                _dbCommand.CommandText = query;
                _dbCommand.ExecuteNonQuery();
            }
        }
        public List<string> SelectIDs()
        {
            using (_dbConnection)
            {
                _dbConnection.Open();
                SqliteCommand _dbCommand;
                _dbCommand = _dbConnection.CreateCommand();
                _dbCommand.CommandText = "SELECT ID FROM APIvalues";
                var reader = _dbCommand.ExecuteReader();

                List<string> IDs = new List<string>();

                while (reader.Read())
                {
                    IDs.Add(!reader.IsDBNull(0) ? reader.GetString(0) : "");
                }

                return IDs;
            }
        }
        public List<Cloud> Select(int pageNumber = 0, int pageSize = 5)
        {
            using (_dbConnection)
            {
                SqliteCommand _dbCommand;
                _dbCommand = _dbConnection.CreateCommand();
                _dbCommand.CommandText = $"SELECT * FROM APIvalues LIMIT {pageSize} OFFSET {pageNumber * pageSize}";

                var dataReader = _dbCommand.ExecuteReader();
                var clouds = new List<Cloud>();

                while (dataReader.Read())
                {
                    clouds.Add(new Cloud
                    {
                        Id = !dataReader.IsDBNull(0) ? dataReader.GetString(0) : "",
                        Name = !dataReader.IsDBNull(1) ? dataReader.GetString(1) : "",
                        Date = !dataReader.IsDBNull(2) ? dataReader.GetString(2) : "",
                        Comment = !dataReader.IsDBNull(3) ? dataReader.GetString(3) : ""
                    });
                }
                return clouds;
            }
        }
        public List<Cloud> Select(Cloud cloud, int pageNumber = 0, int pageSize = 0)
        {
            using (_dbConnection)
            {
                var parsedApiId = 0;
                int.TryParse(cloud.Id, out parsedApiId);

                SqliteCommand _dbCommand;
                _dbCommand = _dbConnection.CreateCommand();
                _dbCommand.CommandText = $@"SELECT * 
                                            FROM APIvalues 
                                            WHERE (id = {parsedApiId}) OR (Name like '%{cloud.Name}%') OR (DATE = '{cloud.Date}') OR (COMMENT LIKE '%{cloud.Comment}%')
                                            LIMIT {pageSize} OFFSET {pageNumber * pageSize}";

                var dataReader = _dbCommand.ExecuteReader();
                var clouds = new List<Cloud>();

                while (dataReader.Read())
                {
                    clouds.Add(new Cloud
                    {
                        Id = !dataReader.IsDBNull(0) ? dataReader.GetString(0) : "",
                        Name = !dataReader.IsDBNull(1) ? dataReader.GetString(1) : "",
                        Date = !dataReader.IsDBNull(2) ? dataReader.GetString(2) : "",
                        Comment = !dataReader.IsDBNull(3) ? dataReader.GetString(3) : ""
                    });
                }
                return clouds;
            }
        }
        public void Delete()
        {
            using (_dbConnection)
            {
                _dbConnection.Open();
                SqliteCommand _dbCommand;
                _dbCommand = _dbConnection.CreateCommand();
                _dbCommand.CommandText = "DELETE FROM APIvalues";
                _dbCommand.ExecuteNonQuery();
            }
        }
    }
}
