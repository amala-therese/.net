using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppcore;

internal class Furniture
{
    public string Type { get; set; }
    public string Wood { get; set; }

    public int Price { get; set; }

    public Furniture()
    {
        Type = Console.ReadLine();
        Wood = Console.ReadLine();
        Price = int.Parse(Console.ReadLine());
    }

    public Furniture(string type, string wood, int price)
    {
        Type = type;
        Wood = wood;
        Price = price;
    }
    public void Show()
    {
        Console.WriteLine(Type);
        Console.WriteLine(Wood);
        Console.WriteLine(Price);
    }
}
