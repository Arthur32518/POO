using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public abstract class Escola
    {
        public string NomeEscola;
        public string Cidade;
        public string Estado;
        public string Serie;

        public abstract void CalcularMedia();
       
        public void DescobrirNome()
        {
            Console.WriteLine("Digite o nome da escola: ");
            string nomeEscola = Console.ReadLine();
            Console.WriteLine("Cidade em que mora: ");
            string cidade = Console.ReadLine();
            Console.WriteLine("Digite o estado em que mora: ");
            string estado = Console.ReadLine();
            Console.WriteLine("Digite a serie em que estuda: ");
            string serie = Console.ReadLine();  

            if (nomeEscola == "Sesi/Senai" && cidade == "Garça")
            {
                Console.WriteLine("Aluno Sesi/Senai");
            }
            else
            {
                Console.WriteLine($"Aluno da escola {nomeEscola} da cidade {cidade}");
            }
        }


    }
}
