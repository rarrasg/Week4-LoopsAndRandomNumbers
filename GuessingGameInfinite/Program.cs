using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10
            //kasutaja peab sea numbrit ära arvama
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud
            //katsete arv on piiramatu
            //programm genereerib juhuslikku numbrit vaid ühe korra

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool gameON = true;

            Console.WriteLine("Arva ära arvuti poolt genereeritud number, mis on vahemikus 1-10");

            while (gameON)
            {                
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if(userNumber == cpuNumber)
                {
                    Console.WriteLine("Arvasid numbri ära, võitsid mängu!!!");
                    gameON = false;
                }
                else
                {
                    Console.WriteLine("Sinu arvatud number on vale. Proovi uuesti!");
                }
                
            }            
        }
    }
}
