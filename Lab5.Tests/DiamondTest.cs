using System;
using JetBrains.Annotations;
using Xunit;

namespace Lab5.Tests;

[TestSubject(typeof(Diamond))]
public class DiamondTests
{
    [Fact]
    public void Constructor_WhenDataIsCorrect_ShouldFillAppropriateFields()
    {
        // Arrange
        var weight = 0.23;
        var transparency = 90;

        // Act
        var gemstone = new Diamond(weight, transparency);

        // Assert
        Assert.Equal(weight, gemstone.WeightInCarats);
        Assert.Equal(transparency, gemstone.Transparency);
        Assert.Equal("Diamond", gemstone.Name);
        Assert.True(gemstone.IsPrecious);
    }

    [Fact]
    public void Constructor_WhenWeightIsNegative_ShouldThrowError()
    {
        // Arrange
        var weight = -0.5;
        var transparency = 90;

        // Act
        var exception = Assert.Throws<ArgumentException>(() => new Diamond(weight, transparency));

        // Assert
        Assert.Equal("WeightInCarats", exception.ParamName);
    }

    [Fact]
    public void CalculatePrice_WhenTransparencyIsHigh_ShouldAddBonus()
    {
        // Arrange
        var diamond = new Diamond(1.0, 95);
        var expectedPrice = 2000m * 1.5m;

        // Act
        var result = diamond.CalculatePrice();

        // Assert
        Assert.Equal(expectedPrice, result);
    }

    [Fact]
    public void CalculatePrice_WhenTransparencyIsLow_ShouldReturnBasePrice()
    {
        // Arrange
        var diamond = new Diamond(1.0, 80);
        var expectedPrice = 2000m;

        // Act
        var result = diamond.CalculatePrice();

        // Assert
        Assert.Equal(expectedPrice, result);
    }

    [Fact]
    public void ToString_WhenCalled_ShouldReturnFormattedString()
    {
        // Arrange
        var ruby = new Diamond(3, 70);
        var expectedStart = "Diamond; Type: Precious; Weight: 3 carats; Transparency: 70%; Price:";

        // Act
        var result = ruby.ToString();

        // Assert
        Assert.StartsWith(expectedStart, result);
    }
}