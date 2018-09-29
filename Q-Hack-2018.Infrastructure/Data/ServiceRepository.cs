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
            // TODO Get Bearer Token from database
            string bearerToken = "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJleHAiOjE1MzgyMjM5NjcsIm5iZiI6MTUzODIyMDM2NywidmVyIjoiMS4wIiwiaXNzIjoiaHR0cHM6Ly9sb2dpbi5taWNyb3NvZnRvbmxpbmUuY29tL2Q1Zjg1NjgyLWY2N2EtNDQ0NC05MzY5LTJjNWVjMWEwZThjZC92Mi4wLyIsInN1YiI6IjQ4MjI3ODRkLTBjMzUtNDg2Yi1hZjYwLWViZGE3NjE4ZDA2MiIsImF1ZCI6ImEwNmE3NGM1LWRlYTgtNGY4Ny1iYTc3LTlkZjZkMDMwODcyNSIsImlhdCI6MTUzODIyMDM2NywiYXV0aF90aW1lIjoxNTM4MjIwMzY3LCJvaWQiOiI0ODIyNzg0ZC0wYzM1LTQ4NmItYWY2MC1lYmRhNzYxOGQwNjIiLCJnaXZlbl9uYW1lIjoibXNiYiIsImZhbWlseV9uYW1lIjoieGFtdGVzdCIsIm5hbWUiOiJtc2JieGFtdGVzdCIsImVtYWlscyI6WyJtYXJ0aW4uc2hvcnRAYmx1ZWJhbmsuaW8iXSwidGZwIjoiQjJDXzFfU0kifQ.hzWnDxzzvYM20dlCseCRa2a2oDuOLNZX-Xrqnc29a_rZOc1Em2vvYySPqS2dcpAQFCPfTl4_iC8wwyADVEUKM_fykWSzAFjzDtI1J8gTqDkLeY27gvUR3_NZnVYP1HGHsv1MLKOIdB9xrmdgi0JmgdtN1wnyfR7QRDHISemwrIYN3aTKqiN7a1ABCS3dF6TMe2RrVH5ks0djbGjokNFZv49r0XzilW963mmxR2LmyvRj8fysgUbkeyNOTvkGpXGn1-FK4q1I7-vDXW8ID1fVrSAcCPtjJanMExr9tix8SnEF340cpFUIF1DoaD2H-oMWTx-TAH5ibdPXWS0SacmAZQ";

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
