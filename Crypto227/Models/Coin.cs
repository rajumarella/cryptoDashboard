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

    public class CoinListByVolume
    {
        [JsonProperty("Data")]
        public List<CoinListByVolumeDetails> Data { get; set; }
    }
    public partial class CoinListByVolumeDetails
    {
        [JsonProperty("SYMBOL")]
        public string Symbol { get; set; }

        [JsonProperty("SUPPLY")]
        public double Supply { get; set; }

        [JsonProperty("FULLNAME")]
        public string Fullname { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("ID")]
        public string Id { get; set; }

        [JsonProperty("VOLUME24HOURTO")]
        public double Volume24Hourto { get; set; }
    }
    public class CoinMain
    {
        public Coin CoinHeader { get; set; }
        public CoinListByVolume CoinDetialByVolume { get; set; }
    }
}
