
<title>Cadastro de clientes</title>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"> 
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">

<h1>Cadastro de clientes</h1>
<form method="post">
  <div class="form-group row">
    <label for="cliente_nome" class="col-4 col-form-label">Nome</label> 
    <div class="col-8">
      <input id="cliente_nome" name="cliente_nome" type="text" class="form-control">
    </div>
  </div>
  <div class="form-group row">
    <label for="cliente_telefone" class="col-4 col-form-label">Telefone</label> 
    <div class="col-8">
      <input id="cliente_telefone" name="cliente_telefone" type="text" class="form-control">
    </div>
  </div>
  <div class="form-group row">
    <label for="cliente_endereco" class="col-4 col-form-label">Endereço</label> 
    <div class="col-8">
      <input id="cliente_endereco" name="cliente_endereco" type="text" class="form-control">
    </div>
  </div>
  <div class="form-group row">
    <label for="cliente_obs" class="col-4 col-form-label">Observação</label> 
    <div class="col-8">
      <textarea id="cliente_obs" name="cliente_obs" cols="40" rows="5" class="form-control"></textarea>
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
			$comandoSQL = "INSERT INTO tb01_clientes (cliente_nome, cliente_telefone, cliente_endereco, cliente_obs) VALUES ('$_POST[cliente_nome]', '$_POST[cliente_telefone]', '$_POST[cliente_endereco]', '$_POST[cliente_obs]')";
			echo $comandoSQL; // Este echo serve apenas para teste.
			$grava = $conecta->prepare($comandoSQL); //testa o comando SQL
			$grava->execute(array()); 			
		} catch(PDOException $e) { // caso retorne erro
			echo('Deu erro: ' . $e->getMessage());  // Este echo também serve apenas para teste.
		}
        //try e catch servem para a aplicação não travar
	} 
?>
