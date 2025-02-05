namespace Excersice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare string variable's and outputting to console 
            string declareText = "I'm in Game 1377: Scripting for Game Designers.";
            Console.WriteLine(declareText);

            //Making it uppercase
            string declareTextUppercase = declareText.ToUpper();
            Console.WriteLine(declareTextUppercase);

            //Making it lowercase
            string declareTextLowercase = declareText.ToLower();
            Console.WriteLine(declareTextLowercase);

            //Outputting letters starting from 8
            string declareTextLastWord = declareText.Substring(8);
            Console.WriteLine(declareTextLastWord);

            //Outputting letters 8-11 only 
            string declareTextFirstWord = declareText.Substring(8, 11);
            Console.WriteLine(declareTextFirstWord);

            //Outputting letter 8 only
            char letter8 = declareText[7];
            Console.WriteLine(letter8);

            // Arithemetic 


            Console.WriteLine("Enter your first int");
            int intInput1 = Convert.ToInt32(Console.ReadLine());

            if (intInput1 != null)
            {
                Console.WriteLine("Your first int is " + intInput1);
            }

            Console.WriteLine("Enter your second int");
            int intInput2 = Convert.ToInt32(Console.ReadLine());

            if (intInput2 != null)
            {
                Console.WriteLine("Your second int is " + intInput2);
            }

            int sum = intInput1 + intInput2;
            int diff = intInput1 - intInput2;
            int product = intInput1 * intInput2;
            float quotient = (float)intInput1 / intInput2;
            int remainder = intInput1 % intInput2;

            // Assignment 

            Console.WriteLine("Enter your first float");
            float floatInput1 = Convert.ToInt32(Console.ReadLine());

            if (floatInput1 != null)
            {
                Console.WriteLine("Your first float is" + floatInput1);

            }
            Console.WriteLine("Enter your second float");
            float floatInput2 = Convert.ToInt32(Console.ReadLine());

            if (floatInput2 != null)
            {
                Console.WriteLine("Your second float is " + floatInput2);

            }

            floatInput2 = floatInput1 + floatInput2;
            floatInput2 = floatInput1 - floatInput2;
            floatInput2 = floatInput1 * floatInput2;
            floatInput2 = floatInput1 / floatInput2;

            // Comparison and Conditionals 

            Console.WriteLine("Enter your first int");
            int intInput3 = Convert.ToInt32(Console.ReadLine());

            if (intInput3 != null)
            {
                Console.WriteLine("Your first int is " + intInput3);

            }

            Console.WriteLine("Enter your second int");
            int intInput4 = Convert.ToInt32(Console.ReadLine());

            if (intInput4 != null)
            {
                Console.WriteLine("Your second int is " + intInput4);

            }

            if (intInput3 == intInput4)
            {
                Console.WriteLine("The Inputs are equal");
            }

            else if (intInput3 > intInput4)
            {
                Console.WriteLine("Input 3 is greater than Input 4.");
            }

            else if (intInput3 < intInput4)
            {
                Console.WriteLine("Input 3 is less than Input 4");
            }
        }
    }
}


