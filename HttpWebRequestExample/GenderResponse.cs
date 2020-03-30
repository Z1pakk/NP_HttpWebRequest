using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpWebRequestExample
{
    public class GenderResponse
    {
        [JsonProperty("name")]
        public string NameOfPerson { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("probability")]
        public double Probability { get; set; }

        public int Count { get; set; }
    }
}
