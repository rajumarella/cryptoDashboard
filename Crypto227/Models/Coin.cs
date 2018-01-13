using Crypto227.Supporters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Crypto227.Models
{
    /// <summary>
    ///  RAW and DISPLAY details will be saved as keys
    /// </summary>
    public class Coin
    {
        [JsonConverter(typeof(CoinConverter))]
        public Dictionary<string, DataType> DataTypes { get; set; }

        public Coin()
        {
            DataTypes = new Dictionary<string, DataType>();
        }
    }

    /// <summary>
    /// BTC and other coins 
    /// </summary>
    public class DataType
    {
        public  Dictionary<string, CoinType> CoinTypes { get; set; }

        public DataType()
        {
            CoinTypes = new Dictionary<string, CoinType>();
        }
    }

    public class CoinType
    {
        public Dictionary<string, Dictionary<string,string>> Currencies { get; set; }

        public CoinType()
        {
            Currencies = new Dictionary<string, Dictionary<string, string>>();
        }
    }

    
    //public partial class CurrencyParam
    //{
    //    [JsonProperty("TYPE")]
    //    public string Type { get; set; }

    //    [JsonProperty("MARKET")]
    //    public string Market { get; set; }

    //    [JsonProperty("FROMSYMBOL")]
    //    public string Fromsymbol { get; set; }

    //    [JsonProperty("TOSYMBOL")]
    //    public string Tosymbol { get; set; }

    //    [JsonProperty("FLAGS")]
    //    public string Flags { get; set; }

    //    [JsonProperty("PRICE")]
    //    public string Price { get; set; }

    //    [JsonProperty("LASTUPDATE")]
    //    public string Lastupdate { get; set; }

    //    [JsonProperty("LASTVOLUME")]
    //    public string Lastvolume { get; set; }

    //    [JsonProperty("LASTVOLUMETO")]
    //    public string Lastvolumeto { get; set; }

    //    [JsonProperty("LASTTRADEID")]
    //    public string Lasttradeid { get; set; }

    //    [JsonProperty("VOLUMEDAY")]
    //    public string Volumeday { get; set; }

    //    [JsonProperty("VOLUMEDAYTO")]
    //    public string Volumedayto { get; set; }

    //    [JsonProperty("VOLUME24HOUR")]
    //    public string Volume24Hour { get; set; }

    //    [JsonProperty("VOLUME24HOURTO")]
    //    public string Volume24Hourto { get; set; }

    //    [JsonProperty("OPENDAY")]
    //    public string Openday { get; set; }

    //    [JsonProperty("HIGHDAY")]
    //    public string Highday { get; set; }

    //    [JsonProperty("LOWDAY")]
    //    public string Lowday { get; set; }

    //    [JsonProperty("OPEN24HOUR")]
    //    public string Open24Hour { get; set; }

    //    [JsonProperty("HIGH24HOUR")]
    //    public string High24Hour { get; set; }

    //    [JsonProperty("LOW24HOUR")]
    //    public string Low24Hour { get; set; }

    //    [JsonProperty("LASTMARKET")]
    //    public string Lastmarket { get; set; }

    //    [JsonProperty("CHANGE24HOUR")]
    //    public string Change24Hour { get; set; }

    //    [JsonProperty("CHANGEPCT24HOUR")]
    //    public string Changepct24Hour { get; set; }

    //    [JsonProperty("CHANGEDAY")]
    //    public string Changeday { get; set; }

    //    [JsonProperty("CHANGEPCTDAY")]
    //    public string Changepctday { get; set; }

    //    [JsonProperty("SUPPLY")]
    //    public string Supply { get; set; }

    //    [JsonProperty("MKTCAP")]
    //    public string Mktcap { get; set; }

    //    [JsonProperty("TOTALVOLUME24H")]
    //    public string Totalvolume24H { get; set; }

    //    [JsonProperty("TOTALVOLUME24HTO")]
    //    public string Totalvolume24Hto { get; set; }
    //}
}
