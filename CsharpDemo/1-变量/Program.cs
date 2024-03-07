using System;

namespace _1_变量
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 1;
            float b = 1.1f;
            double c = 1.1111;
            char d = '1';
            byte e = 100;
            Console.WriteLine($"整数：{a}");
            Console.WriteLine($"浮点数：{b}");
            Console.WriteLine($"双浮点数：{c}");
            Console.WriteLine($"字符：{d}");
            Console.WriteLine($"字节：{e}");
        }
    }
}