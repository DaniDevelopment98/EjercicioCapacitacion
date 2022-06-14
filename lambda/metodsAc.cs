using System;
using System.Collections.Generic;
using System.Text;

namespace lambda
{
    class metodsAc
    {
        public static void PrintText()
        {
            Console.WriteLine("Texto impreso con la ayuda de action");
        }
        public static void PrintNumbers(int start, int target)
        {
            for (int i = start; i <= target; i++)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine();
        }
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        
        //Metodos que toman parametros y devuelven un valor

        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static string DisplayAddition(int a, int b)
        {
            return string.Format("Suma del {0} and {1} is {2}", a, b, a + b);
        }

        public static string SHowCompleteName(string firstName, string lastName)
        {
            return string.Format("Mi nombre es {0} {1}", firstName, lastName);
        }
        public static int ShowNumber()
        {
            Random r = new Random();
            return r.Next();
        }
    }
}
