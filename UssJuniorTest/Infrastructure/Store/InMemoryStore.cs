using UssJuniorTest.Core.Models;

namespace UssJuniorTest.Infrastructure.Store;

/// <summary>
/// Реализация хранилища в памяти приложения. Эмуляция БД.
/// </summary>
internal sealed class InMemoryStore : IStore
{
    public IQueryable<Car> GetAllCars() => _carObjects.AsQueryable();

    public IQueryable<Person> GetAllPersons() => _personObjects.AsQueryable();

    public IQueryable<DriveLog> GetAllDriveLogs() => _driveLogsObjects.AsQueryable();
    
    private static List<Car> _carObjects => new()
    {
        new()
        {
            Id = 1,
            Manufacturer = "Toyota",
            Model = "Camry"
        },
        new()
        {
            Id = 2,
            Manufacturer = "Volkswagen",
            Model = "Golf"
        },
        new()
        {
            Id = 3,
            Manufacturer = "ГАЗ",
            Model = "ГАЗель"
        }
    };

    private static List<Person> _personObjects => new()
    {
        new()
        {
            Id = 1,
            Name = "Иванов",
            Age = 35
        },
        new()
        {
            Id = 2,
            Name = "Петров",
            Age = 44
        },
        new()
        {
            Id = 3,
            Name = "Сидоров",
            Age = 56
        }
    };
    
    private static List<DriveLog> _driveLogsObjects => new()
    {
        new()
        {
            Id = 1,
            CarId = 1,
            PersonId = 1,
            StartDateTime = new DateTime(2024, 3, 10, 13, 6, 0),
            EndDateTime = new DateTime(2024, 3, 10, 15, 17, 0)
        },
        new()
        {
            Id = 2,
            CarId = 3,
            PersonId = 1,
            StartDateTime = new DateTime(2024, 3, 10, 16, 0, 0),
            EndDateTime = new DateTime(2024, 3, 10, 19, 1, 0)
        },
        new()
        {
            Id = 3,
            CarId = 1,
            PersonId = 2,
            StartDateTime = new DateTime(2024, 3, 11, 16, 17, 0),
            EndDateTime = new DateTime(2024, 3, 11, 17, 1, 0)
        },
        new()
        {
            Id = 4,
            CarId = 2,
            PersonId = 3,
            StartDateTime = new DateTime(2024, 3, 11, 14, 0, 0),
            EndDateTime = new DateTime(2024, 3, 11, 18, 2, 0)
        }
    };
}