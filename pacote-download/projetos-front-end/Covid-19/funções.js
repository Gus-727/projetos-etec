/* Função para trocar a imagem (Barbearia Premium) */
function botao(sta)
{
    if (sta == 2)
    {
        document.getElementById('pomada').src='Imagens/pomada_molhado_barba_de_respeito2.jpg';
    }
    
    else
    {
        document.getElementById('pomada').src='Imagens/pomada_molhado.jpg';
    }
}


/* Função para gravar cadastro */
function gravar()
{
  var nome = document.getElementById('nome').value;
  var email = document.getElementById('email').value;
  var numero = document.getElementById('numero').value;
  var rg = document.getElementById('rg').value;
  var endereco = document.getElementById('endereco').value;
  var comentarios = document.getElementById('comentarios').value;
    
    if (document.getElementById('nome').value == "Gabriel" || document.getElementById('nome').value == "Felipe")
    {
        alert ("Nome inválido");
    }
    
    else
    {
         alert ("Nome Ok");
         document.getElementById('mensag').innerHTML = "<p style='font-size:40px'>Seu cadastro foi enviado com sucesso" + nome + "</p>";
    }

}


/* Funções da calculadora */
var oper = 0;
var memoria = 0;

function escrever(digito) 
{
    var visor = document.getElementById('visor');
    visor.value = visor.value + digito;
}
function operacao(op) 
{
    var visor = document.getElementById('visor');
    oper = op;
    memoria = parseInt(visor.value);
    visor.value = "";
}
function calcula() 
{
    var visor = document.getElementById('visor');
    var resultado = 0;

    if(oper==1) resultado = memoria + parseInt(visor.value);
    if(oper==2) resultado = memoria - parseInt(visor.value);
    if(oper==3) resultado = memoria * parseInt(visor.value);
    if(oper==4) resultado = memoria / parseInt(visor.value);

    visor.value = resultado;
}

function limpa()
{
    document.getElementById('visor').value="";
    oper = 0;
    memoria = 0;        
}

/* Função de gravar o cadastro Covid */
window.totPesq = 0;
var totFebril = 0, totRisco = 0, totFebrilRisco = 0, totMasc = 0, totFemi = 0;

function registra()
{
    if (document.getElementById('temp').value == '' ||
        document.getElementById('idade').value == '' ||        
        document.getElementById('sexo').value == 0 ||
        document.getElementById('sexo').value == '' ||
        document.getElementById('uf').value == 0 ||
        document.getElementById('uf').value == '' ||
        document.getElementById('nome').value == '')
        {
            alert ("Informe todos os dados");
            return;                
        }        

    totPesq = totPesq + 1;

    if (document.getElementById('temp').value >= 37.5)
    {
        totFebril++;
    }

    if (document.getElementById('idade').value >= 60)
    {
        totRisco++;
    }

    if (document.getElementById('idade').value >= 60 && document.getElementById('temp').value >= 37.5)
    {
        totFebrilRisco++;
    }        

    if (document.getElementById('sexo').value == "1")
    {
        totMasc++;
    }
    if (document.getElementById('sexo').value == "2")
    {
        totFemi++;
    }

    document.getElementById('nome').value = "";
    document.getElementById('idade').value = "";
    document.getElementById('sexo').value = "---";
    document.getElementById('temp').value = "";        
    document.getElementById('uf').value = "---";            

    alert("Questionário Gravado");
}


function resumo()
	{
		var brancos = '&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp';		
		var perc = 0;
		
		document.getElementById('tpesq').innerHTML = '<h3>Entrevistados: &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp' + totPesq + '</h3>';	
		
		if (totPesq == 0)
		{
			alert ("Não há dados de pesquisa");
			return;
			
		}
		
		perc = ((totFebril / totPesq) * 100).toFixed(2);
		document.getElementById('tfebril').innerHTML = '<h3>Total Febris: ' + brancos + totFebril + '&nbsp&nbsp&nbsp' + perc + '%' + '</h3>';

		perc = ((totRisco / totPesq) * 100).toFixed(2);		
		document.getElementById('trisco').innerHTML = '<h3>Grupo de Risco: &nbsp&nbsp&nbsp' + totRisco + '&nbsp&nbsp&nbsp' + perc + '%' + '</h3>';			

		perc = ((totFebrilRisco / totPesq) * 100).toFixed(2);
		document.getElementById('frisco').innerHTML = '<h3>Febris de Risco: &nbsp&nbsp&nbsp' + totFebrilRisco + '&nbsp&nbsp&nbsp' + perc + '%' + '</h3>';

		document.getElementById('tmasc').innerHTML = '<h3>Masculino: &nbsp&nbsp&nbsp' + totMasc + '</h3>';	
		document.getElementById('tfemi').innerHTML = '<h3>Feminino : &nbsp&nbsp&nbsp' + totFemi + '</h3>';
		
	}

