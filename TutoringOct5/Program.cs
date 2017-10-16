using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringOct5
{
    class Program
    {
        static void Main(string[] args)
        {


            //string[] favHolidays = { "Halloween", "Thanksgiving", "New Years", "Valentine's Day" };

            //foreach (string holiday in favHolidays)
            //{
            //    Console.WriteLine(holiday);
            //}

            //for(int i = 0; i < favHolidays.Length; i++)
            //{
            //    Console.WriteLine(favHolidays[i]);
            //}



            int[] multOfThree = { 3, 6, 9, 12, 15, 18 };

            int sum = 0;

            foreach (int multiple in multOfThree)
            {
                sum += multiple;

                // or

                //sum = sum + multiple;

            }

            Console.WriteLine(sum);


            // OR
            for (int i = 0; i < multOfThree.Length; i++)
            {
                sum += multOfThree[1];
            }

            Console.WriteLine(sum);

            ////


            string playAgain = "";
            do
            {
                Console.WriteLine("I love this game!What do you think?");
                string UserOpinion = Console.ReadLine();

                Console.WriteLine("It was fun hangning out. Don't you agree?");
                string uderDatisfy = Console.ReadLine();

                Console.WriteLine("Do you wnat to play again?");
                Console.ReadLine().ToLower();

            }

            while (playAgain == "yes");






        }
    }
}
