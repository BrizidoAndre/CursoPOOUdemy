Console.WriteLine(@"Por favor digite o código, a quantidade e o preço do produto como no exemplo abaixo
CC Q 0.00");

string dadoEscrito = Console.ReadLine();

string[] dados = dadoEscrito.Split(" ");

int codigo = int.Parse(dados[0]);
int quantidade = int.Parse(dados[1]);
float preco = float.Parse(dados[2]);

Console.WriteLine($"Agora digite os mesmos valores da 2ª aquisição");

dadoEscrito = Console.ReadLine();

string[] dados1 = dadoEscrito.Split(" ");

int codigo2 = int.Parse(dados1[0]);
int quantidade2 = int.Parse(dados1[1]);
float preco2 = float.Parse(dados1[2]);

Console.WriteLine($"O total é de {preco*quantidade + preco2*quantidade2:C}");
