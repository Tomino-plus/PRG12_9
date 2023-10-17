using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové pole a naplň ho pěti čísly.
            int[] myArray = { 10, 20, 30, 40, 50 };

            //TODO 2: Vypiš do konzole všechny prvky pole, zkus klasický for, kde i využiješ jako index v poli, a foreach (vysvětlíme si).
            Console.WriteLine("Prvni moznost vypsani");
            for (int i = 0; i < myArray.Length; i++) 
            {
                Console.WriteLine(myArray[i]);
            }
            //nebo
            Console.WriteLine("Druha moznost vypsani");
            foreach (int number in myArray)
            {
                Console.WriteLine(number);
            }

            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
            int sum = 0;
            Console.WriteLine("Soucet prvku");
            for (int i =0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }
            Console.WriteLine(sum);

            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            int average = sum / myArray.Length;
            Console.WriteLine("Prumerna hodnota prvku");
            Console.WriteLine(average);

            /*int average = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                average += myArray[i];
            }
            Console.WriteLine(average/myArray.Length);
            */

            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            int max = int.MinValue;
            Console.WriteLine("Maximalni hodnota prku");
            max = myArray.Max();
            Console.WriteLine(max);

            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
            int min = int.MaxValue;
            /*
            min = myArray.Min();
            Console.WriteLine(max);
            */
            Console.WriteLine("Minimalni hodnota prvku");
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < min)
                {
                    min = myArray[i];
                }

            }
            Console.WriteLine(min);

            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
            int index;

            //TODO 8: Změň tvorbu integerového pole tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9. Vytvoř si na to proměnnou typu Random.

            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];

            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.


            Console.ReadKey();
        }
    }
}
