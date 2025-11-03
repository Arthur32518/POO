using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaObjetos
{
    public class Empresario
    {
        public string nome;
        public string cpf;
        public double altura;
        public double peso;
        public string remuneracao;
        public string cnpj;


        public void emprega()
        {
            Console.WriteLine("O empresário emprega pessoas ");
        }
        public void trabalha()
        {
            Console.WriteLine("O empresário trabalha em sua emopresa ");

        }
        public void come()
        {
            Console.WriteLine("O empresário come comida ");

        }
        public void bebe()
        {
            Console.WriteLine("O empresário bebe bebidas ");

        }
        public void dorme()
        {
            Console.WriteLine("O empresário dorme ");

        }

    }
}
