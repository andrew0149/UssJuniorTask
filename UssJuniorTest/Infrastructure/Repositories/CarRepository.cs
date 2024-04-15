using UssJuniorTest.Core;
using UssJuniorTest.Core.Models;
using UssJuniorTest.Infrastructure.Store;

namespace UssJuniorTest.Infrastructure.Repositories;

/// <summary>
/// Класс-репозиторий автомобилей.
/// </summary>
public sealed class CarRepository : IRepository<Car>
{
    private readonly IStore _store;

    public CarRepository(IStore store)
    {
        _store = store;
    }

    /// <inheritdoc />
    public Car? Get(long id)
    {
        return _store.GetAllCars().FirstOrDefault(x => x.Id == id);
    }

    /// <inheritdoc />
    public IEnumerable<Car> GetAll()
    {
        return _store.GetAllCars();
    }
}