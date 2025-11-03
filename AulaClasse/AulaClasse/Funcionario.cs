using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Funcionario
    {
        public string nome;
        public string cargo;
        public string cpf;
        public string endereco;
        public string telefone;
        public string email;
        public double remuneracao;
        public string cargaHoraria;
        public double peso;
        public double altura;
        public int idade;


        public void Trabalha()
        {
            Console.WriteLine("O funcionario esta trabalhando ");
        }

        public void Conversa()
        {
            Console.WriteLine("O funcionario esta conversando");
        }

        public void Come()
        {
            Console.WriteLine("O funcionario esta comendo ");
        }

        public void Descansa()
        {
            Console.WriteLine("O funcionario esta descansando ");
        }
        public void Lucra()
        {
            if (remuneracao == 0)
            {
                Console.WriteLine("Você não especificou a remuneração ");
               

            }
            else
            {
                double novoSalario = remuneracao * 1.25;
                Console.WriteLine("O novo salario é: " + novoSalario);
          
            }
        }
    }
}
