using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Aluno3 : Pessoa2
    {
        private string RA;

        public string ra
        {
            get
            {
                return RA;
            }
            set
            {
                RA = value;
            }

        }
        public void ApresentarAluno()
        {
            Console.WriteLine($"Este usuario chamasse {nome}, tem {idade} anos, sua cor é {cor}, tem {altura} de altura, RA: {RA}");
        }


    }
}
