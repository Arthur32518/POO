using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Bancario : Colaborador3
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("Digite a quantidade de horas extras: ");
            int horasExtras = Convert.ToInt32(Console.ReadLine());
            int valorBruto = horasExtras * 250;

            if(valorBruto > 1000)
            {
                double imposto = valorBruto - (valorBruto * 0.15);
                Console.WriteLine($"Salario descantado {imposto}");

            }
            else if (valorBruto > 500)
            {
                double imposto = valorBruto - (valorBruto * 0.10);
                Console.WriteLine($"Salario descantado {imposto}");

            }
            else
            {
                Console.WriteLine($"Valor bruto: {valorBruto}");         
            }
        }
    }
}
