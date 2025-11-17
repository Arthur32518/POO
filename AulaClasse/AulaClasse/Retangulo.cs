using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Retangulo
    {
        public double base1;
        public double altura;

        public Retangulo(double base1, double altura)
        {
            this.base1 = base1;
            this.altura = altura;
        }

        public void Area()
        {
            double area = base1 * altura;
            Console.WriteLine(area);
        }


    }
}
