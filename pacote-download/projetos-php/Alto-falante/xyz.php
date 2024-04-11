<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link rel="icon" href="../../../../favicon.ico">
    <title>Cadastro</title>
     <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">

</head>

<body>
    <div class="container bg-grey">
    <h1 style="text-align: center">Cadastro Produtos</h1>
    <center>
    <form style="border: 2px solid black;border-radius: 8px" method="post">
       <div class="col-sm-6">
            <label>Informe o código do produto:</label>
            <input class="form-control" type="number" name="txtCod" style="width:65%" required>
        </div>
            <br/><br/>
        <div class="col-sm-6">
            <label>Informe o nome:</label>
            <input class="form-control" type="text" name="txtNome" style="width:60%" required>
        </div>
            <br/><br/>
       
        <div class="col-sm-6">
            <label>Informe o valor do produto:</label>
            <input class="form-control" type="number" name="txtVal" style="width:40%" required>
        </div>
            <br/><br/>
        <div class="col-sm-6">
            <label>Insira o link da imagem do produto:</label>
            <input class="form-control" type="text" name="txtImg" style="width:60%" required>
        </div>
            <br/><br/>
        <div class="col-sm-6">
            <label>Informe a descrição do produto:</label>
            <textarea class="form-control" name="txtDesc" rows="15"></textarea>
        </div>
            <br/><br/>
       
            <button type="submit" class="btn btn-success" style="margin-left: 15px">Enviar</button>
            <button type="reset" class="btn btn-success" style="background-color: red;border: red">Limpar</button>
    </form>
    </center>
<?php
	// Carrega os dados da conexão!
	include("dados-conexao.php"); 
	
	if ($_POST)
	{
		try { // tenta fazer a conexão e executar o INSERT
			$conecta = new PDO("mysql:host=$servidor;dbname=$banco", $usuario , $senha); //instancia a classe PDO
			$conecta->exec("set names utf8"); // Permite caracteres latinos.
			$comandoSQL = "INSERT INTO tb01_produtos (tb01_cod, tb01_nome, tb01_valor, tb01_foto, tb01_desc) VALUES ('$_POST[txtCod]', '$_POST[txtNome]', '$_POST[txtVal]', '$_POST[txtImg]', '$_POST[txtDesc]')";
			echo $comandoSQL; // Este echo serve apenas para teste.
			$grava = $conecta->prepare($comandoSQL); //testa o comando SQL
			$grava->execute(array()); 			
		} catch(PDOException $e) { // caso retorne erro
			echo('Deu erro: ' . $e->getMessage());  // Este echo também serve apenas para teste.
		}
        //try e catch servem para a aplicação não travar
	} 
?>
    </div>
    


    <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>

</body>
</html>