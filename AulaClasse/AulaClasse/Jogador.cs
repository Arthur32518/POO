using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Jogador // classe
    { // atributos
        public string Nome;
        public int Idade;
        public double Peso;
        public double Altura;
        public string Time;
        public string Posicao;
        public string Pais;
        public string NumeroCamisa;

        //metodos 
        public void Correr(string nome, int idade)
        {
            //Propriedade THIS
            this.Nome = nome;
            this.Idade = idade; 

            if(idade >= 18)
            {
                Console.WriteLine("Atleta nivel adulto");
            }
            else if(idade > 15 || idade < 18)
            {
                Console.WriteLine("Atleta Júnior");
            }
            else
            {
                Console.WriteLine("Atleta infantil");
            }

            Console.WriteLine("O nome do atleta é: " + nome);
        }
        public void Chutar()
        {

        }
        public void Falar()
        {

        }
        public void Driblar()
        {

        }
        public void Pular()
        {

        }



    }
}
