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
    }
}
