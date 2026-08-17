class Student
{
    private string Name;
    public string name
    {
        get { return Name; }
        set { Name = value; }
    }
    private int RollNumber;
    public int rollNumber
    {
        get { return RollNumber; }
        set { RollNumber = value; }
    }
    private string Course;
    public string course
    {
        get { return Course; }
        set { Course = value; }
    }
    public void Print()
    {
        Console.WriteLine($"Student Name: {Name}, Roll Number: {RollNumber}, Course: {Course}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        Console.WriteLine("How many student's details you want to enter ? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {

            Console.WriteLine("Enter details for Student" + (i + 1));
            Student s = new Student();

            Console.Write("Enter Name of student: ");
            s.name = Console.ReadLine();

            Console.Write("Enter roll number of student: ");
            s.rollNumber = int.Parse(Console.ReadLine());

            if (s.rollNumber < 0)
            {
                Console.WriteLine("Please enter valid Roll number.");
                continue;
            }
            Console.Write("Enter Course of student: ");
            s.course = Console.ReadLine();

            Console.WriteLine();
            students.Add(s);
        }
        foreach (Student s in students)
        {
            s.Print();
        }
    }
}
