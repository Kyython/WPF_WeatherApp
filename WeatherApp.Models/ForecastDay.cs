using Newtonsoft.Json;
using System;

namespace WeatherApp.Models
{
    public class ForecastDay
    {
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        [JsonProperty("day")]
        public Day Day { get; set; }
    }
}
