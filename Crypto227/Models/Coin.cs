using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crypto227.Models
{

    public partial class CoinObject
    {
        [JsonProperty("RAW")]
        public Raw Raw { get; set; }

        [JsonProperty("DISPLAY")]
        public Display Display { get; set; }
    }

    public partial class Raw
    {
        [JsonProperty("BTC")]
        public Eth Btc { get; set; }

        [JsonProperty("ETH")]
        public Eth Eth { get; set; }

        [JsonProperty("LTC")]
        public Eth Ltc { get; set; }

        [JsonProperty("ZEC")]
        public Eth Zec { get; set; }

        [JsonProperty("DASH")]
        public Eth Dash { get; set; }
    }

    public partial class Eth
    {
        [JsonProperty("USD")]
        public EthUsd Usd { get; set; }
    }

    public partial class EthUsd
    {
        [JsonProperty("TYPE")]
        public string Type { get; set; }

        [JsonProperty("MARKET")]
        public string Market { get; set; }

        [JsonProperty("FROMSYMBOL")]
        public string Fromsymbol { get; set; }

        [JsonProperty("TOSYMBOL")]
        public string Tosymbol { get; set; }

        [JsonProperty("FLAGS")]
        public string Flags { get; set; }

        [JsonProperty("PRICE")]
        public double Price { get; set; }

        [JsonProperty("LASTUPDATE")]
        public long Lastupdate { get; set; }

        [JsonProperty("LASTVOLUME")]
        public double Lastvolume { get; set; }

        [JsonProperty("LASTVOLUMETO")]
        public double Lastvolumeto { get; set; }

        [JsonProperty("LASTTRADEID")]
        public string Lasttradeid { get; set; }

        [JsonProperty("VOLUMEDAY")]
        public double Volumeday { get; set; }

        [JsonProperty("VOLUMEDAYTO")]
        public double Volumedayto { get; set; }

        [JsonProperty("VOLUME24HOUR")]
        public double Volume24Hour { get; set; }

        [JsonProperty("VOLUME24HOURTO")]
        public double Volume24Hourto { get; set; }

        [JsonProperty("OPENDAY")]
        public double Openday { get; set; }

        [JsonProperty("HIGHDAY")]
        public double Highday { get; set; }

        [JsonProperty("LOWDAY")]
        public double Lowday { get; set; }

        [JsonProperty("OPEN24HOUR")]
        public double Open24Hour { get; set; }

        [JsonProperty("HIGH24HOUR")]
        public double High24Hour { get; set; }

        [JsonProperty("LOW24HOUR")]
        public double Low24Hour { get; set; }

        [JsonProperty("LASTMARKET")]
        public string Lastmarket { get; set; }

        [JsonProperty("CHANGE24HOUR")]
        public double Change24Hour { get; set; }

        [JsonProperty("CHANGEPCT24HOUR")]
        public double Changepct24Hour { get; set; }

        [JsonProperty("CHANGEDAY")]
        public double Changeday { get; set; }

        [JsonProperty("CHANGEPCTDAY")]
        public double Changepctday { get; set; }

        [JsonProperty("SUPPLY")]
        public double Supply { get; set; }

        [JsonProperty("MKTCAP")]
        public double Mktcap { get; set; }

        [JsonProperty("TOTALVOLUME24H")]
        public double Totalvolume24H { get; set; }

        [JsonProperty("TOTALVOLUME24HTO")]
        public double Totalvolume24Hto { get; set; }
    }

  public partial class Display
    {
        [JsonProperty("BTC")]
        public Display Btc { get; set; }

        [JsonProperty("ETH")]
        public Display Eth { get; set; }

        [JsonProperty("LTC")]
        public Display Ltc { get; set; }

        [JsonProperty("ZEC")]
        public Display Zec { get; set; }

        [JsonProperty("DASH")]
        public Display Dash { get; set; }
    }

    public partial class Display
    {
        [JsonProperty("USD")]
        public Dictionary<string, string> Usd { get; set; }
    }
}
