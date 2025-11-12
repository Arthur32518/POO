using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Coordenador : Colaborador2
    {
        public override void CalcularSalario(double salario)
        {
            double descontoSalario = salario - (salario * 0.11);

            Console.WriteLine($"Desconto INSS coordenador:  {descontoSalario} R$");
        }
    }
}
