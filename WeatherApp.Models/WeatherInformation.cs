using Newtonsoft.Json;

namespace WeatherApp.Models
{
    public class WeatherInformation
    {
        [JsonProperty("forecast")]
        public Forecast Forecast { get; set; }
    }
}
