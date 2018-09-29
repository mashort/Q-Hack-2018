using System.Data;
using System.Data.SqlClient;

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
    }
}
