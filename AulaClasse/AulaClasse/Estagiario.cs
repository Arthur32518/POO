using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Estagiario : Colaborador
    {
        public override void CalcularValeAlimentacao(double salario)
        {
            double novoSalario = salario * 1.30;

            Console.WriteLine($"Este colaborador tem um vale de {novoSalario} R$");
        }
        public override void CalcularImposto(double salario)
        {
         
            Console.WriteLine($"Este colaborador tem um salario liquido de {salario} R$");
        }
    }
}
