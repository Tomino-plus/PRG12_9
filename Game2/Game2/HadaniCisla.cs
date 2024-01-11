using System;

class HadaniCisla
{
    private int CorrectNumber;
    private bool CorrectlyGuessed;
    int attempts = 0;
    public HadaniCisla()
    {
        CorrectlyGuessed = false;
    }

    public void Play()
    {
        Random random = new Random();
        Console.WriteLine("Vitej v hadani cisla!");
        Console.WriteLine($"Pokusis se tipnout nahodne vygenerovane cislo z intervalu, ktery si vyberes");
        int Min;
        Console.WriteLine("Zadej cele cislo - minimum");
        while (!int.TryParse(Console.ReadLine(), out Min) || Min < 0)
            Console.WriteLine("Zadej kladne cele cislo");
        int Max;
        Console.WriteLine("Zadej cele cislo - maximum");
        while (!int.TryParse(Console.ReadLine(), out Max) || Max < Min)
            Console.WriteLine("Zadej cele cislo vetsi nez minimum");
        
        CorrectNumber = random.Next(Min, Max);

        while (!CorrectlyGuessed)
        {
            Console.WriteLine("Zadej svuj tip");
            string input = Console.ReadLine();
            attempts++;
            if (int.TryParse(input, out int guess))
            {
                CheckGuess(guess);
            }
            else
            {
                Console.WriteLine("Zadej prosim validni cislo");
            }
        }
        if (attempts == 1) 
        {
            Console.WriteLine($"Vyborne! {CorrectNumber} je spravne cislo! Pro uhadnuti jsi potreboval pouze 1 pokus");
        }
        else if (attempts == 2 || attempts == 3 || attempts == 4)
        {
            Console.WriteLine($"Vyborne! {CorrectNumber} je spravne cislo! Pro uhadnuti jsi potreboval pouze 2 pokusy");
        }
        else 
        {
            Console.WriteLine($"Vyborne! {CorrectNumber} je spravne cislo! Pro uhadnuti jsi potreboval {attempts} pokusu");
        }
        Console.ReadKey();
    }


    private void CheckGuess(int guess)
    {
        if (guess == CorrectNumber)
        {
            CorrectlyGuessed = true;
        }
        else if (guess < CorrectNumber)
        {
            Console.WriteLine("Spravne cislo je vyssi nez zadane, zkus to znovu");
        }
        else
        {
            Console.WriteLine("Spravne cislo je nizsi nez zadane, zkus to znovu");
        }
    }
}