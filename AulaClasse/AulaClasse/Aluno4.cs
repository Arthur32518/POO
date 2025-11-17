using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Aluno4
    {
        public string nome;
        public int idade;
        private string rg;
        private string cpf;


        public Aluno4(string nome, int idade, string rg, string cpf)
        {

           rg = Console.ReadLine();
            cpf = Console.ReadLine();
        }
    }
}
