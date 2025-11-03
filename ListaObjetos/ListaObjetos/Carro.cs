using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaObjetos
{
    public class Carro
    {
        public string modelo;
        public string marca;
        public string placa;
        public double ano;
        public string cor;

        public void ligar()
        {
            Console.WriteLine("O carro está ligando ");
        }
        public void acelerar()
        {
            Console.WriteLine("O carro está acelerando ");
        }
        public void frear()
        {
            Console.WriteLine("O carro está freando ");
        }
        public void ascenderFarol()
        {
            Console.WriteLine("O carro está de farol acesso ");
        }
    }
}
