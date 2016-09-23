using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övn1
            /*
            for(int i = 89; i<=100; i=i+1)
            {
                Console.WriteLine(i);
            }
            */
            //Övn2
            /*
            for (int i = 20; i > 0; i = i - 1)
            {
                Console.WriteLine(i);
            }
            */
            //Övn3
            /*
            for(int i=50; i>=2; i = i - 2)
            {
                Console.WriteLine(i);
            }
            */
            //Övn1
            /*
            Console.Write("Mata in start: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.Write("Mata in stop: ");
            int tal2 = int.Parse(Console.ReadLine());
            Console.Write("Mata in steg: ");
            int tal3 = int.Parse(Console.ReadLine());
            for (int i=tal1; i <= tal2; i = i + tal3)
            {
                Console.WriteLine(i);
            }
            */
            //Övn3
            /*
            Console.Write("Mata in ett tal: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.Write("Summan av alla tal från 1 till " + tal1 + " blir: ");
            int y = 0;
            for (int i = 0; i <= tal1; i++)
            {
                y = y + i;
            }
            Console.WriteLine(y);
            */
            //Övn4 CP
            /*
            Console.Write("Mata in ett heltal: ");
            int tal = int.Parse(Console.ReadLine());
            for (int i = 1; i <= tal; i++)
            {
                if (i % 7 == 0 && i % 3 == 0)
                {
                        Console.WriteLine("Talet " + i + " är jämt delbart med 3 och 7");
                }
                else if (i<21)
                {
                    Console.WriteLine("Hittade inga tal...");
                }
            }
            */
            //Övn 5
            /*
            Console.Write("Mata in ett heltal: ");
            int tal = int.Parse(Console.ReadLine());
            int y = 0;
            int x = 1;
            for (int i = 1; i <= tal/2; i++)
            {
                Console.Write(x + " ");
                y = y + x;
                Console.Write(y + " ");
                x = y + x;
            }
            Console.WriteLine();
            */
            //Övn6
            Console.Write("Mata in ett tal: ");
            double tal = double.Parse(Console.ReadLine());
            for (double i = 0; i <= tal; i++) 
            {
                if (i*i*i == tal)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
