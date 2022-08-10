using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp
{
    internal class ItalianChef : Chef
        //we use inheritance to let ItalianChef(SubClass) have the same methods as Chef (SuperClass)
    {

        public override void makeSpecialDish()
        //override means this method can override the superclass method
        {
            Console.WriteLine("The chef can make a spghetti bolognese");
        }

    }
}
