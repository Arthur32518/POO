using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Gerente : Colaborador
    {
        public override void CalcularValeAlimentacao(double salario)
        {
            double novoSalario = salario * 1.10;

            Console.WriteLine($"Este colaborador tem um vale de {novoSalario} R$");
        }
        public override void CalcularImposto(double salario)
        {
            double salarioLiquido = salario - (salario * 0.25);
            Console.WriteLine($"Este colaborador tem um imposto de {salarioLiquido} R$");
        }
    }
}
