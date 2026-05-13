namespace Lab5;

/// <summary>Представляє намисто з коштовного каміння.</summary>
public class Necklace(Gemstone[] stones)
{
    /// <summary>Масив каменів у намисті.</summary>
    public Gemstone[] Stones { get; } = stones;

    /// <summary>Обчислює загальну вагу намиста в каратах.</summary>
    public double CalculateTotalWeight()
    {
        double totalWeight = 0;
        foreach (var gemstone in Stones)
        {
            totalWeight += gemstone.WeightInCarats;
        }
        return totalWeight;
    }

    /// <summary>Обчислює загальну вартість намиста.</summary>
    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (var gemstone in Stones)
        {
            totalPrice += gemstone.CalculatePrice();
        }
        return totalPrice;
    }

    /// <summary>Сортує камені за ціною.</summary>
    public void SortGemstonesByPrice()
    {
        Stones.Sort(GemstoneComparerByPrice);
    }

    /// <summary>Шукає камені за діапазоном прозорості.</summary>
    /// <param name="min">Мінімальна прозорість.</param>
    /// <param name="max">Максимальна прозорість.</param>
    public Gemstone[] FindByTransparency(double min, double max)
    {
        return Array.FindAll(Stones, stone => stone.Transparency >= min && stone.Transparency <= max);
    }

    private static int GemstoneComparerByPrice(Gemstone gemstone1, Gemstone gemstone2)
    {
        var gemstone1Price = gemstone1.CalculatePrice();
        var gemstone2Price = gemstone2.CalculatePrice();
        return gemstone1Price.CompareTo(gemstone2Price);
    }
}