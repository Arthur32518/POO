using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Desenvolvedor : Colaborador3
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("Escolhe uma opção: \n A - PRESENCIAL \n B - HIBRIDO  \n C - REMOTO ");
            string opcao = Console.ReadLine();

            if (opcao == "A")
            {
                Console.WriteLine($"Digite a quantidade de horas extras: ");
                int horas = Convert.ToInt32(Console.ReadLine());
                int horaNova = horas * 100;
                Console.WriteLine($"O total de horas será: {horaNova}");
            }
            else if (opcao == "B")
            {
                Console.WriteLine($"Digite a quantidade de horas extras: ");
                int horas = Convert.ToInt32(Console.ReadLine());
                int horaNova = horas * 50;
                Console.WriteLine($"O total de horas será: {horaNova}");
            }
            else if (opcao == "C")
            {
                Console.WriteLine("Seu salario é flexivel, não tem calculo de horas ");
                
            }
            else
            {
                Console.WriteLine("Opção invalida");
            }
        }
    }
}
