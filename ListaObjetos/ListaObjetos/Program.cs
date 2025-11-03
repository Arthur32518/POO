using AulaClasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.endereco = "Av Paineiras";
            biblioteca.horario = "Das 7 as 18hrs";
            biblioteca.nome = "Igarata";
            biblioteca.telefone = "14992707070";


            biblioteca.realizarLeitura();
            biblioteca.lerLivros();
            biblioteca.aprender();


            Empresario empresario = new Empresario();
            empresario.altura = 1.70;
            empresario.cnpj = "273873292928";
            empresario.remuneracao = "50.000";
            empresario.peso = 70;
            empresario.nome = "Robson";
            empresario.cpf = "48294829284";


            empresario.dorme();
            empresario.bebe();
            empresario.come();
            empresario.trabalha();
            empresario.emprega();

            Escola escola = new Escola();
            escola.nome = "SESI";
            escola.aluno = "Arthur";
            escola.professor = "Ricardo";
            escola.diretor = "Hélio";
            escola.idade = 20;
            escola.cnpj = "891819139339";
            escola.endereco = "Av Corinthians";

            escola.forma();
            escola.corrige();
            escola.passaConhecimento();
            escola.passaConhecimento();
        

            Aluno aluno = new Aluno();
            aluno.altura = 1.60;
            aluno.responsavel = "Pai";
            aluno.idade = 20;
            aluno.nome = "Arthur";
            aluno.peso = 60;
            aluno.escola = "SENAI";

            aluno.estuda();
            aluno.come();
            aluno.bebe();
            aluno.aprende();



        Carro carro = new Carro();
            carro.ano = 2025;
            carro.placa = "12WQ34";
            carro.cor = "preto";
            carro.modelo = "Sedan";
            carro.marca = "Ferrari";


            carro.ligar();
            carro.acelerar();
            carro.frear();
            carro.ascenderFarol();
        }
    }
}
