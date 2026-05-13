namespace Lab5;

/// <summary>Представляє напівдорогоцінний аметист.</summary>
public class Amethyst : Gemstone
{
    /// <summary>Створює аметист.</summary>
    /// <param name="weight">Вага в каратах.</param>
    /// <param name="transparency">Прозорість у відсотках.</param>
    public Amethyst(double weight, int transparency) 
    {
        IsPrecious = false;
        BasePricePerCarat = 50m;
        Name = "Amethyst";
        WeightInCarats = weight;
        Transparency = transparency;
    }

    /// <summary>Обчислює вартість аметиста з урахуванням націнки за малу вагу.</summary>
    public override decimal CalculatePrice()
    {
        var basePrice = base.CalculatePrice();
        return WeightInCarats < 0.5 ? basePrice * 2 : basePrice;
    }
}