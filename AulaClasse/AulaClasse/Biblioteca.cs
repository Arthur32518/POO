using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Biblioteca
    {
        public string nome;
        public string horario;
        public string telefone;
        public string endereco;


        public void realizarLeitura()
        {
            Console.WriteLine("A pessoa está lendo algo");
        }
        public void lerLivros()
        {
            Console.WriteLine("A pessoa está lendo livros");

        }
        public void aprender()
        {
            Console.WriteLine("A pessoa está aprendendo algo");

        }

    }
}
