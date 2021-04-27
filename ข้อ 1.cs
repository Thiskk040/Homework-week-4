using System;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            int row;
            Console.Write("Please insert the number to make the pascla triangle : ");
            row = int.Parse(Console.ReadLine());
            if(row>=0)
            {
                thetrianglepascal(row);
            }
            else if(row<=0)
            {
                Console.WriteLine("Invalid Pascal Traingle");
                Console.Write("Please insert the number to make the pascla triangle again!!! : ");
                row = int.Parse(Console.ReadLine());
                thetrianglepascal(row);
            }

        }
        static void thetrianglepascal(int row)
        {
            int value;
            value = 1;

            for (int i = 0; i <= row; i++)
            {

                for (int j = 0; j <= i; j++)
                {

                    if (j == 0 || i == 0)
                        value = 1;
                    else
                        value = value * (i - j + 1) / j;
                    Console.Write(value + " ");
                }
                Console.WriteLine();

            }
        }

    }

    
    
}



