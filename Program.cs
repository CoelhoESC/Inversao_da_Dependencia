using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversão_da_Dependencia
{
    internal class Program
    {

        class MySqlConnection
        {
            public void Conectar()
            {
                Console.WriteLine("Conexão com MySQL");
            }
        }

        class recuperarSenha
        {
            private MySqlConnection conexaoBanco;
            public recuperarSenha()
            {
                conexaoBanco = new MySqlConnection(); // Alto acoplamento.
                // Codigo....
            }
        }

        /* 
         * - Alto acoplamento entre os modulos do sistemas.
         * - A classe recuperarSenha, precisa sempre instanciar a classe MySqlConnection.
         * - Isso gera uma dificuldade em reutilizar o codigo. 
         * - Isso gera uma violação DIP, pois, a classe recuperarSenha é de alto nivel dependendo da classe MySqlConnetion que é baixo nivel.
         * Ambos as classes estam depedendo de uma implementação e não de uma abstração. 
         * 
         * -- Para resolver esse problema, aplicamos inversão da dependência --
         * - As duas classes, precisa depender de uma interface, que será responsavel por desacoplar o codigo. 
         * - O modulo de baixo nivel MySQLConnection agora depende de uma abstração: a interface IDataBaseConnection.
         * - Para refaturar a classe recuperarSenha, utilizamos Injeção de Dependencia (DI) para que a classe dependa da abstração.
         * - Agora a classe de alto nivel, não precisará criar sempre uma instancia da classe de baixo nivel. 
         * - Ambas as classes, depende da classe de abstração IDataBaseConnection. 
         * - Implementamos assim a inversão da dependencia usando a inversão de controle (IoC) e a injeção de dependencia.
         * 
         */

       interface IDataBaseConnection
        {
            void Conectar();
        }

        class MySQLConnection : IDataBaseConnection
        {
            public void Conectar()
            {
                //Codigo...
            }
        }
        class RecuperarSenha
        {
            private IDataBaseConnection conexaoBanco;
            public RecuperarSenha(IDataBaseConnection conexaoBanco) // DI
            {
                this.conexaoBanco = conexaoBanco;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
