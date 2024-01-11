using System;
class Program
{
    //pri vypracovani bylo vyuzito ChatGPT
    //mel jsem mnohem vyssi ambice, ale nevedel jsem, jak napad realizovat.
    static void Main()
    {
            Console.WriteLine("Vitej v menu hry\nvyber si z nabidky, co si prejes udelat\n1 pro spusteni hry - hadani cisla\n2 pro ukonceni programu");
            string request = "";
            request = Console.ReadLine();
            switch (request)
            {
                case "1":
                    HadaniCisla game = new HadaniCisla();
                    game.Play();
                    break;
                default:
                    Console.WriteLine("Tak nekdy priste");
                    break;
            }       
    }
}
