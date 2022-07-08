using CSharpLearning.Services.List;
using CSharpLearning.Services.List.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSharpLearning.Controllers
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
            this._logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        [Route("GetList")]
        public List<ListCSharp> GetListCSharp()
        {
            List<ListCSharp> response = new List<ListCSharp>();

            response.Add(new ListCSharp { Group = "List", PropertyId = 1, Name = "Capacity", Description = "Gets or sets the total number of elements the internal data structure can hold without resizing." });
            response.Add(new ListCSharp { Group = "List", PropertyId = 2, Name = "Count", Description = "Gets the number of elements contained in the List<T>." });
            response.Add(new ListCSharp { Group = "List", PropertyId = 3, Name = "Item[Int32]", Description = "Gets or sets the element at the specified index." });
            response.Add(new ListCSharp { Group = "List", PropertyId = 4, Name = "Add(T)", Description = "	Adds an object to the end of the List<T>." });
            response.Add(new ListCSharp { Group = "List", PropertyId = 5, Name = "AddRange(IEnumerable<T>)", Description = "Adds the elements of the specified collection to the end of the List<T>." });
            response.Add(new ListCSharp { Group = "List", PropertyId = 6, Name = "AsReadOnly()", Description = "Returns a read-only ReadOnlyCollection<T> wrapper for the current collection." });
            response.Add(new ListCSharp { Group = "List", PropertyId = 7, Name = "BinarySearch()", Description = "Uses a binary search algorithm to locate a specific element in the sorted List<T> or a portion of it." });

            response.Add(new ListCSharp { Group = "List", PropertyId = 8, Name = "Clear()", Description = "	Removes all elements from the List<T>." });
            response.Add(new ListCSharp { Group = "List", PropertyId = 9, Name = "Contains(T)", Description = "Determines whether an element is in the List<T>." });
            response.Add(new ListCSharp { Group = "List", PropertyId = 10, Name = "ConvertAll(Converter)", Description = "Converts the elements in the current List<T> to another type, and returns a list containing the converted elements." });
            response.Add(new ListCSharp { Group = "List", PropertyId = 11, Name = "Add(T)", Description = "	Adds an object to the end of the List<T>." });
            response.Add(new ListCSharp { Group = "List", PropertyId = 12, Name = "AddRange(IEnumerable<T>)", Description = "Adds the elements of the specified collection to the end of the List<T>." });
            response.Add(new ListCSharp { Group = "List", PropertyId = 13, Name = "Add(T)", Description = "	Adds an object to the end of the List<T>." });
            response.Add(new ListCSharp { Group = "List", PropertyId = 14, Name = "AddRange(IEnumerable<T>)", Description = "Adds the elements of the specified collection to the end of the List<T>." });

            return response;
        }

        [HttpGet]
        [Route("GetEnumerable")]
        public List<ListCSharp> GetEnumerable()
        {
            List<ListCSharp> response = new List<ListCSharp>();

            response.Add(new ListCSharp { Group = "Enumerable", PropertyId = 1, Name = "aa", Description = "Gets or sets the total number of elements the internal data structure can hold without resizing." });
            response.Add(new ListCSharp { Group = "Enumerable", PropertyId = 2, Name = "aa", Description = "Gets the number of elements contained in the List<T>." });
            response.Add(new ListCSharp { Group = "Enumerable", PropertyId = 3, Name = "aa[aa]", Description = "Gets or sets the element at the specified index." });
            response.Add(new ListCSharp { Group = "Enumerable", PropertyId = 4, Name = "aa(a)", Description = "	Adds an object to the end of the List<T>." });
            response.Add(new ListCSharp { Group = "Enumerable", PropertyId = 5, Name = "aa(aaa<a>)", Description = "Adds the elements of the specified collection to the end of the List<T>." });

            return response;
        }
    }
}