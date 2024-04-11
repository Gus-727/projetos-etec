using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Urna_BD
{
    public class Conexao
    {
        // define uma string de conexão
        private static string conexao = "server=localhost;port=3307;user=root;pwd=usbw;database=aluno_bd_urna";
        // representa a conexão com o banco
        private static MySqlConnection conn = new MySqlConnection(conexao);
        private bool resultado;
        private MySqlCommand cmd;
        
        public bool Cadastra_Eleicao(Eleicoes e)
        {
            resultado = false;
            try
            {
                conn.Open();
                string sql = "insert into tb01_eleicao values(null, '" + e.Descricao + "', '" + e.Data + "');";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                resultado = true;
            } catch(Exception ex)
            {
                Console.WriteLine("Erro! " + ex);
            }
            finally
            {
                conn.Close();
            }
            return resultado;
        }
    }
}
