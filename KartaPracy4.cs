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
        public static int Sumc(int n)
        {
            int cyfra = 0;
            int sum = 0;
            while (n > 0)
            {
                cyfra = n % 10;
                sum += cyfra;
                n = n / 10;
            }
            return sum;
        }
        public static int Silnia(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return Silnia(n - 1) * n;
        }
        public static int SilniaIteracyjna(int n)
        {
            int wy = 1;
            for (int i = 2; i <= n; i++)
            {
                wy = wy * i;
            }
            return wy;
        }

        public static int fibo(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if(n == 1)
            {
                return 1;
            }
            if (n <= 2)
            {
                return 1;
            }
            return fibo(n-1) + fibo(n-2);
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
            /*ArrayList dzielniki = new ArrayList();
            int n = int.Parse(Console.ReadLine());
            dzielniki = kp3z3(n);
            foreach(int a in dzielniki)
            {
                Console.WriteLine(a + " ");
            }*/

            // zad 2 k 4
            //int n = int.Parse(Console.ReadLine());
            // Console.WriteLine(Sumc(n));

            // zad 3 k 4
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(Silnia(n));

            // zad ankieta 
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(SilniaIteracyjna(n));

            // zad 4
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(fibo(n));
            Console.ReadKey();
        }
    }
}
