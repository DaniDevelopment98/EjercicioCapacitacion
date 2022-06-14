using System;
using System.Collections.Generic;
using System.Linq;

namespace lambda
{
    class Program
    {

        public class MySpecialAttribute : Attribute
        {

        }
        static void Main(string[] args)
        {
            string count;
            Console.WriteLine("1 (Operaciones Lambda), 2(Operaciones Action. function)");
            count = Console.ReadLine();

            switch (count)
            {

                case "1":
                    caso1();                    
                    break;                

                case "2":
                   Caso2();

                    break;

                    case "3":

                        break;
            }
                        
        }

        static void Caso2 ()
        {
            Action printText = new Action(metodsAc.PrintText);
            Action<string> print = new Action<string>(metodsAc.Print);
            Action<int, int> printNumber = new Action<int, int>(metodsAc.PrintNumbers);

            Func<int, int, int> add1 = new Func<int, int, int>(metodsAc.Addition);
            Func<int, int, string> add2 = new Func<int, int, string>(metodsAc.DisplayAddition);
            Func<string, string, string> completeName = new Func<string, string, string>(metodsAc.SHowCompleteName);
            Func<int> random = new Func<int>(metodsAc.ShowNumber);

            Console.WriteLine("\n***************** Action<> Delegate Methods ***************\n");
            printText();    //Parameter: 0 , Returns: nothing
            print("Jorge");  //Parameter: 1 , Returns: nothing
            printNumber(5, 20); //Parameter: 2 , Returns: nothing
            Console.WriteLine();
            Console.WriteLine("**************** Func<> Delegate Methods *****************\n");
            int addition = add1(2, 5);  //Parameter: 2 , Returns: int
            string addition2 = add2(5, 8);  //Parameter: 2 , Returns: string
            string name = completeName("Jorge", "Lopez");    //Parameter:2 , Returns: string
            int randomNumbers = random();   ////Parameter: 0 , Returns: int

            Console.WriteLine("Addition: {0}",addition);
            Console.WriteLine(addition2);
            Console.WriteLine(name);
            Console.WriteLine("Random Number is: {0}",randomNumbers);
            
        Console.ReadLine();
        }
        static void caso1()
        {
            //int[] numbers = { 2, 3, 4, 5 };
            //var squaredNumbers = numbers.Select(x => x * x + 2);
            //Console.WriteLine(string.Join(" ", squaredNumbers));

            //Func<double, double> cube = x => x * x * x;
            //Func<int, int, bool> testForEquality = (x, y) => x == y;
            //Func<int, string, bool> isTooLong = (int x, string s) => s.Length > x;
            Func<(int, int, int), (int, int, int)> doubleThem = ns => (ns.Item1 * ns.Item1, ns.Item2 * ns.Item2, ns.Item3 * ns.Item3);
            var numbers = (5, 9, 6);
            var doubledNumbers = doubleThem(numbers);
            Console.WriteLine($"La lista de numeros {numbers} el cuadrado de la lista es: {doubledNumbers}");
        }

        static void caso4()
        {

        }
    }

}
