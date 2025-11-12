using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Poupanca : Conta2
    {
        public override void calcularImposto(double saque)
        {
            double descontoSaque = saque - (saque * 0.06);

            Console.WriteLine($"Desconto poupança:  {descontoSaque} R$");
        }
    }
}
