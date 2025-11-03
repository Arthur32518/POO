using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Metodos
    {
        public int Valor1;
        public int Valor2;
        public int Valor3;
        

        //Crie um metodo que receba por parametro que receba por parametro 3 valores inteiros: Valor1, Valor2, Valor3
        //Realize a soma dos valores e mostre no terminal a soma para o usuario

        public void Somar(int valor1, int valor2, int valor3)
        {
            this.Valor1 = valor1;
            this.Valor2 = valor2;
            this.Valor3 = valor3;
            int resultado = Valor1 + Valor2 + Valor3;

            Console.WriteLine("O resultado da soma é: " + resultado);
        }

        //VOID é usado para metodos sem retorno
        public int Multiplicar(int valor1, int valor2)
        {
            this.Valor1 = valor1;
            this.Valor2 = valor2;
            return Valor1 * Valor2;
                       
        }

        public string Dividir()
        {
            //chamada do metodo multiplicar
           int resultado = Multiplicar(Valor1, Valor2);

            if(resultado % 2 == 0)
            {
                return "VALOR PAR";
            }
            else
            {
                return "VALOR IMPAR";
            }
        }

        public double Salario(double valor1)
        {
               
            if (valor1 >= 2000) {
                
                return valor1 * 1.2754;
            }
            else
            {
             
                return valor1 * 1.1523;
            }
        }
        public int Somar(int valor1, int valor2)
        {

            this.Valor1 = valor1;
            this.Valor2 = valor2;
            return valor1 + valor2;
           
           
        }
        public void Subtrair(int valor3)
        {
           int soma = Somar(Valor1, Valor2);
            if(valor3 > soma)
            {
                Console.WriteLine("O valorda subtração é maior");
            }
            else
            {
                Console.WriteLine("O valor da soma´é maior");
            }

            


        }



    }
}
