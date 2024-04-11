using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;



namespace UrnaBD
{
    public class Conexao
    {
        // define uma string de conexão
        private static string conexao = @"server=localhost;port=3306;user id=root;pwd=usbw;database=bd_urna";
        // representa a conexão com o banco
        private static MySqlConnection conn = new MySqlConnection(conexao);
        private bool resultado;
        private MySqlCommand cmd;

        public bool Cadastra_Eleicao(Eleicao e)
        {
            resultado = false;
            try
            {
                conn.Open();
                string sql = "insert into tb01_eleicao values('" + e.Descricao + "', '" + e.Data + "', null);";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro! " + ex);
            }
            finally
            {
                conn.Close();
            }
            return resultado;
        }

        public Eleicao Busca_eleicoes(Eleicao ele)
        {
            Eleicao e = new Eleicao();
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM tb01_eleicao WHERE tb01_id_eleicao = @id";
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = ele.Id;

                MySqlDataReader dt = cmd.ExecuteReader();
                if (dt.HasRows)
                {
                    dt.Read();
                    //e.Data = DateTime.Parse(dt["tb01_data"].ToString());
                    e.Descricao = dt["tb01_descricao"].ToString();
                }
            } catch(Exception ex)
            {
                Console.WriteLine("Erro! " + ex);
            }
            finally
            {
                conn.Close();
            }

            return e;
        }

        public bool Atualiza_Eleicao(Eleicao e)
        {
            resultado = false;

            try
            {
                conn.Open();
                string sql = "update tb01_eleicao set tb01_descricao= " + e.Descricao + ", tb01_data=" + e.Data + " where " + "tb01_id_eleicao" + e.Id + ";";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro! " + ex);
            }
            finally
            {
                conn.Close();
            }

            return resultado;
        }

        public bool ComandoSql(string sql)
        {
            resultado = false;

            try 
            {
                conn.Open();
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro!" + ex);
            }
            finally 
            {
                conn.Close();
            }
            return resultado;
        }

        public DataTable Retorna(string sql)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter da = new  MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable data = new DataTable();
                da.Fill(data);
                return data;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
    } 
    
   
}
