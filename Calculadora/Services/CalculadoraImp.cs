using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public double Dividir(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("O divisor não pode ser zero.");
            }
            return num1 / num2;
        }

        public bool EhPar(int num)
        {
            return num % 2 == 0;
        }
    }
}