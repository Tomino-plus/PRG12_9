using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        //porad mam problem s metodami, takze je vetsinou nepouzivam. tady jsem se aspon trochu pokusil
        //TODO formatovani, overovani zadanych hodnot, zbytecne radky...
        static void writeArray(int[,] array) //funkce pro vypsani matice
        {
            for (int i = 0; i < array.GetLength(0); i++) //vypise matici
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vitej v programu Arrays\nPro zacatek je potreba vytvorit prvni matici\n");
            int rows = 0;
            int columns = 0;
            string operation, operationx;
            Random rnd = new Random();
            int xFirst = 0, yFirst = 0, xSecond = 0, ySecond = 0;

            Console.WriteLine("Zadej pocet radku matice");
            while (!(int.TryParse(Console.ReadLine(), out rows) && rows > 0)) //testuje, jestli je input validni
                Console.WriteLine("Zadejte kladne cele cislo");
            Console.WriteLine("Zadej pocet sloupcu matice");
            while (!(int.TryParse(Console.ReadLine(), out columns) && columns > 0)) //testuje, jestli je input validni
                Console.WriteLine("Zadejte kladne cele cislo");

            int[,] array = new int[rows, columns];
            Console.WriteLine("\nZadej 1 pro vyplneni matice nahodnymi cisly\nZadej 2 pro vyplneni matice radou cisel");

            string x = Console.ReadLine();
            while (x != "1" && x != "2") //dokud uzivatel nezada jednu z moznosti, nic se nedeje
            {
                Console.WriteLine("Zadej cislo operace podle nabidky");
                x = Console.ReadLine();
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (x == "1")
                        array[i, j] = rnd.Next(10); //vyplni matici nahodnymi cisly (0 az 9)
                    else
                        array[i, j] = j + i * columns + 1; //vyplni matici radou cisel
                }
            }
            Console.Clear();
            Console.WriteLine("\nToto je vygenerovana matice:");
            writeArray(array);           
            Console.WriteLine("\nZadej pomoci cisla, jakou operaci budes chtit s matici provest");
            Console.WriteLine("1 pro opetovne vypsani matice\n" + "2 pro prohozeni prvku matice\n" + "3 pro prohozeni radku matice\n" + "4 pro prohozeni sloupce matice\n" + "5 pro vynasobeni cisel matice\n" + "6 pro soucet/rozdil dvou matic\n" + "7 pro prohazovani prvku na diagonalach\n" + "8 pro nasobeni matic");
            
            operation = Console.ReadLine();
            while (operation != "1" && operation != "2" && operation != "3" && operation != "4" && operation != "5" && operation != "6" && operation != "7" && operation != "8") //dokud uzivatel nezada jednu z moznosti, nic se nedeje
            {
                Console.WriteLine("Zadej cislo operace z nabidky");
                operation = Console.ReadLine();
            }
            switch (operation)
            {
                default:
                    Console.WriteLine("Neznamy pozadavek, vypisuji matici:\n");
                    writeArray(array);
                    break;
                case "1": //vypsani matice
                    writeArray(array);
                    break;
                case "2": //prohozeni jednoho prvku matice
                    Console.WriteLine("Zadej index radku prvniho cisla");
                    while (!(int.TryParse(Console.ReadLine(), out xFirst) && xFirst > -1 && xFirst < array.GetLength(0))) //overi input
                        Console.WriteLine("Zadej platne cislo");
                    Console.WriteLine("Zadej index sloupce prvniho cisla");
                    while (!(int.TryParse(Console.ReadLine(), out yFirst) && yFirst > -1 && yFirst < array.GetLength(1)))
                        Console.WriteLine("Zadej platne cislo");
                    Console.WriteLine("Zadej index radku druheho cisla");
                    while (!(int.TryParse(Console.ReadLine(), out xSecond) && xSecond > -1 && xSecond < array.GetLength(0)))
                        Console.WriteLine("Zadej platne cislo");
                    Console.WriteLine("Zadej index sloupce druheho cisla");
                    while (!(int.TryParse(Console.ReadLine(), out ySecond) && ySecond > -1 && xSecond < array.GetLength(1)))
                        Console.WriteLine("Zadej platne cislo");
                    
                    int first = array[xFirst, yFirst];
                    int second = array[xSecond, ySecond];
                    int temporary = array[xFirst, yFirst];
                    array[xFirst, yFirst] = array[xSecond, ySecond];
                    array[xSecond, ySecond] = temporary;
                    writeArray(array);
                    break;
                 case "3": //prohozeni radku matice         
                    Console.WriteLine("Zadej index prvniho radku, ktery chces prohodit");
                    string aInput = Console.ReadLine();
                    int rowSwapA = Convert.ToInt32(aInput);
                    Console.WriteLine("Zadej index druheho radku, ktery chces prohodit");
                    string bInput = Console.ReadLine();
                    int rowSwapB = Convert.ToInt32(bInput);
                    for (int i = 0; i < columns; i++)
                    {
                        temporary = array[rowSwapA, i];
                        array[rowSwapA, i] = array[rowSwapB, i];
                        array[rowSwapB, i] = temporary;

                    }
                    writeArray(array);
                    break;
                case "4": //prohozeni sloupce matice

                    Console.WriteLine("Zadej index prvniho sloupce, ktery chces prohodit");
                    string cInput = Console.ReadLine();
                    int columnSwapA = Convert.ToInt32(cInput);

                    Console.WriteLine("Zadej index druheho sloupce, ktery chces prohodit");
                    string dInput = Console.ReadLine();
                    int columnSwapB = Convert.ToInt32(dInput);

                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        temporary = array[i, columnSwapA];
                        array[i, columnSwapA] = array[i, columnSwapB];
                        array[i, columnSwapB] = temporary;
                    }
                    writeArray(array);
                    
                    break;
                case "5": //nasobeni prvku matice ciselnym inputem
                    Console.WriteLine("Zadej cislo, kterym budes nasobit celou matici");
                    int multiplierInput = 0;
                    while(!int.TryParse(Console.ReadLine(), out multiplierInput))
                        Console.WriteLine("Zadej platne cislo");
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            array[i, j] *= multiplierInput;
                        }
                    }
                    writeArray(array);
                    break;
                case "6": //scitani a odcitani matic
                    Console.WriteLine("Pro soucet/rozdil je potreba vytvorit druhou matici");
                    int rowsa = rows;
                    int columnsa = columns;
                    int[,] newarray = new int[rowsa, columnsa]; //druha matice (scitanec/mensitel)
                    int[,] resultarray = new int[rowsa, columnsa];
                    //jaka bude nova matice
                    Console.WriteLine("\nZadej 1 pro vyplneni druhe matice nahodnymi cisly\nZadej 2 pro vyplneni druhe matice radou cisel");
                    string y = Console.ReadLine();
                    while (y != "1" && y != "2") //dokud uzivatel nezada jednu z moznosti, nic se nedeje
                    {
                        Console.WriteLine("Zadej cislo operace podle nabidky");
                        y = Console.ReadLine();
                    }
                    for (int i = 0; i < rowsa; i++)
                    {
                        for (int j = 0; j < columnsa; j++)
                        {
                            if (y == "1")
                                newarray[i, j] = rnd.Next(10); //vyplni matici nahodnymi cisly (0 az 9)
                            else
                                newarray[i, j] = j + i * columnsa + 1; //vyplni matici radou cisel
                        }
                    }   
                    Console.WriteLine("Zadej + pro secteni matic nebo - pro odecteni matic");
                    operationx = Console.ReadLine();
                    while (operationx != "+" && operationx != "-") //dokud uzivatel nezada jednu z moznosti, nic se nedeje
                    {
                        Console.WriteLine("Zadej cislo operace podle nabidky");
                        operationx = Console.ReadLine();
                    }
                    if (operationx == "+")
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                resultarray[i, j] = array[i, j] + newarray[i, j];
                            }
                        }
                    }
                    if (operationx == "-")
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                resultarray[i, j] = array[i, j] - newarray[i, j];
                            }
                        }
                    }
                    Console.WriteLine("Vysledek je:");      
                    writeArray(resultarray);                   
                    break;
                case "7": //prohazovani prvku na diagonale
                    Console.WriteLine("Zadej 1 pro prohozeni prvku na hlavni diagonale\nZadej 2 pro prohozeni prvku na vedlejsi diagonale");
                    operation = Console.ReadLine();
                    while (operation != "1" && operation != "2") //dokud uzivatel nezada jednu z moznosti, nic se nedeje
                    {
                        Console.WriteLine("Zadej cislo operace podle nabidky");
                        operation = Console.ReadLine();
                    }
                    for (int i = 0; i <= rows / 2; i++)
                    {
                        int reversedIndex = rows - i - 1; //prevzato z "2D Array Playground"
                        if (operation == "1")
                        {
                            int temp = array[i, i];
                            array[i, i] = array[reversedIndex, reversedIndex];
                            array[reversedIndex, reversedIndex] = temp;
                        }
                        else
                        {
                            int temp = array[i, reversedIndex]; //prevzato z "2D Array Playground"
                            array[i, reversedIndex] = array[reversedIndex, i];
                            array[reversedIndex, i] = temp;
                        }
                    }
                    writeArray(array);
                    break;
                case "8": //nasobeni matic
                    int a = columns;
                    int b = rows;
                    int[,] secondarray = new int[columns, rows]; //druha matice (druhy cinitel)
                    string arraygenerator = "0"; //operator pro generaci druhe matice
                    //rozmery druhe matice uz uzivatel nezadava, aby bylo mozne matice vzdycky vynasobit (pocet radku prvni = pocet sloupcu druhe)
                    Console.WriteLine("Pro nasobeni matic bude vytvorena druha matice\nZadej 1 pro vyplneni druhe matice nahodnymi cisly\nZadej 2 pro vyplneni druhe matice radou cisel");
                    while (arraygenerator != "1" && arraygenerator != "2") //dokud uzivatel nezada jednu z moznosti, nic se nedeje
                    {
                        Console.WriteLine("Zadej cislo operace podle nabidky");
                        arraygenerator = Console.ReadLine();
                    }
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            if (arraygenerator == "1")
                                secondarray[i, j] = rnd.Next(10); //vyplni matici nahodnymi cisly (0 az 9)
                            else
                                secondarray[i, j] = j + i * b + 1; //vyplni matici radou cisel
                        }
                    }
                    Console.WriteLine("Toto je druha matice:");
                    for (int i = 0; i < secondarray.GetLength(0); i++) //vypise druhoumatici
                    {
                        for (int j = 0; j < secondarray.GetLength(1); j++)
                        {
                            Console.Write(secondarray[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    int[,] multipliedarray = new int[rows, rows]; 
                    int z = array.GetLength(1); //pocet sloupcu 1. matice a zaroven pocet radku 2. matice
                    for (int i = 0; i < rows; i++) //vypocet od kamarada Kosti, sam bych to nevymyslel (snad to funguje jak ma :))
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            for (int k = 0; k < z; k++)
                            {
                                multipliedarray[i, j] += (array[i, k] * secondarray[k, j]); //kazdy z prvku vysledne matice je souctem nasobeni vsech prvku i-teho radku 1. matice a j-teho sloupce 2. matice
                            }
                        }
                    }
                    Console.WriteLine("Vysledna matice je:");
                    for (int i = 0; i < multipliedarray.GetLength(0); i++) //vypise vyslednou matici
                    {
                        for (int j = 0; j < multipliedarray.GetLength(1); j++)
                        {
                            Console.Write(multipliedarray[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    break;
            }

            Console.ReadKey();
        }
        
    }
}
