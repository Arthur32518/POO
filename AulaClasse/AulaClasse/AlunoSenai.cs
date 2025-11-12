using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class AlunoSenai
    {
        public string Nome;
        public string Cidade;
        public string Estado;
        public int Idade;
        public string Cpf;
        public string Rm;

        public AlunoSenai(int idade, string rm, string nome) 
        {
            this.Idade = idade;
            this.Rm = rm;
            this.Nome = nome;
        }

        public void Estudar()
        {
            Console.WriteLine("O aluno esta estudando");
        }
        public void Conversar()
        {
            Console.WriteLine("O aluno esta conversando ");
        }
        public void Programar()
        {
            Console.WriteLine("O aluno esta programando ");
        }
    }
}
