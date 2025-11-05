using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Alunos
    {
        public string Nome;
        public string Escola;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double Nota4;
        public double Nota5;


        public double SomarNotas(double nota1, double nota2, double nota3, double nota4, double nota5)
        {
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.Nota3 = nota3;
            this.Nota4 = nota4;
            this.Nota5 = nota5;
            double media = nota1 + nota2 + nota3 + nota4 + nota5;
            return media;
            
        }
        public string CalcularMedia()
        {
            double resultado = SomarNotas(Nota1, Nota2, Nota3, Nota4, Nota5);
            Console.WriteLine(resultado);

            if(resultado >= 7)
            {
                return "Aluno aprovado";
            }
            else if(resultado >= 5)
            {
                return "Aluno de recuperação";
            }
            else
            {
                return "Aluno reprovado";
            }

            

        }
    }
}
