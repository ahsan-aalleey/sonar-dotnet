using Xunit;

namespace Calculator.xUnit;

public class ModuloTests
{
    [Fact]
    public void Modulo_ReturnsRemainder()
    {
        Assert.Equal(2, global::Calculator.Calculator.Modulo(12, 5));
    }
}
