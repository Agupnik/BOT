﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace CrMonitorBot.Logic
{
    public class Tickers
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("totalSupply")]
        public long TotalSupply { get; set; }

        [JsonProperty("maxSupply")]
        public long MaxSupply { get; set; }

        [JsonProperty("quotes")]
        public Dictionary<string, MyQuotes> Quotes { get; set; }
    }
    public class MyQuotes
    {
        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("percentChange1H")]
        public decimal PercentChange1H { get; set; }

        [JsonProperty("percentChange12H")]
        public decimal PercentChange12H { get; set; }

        [JsonProperty("percentChange24H")]
        public decimal PercentChange24H { get; set; }
    }
    public class CoinInformation
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("is_new")]
        public bool Is_new { get; set; }
        [JsonProperty("is_active")]
        public bool Is_active { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
    public class UserCurrency
    {
        public string crypto { get; set; }
    }
    public class UserCurrencyToChange
    {
        public string real { get; set; }
        public string crypto { get; set; }
        public string crypto_to_change { get; set; }
    }
    public class UserId
    {
        public string Id { get; set; }
    }
    public class UserInfo
    {
        public string Id { get; set; }
        public string Real { get; set; }
        public List<UserMoney> Currency { get; set; }
    }
    public class UserList
    {
        public List<UserInfo> users { get; set; }
    }
    public class UserMoney
    {
        public string Crypto { get; set; }
    }
}
