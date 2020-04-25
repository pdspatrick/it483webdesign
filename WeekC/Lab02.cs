using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace it483
{
    class Lab02
    {
        public static void Main(string[] args)
        {
            string rx = "0";
            string tint = "0";
            double total = 0.0;
            Console.WriteLine("What kind of glasses would you like?");
            while ((rx != "1") && (rx != "2"))
            {
                Console.WriteLine("1 -> prescription, 2 -> non-prescription");
                string rxin = Console.ReadLine();
                rx = rxin;
            }
            while ((tint != "1") && (tint != "2"))
            {
                Console.WriteLine("1 -> anti-glare, 2 -> brown tint");
                string tintin = Console.ReadLine();
                tint = tintin;
            }
            if (tint == "1")
            {
                total += 12.5;
            }
            if (tint == "2")
            {
                total += 9.99;
            }
            if (rx == "1")
            {
                total += 40;
            }
            if (rx == "2")
            {
                total += 25;
            }
            Console.WriteLine("Your total cost is " + total.ToString());
        }
    }
}
