using System;

namespace HeronSeTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, A, s;

            Console.WriteLine("Digite os lados do triangulo\n");

            Console.Write("Lado a : ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Lado b : ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Lado c : ");
            c = double.Parse(Console.ReadLine());

            s = (a + b + c) / 2;
            A = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            if(a < (b + c) && a > Math.Abs(b - c) && b < (a + c ) && b > Math.Abs(a - c) && c < (a + b) && c > Math.Abs(a - b))
            {
                if(a == b && b == c)
                {
                    Console.WriteLine("\n-- Triângulo Equilátero --");
                    Console.WriteLine($"Área = {A:N2}");
                    
                }
                else if(a != b && a != c && b != c)
                {
                    Console.WriteLine("\n-- Triângulo Escaleno --");
                    Console.WriteLine($"Área = {A:N2}");
                    
                }
                else
                {
                    Console.WriteLine("\n-- Triângulo Isóceles --");
                    Console.WriteLine($"Área = {A:N2}");
                }
            }
        }
    }
}
