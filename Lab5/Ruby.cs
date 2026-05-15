namespace Lab5;

/// <summary>Представляє дорогоцінний рубін.</summary>
public class Ruby : Gemstone
{
    /// <summary>Створює рубін.</summary>
    /// <param name="weight">Вага в каратах.</param>
    /// <param name="transparency">Прозорість у відсотках.</param>
    public Ruby(double weight, int transparency)
    {
        IsPrecious = true;
        BasePricePerCarat = 1500m;
        Name = "Ruby";
        WeightInCarats = weight;
        Transparency = transparency;
    }
}