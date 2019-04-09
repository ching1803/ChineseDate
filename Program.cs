using System;

namespace ChineseDate
{
    class Program
    {
        static void Main(string[] args)
        {
            string today = ChineseDate.ConvertToChineseDate(DateTime.Now);
            Console.WriteLine(today);
            Console.ReadKey();
        }
    }
}
