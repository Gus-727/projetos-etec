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


