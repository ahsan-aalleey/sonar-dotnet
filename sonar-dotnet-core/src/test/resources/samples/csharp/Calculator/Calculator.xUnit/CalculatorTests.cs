using Xunit;

namespace Calculator.xUnit;

public class MathTests
{
    [Fact]
    public void Subtract_ReturnsDifference()
    {
        Assert.Equal(2, global::Calculator.Calculator.Subtract(5, 3));
    }

    [Fact]
    public void Multiply_ReturnsProduct()
    {
        Assert.Equal(12, global::Calculator.Calculator.Multiply(3, 4));
    }
}