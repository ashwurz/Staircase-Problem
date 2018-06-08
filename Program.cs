using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void espacos(int contagem, int n)
        {
            for (int i = 0; i < n - contagem; i++)
            {
                Console.Write(" ");
            }
        }       
        static void rashtag(int contagem)
        {
            for (int i = 0; i < contagem; i++)
            {
                Console.Write("#");
            }
        }
        static void staircase(int n)
        {
            int nHash = 0;
            for (int i = 0; i < n; i++)
            {
                nHash = i + 1;
                espacos(nHash, n);
                rashtag(nHash);
                Console.Write("\n");
            }
        }          
        static void Main(string[] args)
        {
            int n = 6;
            staircase(n);
        }
    }
}
