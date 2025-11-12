using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Pessoa2
    {
        public string nome;
        public int idade;
        public string cor;
        public double altura;

        private string cpf;
        private string rg;
        private string cidade;
        private string estado;


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
        public string Rg
        {
            get
            {
                return rg;
            }
            set
            {
                rg = value;
            }
        }
        public string Cidade
        {
            get
            {
                return cidade;
            }
            set
            {
                cidade = value;
            }
        }
        public string Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }

        public void ApresentarPessoa()
        {
           
            Console.WriteLine($"Este usuario chamasse {nome}, tem {idade} anos, sua cor é {cor}, tem {altura} de altura, CPF: {cpf}, RG: {rg}, cidade: {cidade}, estado: {estado}");
        }



    }
}
