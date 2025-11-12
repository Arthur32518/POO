using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    //abstract metodo obrigatorio
    public abstract class Forma
    {
        //nao realiza instancia no main
        public abstract void CalcularArea();
      
        public void DefinirTipo()  //Metodo opcional
        {
            Console.WriteLine("Digite qual forma geomtrica ira calcular");
        }
    }
}
