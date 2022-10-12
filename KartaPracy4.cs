using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int kp1z1(int a,int b)
        {
            return a*a + b*b;
        }
        public static bool kp2z2(int a)
        {
            if (a >= 100 && a < 1000 && a % 17 == 0)
            {
                return true;
            }
            return false;
        }
        public static bool kp2z6(int a,int p)
        {
            if ((Math.Pow(a, p) - a) % p == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void kp3z1(int a)
        {
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(i * i * i + 3);
            }

        }

        public static ArrayList kp3z3(int x)
        {
            ArrayList alist = new ArrayList();
            for (int i = 1; i < x+1; i++)
            {
                if(x%1 == 0)
                {
                    alist.Add(i);
                }
            }
            return alist;
        }

        static void Main(string[] args)
        {
           /* int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine(kp1z1(a,b));
            Console.WriteLine(kp2z2(a));
            Console.WriteLine(kp2z6(a,b));
            kp3z1(a);
*/
            ArrayList dzielniki = new ArrayList();
            int n = int.Parse(Console.ReadLine());
            dzielniki = kp3z3(n);
            foreach(int a in dzielniki)
            {
                Console.WriteLine(a + " ");
            }
            Console.ReadKey();
        }
    }
}
