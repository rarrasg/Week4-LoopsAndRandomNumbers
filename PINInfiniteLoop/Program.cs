using System;

namespace PINInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada PIN kood
            //programm võrdleb sisestatud PIN koodi arvuga 1234
            //kui sisestatud PIN kood on 1234, siis konsool kuvab "tere tulemast"
            //kui sisestatud PIN kood on midagi muud, siis konsool kuvab "vale pin, proovi uuesti"
            //katsete arv on piiramatu

            bool loopActive = true; //boollean --> true/false
            int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }   
                else
                {
                    i++;
                    Console.WriteLine("Vale PIN. Proovi uuesti!");
                    Console.WriteLine($"Oled vale pin koodi {i} korda sisestanud ");
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
