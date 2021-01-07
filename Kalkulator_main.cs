using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and then initialize to zero.
            int num1 = 0; int num2 = 0;

            // Display title as the C# console calculator app.
            Console.WriteLine("Kalkulator w C#\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to type the first number.
            Console.WriteLine("Wpisz liczbę, a następnie wciśnij enter.");
            num1 = Convert.ToInt32(Console.ReadLine());//Pobranie 1 liczby 

            // Ask the user to type the second number.
            Console.WriteLine("Wpisz drugą liczbe, a następnie wciśnij enter.");
            num2 = Convert.ToInt32(Console.ReadLine());//Pobranie 2 liczby

            // Ask the user to choose an option.
            Console.WriteLine("Wybierz operacje z poniższej listy:");
            Console.WriteLine("\td - Dodawanie");
            Console.WriteLine("\to - Odejmowanie");
            Console.WriteLine("\tm - Mnożenie");
            Console.WriteLine("\tdz - Dzielenie");
            Console.Write("Wpisz operacje i naciśnij enter ");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
            }
            // Wait for the user to respond before closing.
            Console.Write("Wciśnij dowolny przycisk by wyjść z programu...");
            Console.ReadKey();
        }
    }
}