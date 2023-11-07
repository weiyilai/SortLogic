// See https://aka.ms/new-console-template for more information
using System.Linq;

Console.WriteLine("Hello, World!");

List<int> ints = new List<int>();
int i;

do
{
    Console.WriteLine("輸入數字");
    var x = Console.ReadLine();
    if (int.TryParse(x, out i))
    {
        ints.Add(i);
    }
} while (ints.Count != 10);

Console.WriteLine(string.Join(", ", ints.OrderByDescending(t => t)));


Console.ReadLine();