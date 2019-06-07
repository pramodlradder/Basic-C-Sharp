using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 a = 10;
            if(a==10)
            {
                Console.WriteLine("a is 10");
            }
            else
            {
                Console.WriteLine("a is not 10");
            }
            for(Int32 i = 0; i < a; i++)
            {
                Console.WriteLine("i is {0}",i);
            }
            //read from the user
            Console.WriteLine("Enter the value");
            Int32 input = Int32.Parse(Console.ReadLine());
            while(input < 10)
            {
                Console.WriteLine("value is {0}",input);
                input++;
            }
            Console.WriteLine("Enter the value");
            Int32 num = Int32.Parse(Console.ReadLine());
            switch (num)
            {
                case 0:
                    Console.WriteLine("Case 0");
                    break;
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Wrong Entry");
                    break;
            }
            Console.ReadKey();
        }
    }
}
