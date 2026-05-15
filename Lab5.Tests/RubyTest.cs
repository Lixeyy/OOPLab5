using System;
using JetBrains.Annotations;
using Xunit;

namespace Lab5.Tests;

[TestSubject(typeof(Ruby))]
public class RubyTests
{
    [Fact]
    public void Constructor_WhenDataIsCorrect_ShouldFillAppropriateFields()
    {
        // Arrange
        var weight = 2;
        var transparency = 35;

        // Act
        var gemstone = new Ruby(weight, transparency);

        // Assert
        Assert.Equal(weight, gemstone.WeightInCarats);
        Assert.Equal(transparency, gemstone.Transparency);
        Assert.Equal("Ruby", gemstone.Name);
        Assert.True(gemstone.IsPrecious);
    }

    [Fact]
    public void Constructor_WhenTransparencyIsNegative_ShouldThrowError()
    {
        // Arrange
        var weight = 2;
        var transparency = -35;

        // Act
        var exception = Assert.Throws<ArgumentException>(() => new Ruby(weight, transparency));

        // Assert
        Assert.Equal("Transparency", exception.ParamName);
    }

    [Fact]
    public void CalculatePrice_WhenCalled_ShouldReturnCorrectBasePrice()
    {
        // Arrange
        var ruby = new Ruby(2.0, 80);
        var expectedPrice = 3000m;

        // Act
        var result = ruby.CalculatePrice();

        // Assert
        Assert.Equal(expectedPrice, result);
    }

    [Fact]
    public void ToString_WhenCalled_ShouldReturnFormattedString()
    {
        // Arrange
        var ruby = new Ruby(1.0, 80);
        var expected = "Ruby; Type: Precious; Weight: 1 carats; Transparency: 80%; Price: 1500.00$";

        // Act
        var result = ruby.ToString();

        // Assert
        Assert.Equal(expected, result);
    }
}