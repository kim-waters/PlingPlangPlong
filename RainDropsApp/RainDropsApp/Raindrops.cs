using System;

namespace RainDropsApp
{
    public class Raindrops
    {
        public static string GetRaindropsString(int n)
        {
            return n.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetRaindropsString(28));
        }
    }
}
