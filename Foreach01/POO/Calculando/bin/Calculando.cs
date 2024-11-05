using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculando.bin
{
    public class Calculando
    {
        public float numero1;

        public float numero2;

        public void somar(float numero1, numero2)
        {
            valor= numero1 + numero2;
            Console.WriteLine($"Resultado da Soma:{valor}");
            
        }

        public void subtrair(float numer01, numero2)
        {
            valor = numero1 - numero2;
             Console.WriteLine($"Resultado da subtracao:{valor}");
        }

        public void multiplicar(float numero1, numero2)
        {
            valor = numero1 * numero2;
             Console.WriteLine($"Resultado da mutiplicacao:{valor}");
        }


        public void dividir(float numero1, numero2)
        {
            valor = numero1 / numero2;
             Console.WriteLine($"Resultado da divisao:{valor}");
        }
    }
}