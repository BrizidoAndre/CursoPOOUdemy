const string senha = "1234";

Console.WriteLine($"Por favor digite a senha");

string senhaDigitada = Console.ReadLine();

while (senha != senhaDigitada)
{
    Console.WriteLine($"Senha incorreta. Acesso Negado");
    senhaDigitada = Console.ReadLine();
}

Console.WriteLine($"Acesso permitido");
