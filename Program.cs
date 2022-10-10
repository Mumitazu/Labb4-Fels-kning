using System;

namespace Labb4_Felsökning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case 1
             Console.WriteLine("Skriv in ett tal");
             int number = int.Parse(Console.ReadLine());

             if (number > 3)
             {
                 Console.WriteLine("Talet är större än tre");
             }
             else if(number < 3)
 {
                 Console.WriteLine("Talet är mindre än tre");
             }

             //Case 2
             for (int i = 1; i < 101; i++)
             {
                 Console.WriteLine(i);
             }

            //Case 3
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            //Case 4
            int i = 1;
            while (i <= 5)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j+"");
                }

                Console.WriteLine();
                i++;
            } 
        
            //Case 5
            int i = 1;

            switch (i)
            {
                case 1:
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
            //Case 6
            int i = 5;
            Console.WriteLine(" 'i' har ett värde mellan 1 till 10, gissa vilket det är!");
            i = int.Parse(Console.ReadLine());
            if (i == 5)
            {
                Console.WriteLine("Rätt, i är 5");
            }
            else if(i!=5)
            { 
               Console.WriteLine("Tyvärr! det stämmer inte"); 
            }
        }
    }
}
