using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Colaborador2
    {
        public string nome;

        public virtual void CalcularSalario(double salario)
        {
            double descontoSalario = salario - (salario * 0.14);
                  
            Console.WriteLine($"Desconto INSS:  {descontoSalario} R$");
        }
        public virtual void CalcularIrrf(double salario)
        {
            double imposto = salario - (salario * 0.02);
;            Console.WriteLine($"Desconto IRRF: {imposto} R$");

        }
    }
}
