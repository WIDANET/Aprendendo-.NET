using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aprendendo_.NET.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} é igual a: {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} é igual a: {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} é igual a: {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} é igual a: {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} é igual a: {pot}");
        }

        public void seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}º é {Math.Round(seno, 4)}");
        }

         public void coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}º é {Math.Round(coseno, 4)}");
        }

         public void tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}º é {Math.Round(tangente, 4)}");
        }
    }
}