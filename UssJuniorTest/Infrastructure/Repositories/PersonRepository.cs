using UssJuniorTest.Core;
using UssJuniorTest.Core.Models;
using UssJuniorTest.Infrastructure.Store;

namespace UssJuniorTest.Infrastructure.Repositories;

/// <summary>
/// Класс-репозиторий людей.
/// </summary>
public sealed class PersonRepository : IRepository<Person>
{
    private readonly IStore _store;

    public PersonRepository(IStore store)
    {
        _store = store;
    }

    /// <inheritdoc />
    public Person? Get(long id)
    {
        return _store.GetAllPersons().FirstOrDefault(x => x.Id == id);
    }

    /// <inheritdoc />
    public IEnumerable<Person> GetAll()
    {
        return _store.GetAllPersons();
    }
}