using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Veiculo1
    {
        public string modelo;
        public string placa;

        public virtual void calcularValorCombustivel()
        {
            Console.WriteLine("Escolhe uma opção: \n 1 - Gasolina (R$ 5,99 por litro) \n 2 - Diesel (R$ 6,99 por litro) \n 3 - Álcool (R$ 3,99 por litro)");
           int opcao = Convert.ToInt32(Console.ReadLine());

            while (opcao < 1 || opcao > 4)
            {
                Console.WriteLine("Opção invalida, tente novamente: ");
                Console.WriteLine("Escolhe uma opção: \n 1 - Gasolina (R$ 5,99 por litro) \n 2 - Diesel (R$ 6,99 por litro) \n 3 - Álcool (R$ 3,99 por litro)");
                opcao = Convert.ToInt32(Console.ReadLine());
                break;
            }

            switch (opcao)
            {
                case 1: 
                    Console.WriteLine("Escolheu Gasolina");
                    Console.WriteLine("Quantos litros deseja: ");
                    double litros = Convert.ToDouble(Console.ReadLine());
                    double valorTotal = litros * 5.99;
                    Console.WriteLine($"Foi colocado {valorTotal} R$ de gasolina");
                    break;

                case 2:
                    Console.WriteLine("Escolheu Diesel");
                    Console.WriteLine("Quantos litros deseja: ");
                    litros = Convert.ToDouble(Console.ReadLine());
                    valorTotal = litros * 6.99;
                    Console.WriteLine($"Foi colocado {valorTotal} R$ de diesel");
                    break;

                case 3:
                    Console.WriteLine("Escolheu Àlcool");
                    Console.WriteLine("Quantos litros deseja: ");
                    litros = Convert.ToDouble(Console.ReadLine());
                    valorTotal = litros * 3.99;
                    Console.WriteLine($"Foi colocado {valorTotal} R$ de Àlcool ");
                    break;
            }
        }
        public virtual void calcularTotal()
        {
            Console.WriteLine("Digite quantas pessoas vão na viagem: ");
            int pessoas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qauntos KM irá rodar: ");
            double km = Convert.ToDouble(Console.ReadLine());

            if (pessoas == 2 && km > 50 )
            {
                double totalViagem = km * 25;
                Console.WriteLine($"A kilometragem total será : {totalViagem} ");
            }
            else if (pessoas == 2 && km <= 50)
            {
                double totalViagem = km * 18;
                Console.WriteLine($"A kilometragem total será : {totalViagem} ");

            }
            else
            {
                double totalViagem = km * 15;
                Console.WriteLine($"A kilometragem total será : {totalViagem} ");

            }

        }
    }
}
