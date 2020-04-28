using System;
using System.Collections.Generic;
using System.Text;

namespace it483
{
    using System;

    public class Lab04
    {
        public static void Main(string[] args)
        {
            int a = 1, b = 3, c = 5;
            double x = 2.2, y = 4.4, z = 6.6, ans;
            ans = average(a, b);
            Console.WriteLine("\naverage(a, b) = " + ans);
            ans = average(a, b, c);
            Console.WriteLine("\naverage(a, b, c) = " + ans);
            ans = average(x, y);
            Console.WriteLine("\naverage(x, y) = " + ans);
            ans = average(x, y, z);
            Console.WriteLine("\naverage(x, y, z) = " + ans);
            ans = average(1, 2.0, 3);
            Console.WriteLine("\naverage(1, 2.0, 3) = " + ans);
            Console.WriteLine("That is a valid answer. Typecasting from int to double is okay. And it uses the double version.");
            double ans2 = average(a, b, c);
            ans = average(a, average(b, c));
            Console.WriteLine("\naverage(a, (average(b, c)) = " + ans);
            Console.WriteLine("average(a, b, c) = " + ans2);
            Console.WriteLine(ans + " is not equal to " + ans2 + ", which means chaining average() will not work for more numbers.");
        }
        public static double average(int n1, int n2)
        {
            return (n1 + n2) / 2.0;
        }
        // Overloaded methoid Definition(s) here ...
        private static double average(double x, double y, double z)
        {
            return ((x + y + z) / 3.0);
        }
        private static double average(double x, double y)
        {
            return ((x + y) / 2.0);
        }
        public static double average(int n1, int n2, int n3)
        {
            return (n1 + n2 + n3) / 3.0;
        }


    }

}
