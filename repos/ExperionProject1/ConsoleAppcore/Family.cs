using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppcore
{
    internal class Family
    {
        public string FamilyName { get; set; }
    }
 class Child : Family
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Occupation { get; set; }

        public void ShowData()
        {
            Console.WriteLine(FamilyName);
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(Occupation);
        }
        

    }
}
