Console.WriteLine($"Digite os valores de bháskara com apenas um espaço entre eles");
string dados = Console.ReadLine();

string[] valores = dados.Split(" ");

double a = double.Parse(valores[0]);
double b = double.Parse(valores[1]);
double c = double.Parse(valores[2]);

double delta = Math.Pow(b, 2) - (4 * a * c);

if (a == 0)
{
    Console.WriteLine($"impossível calcular");

}
else
{
    if (delta < 0)
    {
        Console.WriteLine($"Impossível calcular");
    }
    else
    {
        double x1 = ((-b + Math.Sqrt(delta)) / (2 * a));
        double x2 = ((-b - Math.Sqrt(delta)) / (2 * a));

        Console.WriteLine($"O valor de X1 é {Math.Round(x1, 2)}");
        Console.WriteLine($"O valor de X2 é {Math.Round(x2, 2)}");
    }
}