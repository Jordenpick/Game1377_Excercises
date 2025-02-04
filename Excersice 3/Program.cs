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
                int intInput1, intInput2;
                intInput1 = 3, intInput2 = 4;
                int sum = intInput1 + intInput2;
                int diff = intInput1 - intInput2;
                int product = intInput1 * intInput2;
                float quotient = intInput1 / intInput2;
                int remainder = intInput1 % intInput2;


            }
        }
    }


