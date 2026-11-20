using Xunit;

namespace Calculator.xUnit;

public class DivideTests
{
    [Fact]
    public void Divide_ReturnsQuotient()
    {
        Assert.Equal(4, global::Calculator.Calculator.Divide(12, 3));
    }
}
