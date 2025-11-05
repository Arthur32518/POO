using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Aluno2
    {
        public string nome;
        public int idade;
        public double peso;
        public double altura;


        //Privado encapsulamento
        private string cpf;
        private string rg;
        private string numero_celular;

        //Propriedade Get e Set
        //Get = OBTER
        //Set = DEFINIR 

        //EXCLUSIVO PARA ATRIBUTOS PRIVADOS
        public string Cpf
        {
            get 
            {
                return cpf;
            }
            set
            {
                cpf = value;
            }
        }

    }
}
