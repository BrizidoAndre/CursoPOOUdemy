int dentro = 0;
int fora = 0;

for (int i = 5; i > 0; i--)
{
    Console.WriteLine($"Digite o {i}º número");
    float num = float.Parse(Console.ReadLine());


    if (num <= 20 && num >= 10)
    {
        dentro++;
    }
    else
    {
        fora++;
    }
}

Console.WriteLine(@$"Foram {dentro} numeros dentro 
e {fora} numeros fora");

