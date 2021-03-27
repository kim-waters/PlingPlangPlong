using System;

namespace RainDropsApp
{
    public class Raindrops
    {
        public static string GetRaindropsString(int n)
        {
            string raindropString = "";
            if (n % 3 == 0)
            {
                raindropString += "Pling";
            }
            if (n % 5 == 0)
            {
                raindropString += "Plang";
            }
            if (n % 7 == 0)
            {
                raindropString += "Plong";
            }
            if(raindropString == "")
            {
                raindropString = n.ToString();
            }

            return raindropString;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetRaindropsString(28));
            Console.WriteLine(GetRaindropsString(30));
            Console.WriteLine(GetRaindropsString(34));
        }
    }
}
