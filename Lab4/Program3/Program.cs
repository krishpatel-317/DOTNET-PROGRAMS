using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Person
{
    private string Name;
    public string name
    {
        get { return Name; }
        set { Name = value; }
    }
    private int Age;
    public int age
    {
        get { return Age; }
        set { Age = value; }
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Person's name is : {name} and age is : {age}.");
    }
}
class Teacher : Person
{
    private string Subject;
    public string subject
    {
        get { return Subject; }
        set { Subject = value; }
    }
    private float Salary;
    public float salary
    {
        get { return Salary; }
        set { Salary = value; }
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Teacher's name : {name} , age : {age} , subject : {subject} , and salary is : {salary} .");
    }
}
class program
{
    static void Main(string[] args)
    {
        List<Teacher> teachers = new List<Teacher>
        {
            new Teacher { name = "Krish Patel", age = 30, subject = "Mathematics", salary = 45030.43f },
            new Teacher { name = "Meet Mehta", age = 25, subject = "Computer Science", salary = 60000f },
            new Teacher { name = "Riya Shah", age = 29, subject = "Physics", salary = 52000.75f },
            new Teacher { name = "Aarav Desai", age = 35, subject = "Chemistry", salary = 68000.50f },
            new Teacher { name = "Priya Joshi", age = 32, subject = "English", salary = 55000.25f }
        };
        foreach (var i in teachers)
        {
            i.DisplayInfo();
        }
    }
}
