<?php
	header("Cache-Control: no-cache, no-store, must-revalidate"); // limpa o cache
	header("Access-Control-Allow-Origin: *"); // libera o acesso de sites externos.
?>      

<?php
      echo ("Olá " . $_REQUEST['nome']);
?>