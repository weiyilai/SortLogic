// See https://aka.ms/new-console-template for more information
using System.Linq;

Console.WriteLine("Hello, World!");

List<int> ints = new List<int>();
int i;

do
{
    Console.WriteLine("輸入數字");
    var x = Console.ReadLine();
    bool num = int.TryParse(x, out i);
    if (ints.Exists(t => t == i))
    {
        Console.WriteLine("請輸入不重複的數字");
    }
    else
    {
        ints.Add(i);
    }

} while (ints.Count != 10);

Console.WriteLine(string.Join(", ", ints.OrderByDescending(t => t)));


Console.ReadLine();