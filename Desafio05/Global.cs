using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Desafio05
{
    class Global
    {
        public static MySqlConnection Conexao;

        public static MySqlCommand Comando;

        public static MySqlDataAdapter Adaptador;

        public static DataTable datTabela;


        public static void conectar()
        {
            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=GAAUUEUEHFMCAIJCA8732");

            Conexao.Open();

            Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS bd_desafio05; use bd_desafio05", Conexao);

            Comando.ExecuteNonQuery();

            Conexao.Close();





        }
    }
}
