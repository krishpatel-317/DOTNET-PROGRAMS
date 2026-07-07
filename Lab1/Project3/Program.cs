Console.WriteLine("Enter two Operands: ");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Select the operation you want to do from +,-,*,/,% :");

char c = Convert.ToChar(Console.ReadLine());

switch (c)
{
    case '+':
        Console.WriteLine("You have selected addition and your output is : " + (a + b));
        break;
    case '-':
        Console.WriteLine("You have selected subtraction and your output is : " + (a - b));
        break;
    case '*':
        Console.WriteLine("You have selected Multiplication and your output is : " + (a * b));
        break;
    case '/':
        Console.WriteLine("You have selected Division and your output is : " + (a / b));
        break;
    case '%':
        Console.WriteLine("You have selected Modulo and your output is : " + (a % b));
        break;
}
