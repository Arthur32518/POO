using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaObjetos
{
    public class Escola
    {
        public string nome;
        public int idade;
        public string endereco;
        public string cnpj;
        public string professor;
        public string aluno;
        public string diretor;

        public void passaConhecimento()
        {
            Console.WriteLine("A escola ensina");
        }
        public void educa()
        {
            Console.WriteLine("A escola educa ");

        }
        public void forma()
        {
            Console.WriteLine("A escola forma ");

        }
        public void corrige()
        {
            Console.WriteLine("A escola  corrige");

        }
    }
}
