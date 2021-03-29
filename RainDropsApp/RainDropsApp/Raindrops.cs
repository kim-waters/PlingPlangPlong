using System;

namespace RainDropsApp
{
    public class Raindrops
    {
        /// <summary>
        /// Returns a string based on whether the integer parameter has factors of 3, 5 or 7
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string GetRaindropsString(int n)
        {
            string raindropString = "";
            if (n % 3 == 0)
            {
                // if 3 is a factor, append Pling to the string
                raindropString += "Pling";
            }
            if (n % 5 == 0)
            {
                // if 5 is a factor, append Plang to the string
                raindropString += "Plang";
            }
            if (n % 7 == 0)
            {
                // if 7 is a factor, append Plong to the string
                raindropString += "Plong";
            }
            if(raindropString == "")
            {
                // if neither 3, 5 or 7 are factors then set the string to the digits in n
                raindropString = n.ToString();
            }
            return raindropString;
        }

        static void Main(string[] args)
        {
            int inputInt;
            bool success;
            do
            {
                success = true;
                Console.WriteLine("Enter an integer");
                var input = Console.ReadLine();
                if (!Int32.TryParse(input, out inputInt))
                {
                    // if the user did not enter a valid integer, display an error message and ask them to input again
                    Console.Clear();
                    Console.WriteLine("Invalid input!");
                    success = false;
                }
            } while (success == false);

            Console.WriteLine(GetRaindropsString(inputInt));
        }
    }
}
