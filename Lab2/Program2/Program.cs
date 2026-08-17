bool exit = false;
List<string> names = new List<string>();
while (!exit)
{
    Console.WriteLine("\n----- Student Management System -----");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. Display Students");
    Console.WriteLine("3. Search Student");
    Console.WriteLine("4. Update Student");
    Console.WriteLine("5. Delete Student");
    Console.WriteLine("6. Exit");

    Console.Write("Enter your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            if (name != null)
                addStudent(name);
            break;

        case 2:
            Console.WriteLine("List of Students: ");
            displayStudent();
            break;
        case 3:
            Console.Write("Enter Student Name to search in list: ");
            string search = Console.ReadLine();
            bool found = searchStudent(search);
            if (found == true)
                Console.WriteLine("Student " + search + " is found.");
            else
                Console.WriteLine("Student " + search + " is not found.");
            break;
        case 4:
            Console.Write("Enter which student's name you want to update: ");
            string b = Console.ReadLine();

            if (!searchStudent(b))
            {
                Console.WriteLine("Student " + b + " is not found.");
                break;
            }

            Console.Write("Enter new name for " + b + ": ");
            string n = Console.ReadLine();

            updateStudent(b, n);
            break;

        case 5:
            Console.Write("Enter Student Name to delete: ");
            string deleteName = Console.ReadLine();
            deleteStudent(deleteName);
            break;

        case 6:
            exit = true;
            Console.WriteLine("Exiting...");
            break;

        default:
            Console.WriteLine("Invalid Choice!");
            break;
    }
}
void addStudent(string name)
{
    names.Add(name);
    Console.WriteLine("New Student " + name + " is added.");
}
void displayStudent()
{
    foreach (string a in names)
        Console.WriteLine(a);
}
bool searchStudent(string search)
{
    foreach (string a in names)
    {
        if (a.Equals(search))
            return true;
    }
    return false;
}
void updateStudent(string oldName, string newName)
{
    int index = names.IndexOf(oldName);

    if (index != -1)
    {
        names[index] = newName;
        Console.WriteLine("Student updated successfully.");
    }
    else
    {
        Console.WriteLine("Student not found.");
    }
}
void deleteStudent(string name)
{
    if (names.Remove(name))
        Console.WriteLine("Student " + name + " deleted successfully.");
    else
        Console.WriteLine("Student not found.");
}
