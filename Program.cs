using System;

namespace HeronSeTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, A, s;

            Console.WriteLine("Digite os lados do triangulo");
            Console.Write("Lado a : ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Lado b : ")
            b = double.Parse(Console.ReadLine());

            Console.Write("Lado c : ")
            c = double.Parse(Console.ReadLine());

            if (a < (b + c) && a > Math.Abs(b - c) && b < (a + c) && b > Math.Abs(a - c) && c < (a + b) && c > Math.Abs(a - b))
            {
                if (a)
            }
        }
    }
}
