using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10
            //kasutaja peab sea numbrit ära arvama
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud
            //kasutajal on kolm katset,  kui kasutaja ei ole suutnud kolme katsega numbrit arvata
            //siis mängu võidab arvuti
            //programm genereerib juhuslikku numbrit vaid ühe korra

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;

            Console.WriteLine("Arva ära arvuti poolt genereeritud number, mis on 1-10. Sul on selleks 3 katset!");

            while(i < 3)
            {
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if(userNumber == cpuNumber)
                {
                    Console.WriteLine("Arvasid numbri ära, võitsid mängu!!!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Sinu arvatud number on vale, alles on {3-i} katset");
                }               
            }
            Console.WriteLine("Kaotasid mängu, äkki järgmine kord läheb paremini");
        }
    }
}
