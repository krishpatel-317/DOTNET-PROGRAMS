class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public int Semester { get; set; }
    public int Age { get; set; }
    public float Cgpa { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
            {
                new Student { StudentId = 1, Name = "Krish", Department = "Computer Engineering", Semester = 4, Age = 19, Cgpa = 8.65f },
                new Student { StudentId = 2, Name = "Raj", Department = "Mechanical Engineering", Semester = 2, Age = 18, Cgpa = 7.65f },
                new Student { StudentId = 3, Name = "Het", Department = "Chemical Engineering", Semester = 6, Age = 20, Cgpa = 8.5f },
                new Student { StudentId = 4, Name = "Darsh", Department = "Electronics & Communication Engineering", Semester = 4, Age = 19, Cgpa = 9.3f },
                new Student { StudentId = 5, Name = "Dhruv", Department = "Computer Engineering", Semester = 4, Age = 19, Cgpa = 7.9f }
            };

        var highCgpaStudents = students
            .Where(s => s.Cgpa > 8.0f)
            .Select(s => s.Name);
        Console.WriteLine("Students whose cgpa is greater than 8 is/are : ");
        foreach (var student in highCgpaStudents)
            Console.WriteLine(student);

        Console.WriteLine();

        var compStudents = students
            .Where(s => s.Department == "Computer Engineering")
            .OrderByDescending(s => s.Cgpa)
            .Select(s => s.Name);

        Console.WriteLine("Students whose department is Computer Engineering are displayed based on cgpa : ");

        foreach (var student in compStudents)
            Console.WriteLine(student);

        Console.WriteLine();

        var topStudent = students
            .OrderByDescending(s => s.Cgpa)
            .Select(s => s.Name)
            .Take(3);

        Console.WriteLine("Top 3 students based on cgpa are: ");
        foreach (var student in topStudent)
            Console.WriteLine(student);

        Console.WriteLine();

        var noOfStudsIneachDepartment = students
            .GroupBy(s => s.Department)
            .Select(s => new
            {
                Department = s.Key,
                count = s.Count()
            });
        foreach (var s in noOfStudsIneachDepartment)
            Console.WriteLine("In Department = " + s.Department + " there are " + s.count + " students.");
    }
}
