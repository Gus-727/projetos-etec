<?php
	header("Cache-Control: no-cache, no-store, must-revalidate"); // limpa o cache
	header("Access-Control-Allow-Origin: *"); // libera o acesso de sites externos.
?>      

<?php
     $vt = $_REQUEST['total'];
     $parc = $_REQUEST['parc'];
     $parcTot = $vt / $parc;
     echo 'O valor de cada parcela será de: ' . 'R$'. $parcTot;
?>