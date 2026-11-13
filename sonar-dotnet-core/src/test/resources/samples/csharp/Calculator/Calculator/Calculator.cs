namespace Calculator;

public class Calculator
{
    public int Add(int a, int b, Predicate<int> predicate)
    {
        var sum = a + b;
        return predicate(sum)
            ? sum
            : 0;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static int Divide(int a, int b)
    {
        return a / b;
    }
}
