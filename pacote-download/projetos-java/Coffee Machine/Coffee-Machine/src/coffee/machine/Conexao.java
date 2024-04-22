/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package coffee.machine;

/**
 *
 * @author aluno
 */

  import java.sql.Statement;
  import java.sql.Connection;
  import java.sql.DriverManager;
  import java.sql.ResultSet;
  import java.sql.SQLException;

public class Conexao {
     public static Statement statement = null;

         // String com o caminho onde está o banco de dados
            String URL = "jdbc:mysql://localhost:3306/bd_vendas";
        // Login
           String usuario = "root";
        // Senha
           String senha = "usbw";
       // Variavel para o comando SQL
           private Statement stm = null;
       // Variavel para a conexão
          public Connection conecta = null;

      // Métodos Conectar e Desconectar Banco de Dados 

        public void conectar() throws ClassNotFoundException, SQLException 
       {
       
           // Carga do driver de conexão
              Class.forName("com.mysql.jdbc.Driver");
           // Fazendo a conexão
              conecta = DriverManager.getConnection(URL, usuario, senha);
             statement = (Statement) conecta.createStatement(ResultSet.TYPE_SCROLL_SENSITIVE, 
             ResultSet.CONCUR_UPDATABLE);
       }

       public void desconectar() throws SQLException
       {
           
            // Fechando a conexão
               conecta.close();
       }
   
      public static int runSQL(String sql) 
      {
           int qtdreg = 0;
     
           try
          {
               qtdreg = statement.executeUpdate(sql);
          }
          catch(SQLException sqlex)
         {
           System.out.println("Erro acesso ao BD"+ sqlex);
         }

         return qtdreg;
      }
      
      public ResultSet buscaCafe()
      {
          try {
              statement = conecta.createStatement();
              ResultSet rs = statement.executeQuery("SELECT * FROM tb01_produtos");
              return rs;
          } 
          catch(SQLException e){
              e.printStackTrace();
          }
          return null;
      }
}
