using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_02
{
    [Serializable]
    internal class Score
    {
        [JsonProperty("scorenum")]
        [JsonRequired]
        public int number { get; set; }
        [JsonProperty("type")]
        [JsonRequired]
        public string contributionType { get; set; }
        [JsonProperty("date")]
        [JsonRequired]
        public string openDate { get; set; }
        [JsonProperty("sms")]
        [JsonRequired]
        public bool getSMS { get; set; }
        [JsonProperty("connection")]
        [JsonRequired]
        public bool connectIB { get; set; }

        //[JsonConstructor]
        public Score(int scorenum, string type, string date, bool sms, bool connection) 
        {
            number = scorenum;
            contributionType = type;
            openDate = date;
            getSMS = sms;
            connectIB = connection;
        }

    }
}
