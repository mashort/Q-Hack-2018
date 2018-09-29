namespace Q_Hack_2018.Infrastructure.Data
{
    public class Connection
    {
        public string GetDbConnection()
        {
            string dbConnectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=Q-Hack-2018-DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            return dbConnectionString;
        }
    }
}
