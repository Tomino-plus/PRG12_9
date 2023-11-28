using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        class Human
        {
            public int age;
            public int height; //nejsou videt zvenku
            public int weight;
            public string hairColor;
            public string eyeColor;
            public string name;

            public Human(int age, int height, int weight) //kdyz definuju jenom tyhle tri hodnoty
            {
                this.age = age;
                this.height = height;
                this.weight = weight;
            }
            public Human(int age, int height, int weight, string hairColor, string eyeColor, string name) //kdyz definuju vsechny hodnoty
            {
                this.age = age;
                this.height = height;
                this.weight = weight;
                this.hairColor = hairColor;
                this.eyeColor = eyeColor;
                this.name = name;
            }
            public void PrintCharacteristics() //vypise vlastnosti daneho cloveka
            {
                Console.WriteLine($"{name} je starý/stará {age} let, váží {weight} a měří {height} centimetrů");
            }
            public float BMI() //BMI kalkulacka
            {
                float heightForBMI = height / 100f;   
                float bmi = weight / (heightForBMI * weight);
                return bmi;
            }
            public void SetAge(int age) //overi platnost veku
            {
                if (age < 0 || age > 117)
                {
                    Console.WriteLine("Tento věk není možné zadat");
                }
                else this.age = age;
            }
        }

        static void Main(string[] args)
        {
            Human human1 = new Human(32, 165, 65); //uz nadefinujeme age, height a weight
            /*human1.age = 32;
            human1.height = 165;
            human1.weight = 65;
            
            human1.hairColor = "Brown";
            human1.eyeColor = "Blue";
            human1.name = "Karel";
            */
            human1.PrintCharacteristics();

            Human human2 = new Human(18, 205, 90, "Brown", "Blue", "Lojza");

            human2.PrintCharacteristics();
            float bmi = human2.BMI();
            Console.WriteLine($" {human2.name} má BMI {bmi}");
            
            Console.ReadKey();
        }
    }
}
