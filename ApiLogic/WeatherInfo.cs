using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLogic
{
    public class WeatherInfo
    {
        [JsonProperty("list")]
        public List<ParamList> paramList { get; set; }
    }

    public class ParamList
    {
        [JsonProperty("dt_txt")]
        public string date { get; set; }
        [JsonProperty("main")]
        public Temperature temperature { get; set; }
        [JsonProperty("weather")]
        public List<WeatherDescription> description { get; set; }
    }

    public class Temperature
    {
        [JsonProperty("temp")]
        public double value { get; set; }
    }

    public class WeatherDescription
    {
        [JsonProperty("description")]
        public string text { get; set; }
    }
}
