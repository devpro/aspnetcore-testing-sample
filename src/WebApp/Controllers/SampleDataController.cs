using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Devpro.AspNetCoreTestingSample.Dal.MongoDb.Repositories;
using Devpro.AspNetCoreTestingSample.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Devpro.AspNetCoreTestingSample.WebApp.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private static string[] Summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };

        private readonly UserRepository _userRepository;

        public SampleDataController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        [HttpGet("[action]")]
        public async Task<List<UserModel>> CheckMongoDb()
        {
            return await _userRepository.DummyCheckAsync();
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}
