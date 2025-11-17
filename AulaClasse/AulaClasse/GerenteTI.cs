using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class GerenteTI : Colaborador3
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("Informe o total de horas do mes: ");
            int horasMes = Convert.ToInt32(Console.ReadLine());

            if (horasMes > 100)
            {
                double novoSalario = (horasMes / 2) + 700;
                double diaDescanso = horasMes / 8;
                Console.WriteLine($"O salario sera de {novoSalario}, e terá {diaDescanso} de descanso");

            }
            else
            {
                horasMes = horasMes * 400;
                Console.WriteLine(horasMes);
            }
        }
    }
}
