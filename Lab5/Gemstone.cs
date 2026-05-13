namespace Lab5;

/// <summary>Базовий клас для коштовного каміння.</summary>
public abstract class Gemstone
{
    /// <summary>Чи є камінь дорогоцінним.</summary>
    public bool IsPrecious { get; protected init; }

    /// <summary>Вага каменя в каратах.</summary>
    public double WeightInCarats
    {
        get;
        init => field = value < 0
            ? throw new ArgumentException("Weight cannot be negative", nameof(WeightInCarats))
            : value;
    }

    /// <summary>Рівень прозорості каменя у відсотках.</summary>
    public int Transparency {
        get;
        init => field = value < 0
            ? throw new ArgumentException("Transparency cannot be negative", nameof(Transparency))
            : value;
    }

    /// <summary>Назва каменя.</summary>
    public string Name {        
        get;
        init => field = string.IsNullOrWhiteSpace(value)
            ? throw new ArgumentException("Name cannot be empty", nameof(Name))
            : value.Trim();
    } = "None";

    /// <summary>Базова ціна за карат каменю.</summary>
    protected decimal BasePricePerCarat
    {
        get;
        init => field = value < 0
            ? throw new ArgumentException("Base price cannot be negative", nameof(BasePricePerCarat))
            : value;
    }

    /// <summary>Обчислює вартість каменя.</summary>
    public virtual decimal CalculatePrice()
    {
        return (decimal)WeightInCarats * BasePricePerCarat;
    }

    /// <summary>Повертає рядкове представлення каменя.</summary>
    public override string ToString()
    {
        var type = IsPrecious ? "Precious" : "Semi-precious";
        return $"{Name}; Type: {type}; Weight: {WeightInCarats} carats; Transparency: {Transparency}%; Price: {CalculatePrice()}$";
    }
}