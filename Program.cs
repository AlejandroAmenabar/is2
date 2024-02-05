public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }
}

public class Program
{
    public static void Main()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Add(5, 3);
        Console.WriteLine("Addition result: " + result);

        result = calculator.Subtract(10, 4);
        Console.WriteLine("Subtraction result: " + result);
    }
}