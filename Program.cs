using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int A = 5, B = 13,k=0;
            for (int i=A;i<=B;i++)
            {
                Console.WriteLine(" " + i.ToString());
                k++;
            }
            Console.WriteLine(" Количество: " + k.ToString());
            Console.ReadKey();
        }
    }
}
