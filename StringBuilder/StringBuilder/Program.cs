﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string s ="";

            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for(int i=1;i<=100000;i++)
            {
                s = s + 1;

            }
            sw1.Stop();


            StringBuilder sb = new StringBuilder();
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            for (int i=1;i<=100000;i++)
            {
                sb.Append(i);
            }
            sw2.Stop();

            Console.WriteLine("Time taken for string:" +sw1.ElapsedMilliseconds);
            Console.WriteLine("Time taken for stringBuilder:" + sw2.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }
}
