﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp
{
    internal class Tool
    {

        public static void SayHi(string name) 
        {

            Console.WriteLine("Hey there " + name + "!");

        }
        public static void ArrM(int[] a)
        {
        
            int[] b = new int[5];
            a = b;

        }


    }
}
