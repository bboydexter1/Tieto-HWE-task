using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLogic
{

    public class WeatherForecast
    {
        public string DateFormatted { get; set; }
        public double TemperatureC { get; set; }
        public string Summary { get; set; }

        public double TemperatureF
        {
            get
            {
                return Math.Round(32 + (double)(TemperatureC / 0.5556), 2);
            }
        }
    }

}
