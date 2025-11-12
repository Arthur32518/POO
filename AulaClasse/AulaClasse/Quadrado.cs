using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Quadrado : Forma
    {
        public override void CalcularArea()
        {
            Console.WriteLine("Digite o primeiro lado do quadrado");
            double lado = Convert.ToDouble(Console.ReadLine());

            double area = lado * lado;
            Console.WriteLine("A area do quadrado é " + area);
        }
    }
}
