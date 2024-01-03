using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Somar(int num1, int num2){
            return num1 + num2;
        }

        public int Multiplicar(int num, int numb){
            return num * numb;
        }
        public bool Ehpar(int numero){
            return numero % 2 == 0;
            //verifica se o resultado é igual a zero
            // se for o resultado é par, se o resto for zero
            // o numero será par.
        }
    }
}