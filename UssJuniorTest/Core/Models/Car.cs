namespace UssJuniorTest.Core.Models;

/// <summary>
/// Автомобиль.
/// </summary>
public class Car : Model
{
    /// <summary>
    /// Производитель.
    /// </summary>
    public string Manufacturer  { get; set; }

    /// <summary>
    /// Модель автомобиля.
    /// </summary>
    public string Model { get; set; }
}