using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Senai : Escola 
    {
        public override void CalcularMedia()
        {
            Console.WriteLine("Digite a primeira nota 0 a 10: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota 0 a 10: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota 0 a 10: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota 0 a 10: ");
            double nota4 = Convert.ToDouble(Console.ReadLine());
            while ((nota1 > 10 || nota1 < 0) || (nota2 > 10 || nota2 < 0) || (nota3 > 10 || nota3 < 0) || (nota4 > 10 || nota4 < 0))
            {
                Console.WriteLine("Digite a primeira nota 0 a 10: ");
                nota1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a segunda nota 0 a 10: ");
                nota2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a terceira nota 0 a 10: ");
                nota3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a quarta nota 0 a 10: ");
                nota4 = Convert.ToDouble(Console.ReadLine());
                break;
            }

            double media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine("Informe a frequencia %");
            double freq = Convert.ToDouble(Console.ReadLine());

            if(freq > 90 && media > 7)
            {
                Console.WriteLine("Parabens você foi aprovado no curso técnico senai");
            }
            else if (freq > 90 && media < 7)
            {
                Console.WriteLine("Você precisa fazer trabalho de recuperação");
            }
            else if (freq < 90 && media > 7)
            {
                Console.WriteLine("Você precisa fazer trabalho de recuperação");
            }
            else
            {
                Console.WriteLine("Aluno reprovado");
            }



        }
    }
}
