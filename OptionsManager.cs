using System;

namespace GitExercise
{
    public static class OptionsManager
    {
        public static string[] OptionsList = {
            "a - Add",
            "s - Subtract",
            "m - Multiply"
        };

        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"{a} x {b} = {a * b}");
        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
		while(true)
		{
				Console.Clear();
				Console.WriteLine("Console Calculator App");
				Console.WriteLine(new string(c: '-', count:15));
				
				Console.Write("a = ");
				
				switch (choice)
				{
					case "a":
					OptionsManager.Add(a, b);
					break;
					case "s":
					OptionsManager.Subtract(a, b);
					break;
					case "m":
					OptionsManager.Multiply(a, b);
					break;
					case "ex":
					Console.Clear();
					Console.WriteLine("Goodbye");
					Console.ReadKey(intercept:true);
					return;
				}
				Console.WriteLine("Press any key to continue...");
				Console.ReadKey(intercept:true);
		}
    }
	
}
