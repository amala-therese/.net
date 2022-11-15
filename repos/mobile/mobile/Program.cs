using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace mobile
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var Mob1 = new mobile();
            Mob1.ReadData();

            var Mob2 = new mobile();
            Console.WriteLine("mobile Name:");
            var mbname = Console.ReadLine();
            Console.WriteLine(" Mobile Model");
            var mdl = Console.ReadLine();
            Console.WriteLine(" Mobile Price");
            var prc = int.Parse(Console.ReadLine());
            Console.WriteLine("Mobile Company");
            var Cpny = Console.ReadLine();
            Mob2.ReadData(mbname, mdl, prc, Cpny);



            Mob1.ShowData();
            Mob2.ShowData();














        }
    }









}



