using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Switch();
            Arrays();
        }

        static void Switch()
        {
            Console.WriteLine("Input a WASD key.");
            ConsoleKeyInfo inputKey = Console.ReadKey();
            int input = (char)Console.ReadKey().Key;
            Console.WriteLine();

            if (inputKey.Key == ConsoleKey.W)
            {
                input = 0;
            }
            else if (inputKey.Key == ConsoleKey.A)
            {
                input = 1;
            }
            else if (inputKey.Key == ConsoleKey.S)
            {
                input = 2;
            }
            else if (inputKey.Key == ConsoleKey.D)
            {
                input = 3;
            }
            else
            {
                input = default;
            }
            switch (input)
            {
                case 0:
                    Console.WriteLine("You moved up");
                    break;
                case 1:
                    Console.WriteLine("You moved down");
                    break;
                case 2:
                    Console.WriteLine("You moved left");
                    break;
                case 3:
                    Console.WriteLine("You moved right");
                    break;
                default:
                    Console.WriteLine("You did not press a WASD key");
                    break;
            }
            Console.WriteLine();
        }
        static void Arrays()
        {
            int[] numbers = { 100, 94, 159, -783, 132, 179, 47, 107, 135, 50 };
            for (int i = numbers.Length; i > 0; i--)
            {

                Console.WriteLine(numbers[i - 1]);

            }
            bool numFound = false;

            while (!numFound)
            {
                Console.WriteLine("Type an input number.");
                string? result = Console.ReadLine();
                int.TryParse(result, out int userNumber);
                foreach (int number in numbers)
                {
                    if (number == userNumber)
                    {
                        Console.WriteLine("You found a correct input");
                        numFound = true;
                        break;
                    }

                }
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("The sum of the input numbers is " + sum);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(numbers[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 3 != 0)
                {
                    continue;
                }
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("Enter your first number");
            int arraySize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            int rangeMin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your third number");
            int rangeMax = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[arraySize];
            Random rmd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rmd.Next(rangeMin, rangeMax);
            }
        }
        private static void IntegerArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
        private static void OverLoadMethods(float[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
        private static void OverLoadMethods(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
        private static void IntegerIntoFloat(int[] array)
        {
            float sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += (float)array[i];
            }
        }
        private static void AverageFloat(float[] array)
        {
            float sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
        }
        private static void AverageDouble(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
        }
        private static void RandomInputDynamics(int[] array)
        {
            Console.WriteLine("Enter your first number");
            int arraySize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            int rangeMin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your third number");
            int rangeMax = Convert.ToInt32(Console.ReadLine());

            array = new int[arraySize];
            Random rmd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rmd.Next(rangeMin, rangeMax);
            }
        }
    }
}
