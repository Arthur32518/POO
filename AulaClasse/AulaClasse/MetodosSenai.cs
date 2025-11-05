using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class MetodosSenai
    {
        //1
        //public string Nome;
        //public string Sobrenome;
        //public string Endereco;
        //public string Cidade;
        //public string Estado;
        //public string Pais;

        //2
        //public string Nome;
        //public string MarcaDoProduto;
        //public string CodigoProduto;
        //public int quantidade;

        //3
        //public string Nome;
        //public int Idade;
        //public string NomeDaEscola;

        //5
        //public string Nome;
        //public string Materia;
        //public int Idade;
        //public string Cidade;
        //public string NomeEscola;
        // public string NomeAluno;
        //public double Nota1;
        //public double Nota2;
        //public double Nota3;
        //public double Nota4;

        //6
        //public string Nome;
        //public string Escolaridade;
        //public int Idade;
        //public string Cpf;
        //public string Rg;
        //public double Salario;

        //7
        public double ValorReais;
        public double ValorDolar;
        public double ValorEuro; 




        //--------------------------------------------------------------------


        // 1
        //public void informacoes()
        //{
        //    Console.WriteLine($"O nome é {Nome}, ele mora em {Endereco}, {Cidade} de {Estado} no {Pais} ");

        //}

        // 2
        //public void Produtos()
        //{
        //    Console.WriteLine($"O nome é {Nome}, sua marca {MarcaDoProduto},Código: {CodigoProduto}, tem {quantidade} produtos ");

        //    if (quantidade < 10)
        //    {
        //        int quantidadeAumentada = quantidade * 20;
        //        Console.WriteLine("A nova quantidade é: " + quantidadeAumentada);
        //    }
        //    else if (quantidade < 20)
        //    {
        //        int quantidadeAumentada = quantidade * 25;
        //        Console.WriteLine("A nova quantidade é: " + quantidadeAumentada);
        //    }
        //    else
        //    {
        //        int quantidadeAuemntada = quantidade * 5;

        //        Console.WriteLine("A nova quantidade é: " + quantidadeAuemntada);
        //    }
        //}

        // 3
        //public void Estudar()
        //{
        //    if (NomeDaEscola == "Senai")
        //    {
        //        Console.WriteLine("Parabéns, está em uma boa escola");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Aluno nãopertence ao senai");
        //    }
        //}


        //5

        //public void Informar()
        //{
        //     Console.WriteLine($"O nome é {Nome}, tem {Idade} anos, mora em {Cidade}, trabalha em {NomeEscola}, e da aula de {Materia} ");

        //}
        //public void Calculo(double nota1, double nota2, double nota3, double nota4)
        //{
        //   this.Nota1 = nota1;
        //    this.Nota2 = nota2;
        //    this.Nota3 = nota3;
        //    this.Nota4 = nota4;
        //    double nota = nota1 + nota2 + nota3 + nota4;
        //    nota = nota / 4;
        //    Console.WriteLine($"O aluno {NomeAluno}, e ficou com {nota} na média");

        //}

        //6
        //public void Informar()
        //{
        //    Console.WriteLine($"O colaborador {Nome}, tem {Idade} anos, sua escolaridade {Escolaridade}, CPF: {Cpf}, portador do RG: {Rg} ");

        //}
        //public void Pagar(double salario)
        //{
        //    this.Salario = salario;

        //    if ( salario <= 1000)
        //    {
        //        salario = salario * 1.25;
        //    }
        //    else if ( salario <= 3000)
        //    {
        //        salario = salario * 1.10;
        //    }
        //    else
        //    {
        //        salario = salario * 1.5;
        //    }
        //    Console.WriteLine($"Seu novo salario é de {salario} ");
        //}

        //7
        public void Conveter1(double valorReais )
        {
            this.ValorReais = valorReais;
            double valorDolar;
            valorDolar = valorReais / 5.40;
            Console.WriteLine($"A conversão ficou : {valorDolar}");
        }
        public void Conveter2(double valorDolar)
        {
            
            this.ValorDolar = valorDolar;
            double valorReais;
            valorReais = valorDolar * 5.40;
            Console.WriteLine($"A conversão ficou : {valorReais}");
        }
        public void Conveter3(double valorReais2)
        {
            this.ValorReais = valorReais2;
            double valorEuro;
            valorEuro = valorReais2 * 0.16;
            Console.WriteLine($"A conversão ficou : {valorEuro}");
        }













    }
}
