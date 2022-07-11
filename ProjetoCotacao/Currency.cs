using Newtonsoft.Json;

namespace ProjetoCotacao
{
    public class Currency
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "buy")]
        public decimal Buy { get; set; }

        [JsonProperty(PropertyName = "bell")]
        public decimal Sell { get; set; }

        [JsonProperty(PropertyName = "variation")]
        public decimal Variation { get; set; }


    }
}
