using Xunit;

namespace Calculator.xUnit;

public class SubtractTests
{
    [Fact]
    public void Subtract_ReturnsDifference()
    {
        var sut = new global::Calculator.Calculator();
        Assert.Equal(2, sut.Subtract(5, 3));
    }
}