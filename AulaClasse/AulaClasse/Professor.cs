using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Professor : Pessoa2
    {
        private string nif;
        private string cpf;

        public string Nif
        {
            get 
            { 
                return nif;
            }
            set
            {
                nif = value;
            }

        }      

        public void ApresentarProfessor()
        {
            Console.WriteLine($"Este usuario chamasse {nome}, tem {idade} anos, sua cor é {cor}, tem {altura} de altura, NIF: {Nif}, CPF: {Cpf}");
        }



    }
}
