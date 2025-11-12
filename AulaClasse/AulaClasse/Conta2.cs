using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Conta2
    {
        public string agencia;
        public string conta;
        public string nomeTitular;


        public virtual void calcularImposto(double saque)
        {
            double descontoSaque = saque - (saque * 0.04);
         
        }
    }
}
