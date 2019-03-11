using System.Collections.Generic;
using Newtonsoft.Json;

namespace InfluxDB.Client.Domain
{
    public class AbstractHasLabels : AbstractHasLinks
    {
        [JsonProperty("labels")] 
        public List<Label> Labels { get; set; } = new List<Label>();
    }
}