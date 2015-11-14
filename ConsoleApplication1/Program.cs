using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(estPremier(1)); // false
            Console.WriteLine(estPremier(5)); // true
            Console.WriteLine(estPremier(15)); // false
            Console.WriteLine(estPremier(32)); // false
            Console.WriteLine(estPremier(67)); // true

            Console.ReadLine();
        }

        static bool estPremier(int n)
        {
            var result = true;
            int i;
            if (n == 1) return false;
            for (i = 2; i < n; i++)
            {

                if ((n % i == 0) && (i > 2))
                {
                    Console.WriteLine("le nombre " + n + " est divisible par " + i + " donc il ne peut pas être premier");
                    result = false;
                }
                else
                {
                    Console.WriteLine("le nombre " + n + " n'est pas divisible " + i);
                    //result = true;
                }
            }

            return result;
        }

    }

    public interface B    {
    }
    public interface C
    {
    }
    public interface A : B, C
    {
    }

 
}
