using Xunit;

public class CalculatorTests
{
    private readonly Calculator _calculator;

    public CalculatorTests()
    {
        _calculator = new Calculator();
    }

    [Fact]
    public void Add_ReturnsCorrectResult()
    {
        var result = _calculator.Add(5, 4);
        Assert.Equal(9, result);
    }

    [Fact]
    public void Subtract_ReturnsCorrectResult()
    {
        var result = _calculator.Subtract(10, 4);
        Assert.Equal(6, result);
    }

    [Fact]
    public void Division_ReturnsCorrectResult()
    {
        var result = _calculator.Division(10, 2);
        Assert.Equal(5, result);
    }
}