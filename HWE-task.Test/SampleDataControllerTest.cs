using Microsoft.VisualStudio.TestTools.UnitTesting;
using static HWE_task.Controllers.SampleDataController;

namespace HWE_task.Test
{
    [TestClass]
    public class SampleDataControllerTest
    {
        [TestMethod]
        public void TestFahrenheitCalculation()
        {

            WeatherForecast testWeather = new WeatherForecast();
            testWeather.TemperatureC = 19;
            int expceted = 66;

            Assert.AreEqual(testWeather.TemperatureF, expceted);
        }
    }
}
