using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ApiLogic;
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
                    DateFormatted = result.paramList[index].date,//DateTime.Now.AddDays(index).ToString("d"),
                    TemperatureC = result.paramList[index].temperature.value,//rng.Next(-20, 55),
                    Summary = result.paramList[index].description[0].text//Summaries[rng.Next(Summaries.Length)]
                });
            }
        }
    }
}

