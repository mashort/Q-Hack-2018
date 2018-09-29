using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Q_Hack_2018.Core.Entities;

namespace Q_Hack_2018.Infrastructure.Data
{
    public class DAL
    {
        private string dbConn { get; set; }

        public DAL()
        {
            dbConn = new Connection().GetDbConnection();
        }

        public string GetBearerToken()
        {
            string returnVal = string.Empty;

            using (var connection = new SqlConnection(dbConn))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "dbo.GetSetting";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@name", SqlDbType.VarChar);
                command.Parameters["@name"].Value = "BearerToken";

                command.Connection = connection;

                connection.Open();

                var bearer = command.ExecuteScalar();
                returnVal = bearer.ToString();

                //using (var reader = command.ExecuteReader())
                //{
                //    while (reader.Read())
                //    {
                //        //locationList.Add(new Location { LocationNameId = reader.GetByte(0), LocationName = reader.GetString(1) });
                //    }
                //}
            }

            return returnVal;
        }

        public Dictionary<int, Category> GetCategories()
        {
            Dictionary<int, Category> returnVal = new Dictionary<int, Category>();

            using (var connection = new SqlConnection(dbConn))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "dbo.GetCategories";
                command.CommandType = CommandType.StoredProcedure;

                command.Connection = connection;

                connection.Open();
                
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);

                        returnVal.Add(id, new Category(id, name));
                    }
                }
            }

            return returnVal;
        }

        public Dictionary<string, int> GetCategorisationMatches()
        {
            Dictionary<string, int> returnVal = new Dictionary<string, int>();

            using (var connection = new SqlConnection(dbConn))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "dbo.GetCategorisationMatches";
                command.CommandType = CommandType.StoredProcedure;

                command.Connection = connection;

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string textMatch = reader.GetString(1);
                        int categoryID = reader.GetInt32(2);

                        returnVal.Add(textMatch, categoryID);
                    }
                }
            }

            return returnVal;

        }

        public Dictionary<string, TransactionType> GetTransactionTypes()
        {
            Dictionary<string, TransactionType> returnVal = new Dictionary<string, TransactionType>();

            using (var connection = new SqlConnection(dbConn))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "dbo.GetTransactionTypes";
                command.CommandType = CommandType.StoredProcedure;

                command.Connection = connection;

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        bool? process = reader.IsDBNull(2) ? (bool?) null : reader.GetBoolean(2);
                        int? hardCategoryID = reader.IsDBNull(3) ? (int?) null : reader.GetInt32(3);

                        TransactionType tt = new TransactionType(id, name, process, hardCategoryID);

                        returnVal.Add(name, tt);
                    }
                }
            }

            return returnVal;
        }

        public void InsertGivingHistory(decimal GivenAmount)
        {
            using (var connection = new SqlConnection(dbConn))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "dbo.InsertGivingHistory";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@givenAmount", SqlDbType.VarChar);
                command.Parameters["@givenAmount"].Value = GivenAmount;

                command.Connection = connection;

                connection.Open();

                var cmd = command.ExecuteScalar();  
            }
            
        }

        public decimal GetLatestGivingHistory()
        {
            decimal returnVal = (decimal)0.0;

            using (var connection = new SqlConnection(dbConn))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "dbo.GetLatestGivingHistory";
                command.CommandType = CommandType.StoredProcedure;

                command.Connection = connection;

                connection.Open();

                var amount = command.ExecuteScalar();

                if (amount != null)
                {
                    returnVal = (decimal)amount;
                }                
            }

            return returnVal;
        }

        public decimal GetAverageDailyCost()
        {
            decimal returnVal = 0;

            using (var connection = new SqlConnection(dbConn))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "dbo.GetSetting";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@name", SqlDbType.VarChar);
                command.Parameters["@name"].Value = "AverageDailyCost";

                command.Connection = connection;

                connection.Open();

                var cost = command.ExecuteScalar();
                returnVal = (decimal)cost;
                
            }

            return returnVal;
        }
    }
}
