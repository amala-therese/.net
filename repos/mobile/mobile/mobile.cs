using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobile
{
    internal class mobile
    {
        public string MobName;
        public string Model;
        public int Price;
        public string Company;

        public void ReadData()
        {
            Console.WriteLine("mobile Name:");
            MobName = Console.ReadLine();
            Console.WriteLine(" Mobile Model");
            Model = Console.ReadLine();
            Console.WriteLine(" Mobile Price");
            Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Mobile Company");
            Company = Console.ReadLine();
        }
         
        public void ReadData( string mbname,string mdl,int prc , string cpny)
        {
            MobName = mbname;
            Model = mdl;
            Price = prc;
            Company= cpny;
        }


        public void ShowData()
        {
            Console.WriteLine($"Mobile Name: {MobName}");
            Console.WriteLine($"Model Name: {Model}");
            Console.WriteLine($"Mobile Price: {Price}");
            Console.WriteLine($"Company  Name: {Company}");
        }
            

    }
}
