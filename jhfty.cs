using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int x,y,z;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            if (x >= y && y >= z)
                {
                    Console.WriteLine($"{x} {y} {z}");
                }
            else if(x >= z && z >= y)
            {
                Console.WriteLine($"{y} {x} {z}");
            }
            else if(y >= x && x >= z)
            {
                Console.WriteLine($"{z} {y} {x}");
            }
            else if(z>=x && x >= y)
            {
                Console.WriteLine($"{z} {y} {x}");
            }
            else if(z>=y && y >= x)
            {
                Console.WriteLine($"{z} {x} {y}");
            }
            else if(y >=z && x >= z) { 
                Console.WriteLine($"{x} {z} {y}");
            }*/

            /*int liczba=1,n;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n ; i++)
            {
                liczba = liczba * i;
                Console.WriteLine(liczba);
            }*/


            /*Zad 5
            for (int i = -7; i <= 17; i+=4)
            {
                Console.WriteLine(i);
            }*/

            /*int i = -7;
            while(i <= 17)
            {
                Console.WriteLine(i);
                i = i + 4;
            }*/
            /*Zad 6
            for (int i = 2; i <= 486 ; i*=3)
            {
                Console.WriteLine(i);
            }*/

            /*int i = 2;
            while(i <= 486)
            {
                Console.WriteLine(i);
                i *= 3;
            }*/

            /*int a;
            int ilosc = 0,sumacyfr=0,cyfra;
            a = int.Parse(Console.ReadLine());
            while(a>0)
            {
                cyfra = a % 10;
                a = a / 10;
                ilosc+=1;
                sumacyfr += sumacyfr;
            }
            Console.WriteLine(sumacyfr);*/

            int n;
            bool b=true;
            n = int.Parse(Console.ReadLine());
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n%i==0)
                {
                    b = false;
                    break;
                }
            }
            if (b) Console.WriteLine("jest");
            else Console.WriteLine("nie jest");


        }
    }
}
