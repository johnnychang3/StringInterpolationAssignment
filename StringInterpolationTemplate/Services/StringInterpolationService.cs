using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number02()
    {
        var dateNow = _date.Now;
        return $"{dateNow:yyyy.MM.dd}";
    }

    public string Number03()
    {
        var dateNow = _date.Now;
        return $"Day {dateNow:dd} of {dateNow:MMMM, yyyy}";
    }

    public string Number04()
    {
        var dateNow = _date.Now;
        return $"Year: {dateNow:yyyy}, Month: {dateNow:MM}, Day: {dateNow:dd}";
    }

    public string Number05()
    {
        var dateNow = _date.Now;
        return $"{dateNow.DayOfWeek,10}";
    }

    public string Number06()
    {
        var dateNow = _date.Now;
        return $"{dateNow,10:t}{dateNow,10:dddd}";
    }

    public string Number07()
    {
        var dateNow = _date.Now;
        return $"h:{dateNow:hh}, m:{dateNow:mm}, s:{dateNow:ss}";
    }

    public string Number08()
    {
        var dateNow = _date.Now;
        return $"{dateNow:yyyy}.{dateNow:MM}.{dateNow:dd}.{dateNow:hh}.{dateNow:mm}.{dateNow:ss}";
    }

    public string Number09()
    {
        var pi = Math.PI;
        return $"{pi:C2}";
    }

    public string Number10()
    {
        var pi = Math.PI;
        return $"{pi,10:F3}";
    }

    public string Number11()
    {
        var dateNow = DateTime.Now;
        return $"{dateNow.Year.ToString("X")}";
    }
}
