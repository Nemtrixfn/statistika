using System;

namespace statistika
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo KeyInfo;

            while (true)
            {


                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine(keyInfo.Key.ToString());
            }
        }
    }
}
