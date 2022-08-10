using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp
{
    internal class Chef
    {

        public void makeChicken()
        {
            Console.WriteLine("The chef can make chicken");
        }

        public void makeSalad()
        {
            Console.WriteLine("The chef can make a salad");
        }

        public virtual void makeSpecialDish()
            //virtual means this method can be overridden
        {
            Console.WriteLine("The chef can make a special dish for you.");
        }
    }
}
