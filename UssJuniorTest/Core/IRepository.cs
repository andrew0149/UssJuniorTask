using UssJuniorTest.Core.Models;

namespace UssJuniorTest.Core;

/// <summary>
/// Репозиторий для операций с данными.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IRepository<out T> where T : Model
{
    /// <summary>
    /// Получить объект.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    T? Get(long id);

    /// <summary>
    /// Получить все объекты.
    /// </summary>
    /// <returns></returns>
    IEnumerable<T> GetAll();
}