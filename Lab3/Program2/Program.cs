
using System.Transactions;

class Program
{
    delegate int Operation(int a, int b);
    static int add(int x, int y)
    {
        return x + y;
    }
    static int subtract(int x, int y)
    {
        return x - y;
    }
    static int multiply(int x, int y)
    {
        return x * y;
    }
    static int divide(int x, int y)
    {
        return x / y;
    }
    static int modulo(int x, int y)
    {
        return x % y;
    }
    static void main(String[] args)
    {
        Console.Write("Enter 1st operand: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter 2nd operand: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Enter operator");
        char o = char.Parse(Console.ReadLine());
        switch (o)
        {
            case '+':
                Operation op1 = add;
                Console.WriteLine(op1(number1, number2));
                break;
            case '-':
                Operation op2 = subtract;
                Console.WriteLine(op2(number1, number2));
                break;
            case '*':
                Operation op3 = multiply;
                Console.WriteLine(op3(number1, number2));
                break;
            case '/':
        }



        Operation op4 = divide;
        Console.WriteLine(op4(20, 5));
        Operation op5 = modulo;
        Console.WriteLine(op5(2, 5));
    }
}
