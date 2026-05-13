using JetBrains.Annotations;
using Xunit;

namespace Lab5.Tests;

[TestSubject(typeof(Necklace))]
public class NecklaceTests
{
    [Fact]
    public void CalculateTotalWeight_ShouldReturnCorrectSum()
    {
        // Arrange
        var stones = new Gemstone[]
        {
            new Ruby(1.5, 80),
            new Diamond(1.0, 70)
        };
        var necklace = new Necklace(stones);
        var expectedWeight = 2.5;

        // Act
        var result = necklace.CalculateTotalWeight();

        // Assert
        Assert.Equal(expectedWeight, result);
    }

    [Fact]
    public void CalculateTotalPrice_ShouldReturnCorrectSum()
    {
        // Arrange
        var stones = new Gemstone[]
        {
            new Ruby(1.0, 80),
            new Amethyst(2.0, 50)
        };
        var necklace = new Necklace(stones);
        var expectedPrice = 1600m;

        // Act
        var result = necklace.CalculateTotalPrice();

        // Assert
        Assert.Equal(expectedPrice, result);
    }

    [Fact]
    public void SortGemstonesByPrice_ShouldOrderStonesByPriceAscending()
    {
        // Arrange
        var amethyst = new Amethyst(1.0, 80);
        var ruby = new Ruby(1.0, 80);
        var diamond = new Diamond(1.0, 80);
        var stones = new Gemstone[] { ruby, diamond, amethyst };
        var necklace = new Necklace(stones);

        // Act
        necklace.SortGemstonesByPrice();

        // Assert
        Assert.Equal(amethyst, necklace.Stones[0]);
        Assert.Equal(ruby, necklace.Stones[1]);
        Assert.Equal(diamond, necklace.Stones[2]);
    }

    [Fact]
    public void FindByTransparency_WhenStonesMatch_ShouldReturnStonesInRange()
    {
        // Arrange
        var stone1 = new Ruby(1.0, 20);
        var stone2 = new Amethyst(1.0, 50);
        var stone3 = new Diamond(1.0, 80);
        var necklace = new Necklace([stone1, stone2, stone3]);

        // Act
        var result = necklace.FindByTransparency(40, 60);

        // Assert
        Assert.Single(result);
        Assert.Contains(stone2, result);
    }

    [Fact]
    public void FindByTransparency_WhenNoStonesMatch_ShouldReturnEmptyArray()
    {
        // Arrange
        var stone1 = new Ruby(1.0, 20);
        var necklace = new Necklace([stone1]);

        // Act
        var result = necklace.FindByTransparency(80, 100);

        // Assert
        Assert.Empty(result);
    }
}