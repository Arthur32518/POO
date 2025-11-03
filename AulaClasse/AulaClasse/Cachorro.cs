using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Cachorro
    {
        public double peso;
        public int idade;
        public string cor;
        public double altura;
        public string porte;
        public string tipoHabitat;
        public string raca;
        public string nome;



        public void Latir()
        {
            Console.WriteLine("O cachorro está latindo");
            if (idade <= 3)
            {
                Console.WriteLine("Cachorro não late");
            }
            else
            {
                Console.WriteLine("Cachorro pode latir");
            }
        }

        public void Comer()
        {
            Console.WriteLine("O cachorro está comendo");
        }

        public void Beber()
        {
            Console.WriteLine("O cachorro está bebendo");
        }

        public void Morder()
        {
            Console.WriteLine("O cachorro está mordendo");
        }

        public void Correr()
        {
            Console.WriteLine("O cachorro está correndo");
        }

        public void Brincar()
        {
            Console.WriteLine("O cachorro está brincando");
        }
        public void Dormir()
        {
            Console.WriteLine("O cachorro está dormindo");
        }
         

       
    }
}
