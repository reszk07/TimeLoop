using System;

namespace TimeLoop

{

    class Program

    {

        static void Main(string[] args)

        {

            int x = int.Parse(Console.ReadLine());

            if ((1 <= x) && (x <= 100))

                for (int i = 1; i <= x; i++)

                    Console.WriteLine(i + " Abracadabra");

        }

    }

}