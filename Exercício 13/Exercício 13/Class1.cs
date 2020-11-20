using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_13
{
    class Triangulo
    {
        double lado1;
        double lado2;
        double lado3;

        public void SetLado1(double p)
        {
            lado1 = p;
        }

        public void SetLado2(double p)
        {
            lado2 = p;
        }

        public void SetLado3(double p)
        {
            lado3 = p;
        }

        public double GetLado1()
        {
            return lado1;
        }

        public double GetLado2()
        {
            return lado2;
        }

        public double GetLado3()
        {
            return lado3;
        }

        public int VerificarSeETriangulo()
        {
            int r;

            if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1) r = 1;
            else r = 0;

            return r;
        }

        public string DeterminarTipoDeTriangulo()
        {
            string r;
            if (VerificarSeETriangulo() == 1)
            {
                if (lado1 == lado2 && lado1 == lado3) r = "equilátero";
                else if ((lado1 == lado2 && lado1 != lado3) || (lado1 == lado3 && lado1 != lado2) ||
                (lado2 == lado3 && lado2 != lado1)) r = "isósceles";
                else r = "escaleno";
            }
            else r = "Não é um triângulo";

            return r;
        }

        public string VerificarSeERetangulo()
        {
            string s = "";

            if (VerificarSeETriangulo() == 1)
            {
                if (Math.Pow(lado1, 2) + Math.Pow(lado2, 2) == Math.Pow(lado3, 2)
                    || Math.Pow(lado1, 2) + Math.Pow(lado3, 2) == Math.Pow(lado2, 2)
                    || Math.Pow(lado2, 2) + Math.Pow(lado3, 2) == Math.Pow(lado1, 2))
                {
                    s = "Este triângulo é retângulo";
                }
                else s = "Este triângulo não é retângulo";
            }
            else s = "Não é triângulo";

            return s;

            
        }
    }
}
