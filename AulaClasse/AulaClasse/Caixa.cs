using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Caixa
    {
        public double lado;

        public Caixa(double lado)
        {
            this.lado = lado;

        }
        public double Volume()
        {
            lado = Convert.ToDouble(lado);
            double volume = lado * 3;
            Console.WriteLine(volume);
            return volume;
            
        }

    }
}
