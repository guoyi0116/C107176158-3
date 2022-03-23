using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C107176158_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string symbols = "0123456789ABCDEF";
            num = Convert.ToInt32(Console.ReadLine());
            string result = "";
            while (num > 16)
            {
                result = symbols[num % 16].ToString() + result;
                num = (num / 16);
            }
            result =  symbols[num]+result
                ;
            Console.WriteLine("binary number is {0}", result);
            Console.ReadLine();
               
        }
    }
}
