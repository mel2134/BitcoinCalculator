using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BitcoinKälkulätorMelKosk
{
    public class BitcoinRates
    {
        public Data Data{ get; set; }
    }
    public class BTCEUR
    {
        public int CCSEQ { get; set; }
        public double VALUE { get; set; }
        public string VALUE_FLAG { get; set; }
        public int VALUE_LAST_UPDATE_TS { get; set; }
        public int VALUE_LAST_UPDATE_TS_NS { get; set; }
    }

    public class BTCGBP
    {
        public int CCSEQ { get; set; }
        public double VALUE { get; set; }
        public string VALUE_FLAG { get; set; }
        public int VALUE_LAST_UPDATE_TS { get; set; }
        public int VALUE_LAST_UPDATE_TS_NS { get; set; }
    }

    public class BTCUSD
    {
        public int CCSEQ { get; set; }
        public double VALUE { get; set; }
        public string VALUE_FLAG { get; set; }
        public int VALUE_LAST_UPDATE_TS { get; set; }
        public int VALUE_LAST_UPDATE_TS_NS { get; set; }
    }

    public class Data
    {
        [JsonProperty("BTC-USD")]
        public BTCUSD BTCUSD { get; set; }

        [JsonProperty("BTC-EUR")]
        public BTCEUR BTCEUR { get; set; }

        [JsonProperty("BTC-GBP")]
        public BTCGBP BTCGBP { get; set; }
    }
}
