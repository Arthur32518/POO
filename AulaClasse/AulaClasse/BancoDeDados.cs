using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class BancoDeDados
    {
        private string Host;
        private string Usuario;
        private string Senha;
        private int Porta;
        public BancoDeDados(string host, int porta, string usuario, string senha) 
        {
            host = "localhost";
            porta = 3306;
            usuario = "root";
            senha = "admin";
        }

    }
}
