using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HWE_task.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?id=3083829&APPID=6850ea0f0a2c664709ee1f2eeb158756&units=metric");

                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WeatherInfo>(json);

                return Enumerable.Range(1, 20).Select(index => new WeatherForecast
                {
                    DateFormatted = result.list[index].dt_txt,//DateTime.Now.AddDays(index).ToString("d"),
                    TemperatureC = result.list[index].main.temp,//rng.Next(-20, 55),
                    Summary = result.list[index].weather[0].description//Summaries[rng.Next(Summaries.Length)]
                });
            }
        }

        public class WeatherInfo
        {
            public List<list> list { get; set; }
        }

        public class list
        {
            public string dt_txt { get; set; }
            public main main { get; set; }
            public List<weather> weather { get; set; }
        }

        public class main
        {
            public double temp { get; set; }
        }

        public class weather
        {
            public string description { get; set; }
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public double TemperatureC { get; set; }
            public string Summary { get; set; }

            public double TemperatureF
            {
                get
                {
                    return 32 + (double)(TemperatureC / 0.5556);
                }
            }
        }
    }
}

