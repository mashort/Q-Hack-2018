using Newtonsoft.Json;
using Q_Hack_2018.Core.Entities;
using System.Collections.Generic;
using System.IO;
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

            //string bearerToken = GetBearerToken();

            //using (HttpClient client = new HttpClient())
            //{
            //    client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", OcpApiSubscriptionKey);
            //    client.DefaultRequestHeaders.Add("Authorization", bearerToken);

            //    using (HttpResponseMessage response = await client.GetAsync(string.Format("{0}/accounts/{1}/transactions", ApiBaseAddress, AccountId)))
            //    {
            //        using (HttpContent content = response.Content)
            //        {
            //            string transactionData = await content.ReadAsStringAsync();

            //            transactionData = CleanTransactionData(transactionData);

            //            listOfTransactions = JsonConvert.DeserializeObject<List<Transaction>>(transactionData);
            //        }
            //    }
            //}

            string transactionData = GetTransactionsConnectionless();
            listOfTransactions = JsonConvert.DeserializeObject<List<Transaction>>(transactionData);

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

        public async Task<List<Transaction>> GetSeedData()
        {
            List<Transaction> listOfTransactions = new List<Transaction>();

            foreach (string f in GetJsonFiles())
            {
                using (StreamReader file = File.OpenText(f))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    listOfTransactions.Add((Transaction)serializer.Deserialize(file, typeof(Transaction)));
                }
            }

            return listOfTransactions;
        }

        public string[] GetJsonFiles()
        {
            string folder = Path.GetDirectoryName(@"\SeedData\");

            string[] jsonFiles = Directory.GetFiles(folder);

            return jsonFiles;
        }

        public string GetTransactionsConnectionless()
        {
            string returnValue = string.Empty;

            returnValue = @"[
    {
                ""id"": ""53decdab - 3bc4 - 419e-b7f4 - 39660cb23178"",
        ""transactionDateTime"": ""2017 - 10 - 31T09: 00:00.000Z"",
        ""transactionType"": ""XFR"",
        ""transactionDescription"": ""Salary"",
        ""transactionAmount"": 1384.2,
        ""transactionCurrency"": null,
        ""accountBalance"": 1318.02
    },
    {
                ""id"": ""47667e03 - dc1c - 4c8f - b7dc - 775abdde5612"",
        ""transactionDateTime"": ""2017 - 11 - 14T09: 00:00.000Z"",
        ""transactionType"": ""S / O"",
        ""transactionDescription"": ""Joint Account"",
        ""transactionAmount"": -705,
        ""transactionCurrency"": null,
        ""accountBalance"": -66.18
    },
    {
                ""id"": ""a212dcd1 - be64 - 49cf - 8ab5 - 49465b73a95f"",
        ""transactionDateTime"": ""2017 - 11 - 21T11: 00:00.000Z"",
        ""transactionType"": ""D / D"",
        ""transactionDescription"": ""Direct Line Ins"",
        ""transactionAmount"": -19.12,
        ""transactionCurrency"": null,
        ""accountBalance"": 638.82
    },
    {
                ""id"": ""896d1aa2 - 541a - 42c6 - a239 - 362ed3e8cc8a"",
        ""transactionDateTime"": ""2017 - 11 - 21T09: 00:00.000Z"",
        ""transactionType"": ""D / D"",
        ""transactionDescription"": ""02 Mobile"",
        ""transactionAmount"": -11.99,
        ""transactionCurrency"": null,
        ""accountBalance"": 657.94
    },
    {
                ""id"": ""02c06cba - 0311 - 4117 - bb2c - 6e975f2ada14"",
        ""transactionDateTime"": ""2017 - 11 - 22T13: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Royal Bank"",
        ""transactionAmount"": -47,
        ""transactionCurrency"": null,
        ""accountBalance"": 669.93
    },
    {
                ""id"": ""02fb9365 - 32c5 - 4909 - b41a - 898805172675"",
        ""transactionDateTime"": ""2017 - 11 - 22T12: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""ASDA"",
        ""transactionAmount"": -117.49,
        ""transactionCurrency"": null,
        ""accountBalance"": 716.93
    },
    {
                ""id"": ""6fe03544 - 8ef4 - 41ca - a168 - 17bc27942d6c"",
        ""transactionDateTime"": ""2017 - 11 - 22T11: 00:00.000Z"",
        ""transactionType"": ""DPC"",
        ""transactionDescription"": ""NatWest 545454"",
        ""transactionAmount"": -81.23,
        ""transactionCurrency"": null,
        ""accountBalance"": 834.42
    },
    {
                ""id"": ""846c8848 - e7a7 - 43a1 - af50 - 7eb926ae71cb"",
        ""transactionDateTime"": ""2017 - 11 - 22T10: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""HSBC"",
        ""transactionAmount"": -58.75,
        ""transactionCurrency"": null,
        ""accountBalance"": 915.65
    },
    {
                ""id"": ""9c790dd0 - 5c4a - 438d - a953 - 11ab3833fcd6"",
        ""transactionDateTime"": ""2017 - 11 - 22T09: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""John Lewis Edinburgh GB"",
        ""transactionAmount"": -46.99,
        ""transactionCurrency"": null,
        ""accountBalance"": 974.4
    },
    {
                ""id"": ""ae66175a - b519 - 45ec - ba8a - ce2bed5f3686"",
        ""transactionDateTime"": ""2017 - 11 - 29T09: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Lloyds"",
        ""transactionAmount"": 50,
        ""transactionCurrency"": null,
        ""accountBalance"": 1021.39
    },
    {
                ""id"": ""06897f11 - a5d7 - 4e54 - 803a - 32ad71eb10e2"",
        ""transactionDateTime"": ""2017 - 11 - 30T09: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""Tesco"",
        ""transactionAmount"": -35.25,
        ""transactionCurrency"": null,
        ""accountBalance"": 971.39
    },
    {
                ""id"": ""2faeb017 - 5ce2 - 409f - b83d - 2d6ae87a0330"",
        ""transactionDateTime"": ""2017 - 12 - 01T09: 00:00.000Z"",
        ""transactionType"": """",
        ""transactionDescription"": ""Salary"",
        ""transactionAmount"": 1334.54,
        ""transactionCurrency"": null,
        ""accountBalance"": 1006.64
    },
    {
                ""id"": ""00130004 - e1c8 - 446a - aac3 - 17ca49c0d3b7"",
        ""transactionDateTime"": ""2017 - 12 - 15T09: 00:00.000Z"",
        ""transactionType"": ""S / O"",
        ""transactionDescription"": ""Joint Account"",
        ""transactionAmount"": -705,
        ""transactionCurrency"": null,
        ""accountBalance"": -327.9
    },
    {
                ""id"": ""4bfca39e - bd10 - 49b5 - a3e8 - 9096bc0a28ee"",
        ""transactionDateTime"": ""2017 - 12 - 22T11: 00:00.000Z"",
        ""transactionType"": ""D / D"",
        ""transactionDescription"": ""Direct Line Ins"",
        ""transactionAmount"": -19.12,
        ""transactionCurrency"": null,
        ""accountBalance"": 377.1
    },
    {
                ""id"": ""f4d9d05e - a29d - 4210 - af5a - e7962acc47fc"",
        ""transactionDateTime"": ""2017 - 12 - 22T09: 00:00.000Z"",
        ""transactionType"": ""D / D"",
        ""transactionDescription"": ""02 Mobile"",
        ""transactionAmount"": -11.99,
        ""transactionCurrency"": null,
        ""accountBalance"": 396.22
    },
    {
                ""id"": ""3faea719 - 64c9 - 4faf - a1fc - be03a6e95a86"",
        ""transactionDateTime"": ""2017 - 12 - 23T13: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Royal Bank"",
        ""transactionAmount"": -47,
        ""transactionCurrency"": null,
        ""accountBalance"": 408.21
    },
    {
                ""id"": ""304b5cda - 0236 - 42a0 - 8cf6 - 7888d39f103d"",
        ""transactionDateTime"": ""2017 - 12 - 23T12: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""ASDA"",
        ""transactionAmount"": -70.49,
        ""transactionCurrency"": null,
        ""accountBalance"": 455.21
    },
    {
                ""id"": ""9ca0af14 - b432 - 48dd - 9774 - 88f9e26d3c9f"",
        ""transactionDateTime"": ""2017 - 12 - 23T11: 00:00.000Z"",
        ""transactionType"": ""DPC"",
        ""transactionDescription"": ""NatWest 545454"",
        ""transactionAmount"": -127.65,
        ""transactionCurrency"": null,
        ""accountBalance"": 525.7
    },
    {
                ""id"": ""ded523f2 - dd37 - 475e-b8e8 - 35798d3997c2"",
        ""transactionDateTime"": ""2017 - 12 - 23T10: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Lloyds"",
        ""transactionAmount"": -58.75,
        ""transactionCurrency"": null,
        ""accountBalance"": 653.35
    },
    {
                ""id"": ""e8fa5f38 - 01cd - 4fb1 - ac3a - 1075f7951aa0"",
        ""transactionDateTime"": ""2017 - 12 - 23T09: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""John Lewis Edinburgh GB"",
        ""transactionAmount"": -297.5,
        ""transactionCurrency"": null,
        ""accountBalance"": 712.1
    },
    {
                ""id"": ""6ca20981 - 710a - 474c - 9e05 - afa34a8941fc"",
        ""transactionDateTime"": ""2017 - 12 - 30T09: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Clydesdale"",
        ""transactionAmount"": -70.5,
        ""transactionCurrency"": null,
        ""accountBalance"": 1009.6
    },
    {
                ""id"": ""ee13b3c8 - 4e59 - 438c - a7df - 7e04a51d2d5c"",
        ""transactionDateTime"": ""2017 - 12 - 31T09: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""Tesco"",
        ""transactionAmount"": -35.25,
        ""transactionCurrency"": null,
        ""accountBalance"": 1080.1
    },
    {
                ""id"": ""0893b862 - a8e8 - 4434 - b81d - 0973b1abb7a0"",
        ""transactionDateTime"": ""2018 - 01 - 01T09: 00:00.000Z"",
        ""transactionType"": """",
        ""transactionDescription"": ""Salary"",
        ""transactionAmount"": 1334.54,
        ""transactionCurrency"": null,
        ""accountBalance"": 1115.35
    },
    {
                ""id"": ""78f219d5 - d894 - 4cd1 - a969 - d4868d9dfb33"",
        ""transactionDateTime"": ""2018 - 01 - 14T09: 00:00.000Z"",
        ""transactionType"": ""S / O"",
        ""transactionDescription"": ""Joint Account"",
        ""transactionAmount"": -705,
        ""transactionCurrency"": null,
        ""accountBalance"": -219.19
    },
    {
                ""id"": ""30e51786 - 8c94 - 4dcf - b0ec - 129e29c8e62a"",
        ""transactionDateTime"": ""2018 - 01 - 21T11: 00:00.000Z"",
        ""transactionType"": ""D / D"",
        ""transactionDescription"": ""Direct Line Ins"",
        ""transactionAmount"": -19.12,
        ""transactionCurrency"": null,
        ""accountBalance"": 485.81
    },
    {
                ""id"": ""83a33fe7 - 89d1 - 42a8 - 9a3f - 52dd709861c8"",
        ""transactionDateTime"": ""2018 - 01 - 21T09: 00:00.000Z"",
        ""transactionType"": ""D / D"",
        ""transactionDescription"": ""02 Mobile"",
        ""transactionAmount"": -11.99,
        ""transactionCurrency"": null,
        ""accountBalance"": 504.93
    },
    {
                ""id"": ""1ee41d37 - 0cae - 4c25 - bb91 - ad017b636019"",
        ""transactionDateTime"": ""2018 - 01 - 22T13: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Royal Bank"",
        ""transactionAmount"": -47,
        ""transactionCurrency"": null,
        ""accountBalance"": 516.92
    },
    {
                ""id"": ""96da5cc1 - 6997 - 4495 - a462 - 8fd02627168c"",
        ""transactionDateTime"": ""2018 - 01 - 22T12: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""John Lewis Edinburgh GB"",
        ""transactionAmount"": -46.99,
        ""transactionCurrency"": null,
        ""accountBalance"": 563.92
    },
    {
                ""id"": ""8d0a4c3d - a5d5 - 4948 - b83e - c93f0c1505ce"",
        ""transactionDateTime"": ""2018 - 01 - 22T11: 00:00.000Z"",
        ""transactionType"": ""DPC"",
        ""transactionDescription"": ""NatWest 545454"",
        ""transactionAmount"": -127.65,
        ""transactionCurrency"": null,
        ""accountBalance"": 610.91
    },
    {
                ""id"": ""40b1bec9 - 5e7e - 42ee - 90ca - b90672e54a62"",
        ""transactionDateTime"": ""2018 - 01 - 22T10: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""HSBC"",
        ""transactionAmount"": -58.75,
        ""transactionCurrency"": null,
        ""accountBalance"": 738.56
    },
    {
                ""id"": ""c7d7017a - 756f - 449a - 9789 - b87ea325e29d"",
        ""transactionDateTime"": ""2018 - 01 - 22T09: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""ASDA"",
        ""transactionAmount"": -82.53,
        ""transactionCurrency"": null,
        ""accountBalance"": 797.31
    },
    {
                ""id"": ""f0b90354 - 3216 - 4ccc - aab4 - 33076c97fcd6"",
        ""transactionDateTime"": ""2018 - 01 - 29T09: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Clydesdale"",
        ""transactionAmount"": -47,
        ""transactionCurrency"": null,
        ""accountBalance"": 879.84
    },
    {
                ""id"": ""6678e40a - 53fd - 4342 - 9372 - 75a28a370bdb"",
        ""transactionDateTime"": ""2018 - 01 - 30T09: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""Tesco"",
        ""transactionAmount"": -28.53,
        ""transactionCurrency"": null,
        ""accountBalance"": 926.84
    },
    {
                ""id"": ""4e421df4 - 2582 - 496f - 8fe5 - 524e4125296d"",
        ""transactionDateTime"": ""2018 - 01 - 31T09: 00:00.000Z"",
        ""transactionType"": """",
        ""transactionDescription"": ""Salary"",
        ""transactionAmount"": 1334.54,
        ""transactionCurrency"": null,
        ""accountBalance"": 955.37
    },
    {
                ""id"": ""ec8a1af7 - bc05 - 4198 - bff0 - 1219ba500ee2"",
        ""transactionDateTime"": ""2018 - 02 - 14T09: 00:00.000Z"",
        ""transactionType"": ""S / O"",
        ""transactionDescription"": ""Joint Account"",
        ""transactionAmount"": -705,
        ""transactionCurrency"": null,
        ""accountBalance"": -379.17
    },
    {
                ""id"": ""a61eaa1b - 3589 - 4c74 - b05f - c58dd4418952"",
        ""transactionDateTime"": ""2018 - 02 - 21T11: 00:00.000Z"",
        ""transactionType"": ""D / D"",
        ""transactionDescription"": ""Direct Line Ins"",
        ""transactionAmount"": -19.12,
        ""transactionCurrency"": null,
        ""accountBalance"": 325.83
    },
    {
                ""id"": ""3663efea - 212d - 43a8 - ba14 - 67907b88a71f"",
        ""transactionDateTime"": ""2018 - 02 - 21T09: 00:00.000Z"",
        ""transactionType"": ""D / D"",
        ""transactionDescription"": ""02 Mobile"",
        ""transactionAmount"": -11.99,
        ""transactionCurrency"": null,
        ""accountBalance"": 344.95
    },
    {
                ""id"": ""6685568d - 1493 - 481d - a90b - f722ad2fee28"",
        ""transactionDateTime"": ""2018 - 02 - 22T13: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Royal Bank"",
        ""transactionAmount"": -47,
        ""transactionCurrency"": null,
        ""accountBalance"": 356.94
    },
    {
                ""id"": ""61395175 - a517 - 4a18 - bd84 - bc26817694fc"",
        ""transactionDateTime"": ""2018 - 02 - 22T12: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""ASDA"",
        ""transactionAmount"": -164.49,
        ""transactionCurrency"": null,
        ""accountBalance"": 403.94
    },
    {
                ""id"": ""c6638884 - a276 - 4ead - 80d2 - a1f96805a5bc"",
        ""transactionDateTime"": ""2018 - 02 - 22T11: 00:00.000Z"",
        ""transactionType"": ""DPC"",
        ""transactionDescription"": ""NatWest 545454"",
        ""transactionAmount"": -232.07,
        ""transactionCurrency"": null,
        ""accountBalance"": 568.43
    },
    {
                ""id"": ""8fead02d - d4ce - 4a84 - 9dc0 - bcded1dc1f8b"",
        ""transactionDateTime"": ""2018 - 02 - 22T10: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Lloyds"",
        ""transactionAmount"": -58.75,
        ""transactionCurrency"": null,
        ""accountBalance"": 800.5
    },
    {
                ""id"": ""9cb72f8a - 8c4d - 4009 - 893b - 5e43a83cd6b8"",
        ""transactionDateTime"": ""2018 - 02 - 22T09: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""John Lewis Edinburgh GB"",
        ""transactionAmount"": -35.53,
        ""transactionCurrency"": null,
        ""accountBalance"": 859.25
    },
    {
                ""id"": ""634ca24c - 1340 - 4f95 - bb20 - 073d60efe053"",
        ""transactionDateTime"": ""2018 - 03 - 01T09: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""NatWest 545454"",
        ""transactionAmount"": -47,
        ""transactionCurrency"": null,
        ""accountBalance"": 894.78
    },
    {
                ""id"": ""de15c3b5 - abd9 - 4593 - bf53 - 2e2a06492b3c"",
        ""transactionDateTime"": ""2018 - 03 - 02T09: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""M & S"",
        ""transactionAmount"": -40.5,
        ""transactionCurrency"": null,
        ""accountBalance"": 941.78
    },
    {
                ""id"": ""631d12a0 - 0fca - 49f4 - b9c4 - 646789d0bb13"",
        ""transactionDateTime"": ""2018 - 03 - 03T09: 00:00.000Z"",
        ""transactionType"": """",
        ""transactionDescription"": ""Salary"",
        ""transactionAmount"": 1334.54,
        ""transactionCurrency"": null,
        ""accountBalance"": 982.28
    },
    {
                ""id"": ""b905e1f9 - 0680 - 4e3c - a1df - 4c81edb772bc"",
        ""transactionDateTime"": ""2018 - 03 - 16T09: 00:00.000Z"",
        ""transactionType"": ""S / O"",
        ""transactionDescription"": ""Joint Account"",
        ""transactionAmount"": -705,
        ""transactionCurrency"": null,
        ""accountBalance"": -352.26
    },
    {
                ""id"": ""e86bb585 - 6620 - 408b - 9b82 - 28fa22065d10"",
        ""transactionDateTime"": ""2018 - 03 - 23T11: 00:00.000Z"",
        ""transactionType"": ""D / D"",
        ""transactionDescription"": ""Direct Line Ins"",
        ""transactionAmount"": -19.12,
        ""transactionCurrency"": null,
        ""accountBalance"": 352.74
    },
    {
                ""id"": ""a766d39e - e75c - 4179 - 9e95 - 894fc1c88cab"",
        ""transactionDateTime"": ""2018 - 03 - 23T09: 00:00.000Z"",
        ""transactionType"": ""D / D"",
        ""transactionDescription"": ""02 Mobile"",
        ""transactionAmount"": -11.99,
        ""transactionCurrency"": null,
        ""accountBalance"": 371.86
    },
    {
                ""id"": ""9c621f34 - 02e4 - 4d30 - bbbe - 598a071fe33d"",
        ""transactionDateTime"": ""2018 - 03 - 24T13: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Royal Bank"",
        ""transactionAmount"": -47,
        ""transactionCurrency"": null,
        ""accountBalance"": 383.85
    },
    {
                ""id"": ""687ddd0f - 829f - 459b - 9438 - 72ab5222e426"",
        ""transactionDateTime"": ""2018 - 03 - 24T12: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""John Lewis Edinburgh GB"",
        ""transactionAmount"": -117.49,
        ""transactionCurrency"": null,
        ""accountBalance"": 430.85
    },
    {
                ""id"": ""c230ba2e - aa25 - 4c1a - 9fe5 - c88a94b55bad"",
        ""transactionDateTime"": ""2018 - 03 - 24T11: 00:00.000Z"",
        ""transactionType"": ""DPC"",
        ""transactionDescription"": ""NatWest 545454"",
        ""transactionAmount"": -204.48,
        ""transactionCurrency"": null,
        ""accountBalance"": 548.34
    },
    {
                ""id"": ""a4bc06b5 - 9f02 - 4221 - b3cf - be7906486b42"",
        ""transactionDateTime"": ""2018 - 03 - 24T10: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Bank of Scotland"",
        ""transactionAmount"": -58.75,
        ""transactionCurrency"": null,
        ""accountBalance"": 752.82
    },
    {
                ""id"": ""aa5160f7 - 7715 - 47ad - b94a - c5d5fcefcf87"",
        ""transactionDateTime"": ""2018 - 03 - 24T09: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""ASDA"",
        ""transactionAmount"": -46.63,
        ""transactionCurrency"": null,
        ""accountBalance"": 811.57
    },
    {
                ""id"": ""94916ce9 - 9333 - 46ac - 8bc8 - 92dea063dda3"",
        ""transactionDateTime"": ""2018 - 03 - 31T09: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Clydesdale"",
        ""transactionAmount"": -70.5,
        ""transactionCurrency"": null,
        ""accountBalance"": 858.2
    },
    {
                ""id"": ""3f45a99f - 7d90 - 41dc - af2e - 89735f1a002f"",
        ""transactionDateTime"": ""2018 - 04 - 01T09: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""Tesco"",
        ""transactionAmount"": -12.84,
        ""transactionCurrency"": null,
        ""accountBalance"": 928.7
    },
    {
                ""id"": ""883a2c66 - 9253 - 4bc4 - b22e - df0b2dcbba31"",
        ""transactionDateTime"": ""2018 - 04 - 02T09: 00:00.000Z"",
        ""transactionType"": """",
        ""transactionDescription"": ""Salary"",
        ""transactionAmount"": 1384.17,
        ""transactionCurrency"": null,
        ""accountBalance"": 941.54
    },
    {
                ""id"": ""8a288d43 - 9e6a - 4a0f - 9ba5 - 171fb96fa574"",
        ""transactionDateTime"": ""2018 - 04 - 16T09: 00:00.000Z"",
        ""transactionType"": ""S / O"",
        ""transactionDescription"": ""Joint Account"",
        ""transactionAmount"": -705,
        ""transactionCurrency"": null,
        ""accountBalance"": -442.63
    },
    {
                ""id"": ""5f44e995 - e0d4 - 428d - 8004 - 8bc24b53043b"",
        ""transactionDateTime"": ""2018 - 04 - 23T11: 00:00.000Z"",
        ""transactionType"": ""D / D"",
        ""transactionDescription"": ""Direct Line Ins"",
        ""transactionAmount"": -19.12,
        ""transactionCurrency"": null,
        ""accountBalance"": 262.37
    },
    {
                ""id"": ""85662c57 - e46c - 42f0 - ae13 - 8d6df8c22881"",
        ""transactionDateTime"": ""2018 - 04 - 23T09: 00:00.000Z"",
        ""transactionType"": ""D / D"",
        ""transactionDescription"": ""02 Mobile"",
        ""transactionAmount"": -11.99,
        ""transactionCurrency"": null,
        ""accountBalance"": 281.49
    },
    {
                ""id"": ""80f86c8f - 7fd5 - 4aba - 97fe - 1b7c7b0650bf"",
        ""transactionDateTime"": ""2018 - 04 - 24T13: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Royal Bank"",
        ""transactionAmount"": -47,
        ""transactionCurrency"": null,
        ""accountBalance"": 293.48
    },
    {
                ""id"": ""2a589899 - 7894 - 40c5 - a14e - 0c617a352b73"",
        ""transactionDateTime"": ""2018 - 04 - 24T12: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""ASDA"",
        ""transactionAmount"": -93.99,
        ""transactionCurrency"": null,
        ""accountBalance"": 340.48
    },
    {
                ""id"": ""a68b5840 - 3df6 - 495f - b56a - e05f949525a1"",
        ""transactionDateTime"": ""2018 - 04 - 24T11: 00:00.000Z"",
        ""transactionType"": ""DPC"",
        ""transactionDescription"": ""NatWest 545454"",
        ""transactionAmount"": -127.65,
        ""transactionCurrency"": null,
        ""accountBalance"": 434.47
    },
    {
                ""id"": ""904dea6e - 1ea4 - 4606 - acb8 - 0d4742dbaf50"",
        ""transactionDateTime"": ""2018 - 04 - 24T10: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Santander"",
        ""transactionAmount"": -58.75,
        ""transactionCurrency"": null,
        ""accountBalance"": 562.12
    },
    {
                ""id"": ""3b6f7d20 - d773 - 45d5 - ad5a - 68dac84e4935"",
        ""transactionDateTime"": ""2018 - 04 - 24T09: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""John Lewis Edinburgh GB"",
        ""transactionAmount"": -82.53,
        ""transactionCurrency"": null,
        ""accountBalance"": 620.87
    },
    {
                ""id"": ""bbcda611 - 2bcc - 4448 - 80b0 - 96a60b0df26f"",
        ""transactionDateTime"": ""2018 - 05 - 01T09: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""NatWest"",
        ""transactionAmount"": -58.75,
        ""transactionCurrency"": null,
        ""accountBalance"": 703.4
    },
    {
                ""id"": ""294df257 - eca3 - 4422 - aac6 - b1e4fb43b7ba"",
        ""transactionDateTime"": ""2018 - 05 - 02T09: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""M & S"",
        ""transactionAmount"": -18.43,
        ""transactionCurrency"": null,
        ""accountBalance"": 762.15
    },
    {
                ""id"": ""177b1ec1 - cde7 - 44f5 - 801a - b8e1ae091b82"",
        ""transactionDateTime"": ""2018 - 05 - 03T09: 00:00.000Z"",
        ""transactionType"": """",
        ""transactionDescription"": ""Salary"",
        ""transactionAmount"": 1384.2,
        ""transactionCurrency"": null,
        ""accountBalance"": 780.58
    },
    {
                ""id"": ""201453cc - 3f31 - 4e5c - a0d2 - 8aa78a332c39"",
        ""transactionDateTime"": ""2018 - 05 - 15T09: 00:00.000Z"",
        ""transactionType"": ""S / O"",
        ""transactionDescription"": ""Joint Account"",
        ""transactionAmount"": -705,
        ""transactionCurrency"": null,
        ""accountBalance"": -603.62
    },
    {
                ""id"": ""3c382f16 - 6495 - 457f - 9ff8 - 3e471bf705d0"",
        ""transactionDateTime"": ""2018 - 05 - 22T11: 00:00.000Z"",
        ""transactionType"": ""D / D"",
        ""transactionDescription"": ""Direct Line Ins"",
        ""transactionAmount"": -19.12,
        ""transactionCurrency"": null,
        ""accountBalance"": 101.38
    },
    {
                ""id"": ""90385018 - ca45 - 4bd1 - b9e9 - dbb2535a5735"",
        ""transactionDateTime"": ""2018 - 05 - 22T09: 00:00.000Z"",
        ""transactionType"": ""D / D"",
        ""transactionDescription"": ""02 Mobile"",
        ""transactionAmount"": -11.99,
        ""transactionCurrency"": null,
        ""accountBalance"": 120.5
    },
    {
                ""id"": ""cb06cdf6 - 44bb - 46d9 - 8a8f - 8e880dea3588"",
        ""transactionDateTime"": ""2018 - 05 - 23T13: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Royal Bank"",
        ""transactionAmount"": -47,
        ""transactionCurrency"": null,
        ""accountBalance"": 132.49
    },
    {
                ""id"": ""267fbb53 - 56a2 - 4d36 - ac3d - 2734d2e9dd5b"",
        ""transactionDateTime"": ""2018 - 05 - 23T12: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""ASDA"",
        ""transactionAmount"": -140.99,
        ""transactionCurrency"": null,
        ""accountBalance"": 179.49
    },
    {
                ""id"": ""f47972c8 - 1a04 - 43d4 - 9195 - 0231fc78b50a"",
        ""transactionDateTime"": ""2018 - 05 - 23T11: 00:00.000Z"",
        ""transactionType"": ""DPC"",
        ""transactionDescription"": ""NatWest 545454"",
        ""transactionAmount"": -127.65,
        ""transactionCurrency"": null,
        ""accountBalance"": 320.48
    },
    {
                ""id"": ""e0a4b042 - 576e-4997 - ba18 - dd5021a4b46c"",
        ""transactionDateTime"": ""2018 - 05 - 23T10: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Lloyds"",
        ""transactionAmount"": -58.75,
        ""transactionCurrency"": null,
        ""accountBalance"": 448.13
    },
    {
                ""id"": ""ebc12a7b - 68f8 - 4f07 - b665 - e8f0e8aa7d05"",
        ""transactionDateTime"": ""2018 - 05 - 23T09: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""John Lewis Edinburgh GB"",
        ""transactionAmount"": -82.53,
        ""transactionCurrency"": null,
        ""accountBalance"": 506.88
    },
    {
                ""id"": ""15ff73c1 - 89cd - 4252 - a412 - a36432d31642"",
        ""transactionDateTime"": ""2018 - 05 - 30T09: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Clydesdale"",
        ""transactionAmount"": -70.5,
        ""transactionCurrency"": null,
        ""accountBalance"": 589.41
    },
    {
                ""id"": ""cb3cb3aa - 0b91 - 413e-8c3d - b6ebe9cae035"",
        ""transactionDateTime"": ""2018 - 05 - 31T09: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""M & S"",
        ""transactionAmount"": -22.91,
        ""transactionCurrency"": null,
        ""accountBalance"": 659.91
    },
    {
                ""id"": ""2198eb03 - 1bbe - 4742 - 8cf6 - 4e546b97deb6"",
        ""transactionDateTime"": ""2018 - 06 - 01T09: 00:00.000Z"",
        ""transactionType"": """",
        ""transactionDescription"": ""Salary"",
        ""transactionAmount"": 1384.2,
        ""transactionCurrency"": null,
        ""accountBalance"": 682.82
    },
    {
                ""id"": ""dcc9f7b8 - 8265 - 40c6 - 9b4f - 888d89d34748"",
        ""transactionDateTime"": ""2018 - 06 - 12T09: 00:00.000Z"",
        ""transactionType"": ""S / O"",
        ""transactionDescription"": ""Joint Account"",
        ""transactionAmount"": -705,
        ""transactionCurrency"": null,
        ""accountBalance"": -701.38
    },
    {
                ""id"": ""7f5e36a3 - 3972 - 4dd8 - b1cb - e9a7df5114b6"",
        ""transactionDateTime"": ""2018 - 06 - 22T11: 00:00.000Z"",
        ""transactionType"": ""D / D"",
        ""transactionDescription"": ""Direct Line Ins"",
        ""transactionAmount"": -19.12,
        ""transactionCurrency"": null,
        ""accountBalance"": 3.62
    },
    {
                ""id"": ""9df122c6 - 81bf - 4081 - ba75 - 6ef8c12ba90c"",
        ""transactionDateTime"": ""2018 - 06 - 22T09: 00:00.000Z"",
        ""transactionType"": ""D / D"",
        ""transactionDescription"": ""02 Mobile"",
        ""transactionAmount"": -11.99,
        ""transactionCurrency"": null,
        ""accountBalance"": 22.74
    },
    {
                ""id"": ""e9217917 - d44b - 4f7b - 859a - 4d8d51dd7fae"",
        ""transactionDateTime"": ""2018 - 06 - 23T13: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Royal Bank"",
        ""transactionAmount"": -47,
        ""transactionCurrency"": null,
        ""accountBalance"": 34.73
    },
    {
                ""id"": ""6671ea1a - 1983 - 4207 - be81 - aac9a8e0d82e"",
        ""transactionDateTime"": ""2018 - 06 - 23T12: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""John Lewis Edinburgh GB"",
        ""transactionAmount"": -117.49,
        ""transactionCurrency"": null,
        ""accountBalance"": 81.73
    },
    {
                ""id"": ""b0a6d77b - 4798 - 4a15 - 8b67 - cb21a026bca5"",
        ""transactionDateTime"": ""2018 - 06 - 23T11: 00:00.000Z"",
        ""transactionType"": ""DPC"",
        ""transactionDescription"": ""NatWest 545454"",
        ""transactionAmount"": -362.65,
        ""transactionCurrency"": null,
        ""accountBalance"": 199.22
    },
    {
                ""id"": ""a6a0f4ba - 467f - 439e-97da - 2ac029a2b764"",
        ""transactionDateTime"": ""2018 - 06 - 23T10: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Lloyds"",
        ""transactionAmount"": -58.75,
        ""transactionCurrency"": null,
        ""accountBalance"": 561.87
    },
    {
                ""id"": ""34e9fe80 - f562 - 40ce - 9679 - 8b03e22b1871"",
        ""transactionDateTime"": ""2018 - 06 - 23T09: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""ASDA"",
        ""transactionAmount"": -506.42,
        ""transactionCurrency"": null,
        ""accountBalance"": 620.62
    },
    {
                ""id"": ""9a0f6108 - ae44 - 4efa - beb9 - 42aab79ac5c0"",
        ""transactionDateTime"": ""2018 - 06 - 30T09: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Clydesdale"",
        ""transactionAmount"": -70.5,
        ""transactionCurrency"": null,
        ""accountBalance"": 1127.04
    },
    {
                ""id"": ""a07a1c92 - 1216 - 45b7 - a39b - 2cec8b83bfc7"",
        ""transactionDateTime"": ""2018 - 07 - 01T09: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""ASDA"",
        ""transactionAmount"": -52.44,
        ""transactionCurrency"": null,
        ""accountBalance"": 1197.54
    },
    {
                ""id"": ""3afe442b - 48b7 - 437e-8ee4 - 1b5028b88fe6"",
        ""transactionDateTime"": ""2018 - 07 - 02T09: 00:00.000Z"",
        ""transactionType"": """",
        ""transactionDescription"": ""Salary"",
        ""transactionAmount"": 1384.2,
        ""transactionCurrency"": null,
        ""accountBalance"": 1249.98
    },
    {
                ""id"": ""5aec8d57 - bd06 - 4a6d - 9655 - 1b554df6c1ac"",
        ""transactionDateTime"": ""2018 - 07 - 16T09: 00:00.000Z"",
        ""transactionType"": ""S / O"",
        ""transactionDescription"": ""Joint Account"",
        ""transactionAmount"": -705,
        ""transactionCurrency"": null,
        ""accountBalance"": -134.22
    },
    {
                ""id"": ""6c812e26 - 648e-479f - b53b - 1f796ef758fa"",
        ""transactionDateTime"": ""2018 - 07 - 23T11: 00:00.000Z"",
        ""transactionType"": ""D / D"",
        ""transactionDescription"": ""Direct Line Ins"",
        ""transactionAmount"": -8.12,
        ""transactionCurrency"": null,
        ""accountBalance"": 570.78
    },
    {
                ""id"": ""f9f9827d - 590d - 436d - 87a0 - 86b01b50ba23"",
        ""transactionDateTime"": ""2018 - 07 - 23T09: 00:00.000Z"",
        ""transactionType"": ""D / D"",
        ""transactionDescription"": ""02 Mobile"",
        ""transactionAmount"": 11.99,
        ""transactionCurrency"": null,
        ""accountBalance"": 578.9
    },
    {
                ""id"": ""d15c9083 - f73f - 4f3b - b280 - be344aff3e6c"",
        ""transactionDateTime"": ""2018 - 07 - 24T13: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Royal Bank"",
        ""transactionAmount"": -47,
        ""transactionCurrency"": null,
        ""accountBalance"": 566.91
    },
    {
                ""id"": ""0f51db15 - 093c - 4607 - 9594 - 0c9f5ac19fb4"",
        ""transactionDateTime"": ""2018 - 07 - 24T12: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""John Lewis Edinburgh GB"",
        ""transactionAmount"": -117.49,
        ""transactionCurrency"": null,
        ""accountBalance"": 613.91
    },
    {
                ""id"": ""fb3c184a - 2223 - 42a7 - 9ac4 - 07fb49a02098"",
        ""transactionDateTime"": ""2018 - 07 - 24T11: 00:00.000Z"",
        ""transactionType"": ""DPC"",
        ""transactionDescription"": ""NatWest 545454"",
        ""transactionAmount"": -362.65,
        ""transactionCurrency"": null,
        ""accountBalance"": 731.4
    },
    {
                ""id"": ""f7e98f07 - 2d31 - 4561 - b319 - e4cf3aafc926"",
        ""transactionDateTime"": ""2018 - 07 - 24T10: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Santander"",
        ""transactionAmount"": -58.75,
        ""transactionCurrency"": null,
        ""accountBalance"": 1094.05
    },
    {
                ""id"": ""60eca492 - 596e-4b4e - 91ac - 5b56ad4641bf"",
        ""transactionDateTime"": ""2018 - 07 - 24T09: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""ASDA"",
        ""transactionAmount"": -105.8,
        ""transactionCurrency"": null,
        ""accountBalance"": 1152.8
    },
    {
                ""id"": ""fdfc6208 - d189 - 4b9e - aba8 - ce429b4f168e"",
        ""transactionDateTime"": ""2018 - 07 - 31T09: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Bank of Scotland"",
        ""transactionAmount"": -47,
        ""transactionCurrency"": null,
        ""accountBalance"": 1258.6
    },
    {
                ""id"": ""256bccdc - cb1d - 46f7 - a436 - 67b3ac073ae8"",
        ""transactionDateTime"": ""2018 - 08 - 01T09: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""Tesco"",
        ""transactionAmount"": -12.11,
        ""transactionCurrency"": null,
        ""accountBalance"": 1305.6
    },
    {
                ""id"": ""655e048e - d0dd - 4967 - a760 - c55a17295c82"",
        ""transactionDateTime"": ""2018 - 08 - 02T09: 00:00.000Z"",
        ""transactionType"": """",
        ""transactionDescription"": ""Salary"",
        ""transactionAmount"": 1384.2,
        ""transactionCurrency"": null,
        ""accountBalance"": 1317.71
    },
    {
                ""id"": ""0f5e10fd - dfd3 - 4013 - 866b - de4a4c204ee8"",
        ""transactionDateTime"": ""2018 - 08 - 15T09: 00:00.000Z"",
        ""transactionType"": ""S / O"",
        ""transactionDescription"": ""Joint Account"",
        ""transactionAmount"": -705,
        ""transactionCurrency"": null,
        ""accountBalance"": -66.49
    },
    {
                ""id"": ""9839ebb5 - f709 - 450b - 804c - 8a07cdd52180"",
        ""transactionDateTime"": ""2018 - 08 - 22T11: 00:00.000Z"",
        ""transactionType"": ""D / D"",
        ""transactionDescription"": ""Direct Line Ins"",
        ""transactionAmount"": -19.12,
        ""transactionCurrency"": null,
        ""accountBalance"": 638.51
    },
    {
                ""id"": ""d1e6e424 - dd7a - 4e20 - b84d - 6331ecb940e9"",
        ""transactionDateTime"": ""2018 - 08 - 22T09: 00:00.000Z"",
        ""transactionType"": ""D / D"",
        ""transactionDescription"": ""02 Mobile"",
        ""transactionAmount"": -11.99,
        ""transactionCurrency"": null,
        ""accountBalance"": 657.63
    },
    {
                ""id"": ""36642470 - a6db - 4906 - 9d52 - 27b991f7ccf7"",
        ""transactionDateTime"": ""2018 - 08 - 23T13: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""Royal Bank"",
        ""transactionAmount"": -47,
        ""transactionCurrency"": null,
        ""accountBalance"": 669.62
    },
    {
                ""id"": ""3c07bb50 - 9be4 - 4276 - af98 - 8db28278ad95"",
        ""transactionDateTime"": ""2018 - 08 - 23T12: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""John Lewis Edinburgh GB"",
        ""transactionAmount"": -117.49,
        ""transactionCurrency"": null,
        ""accountBalance"": 716.62
    },
    {
                ""id"": ""99eb2425 - 2f63 - 418f - 8ca0 - 41475135a8ba"",
        ""transactionDateTime"": ""2018 - 08 - 23T11: 00:00.000Z"",
        ""transactionType"": ""DPC"",
        ""transactionDescription"": ""NatWest 545454"",
        ""transactionAmount"": -344.18,
        ""transactionCurrency"": null,
        ""accountBalance"": 834.11
    },
    {
                ""id"": ""c3f612cb - eaeb - 42e7 - 93a3 - f72655608713"",
        ""transactionDateTime"": ""2018 - 08 - 23T10: 00:00.000Z"",
        ""transactionType"": ""C / L"",
        ""transactionDescription"": ""HSBC"",
        ""transactionAmount"": -70.5,
        ""transactionCurrency"": null,
        ""accountBalance"": 1178.29
    },
    {
                ""id"": ""0ca4e961 - 7d9b - 43ae - b435 - 985c0b1240b3"",
        ""transactionDateTime"": ""2018 - 08 - 23T09: 00:00.000Z"",
        ""transactionType"": ""POS"",
        ""transactionDescription"": ""ASDA"",
        ""transactionAmount"": -103.39,
        ""transactionCurrency"": null,
        ""accountBalance"": 1248.79
    }
]";

            return returnValue;
        }
    }
}
