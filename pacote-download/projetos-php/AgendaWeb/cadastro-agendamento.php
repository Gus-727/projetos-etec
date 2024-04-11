<title>Cadastro agendamento</title>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"> 
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">

<h1>Cadastro do agendamento</h1>
<form method="post">
  <div class="form-group row">
   <input list="clientes" name="cliente_codigo" id="cliente_codigo" required>
    <datalist id="clientes">
    <?php
		include("conexao.php"); 
        try {
          $conecta = new PDO("mysql:host=$servidor;dbname=$banco", $usuario , $senha);
          $conecta->exec("set names utf8"); //permite caracteres latinos.
          $comando = "SELECT * FROM	 tb01_clientes ORDER BY tb01_nome";
          $consulta = $conecta->prepare($comando);
          $consulta->execute(array());  
          $resultadoDaConsulta = $consulta->fetchAll();
          
          if ( count($resultadoDaConsulta) ) 
          {
            foreach($resultadoDaConsulta as $registro) // exibe todos os registros
            {
              echo '<option value="' . 
                     $registro['tb01_id_cliente'] . '">' . 
                     $registro['tb01_nome']  . 
                    '</option>';
            }
          }	
        } 
        catch(PDOException $e) 
        {
          echo 'ERRO DO MySQL: ' . $e->getMessage(); 
        }	  
        ?>
    </datalist>
  </div>
  <div class="form-group row">
    <label for="agendamento_data" class="col-4 col-form-label">Data</label> 
    <div class="col-8">
      <input id="agendamento_data" name="agendamento_data" type="text" class="form-control" required>
    </div>
  </div>
  <div class="form-group row">
    <label for="agendamento_hora" class="col-4 col-form-label">Hora</label> 
    <div class="col-8">
      <input id="agendamento_hora" name="agendamento_hora" type="text" class="form-control" required>
    </div>
  </div>
  <div class="form-group row">
    <label for="agendamento_obs" class="col-4 col-form-label">Observação</label> 
    <div class="col-8">
      <textarea id="agendamento_obs" name="agendamento_obs" cols="40" rows="5" class="form-control" required></textarea>
    </div>
  </div> 
  <div class="form-group row">
    <div class="offset-4 col-8">
      <button name="submit" type="submit" class="btn btn-primary">Enviar</button>
    </div>
  </div>
</form>

<?php
	// Carrega os dados da conexão!
	include("conexao.php"); 
	
	if ($_POST)
	{
		try { // tenta fazer a conexão e executar o INSERT
			$conecta = new PDO("mysql:host=$servidor;dbname=$banco", $usuario , $senha); //instancia a classe PDO
			$conecta->exec("set names utf8"); // Permite caracteres latinos.
			$comandoSQL = "INSERT INTO tb02_agendamentos (agendamento_data, agendamento_hora, agendamento_obs) VALUES ('$_POST[agendamento_data]', '$_POST[agendamento_hora]', '$_POST[agendamento_obs]')";
			echo $comandoSQL; // Este echo serve apenas para teste.
			$grava = $conecta->prepare($comandoSQL); //testa o comando SQL
			$grava->execute(array()); 			
		} catch(PDOException $e) { // caso retorne erro
			echo('Deu erro: ' . $e->getMessage());  // Este echo também serve apenas para teste.
		}
        //try e catch servem para a aplicação não travar
	} 
?>