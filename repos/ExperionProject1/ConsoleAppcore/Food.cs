using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppcore
{
    internal class Food
    {

        public string Name { get; set; }

        private int _price { get; set; }

        public int Discount { get; set; }

        public int Price
        {
            get { return _price; }
            set
            {
                if (value > 150)
                {
                    Discount = 10;
                    _price = value - (Discount * value) / 100; ;
                    return;
                }
                _price = value;
               


            }
        }
        public void ShowData()
        {

            Console.WriteLine(Name);
            Console.WriteLine(Price);
            Console.WriteLine(Discount);
        }
       

    
    
    }

}
