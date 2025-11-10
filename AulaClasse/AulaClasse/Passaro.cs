using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    //POLIMORFISMO COM A CLASSE ANIMAL1 PERMITE MODIFICAR O METODO DE ACORDO COM AS CARACTERISTICAS PROPRIAS DO ANIMAL
    public class Passaro : Animal1
    {
        public override void EmitirSom()
        {
            Console.WriteLine("O passaro está cantando");
        }
    }
}
