using JetBrains.Annotations;
using Lab5;
using Xunit;

namespace Lab5.Tests;

[TestSubject(typeof(Amethyst))]
public class AmethystTests
{
    [Fact]
    public void Constructor_WhenDataIsCorrect_ShouldFillAppropriateFields()
    {
        // Arrange
        var weight = 1.5;
        var transparency = 70;

        // Act
        var gemstone = new Amethyst(weight, transparency);

        // Assert
        Assert.Equal(weight, gemstone.WeightInCarats);
        Assert.Equal(transparency, gemstone.Transparency);
        Assert.Equal("Amethyst", gemstone.Name);
        Assert.False(gemstone.IsPrecious);
    }

    [Fact]
    public void CalculatePrice_WhenWeightIsSmall_ShouldAddBonus()
    {
        // Arrange
        var amethyst = new Amethyst(0.4, 50);
        var expectedPrice = (decimal)0.4 * 50m * 2m;

        // Act
        var result = amethyst.CalculatePrice();

        // Assert
        Assert.Equal(expectedPrice, result);
    }

    [Fact]
    public void CalculatePrice_WhenWeightIsNormal_ShouldReturnBasePrice()
    {
        // Arrange
        var amethyst = new Amethyst(1.0, 50);
        var expectedPrice = 50m;

        // Act
        var result = amethyst.CalculatePrice();

        // Assert
        Assert.Equal(expectedPrice, result);
    }
    
    [Fact]
    public void ToString_WhenCalled_ShouldReturnFormattedString()
    {
        // Arrange
        var ruby = new Amethyst(0.255, 85);
        var expected = "Amethyst; Type: Semi-precious; Weight: 0.255 carats; Transparency: 85%; Price: 25.50$";

        // Act
        var result = ruby.ToString();

        // Assert
        Assert.Equal(expected, result);
    }
}