namespace UssJuniorTest.Core.Models;

/// <summary>
/// Базовая модель для всех сущностей.
/// </summary>
public abstract class Model
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public long Id { get; set; }
}