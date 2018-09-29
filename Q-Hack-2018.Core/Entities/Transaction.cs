using Newtonsoft.Json;
using System;

namespace Q_Hack_2018.Core.Entities
{
    public class Transaction
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "transactionDateTime")]
        public DateTime TransactionDateTime { get; set; }

        [JsonProperty(PropertyName = "transactionType")]
        public string TransactionType { get; set; }

        [JsonProperty(PropertyName = "transactionDescription")]
        public string TransactionDescription { get; set; }

        [JsonProperty(PropertyName = "transactionAmount")]
        public decimal TransactionAmount { get; set; }

        [JsonProperty(PropertyName = "transactionCurrency")]
        public string TransactionCurrency { get; set; }

        [JsonProperty(PropertyName = "accountBalance")]
        public decimal AccountBalance { get; set; }
    }
}
