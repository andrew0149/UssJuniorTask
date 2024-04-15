using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using Microsoft.AspNetCore.Mvc;
using UssJuniorTest.Core;
using UssJuniorTest.Core.Models;
using UssJuniorTest.Infrastructure.Repositories;
using UssJuniorTest.Infrastructure.Store;

namespace UssJuniorTest.Controllers;

[Route("api/driveLog")]
public class DriveLogController : Controller
{
    private readonly IStore _store;
    public DriveLogController(IStore store)
    {
        _store = store;
    }

    // TODO
    [HttpGet("start={intervalStart:DateTime}&end={intervalEnd:DateTime}")]
    public IActionResult? GetDriveLogsAggregation(DateTime intervalStart, DateTime intervalEnd)
    {
        return Json(
            _store
                .GetAllDriveLogs()
                .Where(driveLog => driveLog.StartDateTime >= intervalStart)
                .Where(driveLog => driveLog.EndDateTime <= intervalEnd)
                .GroupBy(driveLog => new {driveLog.CarId, driveLog.PersonId})
                .Select(group => new
                {
                    person = _store.GetAllPersons()
                        .Where(person => person.Id == group.First().PersonId)
                        .Select(person => new
                        {
                            name = person.Name,
                            age = person.Age
                        })
                        .First(),
                    car = _store.GetAllCars()
                        .Where(car => car.Id == group.First().CarId)
                        .Select(car => new
                        {
                            manufacturer = car.Manufacturer, 
                            model = car.Model
                        })
                        .First(),
                    totalCarUsage = new {
                        days = group.Sum(driveLog => (driveLog.EndDateTime - driveLog.StartDateTime).Days),
                        hours = group.Sum(driveLog => (driveLog.EndDateTime - driveLog.StartDateTime).Hours),
                        minutes = group.Sum(driveLog => (driveLog.EndDateTime - driveLog.StartDateTime).Minutes)
                    },
                }),
            new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            });
    }
}