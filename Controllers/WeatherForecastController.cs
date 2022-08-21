using Microsoft.AspNetCore.Mvc;
using models;
using services;
namespace _18._08.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    readonly UserService _userService;
    public WeatherForecastController(ILogger<WeatherForecastController> logger, UserService userService)
    {
        _userService = userService;
        _logger = logger;
    }

    [HttpGet(Name = "GetAllUsers")]
    public List<User> GetAllUser(){
        var user =  _userService.GetUsers();
        return user;
    }

    
    [HttpGet(Name = "GetWeatherForecast")]
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
    
    [HttpPost(Name = "GetModel")]
    public string GetModel()
    {
        _logger.LogInformation("Был запрос GetModel");
        return "получилось";
    }
}
