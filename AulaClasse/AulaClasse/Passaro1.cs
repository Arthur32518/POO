using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Passaro1
    {
        public double altura;
        public int peso;
        public string especie;
        public string nome;
        public int idade;


        public Passaro1()
        {
            altura = 10;
            peso = 7;
            especie = "Pombo";
            nome = "God Bird";
            idade = 3;

            Console.WriteLine(altura);
            Console.WriteLine(peso);
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(especie);
                


        }
        public void Voar()
        {
            Console.WriteLine("O passaro está voando");
        }
        public void Cantar()
        {
            Console.WriteLine("O passaro esta cantando");
        }
    }
}
