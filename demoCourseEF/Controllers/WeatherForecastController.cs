using Microsoft.AspNetCore.Mvc;

namespace demoCourseEF.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IConfiguration _config;

    public WeatherForecastController(
        ILogger<WeatherForecastController> logger,
        IConfiguration config)
    {
        _logger = logger;
        this._config = config;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var conn = _config.GetConnectionString("DefaultConnection");
        return Ok(conn);
    }
}
