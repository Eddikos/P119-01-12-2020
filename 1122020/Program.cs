using System;

namespace _1122020
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsMarrad = true;
            bool IsOk = false;
            bool IsHere = false;
            int brotherAge = 66;
            int sisterAge = 18;
            string capital = "Baku";

            if (brotherAge > 65 && sisterAge <= 16)
            {
                Console.WriteLine("He is old");
            }
            else
            {
                Console.WriteLine("He is old");
            }


            if (brotherAge > 18)
            {
                Console.WriteLine("He is an adult");
            }
            else if (sisterAge == 17)
            {
                Console.WriteLine("He is an adult");
            }

            Console.WriteLine("Tamamdir");

            if (sisterAge == 16)
            {
                Console.WriteLine("He is an adult");
            }
            else
            {
                Console.WriteLine("He is a kid");
            }


            switch (capital)
            {
                case "Balu":
                    Console.WriteLine("Paytaxt du deyil");
                    break;
                case "Baku":
                case "Xezri":
                    Console.WriteLine("Paytaxt budur");
                    break;
                default:
                    Console.WriteLine("Namelum");
                    break;
            }

            // Loops 
            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine("Eded: " + i);

            //    if (i == 9)
            //    {
            //        Console.WriteLine("bitdi");
            //    }
            //}

            //int i = 0;
            //while (i < -1)
            //{
            //    Console.WriteLine("Eded: " + i);

            //    if (i == 9)
            //    {
            //        Console.WriteLine("bitdi");
            //    }

            //    i++;
            //}


            int i = 0;
            do
            {
                Console.WriteLine("Eded: " + i);

                if (i == 9)
                {
                    Console.WriteLine("bitdi");
                }

                i++;
            } while (i < -1);





            if (brotherAge < 18)
            {
                Console.WriteLine("He is a kid");
            }
            else
            {
                Console.WriteLine("HE is 18");
            }

            int[] aylar = { 1,2,3,4,5,6,7,8,9,10,11,12};

            Console.WriteLine(!IsMarrad);
            Console.WriteLine(6 % 5);
            Console.WriteLine((IsMarrad && IsHere) || IsOk);
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
