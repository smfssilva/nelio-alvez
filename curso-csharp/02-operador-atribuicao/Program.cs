using System;

namespace operador_atribuicao
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            a++;
            Console.WriteLine(a);

            string s = "abc";
            Console.WriteLine(s);
            s += "XXX";
            Console.WriteLine(s);

        }
    }
}
