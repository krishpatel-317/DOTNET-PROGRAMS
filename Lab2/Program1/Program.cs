// List
Console.WriteLine("List Demo");
List<int> nums = new List<int>();
for (int i = 0; i < 5; i++)
{
    nums.Add(i);
}
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(nums[i]);
}
Console.WriteLine();
Console.WriteLine("Dictionary Demo");
//Dictionary
Dictionary<int, string> sub = new Dictionary<int, string>();
sub.Add(1, "C#");
sub.Add(2, "Javascript");
sub.Add(3, "Dart");
sub.Add(4, "MongoDB");
sub.Add(5, "Java");
foreach (var a in sub)
{
    Console.WriteLine($"{a.Key} {a.Value}");
}
Console.WriteLine();
Console.WriteLine("Stack Demo");
Stack<int> s = new Stack<int>();

for (int i = 0; i < 5; i++)
{
    s.Push(i);
}
while (s.Count > 0)
{
    Console.WriteLine(s.Pop());
}
Console.WriteLine();
Console.WriteLine("Queue Demo");
Queue<int> queue = new Queue<int>();
for (int i = 0; i < 5; i++)
{
    queue.Enqueue(i);
}
while (queue.Count > 0)
{
    Console.WriteLine(queue.Dequeue());
}
