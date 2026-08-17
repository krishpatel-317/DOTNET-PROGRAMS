class Calculator
{
    public static async Task<int> Add(int a, int b)
    {
        await Task.Delay(2000);
        return a + b;
    }
    public static async Task<int> Subtract(int a, int b)
    {
        await Task.Delay(2000);
        return a - b;
    }
    public static async Task<int> Multiply(int a, int b)
    {
        await Task.Delay(2000);
        return a * b;
    }
    public static async Task<int> Divide(int a, int b)
    {
        await Task.Delay(2000);
        if (b == 0)
            return -1;
        return a / b;
    }
};
class program
{
    static async Task Main()
    {
        int a = 2, b = 3;
        Task<int> task1 = Calculator.Add(a, b);
        Task<int> task2 = Calculator.Subtract(a, b);
        Task<int> task3 = Calculator.Multiply(a, b);
        Task<int> task4 = Calculator.Divide(a, b);

        int[] result = await Task.WhenAll(task1, task2, task3, task4);

        Console.WriteLine($"Result of Addition,Subtraction,Multiplication and Division are : ");

        Console.WriteLine($"{a} + {b} = {result[0]}");
        Console.WriteLine($"{a} - {b} = {result[1]}");
        Console.WriteLine($"{a} * {b} = {result[2]}");
        Console.WriteLine($"{a} / {b} = {result[3]}");
    }
}