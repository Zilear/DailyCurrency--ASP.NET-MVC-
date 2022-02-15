using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Model
{
    public partial class Root
    {
        [JsonProperty("Date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("PreviousDate")]
        public DateTimeOffset PreviousDate { get; set; }

        [JsonProperty("PreviousURL")]
        public string PreviousUrl { get; set; }

        [JsonProperty("Timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("Valute")]
        public Dictionary<string, Currency> Currency { get; set; }
    }
}
