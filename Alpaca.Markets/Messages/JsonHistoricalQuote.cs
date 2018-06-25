﻿using System;
using Newtonsoft.Json;

namespace Alpaca.Markets
{
    public sealed class JsonHistoricalQuote : IHistoricalQuote
    {
        [JsonProperty(PropertyName = "bE", Required = Required.Always)]
        public String BidExchange { get; set; }

        [JsonProperty(PropertyName = "aE", Required = Required.Always)]
        public String AskExchange { get; set; }

        [JsonProperty(PropertyName = "bP", Required = Required.Always)]
        public Decimal BidPrice { get; set; }

        [JsonProperty(PropertyName = "aP", Required = Required.Always)]
        public Decimal AskPrice { get; set; }

        [JsonProperty(PropertyName = "bS", Required = Required.Always)]
        public Int64 BidSize { get; set; }

        [JsonProperty(PropertyName = "aS", Required = Required.Always)]
        public Int64 AskSize { get; set; }

        [JsonProperty(PropertyName = "t", Required = Required.Always)]
        public Int64 TimeOffset { get; set; }
    }
}