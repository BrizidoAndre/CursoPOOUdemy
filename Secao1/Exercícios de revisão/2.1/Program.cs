while (true)
{    
Console.WriteLine(@$"
--------------------------------------
 CODIGO        PRODUTO           PRECO
--------------------------------------
1            CACHORRO QUENTE      $4.00
2            X-SALADA             $4.50
3            X-BACON              $5.00
4            TORRADA              $2.00
5            REFRIGERANTE         $1.50");

Console.WriteLine($"Agora digite o código do produto e quantos você deseja");

string dadoDigitado = Console.ReadLine();

string[] dados = dadoDigitado.Split(" ");

int codigo = int.Parse(dados[0]);
int quantidade = int.Parse(dados[1]);
float preco = 0;
float total;
switch (codigo)
{
    case 1:
    preco = 4;
        break;
    case 2:
    preco = 4.5f;
        break;
    case 3:
    preco = 5;
        break;
    case 4:
    preco = 2;
        break;
    case 5:
    preco = 1.5f;
        break;
    default:
    Console.WriteLine($"O codigo inserido não corresponde!");
        break;
}
total = preco *quantidade;

if (preco != 0)
{
    Console.WriteLine($"O valor a ser pagado é de {total:C}");
}
}