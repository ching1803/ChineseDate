using System;

namespace ChineseDate
{
    class Program
    {
        static void Main(string[] args)
        {
            string today = ChineseDate.ConvertToChineseDate(DateTime.Now);
            string todayDetails = ChineseDate.ConvertToChineseDate(DateTime.Now,true,true,true);
            Console.WriteLine(today);
            Console.WriteLine(todayDetails);
            Console.ReadKey();
        }
    }
}
