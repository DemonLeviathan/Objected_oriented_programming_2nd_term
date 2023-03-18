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
        public int number { get; set; }
        [JsonProperty("type")]
        public string contributionType { get; set; }
        [JsonProperty("date")]
        public string openDate { get; set; }
        [JsonProperty("sms")]
        public bool getSMS { get; set; }
        [JsonProperty("connection")]
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
