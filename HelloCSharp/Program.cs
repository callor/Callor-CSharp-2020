using System;

namespace HelloCSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            NewClass hello = new NewClass();

            Console.WriteLine("반가워 C#");
            int sum = hello.add(200, 300);
            //Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("결과 : " + sum);

        }
    }
}




