using System;
using System.Reflection;
using System.Linq;
namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            string selc;

            Console.WriteLine("Seleccione un Evento 1 (Reflection), 2 (extension),3 (stringFormat), 4(string interpolation), 5 nullabletype"+ 
                "6 ()");
            selc = Console.ReadLine();

            switch (selc)
            {
                case "1":
                    Type tipo = typeof(System.String);

                    Console.WriteLine(" " + tipo.Name);
                    ConstructorInfo[] c = tipo.GetConstructors();

                    foreach (var co in c)
                    {
                        Console.WriteLine(" " + co.Name);
                    }

                    break;
                    //Caso dos que realiza un ordenamiento de numeros dentro de un arreglo por medio de una palabra reservada por linq
                case "2":
                    int[] ints = { 10, 45, 15, 39, 21, 26 };
                    var result = ints.OrderBy(g => g);
                    foreach (var i in result)
                    {
                        System.Console.Write(i + " ");
                    }
                    break;

                case "3":
                    Decimal pricePerOunce = 17.36m;
                    String s = String.Format("The current price is {0:C2} per ounce.",
                                             pricePerOunce);
                    Console.WriteLine(s);
                    

                    // Creo 5 array tuple, para agregar los datos a las ciudades 
                    Tuple<string, DateTime, int, DateTime, int>[] cities =
                        { Tuple.Create("Los Angeles", new DateTime(1940, 1, 1), 1504277,
                        new DateTime(1950, 1, 1), 1970358),
                      Tuple.Create("New York", new DateTime(1940, 1, 1), 7454995,
                         new DateTime(1950, 1, 1), 7891957),
                        Tuple.Create("Chicago", new DateTime(1940, 1, 1), 3396808,
                               new DateTime(1950, 1, 1), 3620962),
                         Tuple.Create("Detroit", new DateTime(1940, 1, 1), 1623452,
                               new DateTime(1950, 1, 1), 1849568) };

                    // Diseñando el encabezado
                    var header = String.Format("{0,-12}{1,8}{2,12}{1,8}{2,12}{3,14}\n",
                                                  "Ciudad", "Año", "Popularidad", "Cambio (%)");
                    Console.WriteLine(header);
                    //Se impirime todo lo que hay en las ciudades
                    foreach (var city in cities)
                    {
                        var output = String.Format("{0,-12}{1,8:yyyy}{2,12:N0}{3,8:yyyy}{4,12:N0}{5,14:P1}",
                                               city.Item1, city.Item2, city.Item3, city.Item4, city.Item5,
                                               (city.Item5 - city.Item3) / (double)city.Item3);
                        Console.WriteLine(output);
                    }
                    break;
                case "4":
                    var date = new DateTime(1998, 3, 3);
                    Console.WriteLine($"El {date:dddd, MMMM dd, yyyy} Jorge Daniel entiende en clases que {Math.PI} es el valor de pi");
                    
                    break;

                case "5":
                    //double? pi = 3.14;
                    //char? letter = 'a';

                    //int m2 = 10;
                    //int? m = m2;

                    //bool? flag = null;

                    //// An array of a nullable value type:
                    //int?[] arr = new int?[10];

                    int? a = 42;
                    if (a is int valueOfA)
                    {
                        Console.WriteLine($"a es {valueOfA}");
                    }
                    else
                    {
                        Console.WriteLine("a no contiene un valor");
                    }

                    break;
            }
        }
    }

    
}
