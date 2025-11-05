using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Moeda
    {
        public double ValorReais;
        public double ValorDolar;
        public double ValorEuro;


        public void Conveter1(double valorReais)
        {
            this.ValorReais = valorReais;
            double valorDolar;
            valorDolar = valorReais / 5.40;
            Console.WriteLine($"A conversão ficou : {valorDolar}");
        }
        public void Conveter2(double valorDolar)
        {

            this.ValorDolar = valorDolar;
            double valorReais;
            valorReais = valorDolar * 5.40;
            Console.WriteLine($"A conversão ficou : {valorReais}");
        }
        public void Conveter3(double valorReais2)
        {
            this.ValorReais = valorReais2;
            double valorEuro;
            valorEuro = valorReais2 * 0.16;
            Console.WriteLine($"A conversão ficou : {valorEuro}");
        }

    }
}
