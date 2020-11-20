using System;

namespace Exercício_13
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Triangulo();
            double k;

            do
            {
                Console.Write("Informe o valor do primeiro lado do triângulo: ");
                k = double.Parse(Console.ReadLine());

                if (k > 0) a1.SetLado1(k);
            }
            while (k <= 0);

            do
            {
                Console.Write("Informe o valor do segundo lado do triângulo: ");
                k = double.Parse(Console.ReadLine());

                if (k > 0) a1.SetLado2(k);
            }
            while (k <= 0);

            do
            {
                Console.Write("Informe o valor do terceiro lado do triângulo: ");
                k = double.Parse(Console.ReadLine());

                if (k > 0) a1.SetLado3(k);
            }
            while (k <= 0);

            Console.WriteLine(a1.VerificarSeERetangulo());
        }
    }
}
