using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 * Pri psani kodu bylo vyuzito ChatGPT pro objasneni nekterych funkci (syntax, vyuziti, logika). Dalsi poznamky ke kodu primo u konkretnich funkci.
 */

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            double a;
            double b;
            string prevody; //string potrebny pro prevody mezi soustavami (navod od ChatGPT), viz poznamky radku 70 a 71
            string operace;
            bool platnost = true; //vyuziti a syntax "bool" mi objasnilo ChatGPT
            Console.WriteLine("Program Kalkulacka\n moc toho neumi, ale snad to bude stacit :)\n"); //uvodni text je pred cyklem, protoze uvod staci precist proste jenom jednou :)
            while (platnost)
            {
                Console.WriteLine("Vysvetleni nekterych operaci:\n '^' je mocneni kde [prvni cislo] je mocnenec, [druhe cislo] je mocnitel\n 'sqrt' je odmocneni kde [prvni cislo] je odmocnenec, [druhe cislo] je odmocnitel)\n 'log' je logaritmus kde [prvni cislo] je zaklad\n 'soustavy' je prevod [prvni cislo] (v desitkove soustave) do soustavy [druhe cislo] (funguje pro soustavy 2, 8, 10, 16)\n");
                Console.WriteLine("Zadej prvni cislo");
                while (!double.TryParse(Console.ReadLine(), out a)) //overi, zda je mozne prevest zadany vyraz (cislo a) na double, pokud ne, znovu se zepta na novou hodnotu
                {
                    Console.WriteLine("Spatny input");
                }
                Console.WriteLine("Zadej druhe cislo");
                while (!double.TryParse(Console.ReadLine(), out b)) //overi, zda je mozne prevest zadany vyraz (cislo b) na double, pokud ne, znovu se zepta na novou hodnotu
                {
                    Console.WriteLine("Spatny input");
                }
                Console.WriteLine("Zadej nazev operace (+, -, *, /, ^, sqrt, log, soustavy)");
                while (platnost)
                {
                    operace = Console.ReadLine();
                    platnost = false; //po zadani platne operace "vypne" cyklus, aby program pokracoval, jinak znovu spusti cyklus a vyzada novy input operace (default)
                    switch (operace)
                    {
                        case "+":
                            result = a + b;
                            break;
                        case "-":
                            result = a - b;
                            break;
                        case "*":
                            result = a * b;
                            break;
                        case "/":
                            result = a / b;
                            break;
                        case "^":
                            result = Math.Pow(a, b);
                            break;
                        case "sqrt":
                            result = Math.Pow(a, 1 / b);
                            break;
                        case "log":
                            result = Math.Log(b, a);
                            break;
                        case "soustavy":
                            prevody = Convert.ToString(Convert.ToInt32(Math.Floor(a)), Convert.ToInt32(Math.Floor(b))); //ChatGPT poradil tuto funkci pro prevody soustav: Convert.ToString (Int a, Int b). Funkce Math.Floor zaroven eliminuje desetinna mista v zadanych hodnotach (vrati dolni celou cast). 
                            result = int.Parse(prevody); //prevod funguje pro soustavy: 2, 8, 16 (a 10). Vypracovano ve spolupraci s Matousem Jindrichem.
                            break;
                        default:
                            Console.WriteLine("Neplatny nazev operace"); //neplatny nazev operace spusti cyklus znovu a vyzada novy input operace
                            platnost = true;
                            break;
                    }
                }
                Console.WriteLine(result);
                Console.WriteLine("napis 'konec' pro ukonceni nebo stiskni ENTER pro dalsi pocitani");
                if (!(Console.ReadLine() == "konec")) //pokud input neni "konec", vrati bool "platnost" na true a tim spusti znovu cely cyklus
                {
                    platnost = true;
                }
                Console.Clear(); //vymaze cely text pro prehlednost pri dalsim pocitani (vetsina textu se objevi znovu po spusteni, takze ve finale zmizi jenom uvod mimo cyklus)

            }
          
            Console.ReadKey();
        }
    }
}
