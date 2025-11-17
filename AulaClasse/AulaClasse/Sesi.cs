using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Sesi : Escola
    {
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public override void CalcularMedia()
        {
            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());
            double media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7)
            {
                Console.WriteLine("Aluno aprovado");
            }
            else if (media >= 4)
            {
                Console.WriteLine("Aluno de recuperação");
            }
            else
            {
                Console.WriteLine("Aluno reprovado");
            }

        }
    }
}
