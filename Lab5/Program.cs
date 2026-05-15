namespace Lab5;

internal class Program
{
    private static void Main(string[] args)
    {
        Gemstone[] stones =
        [
            new Diamond(1.2, 95),
            new Amethyst(0.8, 40),
            new Ruby(2.0, 75),
            new Diamond(0.5, 85),
            new Amethyst(0.3, 30)
        ];

        var necklace = new Necklace(stones);
        Console.WriteLine("Init stones:");
        PrintStones(necklace.Stones);

        Console.WriteLine($"\nNecklace weight: {necklace.CalculateTotalWeight()} carats");
        Console.WriteLine($"Necklace price: {necklace.CalculateTotalPrice()} $");

        Console.WriteLine("\nSorted stones:");
        necklace.SortGemstonesByPrice();
        PrintStones(necklace.Stones);

        Console.WriteLine("\nGemstones by transparency (from 70% to 100%):");
        var foundStones = necklace.FindByTransparency(70, 100);
        PrintStones(foundStones);
    }

    private static void PrintStones(Gemstone[] gemstones)
    {
        foreach (var gemstone in gemstones)
        {
            Console.WriteLine(gemstone);
        }
    }
}
