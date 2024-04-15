namespace UssJuniorTest.Core.Models;

/// <summary>
/// Человек.
/// </summary>
public class Person : Model
{
    /// <summary>
    /// Имя.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Возраст.
    /// </summary>
    public int Age { get; set; }
}