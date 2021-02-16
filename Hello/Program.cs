using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("문자열을 입력하세요");
            string str = Console.ReadLine();
            Console.WriteLine($"Hello World! 반가워 {str}");
        }
    }
}
