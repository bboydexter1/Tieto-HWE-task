using ApiLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;


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
            double expceted = 66.20;

            Assert.AreEqual(testWeather.TemperatureF, expceted);
        }
    }
}
