using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using WebApi2.Model.Danual;
using WebApi2.Services;

namespace WebApi2.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            //EbayListing myebaylisting = new EbayListing();
            //Product product = new Product();

            //product = myebaylisting;

            //myebaylisting = (EbayListing)product;



            //TestClass test1 = new TestClass { FirstName = "Miriam", LastName = "Waymire", Place = 1 };
            //TestClass test2 = new TestClass { FirstName = "Keith", LastName = "Wilson", Place = 2 };

            //List <TestClass> testClasses = new List<TestClass>();

            //testClasses.Add(test1);
            //testClasses.Add(test2);

            //return null;
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }

    public class TestClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Place { get; set; }
    }
}