using Newtonsoft.Json;
using Q_Hack_2018.Core.Entities;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Q_Hack_2018.Infrastructure.Data
{
    public class ServiceRepository
    {
        public string OcpApiSubscriptionKey = "28bf4afd9f664b5598df90ed41146a9b";
        public string ApiBaseAddress = "https://bluebank.azure-api.net/api/v0.7";
        public string AccountId = "5d1c302a-34ee-44dd-a340-1d98c11dea07";

        public async Task<List<Transaction>> GetTransactions()
        {
            List<Transaction> listOfTransactions = new List<Transaction>();

            string bearerToken = GetBearerToken();

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", OcpApiSubscriptionKey);
                client.DefaultRequestHeaders.Add("Authorization", bearerToken);

                using (HttpResponseMessage response = await client.GetAsync(string.Format("{0}/accounts/{1}/transactions", ApiBaseAddress, AccountId)))
                {
                    using (HttpContent content = response.Content)
                    {
                        string transactionData = await content.ReadAsStringAsync();

                        transactionData = CleanTransactionData(transactionData);

                        listOfTransactions = JsonConvert.DeserializeObject<List<Transaction>>(transactionData);
                    }
                }
            }

            return listOfTransactions;
        }

        public string GetBearerToken()
        {
            string bearerToken = new DAL().GetBearerToken();

            return bearerToken;
        }

        private string CleanTransactionData(string transactionData)
        {
            string returnVal = string.Empty;

            returnVal = transactionData.Replace(@",""meta"":{""total"":108,""count"":108}", "");
            returnVal = returnVal.Replace(@"{""results"":", "");
            returnVal = returnVal.TrimEnd('}');

            return returnVal;
        }
    }
}
