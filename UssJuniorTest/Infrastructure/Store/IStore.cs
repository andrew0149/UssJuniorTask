using UssJuniorTest.Core.Models;

namespace UssJuniorTest.Infrastructure.Store;

/// <summary>
/// Хранилище данных. Эмуляция БД.
/// </summary>
public interface IStore
{
    IQueryable<Car> GetAllCars();
    
    IQueryable<Person> GetAllPersons();
    
    IQueryable<DriveLog> GetAllDriveLogs();
}