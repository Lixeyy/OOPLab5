namespace Lab5;

/// <summary>Представляє дорогоцінний діамант.</summary>
public class Diamond: Gemstone
{
    /// <summary>Створює діамант.</summary>
    /// <param name="weight">Вага в каратах.</param>
    /// <param name="transparency">Прозорість у відсотках.</param>
    public Diamond(double weight, int transparency) 
    {
        IsPrecious = true;
        BasePricePerCarat = 2000m;
        Name = "Diamond";
        WeightInCarats = weight;
        Transparency = transparency;
    }

    /// <summary>Обчислює вартість діаманта з урахуванням націнки за високу прозорість.</summary>
    public override decimal CalculatePrice()
    {
        var basePrice = base.CalculatePrice();
        return Transparency > 90 ? basePrice * 1.5m : basePrice;
    }
}