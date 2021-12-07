namespace CourseApp
{
    using System;
    /* using System.Collections.Generic;*/

    public class Program
    {
        public static void Main(string[] args)
        {
            string[] phraseArray = { ":(", "Жаль :(", "Понмянем :(" };
            Pig pigOne = new Pig();
            Pig pigTwo = new Pig("Бычок", 9, 99);
            Bull boarOne = new Bull("Бычок 1", 1, 5, 7);
            Bull boarTwo = new Bull("Бычок 2", 3, 2, 8);
            Animals[] animals = new Animals[] { pigOne, pigTwo, boarOne, boarTwo };
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.Write(pigTwo.Died());
            Console.WriteLine(pigTwo.MakePhrase(phraseArray));
            Console.Write(boarTwo.Died());
            Console.WriteLine(boarTwo.MakePhrase(phraseArray));
        }
    }
}
