Console.WriteLine("Enter the marks of 5 subjects out of 100 : ");
int[] marks = new int[5];
int sum = 0;
for (int i = 0; i < 5; i++)
{
    marks[i] = Convert.ToInt32(Console.ReadLine());
    sum += marks[i];
}
int percentage = (sum * 100) / 500;
char grade;
if (percentage >= 85 && percentage <= 100)
    grade = 'A';
else if (percentage >= 75 && percentage < 85)
    grade = 'B';
else if (percentage >= 65 && percentage < 75)
    grade = 'C';
else if (percentage >= 50 && percentage < 65)
    grade = 'D';
else if (percentage >= 40 && percentage < 50)
    grade = 'E';
else
    grade = 'F';

//Console.Write($"{sum} {percentage} {grade}");
Console.WriteLine("Your total marks of 5 subjects are :" + sum);
Console.WriteLine("Your Percentage is: " + percentage);
Console.WriteLine("Your Grade is : " + grade);
