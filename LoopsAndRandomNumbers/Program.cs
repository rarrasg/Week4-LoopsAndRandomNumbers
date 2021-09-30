using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada PIN kood
            //programm võrdleb sisestatud PIN koodi arvuga 1234
            //kui sisestatud PIN kood on 1234, siis konsool kuvab "tere tulemast"
            //kui sisestatud PIN kood on midagi muud, siis konsool kuvab "vale pin, proovi uuesti"
            //kasutajal on kolm katset

            int i = 0; //i - iteration
            
            while (i < 3) // while loop
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234) 
                 {
                    Console.WriteLine("Tere tulemast!");
                    break;
                 }
                else
                 {
                    //i = i + 1;
                    i++;
                    Console.WriteLine($"Vale PIN. {3 - i} katset on jäänud.");
                 }
            }
            
            Console.WriteLine("Kena päeva!");
        }
    }
}
