using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Corrente : Conta2
    {
        public override void calcularImposto(double saque)
        {
            double descontoSaque = saque - (saque * 0.15);

            Console.WriteLine($"Desconto corrente:  {descontoSaque} R$");
        }
    }
}
