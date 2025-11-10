using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Colaborador1
    {
        public virtual void CalcularSalario(double salario)
        {
            double novoSalario = salario * 1.25;

            Console.WriteLine($"Este colaborador tem um novo salario de {novoSalario} R$");
        }
        public virtual void CalcularImposto(double salario)
        {
            double imposto = salario * 0.15;
            double salarioLiquido = salario - imposto;
            Console.WriteLine($"Este colaborador tem um salario liquido de {salarioLiquido} R$");

        }
    }
}
