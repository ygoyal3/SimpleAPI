using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        WeatherForecastController obj;
        [Fact]
        public void GetReturnValue()
        {
              obj=new WeatherForecastController();
              var objget=obj.Get(1);
              Assert.Equal("Ritu Garg1",objget.Value);
        }
    }
}
