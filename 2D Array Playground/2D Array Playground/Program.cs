using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace _2D_Array_Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové 2D pole velikosti 5 x 5, naplň ho čísly od 1 do 25 a vypiš ho do konzole (5 řádků po 5 číslech).
            /*Console.WriteLine("Zadej pocet radku matice");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Zadej pocet sloupcu matice");
            int b = Int32.Parse(Console.ReadLine());*/
            int a = 5; 
            int b = 5;
            int[,] array = new int[a, b];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("\n");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = i * 5 + j + 1;
                    Console.Write(array[i, j]);
                    Console.Write(" ");
                }
            }
            Console.WriteLine("\n");
            //TODO 2: Vypiš do konzole n-tý řádek pole, kde n určuje proměnná nRow.
            int nRow = 0;
            
            //TODO 3: Vypiš do konzole n-tý sloupec pole, kde n určuje proměnná nColumn.
            int nColumn = 0;

            //TODO 4: Prohoď prvek na souřadnicích [xFirst, yFirst] s prvkem na souřadnicích [xSecond, ySecond] a vypiš celé pole do konzole po prohození.
            //Nápověda: Budeš potřebovat proměnnou navíc, do které si uložíš první z prvků před tím, než ho přepíšeš druhým, abys hodnotou prvního prvku potom mohl přepsat druhý
            int xFirst = 0;
            int yFirst = 0;
            int xSecond = 1;
            int ySecond = 1;
            //int first = array[xFirst, yFirst];
            //int second = array[xSecond, ySecond];
            /*int temp = array[xFirst, yFirst];
            array[xFirst, yFirst] = array[xSecond, ySecond];
            array[xSecond, ySecond] = temp;

            for (int i = 0; i < array.GetLength(0); i++) 
            {
                Console.Write("\n"); 
                for (int j = 0; j < array.GetLength(1); j++) 
                {
                    Console.Write(" " + array[i, j]);
                }
            }
            Console.WriteLine("\n");
            */
            /*TODO 5: Prohoď n-tý řádek v poli s m-tým řádkem (n je dáno proměnnou nRowSwap, m mRowSwap) a vypiš celé pole do konzole po prohození.
            
            int nRowSwap = 0;
            int mRowSwap = 1;
            int[] tempArray = new int[5];
            */

            //TODO 6: Prohoď n-tý sloupec v poli s m-tým sloupcem (n je dáno proměnnou nColSwap, m mColSwap) a vypiš celé pole do konzole po prohození.

            int nColSwap = 0;
            int mColSwap = 1;
            /*int[] temparray = new int[5];
            for (int i = 0;i < array.GetLength(0); i++)
            {
                temparray[i] = array[i, nColSwap];
            }
            */
            //TODO 7: Otoč pořadí prvků na hlavní diagonále (z levého horního rohu do pravého dolního rohu) a vypiš celé pole do konzole po otočení.
            for (int i = 0;i <= array.GetLength(0) / 2; i++) //int se tady zaokrouhli dolu, 5 / 2 = 2
            {
                int temp = array[i, i];
                int reversedIndex = array.GetLength(0) - i - 1;
                array[i, i] = array[reversedIndex, reversedIndex];
                array[reversedIndex, reversedIndex] = temp;

            }
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                Console.Write("\n"); 
                for (int j = 0; j < array.GetLength(1); j++) 
                {
                    Console.Write(" " + array[i, j]);
                }
            }
            //TODO 8: Otoč pořadí prvků na vedlejší diagonále (z pravého horního rohu do levého dolního rohu) a vypiš celé pole do konzole po otočení.


            Console.ReadKey();
        }
    }
}
